Imports System.ComponentModel
Imports System.Windows.Forms

Public Class dialog
    Private Sub OK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Abort(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        If loader.Visible = True Then
            loader.Close()
        End If
        Me.DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub Retry(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetry.Click
        If loader.Visible = True Then
            loader.Close()
            loader.Show()
        End If
        Me.DialogResult = DialogResult.Retry
        Me.Close()
    End Sub

    Private Sub Ignore(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgnore.Click
        Me.DialogResult = DialogResult.Ignore
        Me.Close()
    End Sub

    Public Sub box(m As String, Optional t As String = "", Optional b As Integer = vbOK, Optional e As String = "")
        Show()
        If b = vbOKCancel Then
            btnOK.Visible = True
            btnCancel.Visible = True
        ElseIf b = vbOK Or b = vbOKOnly Then
            btnOK.Visible = True
        ElseIf b = vbAbortRetryIgnore Then
            btnIgnore.Visible = True
            btnRetry.Visible = True
            btnAbort.Visible = True
        ElseIf b = vbAbort & vbRetry Then
            btnRetry.Visible = True
            btnAbort.Visible = True
        ElseIf b = vbAbort Then
            btnAbort.Visible = True
        Else
            btnOK.Visible = True
        End If
        If t <> "" Then
            Text = t
        End If
        lbl.Text = m
        txtInfo.Text = e
        Width = lbl.Width
        Height = 137 + lbl.Height
        If e <> "" Then
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

    Private Sub dialog_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If loader.Visible = True Then
            loader.Close()
        End If
    End Sub
End Class
