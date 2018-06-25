Imports Discord
Imports Discord.WebSocket
Imports System.Net
Imports System.IO
Imports System.Net.NetworkInformation
Public Class main
    Const botOwner As String = "TheOneCode#0445"                                                                        'I put my user name here (replace with your own username on compile
    Dim adminRole As Decimal = 454406710044393484                                                                       'the numeric ID of the admin or similar role
    Dim catcher As Integer                                                                                              'catcher for each attempt to catch info
    Dim webClient As WebClient = New WebClient                                                                          'webClient for catching info
    Dim profilePic As Bitmap                                                                                            'profile picture for caught info
    Dim discord As New DiscordSocketClient(New DiscordSocketConfig With {.MessageCacheSize = 50})                       'discord socket configuration
    Dim id As String = login.ID                                                                                         'gets ID from login
    Dim token As String = login.Token                                                                                   'gets token from login
    Dim authUrl As String = "https://discordapp.com/api/oauth2/authorize?client_id=" & id & "&permissions=0&scope=bot"  'gets auth url for adding bot to discord with a few clicks
    Dim wake As String = "/"                                                                                            'gets wake key
    Dim wakeSpace As Boolean = False                                                                                    'is there a space after?
    Dim lastCommand As String = "[NO VAR SAVED]"                                                                        'last command
    Dim remoteControl As Boolean = False
    Dim enabledCommand = New Boolean() {False, True, True, True, False, False}
    'load
    Private Async Sub connectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PingNow()
        AddHandler discord.MessageReceived, AddressOf onMessage
        Try
            Await discord.LoginAsync(TokenType.Bot, token)
            logger("Token approved, bot online!")
        Catch ex As Exception
            login.failed(ex)
            Close()
        End Try
        Await discord.StartAsync()
    End Sub
    'This is where all the magic happens (command inturperater)
    Private Async Function onMessage(message As SocketMessage) As Task
        'check if it's a bot or not
        If message.Source <> MessageSource.Bot And message.Content.StartsWith(wake) Then
            'commands
            If message.Content.StartsWith(wake & "help") = True And enabledCommand(1) Or message.Content.StartsWith(wake & "commands") And enabledCommand(1) Then
                'help
                If DirectCast(message.Author, SocketGuildUser).Roles.ToList.Contains(DirectCast(message.Channel, IGuildChannel).Guild.GetRole(adminRole)) Or message.Author.Username = DirectCast(message.Author, SocketGuildUser).Guild.Owner.Username And message.Author.Discriminator = DirectCast(message.Author, SocketGuildUser).Guild.Owner.Discriminator Or message.Author.Username & "#" & message.Author.Discriminator = botOwner Then
                    Await message.Channel.SendMessageAsync(txtHelp.Text.Replace("{wake}", wake) & vbNewLine & txtHelpAdmin.Text.Replace("{wake}", wake))
                Else
                    Await message.Channel.SendMessageAsync(txtHelp.Text.Replace("{wake}", wake))
                End If
            ElseIf message.Content.StartsWith(wake & "online") Then
                'online (always enabled)
                Await message.Channel.SendMessageAsync("Status: `I am offline ( ͡° ͜ʖ ͡°)`")
            ElseIf message.Content.StartsWith(wake & "ping") And enabledCommand(2) Then
                'ping
                If message.Content.Contains("ping ") Then
                    Dim messageRecieved As String = message.Content.Replace(wake & "ping ", "")
                    Await message.Channel.SendMessageAsync("Ping results for " & message.Author.Username & ":" & vbNewLine & "`" & PingNow(messageRecieved, True) & "`")
                Else
                    Await message.Channel.SendMessageAsync("Ping results for " & message.Author.Username & ":" & vbNewLine & "`" & PingNow(, True) & "`")
                End If
            ElseIf message.Content.StartsWith(wake & "repeat ") Or message.Content.StartsWith(wake & "echo ") And enabledCommand(3) Then
                'echo
                Dim repeat As String = message.Content
                repeat = repeat.Replace(wake & "repeat ", "")
                repeat = repeat.Replace(wake & "echo ", "")
                repeat = message.Author.Username & " said : " & repeat
                Await message.Channel.SendMessageAsync(repeat)
                logger(message.Author.Username & " echoed " & repeat)
            ElseIf message.Content.StartsWith(wake & "last") And enabledCommand(4) Or message.Content.StartsWith(wake & "previous") And enabledCommand(4) Then
                'last
                Await message.Channel.SendMessageAsync(lastCommand)
            ElseIf message.Content.StartsWith(wake & "stats ") And enabledCommand(5) Then
                'stats (currently calls on Fortnite stats bot)
                Dim stats As String = message.Content.Replace(wake & "stats ", "")
                Await message.Channel.SendMessageAsync("!ftn " & stats)
            ElseIf message.Content.StartsWith(wake & "setup ") And remoteControl Then
                'setup
                Dim change As String = message.Content.Replace(wake & "setup ", "")
                If DirectCast(message.Author, SocketGuildUser).Roles.ToList.Contains(DirectCast(message.Channel, IGuildChannel).Guild.GetRole(adminRole)) Or message.Author.Username = DirectCast(message.Author, SocketGuildUser).Guild.Owner.Username And message.Author.Discriminator = DirectCast(message.Author, SocketGuildUser).Guild.Owner.Discriminator Or message.Author.Username & "#" & message.Author.Discriminator = botOwner Then
                    If change.StartsWith("wake") Then
                        change = change.Replace("wake ", "")
                        If change.StartsWith("-s") Or change.StartsWith("-space") Then
                            change = change.Replace("-s ", "")
                            change = change.Replace("-space", "")
                            wakeChange(change, True)
                        Else
                            wakeChange(change, False)
                        End If
                        Await message.Channel.SendMessageAsync("Wakeword changed to `" & wake & "`")
                    ElseIf change.StartsWith("reset") Then
                        reset()
                        Await message.Channel.SendMessageAsync("```prolog" & vbNewLine & "Preferances reset```")
                    End If
                Else
                    Await message.Channel.SendMessageAsync("You do not have a `@moderator` or similar privelage!")
                End If
            End If
            'record last>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            lastCommand = message.Author.Username & " said : " & vbNewLine & "```" & message.Content & "```" & vbNewLine & "Was the last command executed"
            'remove>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If enabledCommand(0) Then
                Await message.DeleteAsync
            End If
        End If
    End Function
    Private Sub wakeChange(newWake As String, space As Boolean)
        If space Then
            wake = newWake & " "
            wakeSpace = True
        Else
            wake = newWake
            wakeSpace = False
        End If
    End Sub
    Private Sub reset()
        wake = "/"
        'save
    End Sub
    Private Async Sub Check_Tick(sender As Object, e As EventArgs) Handles Check.Tick
        If discord.LoginState = LoginState.LoggedIn Then
            lblStatus.Text = "Online"
            btnCon.Text = "Disconnect"
            btnCon.Enabled = True
            Try
                lblUname.Text = discord.CurrentUser.Username.ToString & "#" & discord.CurrentUser.Discriminator
                profilePic = Bitmap.FromStream(New MemoryStream(webClient.DownloadData(discord.CurrentUser.GetAvatarUrl)))
                picProfile.Image = profilePic
                picBot.Visible = True
                If id <> discord.CurrentUser.Id Then
                    dialog.box("Login failed, check ID", "Login failed", vbOK, "Bot ID does not match the Bot token, check credentials and retry." & vbNewLine & "If error persists, visit https://discordapp.com/developers/applications to get a new token.")
                    Close()
                Else
                    Show()
                    login.Close()
                End If
                Await discord.SetGameAsync("TheOneBot by TheOneCode", "https://github.com/TheOneTrueCode/TheOneBot", StreamType.Twitch)
                logger("Loaded profile info sucessfully with " & catcher & " attempts")
                catcher = 0
                Check.Stop()
            Catch
                catcher += 1
                If catcher >= 25 Then
                    Check.Stop()
                    logger("Too many tries, giving up.")
                    MsgBox("Could not catch info, check network connection." & vbNewLine & "Now restarting")
                    Close()
                ElseIf catcher >= 5 Then
                    logger("Loading profile is taking longer than usual (" & catcher & " tries)")
                ElseIf catcher = 1 Then
                    logger("Loading profile info...")
                End If
            End Try
        ElseIf discord.LoginState = LoginState.LoggedOut Then
            logger("Now offline.")
            lblStatus.Text = "Offline"
            btnCon.Text = "Connect"
            btnCon.Enabled = True
            lblUname.Text = "Offline"
            picProfile.Image = My.Resources.none
            Check.Stop()
        ElseIf discord.LoginState = LoginState.LoggingIn Then
            logger("Connecting to discord...")
            lblStatus.Text = "Connecting"
            btnCon.Text = "Connecting"
            btnCon.Enabled = False
            lblUname.Text = "Loading"
            picProfile.Image = My.Resources.none
        ElseIf discord.LoginState = LoginState.LoggingOut Then
            logger("Disconnecting from discord...")
            lblStatus.Text = "Disconnecting"
            btnCon.Text = "Disconnecting"
            btnCon.Enabled = False
            lblUname.Text = "Offline"
            picProfile.Image = My.Resources.none
        Else
            MsgBox("Idk what happened")
            Close()
        End If
    End Sub

    Private Async Sub btnCon_Click(sender As Object, e As EventArgs) Handles btnCon.Click
        If discord.LoginState = LoginState.LoggedIn Then
            Await discord.LogoutAsync
            Check.Start()
        ElseIf discord.LoginState = LoginState.LoggedOut Then
            Await discord.LoginAsync(TokenType.Bot, token)
            Check.Start()
        Else
            MsgBox("Idk what happened")
            Close()
        End If
    End Sub
    Private Sub logger(e As String)
        log.BeginUpdate()
        log.Items.Add(DateString & " " & TimeString & " " & e)
        log.EndUpdate()
    End Sub
    Private Async Sub disconnecting() Handles MyBase.Closing
        Await discord.LogoutAsync
    End Sub

    Private Sub txtWake_TextChanged(sender As Object, e As EventArgs) Handles txtWake.TextChanged
        wakeChange(txtWake.Text, False)
    End Sub

    Private Sub reload() Handles Reloader.Tick
        txtWake.Text = wake
        lblWakeCount.Text = "Characters: " & txtWake.TextLength
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Process.Start(authUrl)
    End Sub
    Private Sub chkDel_CheckedChanged(sender As Object, e As EventArgs) Handles chkDel.CheckedChanged
        enabledCommand(0) = chkDel.Checked
    End Sub
    Private Sub chkHelp_CheckedChanged(sender As Object, e As EventArgs) Handles chkHelp.CheckedChanged
        enabledCommand(1) = chkHelp.Checked
    End Sub
    Private Sub chkPing_CheckedChanged(sender As Object, e As EventArgs) Handles chkPing.CheckedChanged
        enabledCommand(2) = chkHelp.Checked
    End Sub
    Private Sub chkEcho_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcho.CheckedChanged
        enabledCommand(3) = chkHelp.Checked
    End Sub
    Private Sub chkLast_CheckedChanged(sender As Object, e As EventArgs) Handles chkLast.CheckedChanged
        enabledCommand(4) = chkHelp.Checked
    End Sub
    Private Sub chkStats_CheckedChanged(sender As Object, e As EventArgs) Handles chkStats.CheckedChanged
        enabledCommand(5) = chkHelp.Checked
    End Sub

    Private Sub chkRemote_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemote.CheckedChanged
        remoteControl = chkRemote.Checked
    End Sub

    Private Function PingNow(Optional address As String = "discord.com", Optional w As Boolean = False)
        Dim pinger As New Ping
        Dim reply As PingReply = pinger.Send(address)
        If w Then
            Return reply.Address.ToString & "@ " & reply.RoundtripTime & "ms"
        Else
            Return reply.RoundtripTime
        End If
    End Function

    Private Sub Ping_Tick(sender As Object, e As EventArgs) Handles Ping.Tick
        Dim time = PingNow()
        lblPing.Text = time & "ms"
        If time <= 50 Then
            panPing.BackColor = System.Drawing.Color.Green
        ElseIf time <= 250 Then
            panPing.BackColor = System.Drawing.Color.GreenYellow
        Else
            panPing.BackColor = System.Drawing.Color.Red
        End If
    End Sub
End Class
