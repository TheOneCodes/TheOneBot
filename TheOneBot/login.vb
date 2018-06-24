Imports System.ComponentModel

Public Class login
    Public Token                    'discord bot token ID
    Public ID                       'the bot's user ID (for added security)
    Dim animTick As Integer         'ticks for the animation
    Dim ready As Boolean = True     'ready to close (lets the animation run)
    'On load setup
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(210, 231)
        Location = New Point(My.Computer.Screen.WorkingArea.Width / 2 - Width / 2, My.Computer.Screen.WorkingArea.Height / 2 - Height / 2)
        pbFull.Location = New Point(0, 0)
        pbFull.BringToFront()
        Tooltip.SetToolTip(UsernameTextBox, "Seemingly random, 18 numeric characters, always numeric" & vbNewLine & "The bot ID is not entirely required, but used as an extra level of security")
        Tooltip.SetToolTip(PasswordTextBox, "Seemingly random, 59 alphanumeric characters, always a '.' at character 25 and 32" & vbNewLine & "The token is more of a ""Password"" for the bot")
        If Ping("discord.gg") = False Then
            Enabled = False
            dialog.box("Lost network connection," & vbNewLine & "Please check connection and try again", "Connection issue", vbOK, "ping discord returned false" & vbNewLine & "internet.connected returned false")
        End If
    End Sub
    'when entries are made
    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged, PasswordTextBox.TextChanged
        'Do they follow the Discord Token or ID rules (I'll specify them in a .md file
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Or PasswordTextBox.TextLength <> 59 Or UsernameTextBox.Text.Length <> 18 Or PasswordTextBox.Text.IndexOf(".") <> 24 Or PasswordTextBox.Text.LastIndexOf(".") <> 31 Or IsNumeric(UsernameTextBox.Text) = False Then
            OK.Enabled = False
        Else
            OK.Enabled = True
        End If
        Token = PasswordTextBox.Text
        ID = UsernameTextBox.Text
    End Sub
    'link to discord developper console (you can obtain a bot id and token here)
    Private Sub lblReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblReset.LinkClicked
        System.Diagnostics.Process.Start("https://discordapp.com/developers/applications")
    End Sub
    'when failed (called from other form
    Public Sub failed(e As Exception)
        dialog.box("Login failed, check credentials", "Login Failed", vbOK, e.ToString)
        Enabled = True
    End Sub
    'pings an indicated server
    Public Function Ping(e As String) As Boolean
        Try
            Return My.Computer.Network.Ping(e)
        Catch
            Return False
        End Try
    End Function
    'Open animation
    Private Sub animate_Tick(sender As Object, e As EventArgs) Handles animate.Tick
        animTick += 1
        If animTick > 20 Then
            If Width <= 420 Then
                Width += 16
                Location = New Point(My.Computer.Screen.WorkingArea.Width / 2 - Width / 2, My.Computer.Screen.WorkingArea.Height / 2 - Height / 2)
            ElseIf Width > 420 Then
                Width = 420
            End If
            If pbFull.Width > pbImg.Width Then
                pbFull.Width -= 8
            Else
                pbFull.Visible = False
            End If
            If pbFull.Visible = False And Width = 420 Then
                animate.Stop()
            End If
        End If
    End Sub
    'close animation
    Private Sub etamina_Tick(sender As Object, e As EventArgs) Handles etamina.Tick
        animTick -= 1
        If Width > 210 Then
            Width -= 16
            Location = New Point(My.Computer.Screen.WorkingArea.Width / 2 - Width / 2, My.Computer.Screen.WorkingArea.Height / 2 - Height / 2)
        ElseIf Width < 210 Then
            Width = 210
        End If
        If pbFull.Width >= 194 Then
            pbFull.Width = 194
        ElseIf pbFull.Width < pbImg.Width Then
            pbFull.Visible = False
            pbFull.Width += 8
        ElseIf pbFull.Width >= pbImg.Width Then
            pbFull.Visible = True
            pbFull.Width += 8
        End If
        If pbFull.Width = 194 And Width = 210 Then
            If animTick = 0 Then
                ready = False
                Close()
                etamina.Stop()
            End If
        End If
    End Sub
    'OK
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Enabled = False
        main.Show()
    End Sub
    'Cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    'close
    Private Sub login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ready Then
            e.Cancel = ready
            etamina.Start()
        End If
    End Sub

End Class
