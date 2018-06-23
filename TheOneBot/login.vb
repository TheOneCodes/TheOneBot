Public Class login

    Public Token
    Public ID

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Enabled = False
        main.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged, PasswordTextBox.TextChanged
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Or PasswordTextBox.TextLength <> 59 Or PasswordTextBox.Text.IndexOf(".") <> 24 Or PasswordTextBox.Text.LastIndexOf(".") <> 31 Or IsNumeric(UsernameTextBox.Text) = False Then
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
        dialog.box("Login failed, check credentials", "Login Failed", True, e.ToString)
        Enabled = True
    End Sub
End Class
