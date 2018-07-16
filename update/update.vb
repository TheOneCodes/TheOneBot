Imports System.Net
Imports System.IO
Imports System.Threading.Thread
Imports System.ComponentModel

Public Class update
    'Version 0.01 hasn't even been released yet, wait for update to update.
    Const netRequired As Double = 4.7
    Const version As Double = 0.01
    Const netDownload As String = "http://go.microsoft.com/fwlink/?LinkId=863262"
    Const TheOneBot As String = "https://cdn.discordapp.com/attachments/459412645951569920/468134501684477954/TheOneBot.exe"
    ReadOnly configure As String = Directory.GetParent(Directory.GetParent(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData).FullName).FullName & Path.DirectorySeparatorChar & "location.config"
    Dim TheOneBotLocation As String = AppDomain.CurrentDomain.BaseDirectory & "updated.exe"
    Dim installLocation As String = "C:\Program Files\TheOneBot\"
    Dim netDownloadLocation As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\dotnet4.7.exe"
    Dim netversion As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full", "Version", 4)
    Public bottomText = "Waiting"
    Dim bottomDots As Integer = 0
    Dim client As WebClient = New WebClient
    Dim reader As StreamReader
    Dim doneUpdate As Boolean = False
    Private Sub Update_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If File.Exists(configure) Then
            reader = My.Computer.FileSystem.OpenTextFileReader(configure)
            installLocation = reader.ReadLine
            reader.Close()
            Try
                If File.Exists(installLocation & "TheOneBot.exe") Then
                    Try
                        File.Delete(installLocation & "TheOneBot.exe")
                    Catch ex As DirectoryNotFoundException
                        FatalError("Origional not found," & vbNewLine & "Try the installer.")
                    Catch ex As UnauthorizedAccessException
                        Dim user As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
                        Dim principal As System.Security.Principal.WindowsPrincipal = New System.Security.Principal.WindowsPrincipal(user)
                        If principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator) Then
                            FatalError()
                        Else
                            RequireAdmin()
                        End If
                    End Try
                End If
            Catch
                Dim user As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
                Dim principal As System.Security.Principal.WindowsPrincipal = New System.Security.Principal.WindowsPrincipal(user)
                If principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator) Then
                    FatalError()
                Else
                    RequireAdmin()
                End If
            End Try
            CheckFramework()
        Else
            bottomText = "Previous version could not be found"
            FatalError("Origional not found," & vbNewLine & "Try the installer.")
        End If
    End Sub
    Private Sub RequireAdmin()
        bottomText = "Asking for admin"
        Dim procStartInfo As New ProcessStartInfo With {
            .FileName = Application.ExecutablePath(),
            .Verb = "runas"
        }
        Process.Start(procStartInfo)
        Sleep(1000)
        doneUpdate = True
        Close()
    End Sub
    Private Sub CheckFramework()
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
    Private Sub GetFramework()
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
    Private Sub DownloadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        bottomText = "Installing .net framework " & netRequired
        progress.Value = 0
        progress.Visible = False
        Try
            Process.Start(netDownloadLocation).WaitForExit()
            UpdateTheOneBot()
        Catch ex As Exception
            bottomText = "Canceled by user"
            FatalError()
        End Try
    End Sub
    Private Sub UpdateTheOneBot()
        bottomText = "Downloading update"
        progress.Visible = True
        AddHandler client.DownloadProgressChanged, AddressOf UpdateProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf updateNow
        client.DownloadFileAsync(New Uri(TheOneBot), TheOneBotLocation)
    End Sub
    Private Sub UpdateProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 1000
        Dim percentageOn100 As Integer = bytesIn / totalBytes * 100
        bottomText = "Downloading update" & vbNewLine & Math.Round(bytesIn / 1000000, 2, MidpointRounding.AwayFromZero) & "MB " & percentageOn100 & "% complete"
        progress.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    Private Sub UpdateNow()
        progress.Visible = False
        bottomText = "Installing"
        File.Move(TheOneBotLocation, installLocation & "TheOneBot.exe")
        bottomText = "Installation complete, cleaning up"
        Sleep(1000)
        Done()
    End Sub
    Private Sub Done()
        progress.Visible = False
        WindowState = FormWindowState.Normal
        Cursor = Cursors.Default
        btnLaunch.Visible = True
        bottomText = "Update Complete"
        lblText.Text = bottomText & "."
        lblName.Text = "Done"
        doneUpdate = True
        Dots.Stop()
    End Sub
    Public Sub FatalError(Optional s As String = "Fatal Error," & vbNewLine & "Try the installer.")
        progress.Visible = False
        WindowState = FormWindowState.Normal
        Cursor = Cursors.Default
        lblName.Text = "Update failed"
        lblText.Text = s
        btnOK.Visible = True
        Dots.Stop()
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

    Private Sub BtnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Try
            Process.Start(installLocation & "TheOneBot.exe")
            Close()
        Catch ex As Exception
            bottomText = "Launch failed, " & vbNewLine & "click OK to close"
            lblText.Text = bottomText & "."
            lblName.Text = "Error"
            btnLaunch.Visible = False
            btnOK.Visible = True
        End Try
    End Sub

    Private Sub Update_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If doneUpdate = False Then
            Dim message = MsgBox("Are you sure you would like to cancel" & vbNewLine & "(probably a bad idea)", vbYesNo)
            If message = vbYes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        doneUpdate = True
        Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.ForeColor = Color.Blue
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.ForeColor = Color.White
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMini_MouseEnter(sender As Object, e As EventArgs) Handles btnMini.MouseEnter
        btnMini.Image = My.Resources.minimize_hover
    End Sub

    Private Sub btnMini_MouseLeave(sender As Object, e As EventArgs) Handles btnMini.MouseLeave
        btnMini.Image = My.Resources.minimize
    End Sub
End Class