Imports System.Net
Imports System.IO
Imports System.IO.Compression.ZipFile
Imports System.Threading.Thread
Imports System.ComponentModel

Public Class update
    'Version 0.01 hasn't even been released yet, wait for update to update.
    Const netRequired As Double = 4.7
    Const version As Double = 0.01
    Const netDownload As String = "http://go.microsoft.com/fwlink/?LinkId=863262"
    Const TheOneBotZip As String = "https://cdn.discordapp.com/attachments/459412645951569920/461336795574173716/test.zip"
    ReadOnly backup As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\backup"
    ReadOnly configure As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\TheOneBot\location.config"
    Dim TheOneBotZipLocation As String = AppDomain.CurrentDomain.BaseDirectory & "update\update.zip"
    Dim installLocation As String = ""
    Dim updateLocation As String = AppDomain.CurrentDomain.BaseDirectory & "update\"
    Dim netDownloadLocation As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\dotnet4.7.exe"
    Dim netversion As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full", "Version", 4)
    Dim bottomText = ""
    Dim bottomDots As Integer = 0
    Dim client As WebClient = New WebClient
    Dim reader As StreamReader
    Dim doneUpdate As Boolean = False
    Private Sub update_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Directory.Exists(updateLocation) Then
            Dim directories As New DirectoryInfo(updateLocation)
            ' Get a reference to each file in that directory.
            Dim directoryInfo As FileInfo() = directories.GetFiles()
            ' Display the names of the files.
            For Each f As FileInfo In directoryInfo
                f.Delete()
            Next f
            Directory.Delete(updateLocation)
        End If
        If Directory.Exists(backup) Then
            Dim directories As New DirectoryInfo(backup)
            Dim directoryInfo As FileInfo() = directories.GetFiles()
            For Each f As FileInfo In directoryInfo
                f.Delete()
            Next f
        ElseIf Directory.Exists(backup) = False Then
            Try
                Directory.CreateDirectory(backup)
            Catch ex As Exception
                bottomText = "(╯°□°）╯︵ ┻━┻"
                Sleep(5000)
            End Try
        End If
        Directory.CreateDirectory(updateLocation)
        If File.Exists(TheOneBotZipLocation) Then
            File.Delete(TheOneBotZipLocation)
        End If
        If File.Exists(configure) Then
            reader = My.Computer.FileSystem.OpenTextFileReader(configure)
            installLocation = reader.ReadLine
            reader.Close()
            checkFramework()
        Else
            bottomText = "Previous version could not be found"
            fatalError()
        End If
    End Sub
    Private Sub checkFramework()
        bottomText = "Checking .net framework"
        Dim netVersionDot = netversion.LastIndexOf(".")
        Dim netversionDoub As Double = netversion.Substring(0, netVersionDot)
        If netversionDoub < netRequired Then
            progress.Visible = True
            bottomText = "Downloading .net " & netRequired
            getFramework()
        Else
            updateTheOneBot()
        End If
    End Sub
    Private Sub getFramework()
        progress.Visible = True
        AddHandler client.DownloadProgressChanged, AddressOf ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf DownloadCompleted
        client.DownloadFileAsync(New Uri(netDownload), netDownloadLocation)
    End Sub
    Private Sub ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 1000
        Dim percentageOn100 As Integer = bytesIn / totalBytes * 100
        bottomText = "Downloading .net " & netRequired & " " & percentageOn100 & "% complete"
        progress.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    Private Sub DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        bottomText = "Installing .net framework " & netRequired
        progress.Value = 0
        progress.Visible = False
        Try
            Process.Start(netDownloadLocation).WaitForExit()
            updateTheOneBot()
        Catch ex As Exception
            bottomText = "Canceled by user"
            fatalError()
        End Try
    End Sub
    Private Sub updateTheOneBot()
        bottomText = "Downloading update"
        progress.Visible = True
        AddHandler client.DownloadProgressChanged, AddressOf UpdateProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf UpdateExtract
        client.DownloadFileAsync(New Uri(TheOneBotZip), TheOneBotZipLocation)
    End Sub
    Private Sub UpdateProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 1000
        Dim percentageOn100 As Integer = bytesIn / totalBytes * 100
        bottomText = "Downloading update " & version & " " & percentageOn100 & "% complete"
        progress.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    Private Sub UpdateExtract(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        bottomText = "Extracting update contents"
        progress.Value = 0
        progress.Visible = False
        Try
            ExtractToDirectory(TheOneBotZipLocation, updateLocation)
            bottomText = "Extracted successfully"
            deleteZip()
        Catch ex As Exception
            bottomText = "Corrupted .zip file"
            fatalError()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub deleteZip()
        File.Delete(TheOneBotZipLocation)
        Sleep(1000)
        updateNow()
    End Sub
    Private Sub updateNow()
        bottomText = "Installing"
        Try
            Dim directories
            Dim directoryInfo As FileInfo()
            If Directory.Exists(installLocation) Then
                directories = New DirectoryInfo(installLocation)
                directoryInfo = directories.GetFiles()
                For Each f As FileInfo In directoryInfo
                    If f.Name.EndsWith(".exe") Or f.Name.EndsWith(".dll") Or f.Name.EndsWith(".xml") Or f.Name.EndsWith(".zip") Then
                        f.Delete()
                    Else
                        Try
                            If Directory.Exists(backup) = False Then
                                Directory.CreateDirectory(backup)
                            End If
                        Catch ex As Exception
                            bottomText = bottomText & " error"
                        End Try
                        If File.Exists(backup & "\" & f.Name) Then
                            File.Delete(backup & "\" & f.Name)
                        End If
                        Try
                            f.MoveTo(backup)
                        Catch
                            f.Delete()
                            bottomText = bottomText & " error"
                        End Try
                    End If
                Next f
                Directory.Delete(installLocation)
            End If
            Sleep(100)
            Directory.Move(updateLocation, installLocation)
            If Directory.Exists(backup) Then
                directories = New DirectoryInfo(backup)
                directoryInfo = directories.GetFiles
                For Each f As FileInfo In directoryInfo
                    f.MoveTo(installLocation)
                Next f
            Else
                bottomText = bottomText & " error"
            End If
        Catch ex As Exception
            bottomText = "Couldn't copy, check permissions"
            fatalError()
        End Try
        If bottomText.Contains("error") Then
            bottomText = "Installation complete, with backup errors"
            Sleep(2000)
        End If
        bottomText = "Installation complete, cleaning up"
        Sleep(1000)
        done()
    End Sub
    Private Sub done()
        Dots.Stop()
        btnLaunch.Visible = True
        bottomText = "Update Complete"
        lblText.Text = bottomText & "."
        lblName.Text = "Done"
        doneUpdate = True
    End Sub
    Private Sub fatalError()
        Dots.Stop()
        lblName.Text = "Update failed"
        lblText.Text = bottomText & "." & vbNewLine & "Try the installer."
        btnOK.Visible = True
    End Sub
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

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Try
            Process.Start(installLocation & "TheOneBot.exe")
            Close()
        Catch ex As Exception
            bottomText = "Launch failed"
            lblText.Text = bottomText & "."
            lblName.Text = "Error"
            btnLaunch.Visible = False
            btnOK.Visible = True
        End Try
    End Sub

    Private Sub update_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If doneUpdate = False Then
            Dim message = MsgBox("Are you sure you would like to cancel" & vbNewLine & "(probably a bad idea)", vbYesNo)
            If message = vbYes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        doneUpdate = True
        Close()
    End Sub
End Class