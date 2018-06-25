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
    Dim remoteControl As Boolean = My.Settings.remoteControl
    Dim enabledCommandTemp = My.Settings.enabledCommand.ToArray
    Dim enabledCommand = New Boolean(5) {False, True, True, True, False, False}
    'load
    Private Async Sub connectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
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
        Reloader.Start()
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
            ElseIf message.Content.StartsWith(wake & "repeat ") And enabledCommand(3) Or message.Content.StartsWith(wake & "echo ") And enabledCommand(3) Then
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
                    ElseIf change.StartsWith("command") Or change.StartsWith("enabled") Or change.StartsWith("commands") Then
                        change = change.Replace("command ", "")
                        change = change.Replace("commands ", "")
                        change = change.Replace("enabled ", "")
                        If change.StartsWith("delete") Then
                            If change.Contains("true") Then
                                enabledCommand(0) = True
                                Await message.Channel.SendMessageAsync("The bot will now delete all sent commands after excecution")
                            Else
                                enabledCommand(0) = False
                                Await message.Channel.SendMessageAsync("The bot will no longer delete sent commands after excecution")
                            End If
                        ElseIf change.StartsWith("help") Or change.StartsWith("commands") Then
                            If change.Contains("true") Then
                                enabledCommand(1) = True
                                Await message.Channel.SendMessageAsync("The bot will now display a list of commands with 'help'")
                            Else
                                enabledCommand(1) = False
                                Await message.Channel.SendMessageAsync("The bot will no longer display a list of commands with 'help'")
                            End If
                        ElseIf change.StartsWith("ping") Then
                            If change.Contains("true") Then
                                enabledCommand(2) = True
                                Await message.Channel.SendMessageAsync("The bot will now ping sites to give responce times with 'ping'")
                            Else
                                enabledCommand(2) = False
                                Await message.Channel.SendMessageAsync("The bot will no longer ping sites to give responce time with 'ping'")
                            End If
                        ElseIf change.StartsWith("echo") Or change.StartsWith("repeat") Then
                            If change.Contains("true") Then
                                enabledCommand(3) = True
                                Await message.Channel.SendMessageAsync("The bot will now echo uselessley on command with 'echo'")
                            Else
                                enabledCommand(3) = False
                                Await message.Channel.SendMessageAsync("The bot will no longer echo uselessley on command with 'echo'")
                            End If
                        ElseIf change.StartsWith("last") Or change.StartsWith("previous") Then
                            If change.Contains("true") Then
                                enabledCommand(4) = True
                                Await message.Channel.SendMessageAsync("The bot will now display the last excecuted command with 'last'")
                            Else
                                enabledCommand(4) = False
                                Await message.Channel.SendMessageAsync("The bot will no longer display the last excecuted command with 'last'")
                            End If
                        ElseIf change.StartsWith("stats") Then
                            If change.Contains("true") Then
                                enabledCommand(5) = True
                                Await message.Channel.SendMessageAsync("'EXPERAMENTAL' stats feature on, be careful")
                            Else
                                enabledCommand(5) = False
                                Await message.Channel.SendMessageAsync("'EXPERAMENTAL' stats feature off")
                            End If
                        ElseIf change.StartsWith("setup") Or change.StartsWith("remote") Or change.StartsWith("admin") Then
                            If change.Contains("true") Then
                                remoteControl = True
                                Await message.Channel.SendMessageAsync("You are using this feature")
                            Else
                                remoteControl = False
                                Await message.Channel.SendMessageAsync("You will no longer be able to remotely administrate this bot")
                            End If
                        End If
                        reload()
                    End If
                Else
                    Await message.Channel.SendMessageAsync("You do not have a `@moderator` or similar privelage!")
                End If
            End If
            'record last
            lastCommand = message.Author.Username & " said : " & vbNewLine & "```" & message.Content & "```" & vbNewLine & "Was the last command executed"
            'remove
            If enabledCommand(0) Then
                Await message.DeleteAsync
            End If
        End If
    End Function
    'changes wake
    Private Sub wakeChange(newWake As String, space As Boolean)
        If space Then
            wake = newWake & " "
            wakeSpace = True
        Else
            wake = newWake
            wakeSpace = False
        End If
        reload()
    End Sub
    Private Sub save()
        My.Settings.remoteControl = remoteControl
        My.Settings.enabledCommand(0) = enabledCommand(0)
        My.Settings.enabledCommand(1) = enabledCommand(1)
        My.Settings.enabledCommand(2) = enabledCommand(2)
        My.Settings.enabledCommand(3) = enabledCommand(3)
        My.Settings.enabledCommand(4) = enabledCommand(4)
        My.Settings.enabledCommand(5) = enabledCommand(5)
        My.Settings.Save()
    End Sub
    Private Sub reset()
        Enabled = False
        wake = "/"
        If enabledCommandTemp(0) = True Then
            enabledCommand(0) = True
        Else
            enabledCommand(0) = False
        End If
        If enabledCommandTemp(1) = True Then
            enabledCommand(1) = True
        Else
            enabledCommand(1) = False
        End If
        If enabledCommandTemp(2) = True Then
            enabledCommand(2) = True
        Else
            enabledCommand(2) = False
        End If
        If enabledCommandTemp(3) = True Then
            enabledCommand(3) = True
        Else
            enabledCommand(3) = False
        End If
        If enabledCommandTemp(4) = True Then
            enabledCommand(4) = True
        Else
            enabledCommand(4) = False
        End If
        If enabledCommandTemp(5) = True Then
            enabledCommand(5) = True
        Else
            enabledCommand(5) = False
        End If
        chkDel.Checked = enabledCommand(0)
        chkHelp.Checked = enabledCommand(1)
        chkPing.Checked = enabledCommand(2)
        chkEcho.Checked = enabledCommand(3)
        chkLast.Checked = enabledCommand(4)
        chkStats.Checked = enabledCommand(5)
        remoteControl = My.Settings.remoteControl
        Enabled = True
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
        save()
        Await discord.LogoutAsync
    End Sub

    Private Sub txtWake_TextChanged(sender As Object, e As EventArgs) Handles txtWake.TextChanged
        wakeChange(txtWake.Text, False)
    End Sub

    Private Sub reload() Handles Reloader.Tick
        txtWake.Text = wake
        lblWakeCount.Text = "Characters: " & txtWake.TextLength
        chkDel.Checked = enabledCommand(0)
        chkHelp.Checked = enabledCommand(1)
        chkPing.Checked = enabledCommand(2)
        chkEcho.Checked = enabledCommand(3)
        chkLast.Checked = enabledCommand(4)
        chkStats.Checked = enabledCommand(5)
        chkRemote.Checked = remoteControl
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
        enabledCommand(2) = chkPing.Checked
    End Sub
    Private Sub chkEcho_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcho.CheckedChanged
        enabledCommand(3) = chkEcho.Checked
    End Sub
    Private Sub chkLast_CheckedChanged(sender As Object, e As EventArgs) Handles chkLast.CheckedChanged
        enabledCommand(4) = chkLast.Checked
    End Sub
    Private Sub chkStats_CheckedChanged(sender As Object, e As EventArgs) Handles chkStats.CheckedChanged
        enabledCommand(5) = chkStats.Checked
    End Sub
    Private Sub chkRemote_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemote.CheckedChanged
        remoteControl = chkRemote.Checked
    End Sub
    Private Function PingNow(Optional address As String = "discord.com", Optional w As Boolean = False)
        Try
            Dim pinger As New Ping
            Dim reply As PingReply = pinger.Send(address)
            If w Then
                Return reply.Address.ToString & " took " & reply.RoundtripTime & "ms"
            Else
                Return reply.RoundtripTime
            End If
        Catch
            Return address & " could not connect!"
        End Try
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
