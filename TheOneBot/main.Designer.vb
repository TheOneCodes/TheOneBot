Imports System.Drawing.Color
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCon = New System.Windows.Forms.Button()
        Me.chkRemote = New System.Windows.Forms.CheckBox()
        Me.tblTop = New System.Windows.Forms.TableLayoutPanel()
        Me.flowTopLeft = New System.Windows.Forms.FlowLayoutPanel()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.picBot = New System.Windows.Forms.PictureBox()
        Me.flowTopRight = New System.Windows.Forms.FlowLayoutPanel()
        Me.panPing = New System.Windows.Forms.Panel()
        Me.lblPing = New System.Windows.Forms.Label()
        Me.secondlast = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.flowGeneral = New System.Windows.Forms.FlowLayoutPanel()
        Me.tblWake = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWake = New System.Windows.Forms.Label()
        Me.txtWake = New System.Windows.Forms.TextBox()
        Me.lblWakeCount = New System.Windows.Forms.Label()
        Me.tblUser = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDiscrim = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tblMod = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMod = New System.Windows.Forms.Label()
        Me.txtMod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.txtGame = New System.Windows.Forms.TextBox()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.tabCom = New System.Windows.Forms.TabPage()
        Me.flowCommand = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkDel = New System.Windows.Forms.CheckBox()
        Me.chkHelp = New System.Windows.Forms.CheckBox()
        Me.chkPing = New System.Windows.Forms.CheckBox()
        Me.chkEcho = New System.Windows.Forms.CheckBox()
        Me.chkLast = New System.Windows.Forms.CheckBox()
        Me.chkStats = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabHelp = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panHelpAdm = New System.Windows.Forms.Panel()
        Me.txtHelpAdmin = New System.Windows.Forms.TextBox()
        Me.panHelp = New System.Windows.Forms.Panel()
        Me.txtHelp = New System.Windows.Forms.TextBox()
        Me.tabLog = New System.Windows.Forms.TabPage()
        Me.log = New System.Windows.Forms.ListBox()
        Me.Check = New System.Windows.Forms.Timer(Me.components)
        Me.Reloader = New System.Windows.Forms.Timer(Me.components)
        Me.Ping = New System.Windows.Forms.Timer(Me.components)
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.trayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.trayName = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.trayWake = New System.Windows.Forms.ToolStripTextBox()
        Me.trayGame = New System.Windows.Forms.ToolStripTextBox()
        Me.trayStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.trayConnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.trayDisconnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.trayQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tblMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblTop.SuspendLayout()
        Me.flowTopLeft.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flowTopRight.SuspendLayout()
        Me.secondlast.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.flowGeneral.SuspendLayout()
        Me.tblWake.SuspendLayout()
        Me.tblUser.SuspendLayout()
        Me.tblMod.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tabCom.SuspendLayout()
        Me.flowCommand.SuspendLayout()
        Me.tabHelp.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panHelpAdm.SuspendLayout()
        Me.panHelp.SuspendLayout()
        Me.tabLog.SuspendLayout()
        Me.trayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 1
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Controls.Add(Me.Panel1, 0, 2)
        Me.tblMain.Controls.Add(Me.tblTop, 0, 0)
        Me.tblMain.Controls.Add(Me.secondlast, 0, 1)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(0, 0)
        Me.tblMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 3
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tblMain.Size = New System.Drawing.Size(940, 505)
        Me.tblMain.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.btnCon)
        Me.Panel1.Controls.Add(Me.chkRemote)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 457)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 44)
        Me.Panel1.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(3, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(192, 36)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Offline"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCon
        '
        Me.btnCon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCon.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCon.Location = New System.Drawing.Point(791, 4)
        Me.btnCon.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(137, 36)
        Me.btnCon.TabIndex = 0
        Me.btnCon.Text = "Connect"
        Me.btnCon.UseVisualStyleBackColor = False
        '
        'chkRemote
        '
        Me.chkRemote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkRemote.AutoSize = True
        Me.chkRemote.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRemote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkRemote.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.chkRemote.Location = New System.Drawing.Point(617, 7)
        Me.chkRemote.Name = "chkRemote"
        Me.chkRemote.Size = New System.Drawing.Size(167, 32)
        Me.chkRemote.TabIndex = 4
        Me.chkRemote.Text = "Remote Admin"
        Me.chkRemote.UseVisualStyleBackColor = True
        '
        'tblTop
        '
        Me.tblTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.tblTop.ColumnCount = 2
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tblTop.Controls.Add(Me.flowTopLeft, 0, 0)
        Me.tblTop.Controls.Add(Me.flowTopRight, 1, 0)
        Me.tblTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTop.Location = New System.Drawing.Point(3, 3)
        Me.tblTop.Name = "tblTop"
        Me.tblTop.RowCount = 1
        Me.tblTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTop.Size = New System.Drawing.Size(934, 51)
        Me.tblTop.TabIndex = 5
        '
        'flowTopLeft
        '
        Me.flowTopLeft.Controls.Add(Me.picProfile)
        Me.flowTopLeft.Controls.Add(Me.lblUname)
        Me.flowTopLeft.Controls.Add(Me.picBot)
        Me.flowTopLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowTopLeft.Location = New System.Drawing.Point(3, 3)
        Me.flowTopLeft.Name = "flowTopLeft"
        Me.flowTopLeft.Size = New System.Drawing.Size(528, 45)
        Me.flowTopLeft.TabIndex = 5
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.picProfile.BackgroundImage = Global.TheOneBot.My.Resources.Resources.full
        Me.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picProfile.Image = Global.TheOneBot.My.Resources.Resources.circle
        Me.picProfile.Location = New System.Drawing.Point(3, 3)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(40, 40)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 4
        Me.picProfile.TabStop = False
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUname.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUname.Location = New System.Drawing.Point(49, 0)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblUname.Size = New System.Drawing.Size(88, 39)
        Me.lblUname.TabIndex = 2
        Me.lblUname.Text = "Offline"
        Me.lblUname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picBot
        '
        Me.picBot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBot.Image = Global.TheOneBot.My.Resources.Resources.bot
        Me.picBot.Location = New System.Drawing.Point(143, 3)
        Me.picBot.Name = "picBot"
        Me.picBot.Size = New System.Drawing.Size(50, 30)
        Me.picBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBot.TabIndex = 5
        Me.picBot.TabStop = False
        Me.picBot.Visible = False
        '
        'flowTopRight
        '
        Me.flowTopRight.Controls.Add(Me.panPing)
        Me.flowTopRight.Controls.Add(Me.lblPing)
        Me.flowTopRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowTopRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flowTopRight.Location = New System.Drawing.Point(537, 3)
        Me.flowTopRight.Name = "flowTopRight"
        Me.flowTopRight.Size = New System.Drawing.Size(394, 45)
        Me.flowTopRight.TabIndex = 6
        '
        'panPing
        '
        Me.panPing.BackColor = System.Drawing.Color.Red
        Me.panPing.Location = New System.Drawing.Point(361, 3)
        Me.panPing.Name = "panPing"
        Me.panPing.Size = New System.Drawing.Size(30, 30)
        Me.panPing.TabIndex = 3
        '
        'lblPing
        '
        Me.lblPing.AutoSize = True
        Me.lblPing.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPing.Location = New System.Drawing.Point(296, 0)
        Me.lblPing.Name = "lblPing"
        Me.lblPing.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblPing.Size = New System.Drawing.Size(59, 36)
        Me.lblPing.TabIndex = 2
        Me.lblPing.Text = "0ms"
        Me.lblPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'secondlast
        '
        Me.secondlast.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.secondlast.Controls.Add(Me.tabGeneral)
        Me.secondlast.Controls.Add(Me.tabCom)
        Me.secondlast.Controls.Add(Me.tabHelp)
        Me.secondlast.Controls.Add(Me.tabLog)
        Me.secondlast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.secondlast.Location = New System.Drawing.Point(3, 60)
        Me.secondlast.Name = "secondlast"
        Me.secondlast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.secondlast.SelectedIndex = 0
        Me.secondlast.Size = New System.Drawing.Size(934, 390)
        Me.secondlast.TabIndex = 10
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.flowGeneral)
        Me.tabGeneral.Controls.Add(Me.lblGeneral)
        Me.tabGeneral.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabGeneral.ForeColor = System.Drawing.Color.Black
        Me.tabGeneral.Location = New System.Drawing.Point(4, 26)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(926, 360)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'flowGeneral
        '
        Me.flowGeneral.AutoScroll = True
        Me.flowGeneral.Controls.Add(Me.tblWake)
        Me.flowGeneral.Controls.Add(Me.tblUser)
        Me.flowGeneral.Controls.Add(Me.tblMod)
        Me.flowGeneral.Controls.Add(Me.TableLayoutPanel2)
        Me.flowGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowGeneral.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowGeneral.Location = New System.Drawing.Point(3, 43)
        Me.flowGeneral.Name = "flowGeneral"
        Me.flowGeneral.Size = New System.Drawing.Size(920, 314)
        Me.flowGeneral.TabIndex = 5
        '
        'tblWake
        '
        Me.tblWake.ColumnCount = 3
        Me.tblWake.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tblWake.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblWake.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.tblWake.Controls.Add(Me.lblWake, 0, 0)
        Me.tblWake.Controls.Add(Me.txtWake, 1, 0)
        Me.tblWake.Controls.Add(Me.lblWakeCount, 2, 0)
        Me.tblWake.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tblWake.Location = New System.Drawing.Point(3, 3)
        Me.tblWake.Name = "tblWake"
        Me.tblWake.RowCount = 1
        Me.tblWake.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblWake.Size = New System.Drawing.Size(401, 31)
        Me.tblWake.TabIndex = 4
        '
        'lblWake
        '
        Me.lblWake.AutoSize = True
        Me.lblWake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWake.Location = New System.Drawing.Point(3, 0)
        Me.lblWake.Name = "lblWake"
        Me.lblWake.Size = New System.Drawing.Size(144, 31)
        Me.lblWake.TabIndex = 0
        Me.lblWake.Text = "Wake key:"
        Me.lblWake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWake
        '
        Me.txtWake.BackColor = System.Drawing.SystemColors.Control
        Me.txtWake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWake.ForeColor = System.Drawing.Color.Black
        Me.txtWake.Location = New System.Drawing.Point(153, 3)
        Me.txtWake.Name = "txtWake"
        Me.txtWake.Size = New System.Drawing.Size(94, 25)
        Me.txtWake.TabIndex = 1
        Me.txtWake.Text = "/"
        '
        'lblWakeCount
        '
        Me.lblWakeCount.AutoSize = True
        Me.lblWakeCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWakeCount.Location = New System.Drawing.Point(253, 0)
        Me.lblWakeCount.Name = "lblWakeCount"
        Me.lblWakeCount.Size = New System.Drawing.Size(145, 31)
        Me.lblWakeCount.TabIndex = 2
        Me.lblWakeCount.Text = "Characters: "
        Me.lblWakeCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblUser
        '
        Me.tblUser.ColumnCount = 4
        Me.tblUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tblUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.tblUser.Controls.Add(Me.txtDiscrim, 3, 0)
        Me.tblUser.Controls.Add(Me.lblUser, 0, 0)
        Me.tblUser.Controls.Add(Me.txtUser, 1, 0)
        Me.tblUser.Controls.Add(Me.Label3, 2, 0)
        Me.tblUser.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tblUser.Location = New System.Drawing.Point(3, 40)
        Me.tblUser.Name = "tblUser"
        Me.tblUser.RowCount = 1
        Me.tblUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblUser.Size = New System.Drawing.Size(401, 31)
        Me.tblUser.TabIndex = 4
        '
        'txtDiscrim
        '
        Me.txtDiscrim.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiscrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDiscrim.ForeColor = System.Drawing.Color.Black
        Me.txtDiscrim.Location = New System.Drawing.Point(353, 3)
        Me.txtDiscrim.Name = "txtDiscrim"
        Me.txtDiscrim.Size = New System.Drawing.Size(45, 25)
        Me.txtDiscrim.TabIndex = 3
        Me.txtDiscrim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUser.Location = New System.Drawing.Point(3, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(144, 31)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Server admin (you):"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.Control
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.Location = New System.Drawing.Point(153, 3)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(94, 25)
        Me.txtUser.TabIndex = 1
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(253, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Discriminator:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblMod
        '
        Me.tblMod.ColumnCount = 3
        Me.tblMod.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tblMod.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblMod.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.tblMod.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblMod.Controls.Add(Me.lblMod, 0, 0)
        Me.tblMod.Controls.Add(Me.txtMod, 1, 0)
        Me.tblMod.Controls.Add(Me.Label4, 2, 0)
        Me.tblMod.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tblMod.Location = New System.Drawing.Point(3, 77)
        Me.tblMod.Name = "tblMod"
        Me.tblMod.RowCount = 1
        Me.tblMod.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMod.Size = New System.Drawing.Size(401, 31)
        Me.tblMod.TabIndex = 4
        '
        'lblMod
        '
        Me.lblMod.AutoSize = True
        Me.lblMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMod.Location = New System.Drawing.Point(3, 0)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(144, 31)
        Me.lblMod.TabIndex = 0
        Me.lblMod.Text = "Moderator role id:"
        Me.lblMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMod
        '
        Me.txtMod.BackColor = System.Drawing.SystemColors.Control
        Me.txtMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMod.ForeColor = System.Drawing.Color.Black
        Me.txtMod.Location = New System.Drawing.Point(153, 3)
        Me.txtMod.Name = "txtMod"
        Me.txtMod.Size = New System.Drawing.Size(94, 25)
        Me.txtMod.TabIndex = 1
        Me.txtMod.Text = "000000000000000000"
        Me.txtMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(253, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Found by \@role"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblGame, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtGame, 1, 0)
        Me.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 114)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(401, 31)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGame.Location = New System.Drawing.Point(3, 0)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(144, 31)
        Me.lblGame.TabIndex = 0
        Me.lblGame.Text = "Game Info:"
        Me.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGame
        '
        Me.txtGame.BackColor = System.Drawing.SystemColors.Control
        Me.txtGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGame.ForeColor = System.Drawing.Color.Black
        Me.txtGame.Location = New System.Drawing.Point(153, 3)
        Me.txtGame.Name = "txtGame"
        Me.txtGame.Size = New System.Drawing.Size(245, 25)
        Me.txtGame.TabIndex = 1
        Me.txtGame.Text = "TheOneBot"
        '
        'lblGeneral
        '
        Me.lblGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGeneral.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.Location = New System.Drawing.Point(3, 3)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblGeneral.Size = New System.Drawing.Size(920, 40)
        Me.lblGeneral.TabIndex = 3
        Me.lblGeneral.Text = "General"
        Me.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabCom
        '
        Me.tabCom.Controls.Add(Me.flowCommand)
        Me.tabCom.Controls.Add(Me.Label1)
        Me.tabCom.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabCom.ForeColor = System.Drawing.Color.Black
        Me.tabCom.Location = New System.Drawing.Point(4, 26)
        Me.tabCom.Name = "tabCom"
        Me.tabCom.Size = New System.Drawing.Size(926, 360)
        Me.tabCom.TabIndex = 11
        Me.tabCom.Text = "Commands"
        Me.tabCom.UseVisualStyleBackColor = True
        '
        'flowCommand
        '
        Me.flowCommand.AutoScroll = True
        Me.flowCommand.Controls.Add(Me.chkDel)
        Me.flowCommand.Controls.Add(Me.chkHelp)
        Me.flowCommand.Controls.Add(Me.chkPing)
        Me.flowCommand.Controls.Add(Me.chkEcho)
        Me.flowCommand.Controls.Add(Me.chkLast)
        Me.flowCommand.Controls.Add(Me.chkStats)
        Me.flowCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowCommand.Location = New System.Drawing.Point(0, 40)
        Me.flowCommand.Name = "flowCommand"
        Me.flowCommand.Size = New System.Drawing.Size(926, 320)
        Me.flowCommand.TabIndex = 5
        '
        'chkDel
        '
        Me.chkDel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDel.Location = New System.Drawing.Point(3, 3)
        Me.chkDel.Name = "chkDel"
        Me.chkDel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDel.Size = New System.Drawing.Size(342, 25)
        Me.chkDel.TabIndex = 2
        Me.chkDel.Text = "Delete command after excecution:"
        Me.chkDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDel.UseVisualStyleBackColor = True
        '
        'chkHelp
        '
        Me.chkHelp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHelp.Checked = True
        Me.chkHelp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkHelp.Location = New System.Drawing.Point(351, 3)
        Me.chkHelp.Name = "chkHelp"
        Me.chkHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHelp.Size = New System.Drawing.Size(168, 25)
        Me.chkHelp.TabIndex = 2
        Me.chkHelp.Text = "Help:"
        Me.chkHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHelp.UseVisualStyleBackColor = True
        '
        'chkPing
        '
        Me.chkPing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPing.Checked = True
        Me.chkPing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkPing.Location = New System.Drawing.Point(525, 3)
        Me.chkPing.Name = "chkPing"
        Me.chkPing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPing.Size = New System.Drawing.Size(168, 25)
        Me.chkPing.TabIndex = 2
        Me.chkPing.Text = "Ping:"
        Me.chkPing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPing.UseVisualStyleBackColor = True
        '
        'chkEcho
        '
        Me.chkEcho.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEcho.Checked = True
        Me.chkEcho.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEcho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkEcho.Location = New System.Drawing.Point(699, 3)
        Me.chkEcho.Name = "chkEcho"
        Me.chkEcho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkEcho.Size = New System.Drawing.Size(168, 25)
        Me.chkEcho.TabIndex = 2
        Me.chkEcho.Text = "Echo:"
        Me.chkEcho.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEcho.UseVisualStyleBackColor = True
        '
        'chkLast
        '
        Me.chkLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkLast.Location = New System.Drawing.Point(3, 34)
        Me.chkLast.Name = "chkLast"
        Me.chkLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLast.Size = New System.Drawing.Size(168, 25)
        Me.chkLast.TabIndex = 2
        Me.chkLast.Text = "Previous:"
        Me.chkLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLast.UseVisualStyleBackColor = True
        '
        'chkStats
        '
        Me.chkStats.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkStats.Location = New System.Drawing.Point(177, 34)
        Me.chkStats.Name = "chkStats"
        Me.chkStats.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkStats.Size = New System.Drawing.Size(168, 25)
        Me.chkStats.TabIndex = 2
        Me.chkStats.Text = "Stats (exparemental):"
        Me.chkStats.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStats.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(926, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Command toggles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.TableLayoutPanel1)
        Me.tabHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabHelp.Location = New System.Drawing.Point(4, 26)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHelp.Size = New System.Drawing.Size(926, 360)
        Me.tabHelp.TabIndex = 2
        Me.tabHelp.Text = "Help List"
        Me.tabHelp.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panHelpAdm, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.panHelp, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(920, 354)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'panHelpAdm
        '
        Me.panHelpAdm.Controls.Add(Me.txtHelpAdmin)
        Me.panHelpAdm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHelpAdm.Location = New System.Drawing.Point(3, 239)
        Me.panHelpAdm.Name = "panHelpAdm"
        Me.panHelpAdm.Padding = New System.Windows.Forms.Padding(10)
        Me.panHelpAdm.Size = New System.Drawing.Size(914, 112)
        Me.panHelpAdm.TabIndex = 2
        '
        'txtHelpAdmin
        '
        Me.txtHelpAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtHelpAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHelpAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHelpAdmin.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpAdmin.ForeColor = System.Drawing.Color.White
        Me.txtHelpAdmin.Location = New System.Drawing.Point(10, 10)
        Me.txtHelpAdmin.Multiline = True
        Me.txtHelpAdmin.Name = "txtHelpAdmin"
        Me.txtHelpAdmin.Size = New System.Drawing.Size(894, 92)
        Me.txtHelpAdmin.TabIndex = 0
        Me.txtHelpAdmin.Text = resources.GetString("txtHelpAdmin.Text")
        Me.txtHelpAdmin.WordWrap = False
        '
        'panHelp
        '
        Me.panHelp.Controls.Add(Me.txtHelp)
        Me.panHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHelp.Location = New System.Drawing.Point(3, 3)
        Me.panHelp.Name = "panHelp"
        Me.panHelp.Padding = New System.Windows.Forms.Padding(10)
        Me.panHelp.Size = New System.Drawing.Size(914, 230)
        Me.panHelp.TabIndex = 1
        '
        'txtHelp
        '
        Me.txtHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHelp.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelp.ForeColor = System.Drawing.Color.White
        Me.txtHelp.Location = New System.Drawing.Point(10, 10)
        Me.txtHelp.Multiline = True
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.Size = New System.Drawing.Size(894, 210)
        Me.txtHelp.TabIndex = 0
        Me.txtHelp.Text = resources.GetString("txtHelp.Text")
        Me.txtHelp.WordWrap = False
        '
        'tabLog
        '
        Me.tabLog.Controls.Add(Me.log)
        Me.tabLog.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tabLog.Location = New System.Drawing.Point(4, 26)
        Me.tabLog.Name = "tabLog"
        Me.tabLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLog.Size = New System.Drawing.Size(926, 360)
        Me.tabLog.TabIndex = 1
        Me.tabLog.Text = "Log"
        Me.tabLog.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.log.ForeColor = System.Drawing.Color.Black
        Me.log.FormattingEnabled = True
        Me.log.ItemHeight = 17
        Me.log.Location = New System.Drawing.Point(3, 3)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(920, 354)
        Me.log.TabIndex = 0
        '
        'Check
        '
        Me.Check.Enabled = True
        Me.Check.Interval = 500
        '
        'Reloader
        '
        Me.Reloader.Interval = 1000
        '
        'Ping
        '
        Me.Ping.Enabled = True
        Me.Ping.Interval = 10000
        '
        'trayIcon
        '
        Me.trayIcon.ContextMenuStrip = Me.trayMenu
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "TheOneBot"
        '
        'trayMenu
        '
        Me.trayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.trayName, Me.ToolStripSeparator1, Me.trayWake, Me.trayGame, Me.trayStatus, Me.ToolStripSeparator2, Me.trayQuit})
        Me.trayMenu.Name = "trayMenu"
        Me.trayMenu.Size = New System.Drawing.Size(161, 132)
        '
        'trayName
        '
        Me.trayName.BackgroundImage = Global.TheOneBot.My.Resources.Resources.shadow
        Me.trayName.Name = "trayName"
        Me.trayName.Size = New System.Drawing.Size(160, 22)
        Me.trayName.Text = "TheOneBot"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'trayWake
        '
        Me.trayWake.Name = "trayWake"
        Me.trayWake.Size = New System.Drawing.Size(100, 23)
        Me.trayWake.Text = "/"
        '
        'trayGame
        '
        Me.trayGame.Name = "trayGame"
        Me.trayGame.Size = New System.Drawing.Size(100, 23)
        Me.trayGame.Text = "TheOneBot"
        '
        'trayStatus
        '
        Me.trayStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.trayConnect, Me.trayDisconnect})
        Me.trayStatus.Name = "trayStatus"
        Me.trayStatus.Size = New System.Drawing.Size(160, 22)
        Me.trayStatus.Text = "Offline"
        '
        'trayConnect
        '
        Me.trayConnect.Name = "trayConnect"
        Me.trayConnect.Size = New System.Drawing.Size(180, 22)
        Me.trayConnect.Text = "Connect"
        '
        'trayDisconnect
        '
        Me.trayDisconnect.Enabled = False
        Me.trayDisconnect.Name = "trayDisconnect"
        Me.trayDisconnect.Size = New System.Drawing.Size(180, 22)
        Me.trayDisconnect.Text = "Disconnect"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'trayQuit
        '
        Me.trayQuit.Name = "trayQuit"
        Me.trayQuit.Size = New System.Drawing.Size(160, 22)
        Me.trayQuit.Text = "Quit"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(940, 505)
        Me.Controls.Add(Me.tblMain)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(624, 540)
        Me.Name = "main"
        Me.Text = "TheOneBot - Serverhost"
        Me.tblMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblTop.ResumeLayout(False)
        Me.flowTopLeft.ResumeLayout(False)
        Me.flowTopLeft.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flowTopRight.ResumeLayout(False)
        Me.flowTopRight.PerformLayout()
        Me.secondlast.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.flowGeneral.ResumeLayout(False)
        Me.tblWake.ResumeLayout(False)
        Me.tblWake.PerformLayout()
        Me.tblUser.ResumeLayout(False)
        Me.tblUser.PerformLayout()
        Me.tblMod.ResumeLayout(False)
        Me.tblMod.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tabCom.ResumeLayout(False)
        Me.flowCommand.ResumeLayout(False)
        Me.tabHelp.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.panHelpAdm.ResumeLayout(False)
        Me.panHelpAdm.PerformLayout()
        Me.panHelp.ResumeLayout(False)
        Me.panHelp.PerformLayout()
        Me.tabLog.ResumeLayout(False)
        Me.trayMenu.ResumeLayout(False)
        Me.trayMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents btnCon As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents Check As Timer
    Friend WithEvents tblTop As TableLayoutPanel
    Friend WithEvents flowTopLeft As FlowLayoutPanel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblUname As Label
    Friend WithEvents picBot As PictureBox
    Friend WithEvents flowTopRight As FlowLayoutPanel
    Friend WithEvents lblPing As Label
    Friend WithEvents Reloader As Timer
    Friend WithEvents Ping As Timer
    Friend WithEvents panPing As Panel
    Friend WithEvents chkRemote As CheckBox
    Friend WithEvents secondlast As TabControl
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents flowGeneral As FlowLayoutPanel
    Friend WithEvents tblWake As TableLayoutPanel
    Friend WithEvents lblWake As Label
    Friend WithEvents txtWake As TextBox
    Friend WithEvents lblWakeCount As Label
    Friend WithEvents tblUser As TableLayoutPanel
    Friend WithEvents txtDiscrim As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tblMod As TableLayoutPanel
    Friend WithEvents lblMod As Label
    Friend WithEvents txtMod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGeneral As Label
    Friend WithEvents tabCom As TabPage
    Friend WithEvents flowCommand As FlowLayoutPanel
    Friend WithEvents chkDel As CheckBox
    Friend WithEvents chkHelp As CheckBox
    Friend WithEvents chkPing As CheckBox
    Friend WithEvents chkEcho As CheckBox
    Friend WithEvents chkLast As CheckBox
    Friend WithEvents chkStats As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabHelp As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents panHelpAdm As Panel
    Friend WithEvents txtHelpAdmin As TextBox
    Friend WithEvents panHelp As Panel
    Friend WithEvents txtHelp As TextBox
    Friend WithEvents tabLog As TabPage
    Friend WithEvents log As ListBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblGame As Label
    Friend WithEvents txtGame As TextBox
    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents trayMenu As ContextMenuStrip
    Friend WithEvents trayName As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents trayWake As ToolStripTextBox
    Friend WithEvents trayGame As ToolStripTextBox
    Friend WithEvents trayStatus As ToolStripMenuItem
    Friend WithEvents trayConnect As ToolStripMenuItem
    Friend WithEvents trayDisconnect As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents trayQuit As ToolStripMenuItem
End Class
