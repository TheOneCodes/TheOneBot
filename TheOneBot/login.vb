Imports System.ComponentModel

Public Class login

    Public Token
    Public ID
    Dim animTick As Integer
    Dim ready As Boolean = True
    Dim waitmark As Integer = 0

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Enabled = False
        main.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged, PasswordTextBox.TextChanged
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Or PasswordTextBox.TextLength <> 59 Or UsernameTextBox.Text.Length <> 18 Or PasswordTextBox.Text.IndexOf(".") <> 24 Or PasswordTextBox.Text.LastIndexOf(".") <> 31 Or IsNumeric(UsernameTextBox.Text) = False Then
            OK.Enabled = False
        Else
            OK.Enabled = True
        End If
        Token = PasswordTextBox.Text
        ID = UsernameTextBox.Text
    End Sub

    Private Sub lblReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblReset.LinkClicked
        System.Diagnostics.Process.Start("https://discordapp.com/developers/applications")
    End Sub

    Public Sub failed(e As Exception)
        dialog.box("Login failed, check credentials", "Login Failed", vbOK, e.ToString)
        Enabled = True
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(210, 231)
        pbFull.Location = New Point(0, 0)
        pbFull.BringToFront()
        Tooltip.SetToolTip(UsernameTextBox, "Seemingly random, 18 numeric characters, always numeric" & vbNewLine & "The bot ID is not entirely required, but used as an extra level of security")
        Tooltip.SetToolTip(PasswordTextBox, "Seemingly random, 59 alphanumeric characters, always a '.' at character 25 and 32" & vbNewLine & "The token is more of a ""Password"" for the bot")
        If Ping("google.ca") = False Then
            Enabled = False
            dialog.box("Could not connect to internet," & vbNewLine & "Please check connection and try again", "Connection issue", vbOK, "ping google.com returned false" & vbNewLine & "internet.connected returned false")
        End If
    End Sub

    Public Function Ping(e As String) As Boolean
        Try
            Return My.Computer.Network.Ping(e)
        Catch
            Return False
        End Try
    End Function

    Private Sub animate_Tick(sender As Object, e As EventArgs) Handles animate.Tick
        animTick += 1
        If animTick > 20 Then
            If Width <= 420 Then
                Width += 16
                Location = New Point(Location.X - 8, Location.Y)
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

    Private Sub etamina_Tick(sender As Object, e As EventArgs) Handles etamina.Tick
        animTick -= 1
        If Width > 210 Then
            Width -= 16
            Location = New Point(Location.X + 8, Location.Y)
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

    Private Sub login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ready Then
            e.Cancel = ready
            etamina.Start()
        End If
    End Sub

End Class
