Imports System.Net
Imports System.IO
Public NotInheritable Class loader
    ReadOnly updateInfo As String = My.Application.Info.DirectoryPath & "\update"           'location to store update info
    ReadOnly updateFile As String = My.Application.Info.DirectoryPath & "\excecute.exe"     'location to store update
    Const version As Decimal = 0.01                                                         'the current version number
    Const stock As Boolean = True                                                           'is this changed (stops auto updates to conserve updates)
    Dim newVersion As Decimal                                                               'the new version id (when loaded from GitHub)
    Dim updatePath As Uri                                                                   'the update download url (installation excecutable)
    Dim bottomText As String = "Loading"                                                    'the information text
    Dim bottomDots As Single = 0                                                            'the tripple dot animation "frame" number
    Dim client As WebClient = New WebClient                                                 'the download client
    Dim reader As StreamReader                                                              'the info reader
    'On load
    Private Sub loader_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'is this stock
        If stock = False Then
            bottomText = "Loading v" & version & " (modified)"
        End If
        'is the internet connected
        If Ping("discord.gg") Then
            If stock Then
                checkUpdate()
            Else
                finish.Start()
            End If
        Else
            Dim dialogBox = New dialog
            'OoF
            dialogBox.box("Check network connection" & vbNewLine & "An internet connection is required for this app", "No Internet", vbAbort & vbRetry, "No internet or limited access")
        End If
    End Sub
    'ping
    Public Function Ping(e As String) As Boolean
        Try
            Return My.Computer.Network.Ping(e)
        Catch
            Return False
        End Try
    End Function
    'check for updates
    Private Sub checkUpdate()
        bottomText = "Checking for update"
        'remove previous files
        If File.Exists(updateInfo) Then
            File.Delete(updateInfo)
        End If
        If File.Exists(updateFile) Then
            File.Delete(updateFile)
        End If
        'check if GitHub still has update files
        If fileExists() Then
            'download
            progress.Visible = True
            AddHandler client.DownloadProgressChanged, AddressOf ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf LoadCompleted
            client.DownloadFileAsync(New Uri("https://theonetruecode.github.io/TheOneBot/release"), updateInfo)
        Else
            bottomText = "Something went wrong"
            finish.Start()
        End If
    End Sub
    'update version
    Private Sub updateVersion()
        bottomText = "Downloading update"
        progress.Visible = True
        AddHandler client.DownloadProgressChanged, AddressOf ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf DownloadCompleted
        client.DownloadFileAsync(updatePath, updateFile)
    End Sub
    'does a web file exist? (automatically the update file)
    Private Function fileExists(Optional f As String = "https://theonetruecode.github.io/TheOneBot/release")
        Try
            Dim request As WebRequest = WebRequest.Create("https://theonetruecode.github.io/TheOneBot/release")
            Dim response As WebResponse = request.GetResponse()
            'yes
            Return True
        Catch ex As Exception
            'no
            Return False
        End Try
    End Function
    'progress updator for downloads
    Private Sub ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 1000
        progress.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    '100% loaded version info
    Private Sub LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        progress.Value = 0
        progress.Visible = False
        reader = My.Computer.FileSystem.OpenTextFileReader(updateInfo)
        newVersion = Convert.ToDecimal(reader.ReadLine)
        updatePath = New Uri(reader.ReadLine)
        If newVersion > version Then
            updateVersion()
        Else
            bottomText = "Done"
            finish.Start()
        End If
    End Sub
    '100% downloaded update
    Private Sub DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        progress.Value = 0
        progress.Visible = False
        bottomText = "Download complete, loading"
        updateNow.Start()
    End Sub
    '... animation
    Private Sub Dots_Tick(sender As Object, e As EventArgs) Handles Dots.Tick
        If bottomDots >= 0 And bottomDots <= 5 Then
            lblText.Text = bottomText
            bottomDots += 1
        ElseIf bottomDots >= 6 And bottomDots <= 10 Then
            lblText.Text = bottomText & "."
            bottomDots += 1
        ElseIf bottomDots >= 11 And bottomDots <= 15 Then
            lblText.Text = bottomText & ".."
            bottomDots += 1
        ElseIf bottomDots >= 16 And bottomDots <= 20 Then
            lblText.Text = bottomText & "..."
            bottomDots += 1
        Else
            bottomDots = 0
            lblText.Text = bottomText & "..."
        End If
    End Sub
    'close when done
    Private Sub Finished(sender As Object, e As EventArgs) Handles finish.Tick
        login.Show()
        Close()
    End Sub
    'update when done
    Private Sub updateNow_Tick(sender As Object, e As EventArgs) Handles updateNow.Tick
        System.Diagnostics.Process.Start(updateFile)
        Close()
    End Sub
End Class
