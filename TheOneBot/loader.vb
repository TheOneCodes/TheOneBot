Imports System.Net
Public NotInheritable Class loader
    Dim bottomText As String = "Loading"
    Dim bottomDots As Single = 3
    Private Sub loader_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Ping("discord.gg") Then
            Download()
        Else
            Dim dialogBox = New dialog
            dialogBox.box("Check network connection" & vbNewLine & "An internet connection is required for this app", "No Internet", vbAbort & vbRetry, "No internet or limited access")
        End If
    End Sub
    Private Sub checkUpdate()
        bottomText = "Checking for update"
    End Sub
    Private Sub Download()
        bottomText = "Downloading update"
        progress.Visible = True
        Dim client As WebClient = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf DownloadCompleted
        client.DownloadFileAsync(New Uri("http://speedtest.ftp.otenet.gr/files/test10Mb.db"), My.Application.Info.DirectoryPath & "\test")
    End Sub
    Private Sub ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 1000
        progress.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    Private Sub DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        progress.Value = 0
        MessageBox.Show("Download Complete")
        progress.Visible = False
        login.Show()
        Close()
    End Sub
    Public Function Ping(e As String) As Boolean
        Try
            Return My.Computer.Network.Ping(e)
        Catch
            Return False
        End Try
    End Function

    Private Sub Dots_Tick(sender As Object, e As EventArgs) Handles Dots.Tick
        If bottomDots = 0 Then
            lblText.Text = bottomText
            bottomDots = 1
        ElseIf bottomDots = 1 Then
            lblText.Text = bottomText & "."
            bottomDots = 2
        ElseIf bottomDots = 2 Then
            lblText.Text = bottomText & ".."
            bottomDots = 3
        ElseIf bottomDots = 3 Then
            lblText.Text = bottomText & "..."
            bottomDots = 0
        Else
            bottomDots = 0
            lblText.Text = bottomText & "..."
        End If
    End Sub
End Class
