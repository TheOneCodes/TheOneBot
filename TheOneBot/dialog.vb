Imports System.Windows.Forms

Public Class dialog
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub box(m As String, Optional t As String = "", Optional eo As Boolean = False, Optional e As String = "")
        Show()
        If t <> "" Then
            Text = t
        End If
        lbl.Text = m
        txtInfo.Text = e
        Width = lbl.Width
        Height = 137 + lbl.Height
        If eo = True Then
            lblMore.Visible = True
            txtInfo.Visible = False
        Else
            lblMore.Visible = False
            txtInfo.Visible = False
        End If
    End Sub

    Private Sub lblMore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblMore.LinkClicked
        If txtInfo.Visible = False Then
            txtInfo.Visible = True
            lblMore.Text = "Less details"
            Height = 227 + lbl.Height
            FormBorderStyle = FormBorderStyle.Sizable
        Else
            txtInfo.Visible = False
            lblMore.Text = "More details"
            Height = 137 + lbl.Height
            Width = lbl.Width
            FormBorderStyle = FormBorderStyle.FixedDialog
        End If
    End Sub
End Class
