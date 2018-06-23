Imports Discord
Imports Discord.WebSocket
Imports System.Net
Imports System.IO
Imports System.Drawing.Color
Public Class main
    Dim catcher As Integer
    Dim webClient As WebClient = New WebClient
    Dim profilePic As Bitmap
    Dim discord As New DiscordSocketClient(New DiscordSocketConfig With {.MessageCacheSize = 50})
    Dim token As String '= "'Bot Token"
    Dim id As String '= "Bot ID"
    Dim authUrl As String = "https://discordapp.com/api/oauth2/authorize?client_id=" & id & "&permissions=0&scope=bot"
    Dim wake As String = "/"
    Dim wakeSpace As Boolean = False
    Dim lastCommand As String = "[NO VAR SAVED]"
    Private Async Sub connectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = FromArgb(44, 47, 51)
        ForeColor = White
        tabGeneral.ForeColor = Black
        AddHandler discord.MessageReceived, AddressOf onMessage
        Try
            Await discord.LoginAsync(TokenType.Bot, token)
            logger("Login Sucessfull, bot online!")
        Catch ex As Exception
            logger("Login Failed, bot offline!")
            MsgBox("Login Failed" & vbNewLine & "Check token code", vbOK, "Exception occured")
            Close()
        End Try
        Await discord.StartAsync()
    End Sub
    'var/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Async Function onMessage(message As SocketMessage) As Task
        If message.Source <> MessageSource.Bot And message.Content.StartsWith(wake) Then
            If message.Content.StartsWith(wake & "help") Or message.Content.StartsWith(wake & "commands") Then
                If DirectCast(message.Author, SocketGuildUser).Roles.ToList.Contains(DirectCast(message.Channel, IGuildChannel).Guild.GetRole("454406710044393484")) Or DirectCast(message.Author, SocketGuildUser).Roles.ToList.Contains(DirectCast(message.Channel, IGuildChannel).Guild.GetRole("406993865233661963")) Then
                    Await message.Channel.SendMessageAsync(txtHelp.Text.Replace("{wake}", wake) & vbNewLine & txtHelpAdmin.Text.Replace("{wake}", wake))
                Else
                    Await message.Channel.SendMessageAsync(txtHelp.Text.Replace("{wake}", wake))
                End If
            ElseIf message.Content.StartsWith(wake & "repeat ") Or message.Content.StartsWith(wake & "echo ") Then
                'echo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim repeat As String = message.Content
                repeat = repeat.Replace(wake & "repeat ", "")
                repeat = repeat.Replace(wake & "echo ", "")
                repeat = message.Author.Username & " said : " & repeat
                Await message.Channel.SendMessageAsync(repeat)
                logger(message.Author.Username & " echoed " & repeat)
            ElseIf message.Content.StartsWith(wake & "last") Then
                'last~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Await message.Channel.SendMessageAsync(lastCommand)
            ElseIf message.Content.StartsWith(wake & "stats ") Then
                'stats~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim stats As String = message.Content.Replace(wake & "stats ", "")
                Await message.Channel.SendMessageAsync("!ftn " & stats)
            ElseIf message.Content.StartsWith(wake & "setup ") Then
                'SETUP~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Dim change As String = message.Content.Replace(wake & "setup ", "")
                If DirectCast(message.Author, SocketGuildUser).Roles.ToList.Contains(DirectCast(message.Channel, IGuildChannel).Guild.GetRole("454406710044393484")) Or DirectCast(message.Author, SocketGuildUser).Roles.ToList.Contains(DirectCast(message.Channel, IGuildChannel).Guild.GetRole("406993865233661963")) Then
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
            Await message.DeleteAsync
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

    Private Sub Load_Tick(sender As Object, e As EventArgs) Handles Loader.Tick
        txtWake.Text = wake
        lblWakeCount.Text = "Characters: " & txtWake.TextLength
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        System.Diagnostics.Process.Start(authUrl)
    End Sub
End Class
