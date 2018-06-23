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
        Me.secondlast = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.txtWake = New System.Windows.Forms.TextBox()
        Me.bckWake = New System.Windows.Forms.Panel()
        Me.lblWakeCount = New System.Windows.Forms.Label()
        Me.lblWake = New System.Windows.Forms.Label()
        Me.tabLog = New System.Windows.Forms.TabPage()
        Me.log = New System.Windows.Forms.ListBox()
        Me.tabAuth = New System.Windows.Forms.TabPage()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tabHelp = New System.Windows.Forms.TabPage()
        Me.tblTop = New System.Windows.Forms.TableLayoutPanel()
        Me.flowTop = New System.Windows.Forms.FlowLayoutPanel()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.picBot = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblPing = New System.Windows.Forms.Label()
        Me.Check = New System.Windows.Forms.Timer(Me.components)
        Me.Loader = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtHelp = New System.Windows.Forms.TextBox()
        Me.panHelp = New System.Windows.Forms.Panel()
        Me.panHelpAdm = New System.Windows.Forms.Panel()
        Me.txtHelpAdmin = New System.Windows.Forms.TextBox()
        Me.tblMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.secondlast.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabLog.SuspendLayout()
        Me.tabAuth.SuspendLayout()
        Me.tabHelp.SuspendLayout()
        Me.tblTop.SuspendLayout()
        Me.flowTop.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panHelp.SuspendLayout()
        Me.panHelpAdm.SuspendLayout()
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
        Me.tblMain.Size = New System.Drawing.Size(944, 501)
        Me.tblMain.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.btnCon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 453)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 44)
        Me.Panel1.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(3, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(201, 36)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Offline"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCon
        '
        Me.btnCon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCon.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCon.Location = New System.Drawing.Point(795, 4)
        Me.btnCon.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(137, 36)
        Me.btnCon.TabIndex = 0
        Me.btnCon.Text = "Connect"
        Me.btnCon.UseVisualStyleBackColor = False
        '
        'secondlast
        '
        Me.secondlast.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.secondlast.Controls.Add(Me.tabGeneral)
        Me.secondlast.Controls.Add(Me.tabLog)
        Me.secondlast.Controls.Add(Me.tabHelp)
        Me.secondlast.Controls.Add(Me.tabAuth)
        Me.secondlast.Location = New System.Drawing.Point(3, 60)
        Me.secondlast.Name = "secondlast"
        Me.secondlast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.secondlast.SelectedIndex = 0
        Me.secondlast.Size = New System.Drawing.Size(938, 386)
        Me.secondlast.TabIndex = 10
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.txtWake)
        Me.tabGeneral.Controls.Add(Me.bckWake)
        Me.tabGeneral.Controls.Add(Me.lblWakeCount)
        Me.tabGeneral.Controls.Add(Me.lblWake)
        Me.tabGeneral.ForeColor = System.Drawing.Color.Black
        Me.tabGeneral.Location = New System.Drawing.Point(4, 26)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(930, 356)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'txtWake
        '
        Me.txtWake.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtWake.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWake.ForeColor = System.Drawing.Color.White
        Me.txtWake.Location = New System.Drawing.Point(162, 32)
        Me.txtWake.Name = "txtWake"
        Me.txtWake.Size = New System.Drawing.Size(44, 18)
        Me.txtWake.TabIndex = 1
        Me.txtWake.Text = "/"
        '
        'bckWake
        '
        Me.bckWake.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.bckWake.Location = New System.Drawing.Point(159, 28)
        Me.bckWake.Name = "bckWake"
        Me.bckWake.Size = New System.Drawing.Size(50, 25)
        Me.bckWake.TabIndex = 3
        '
        'lblWakeCount
        '
        Me.lblWakeCount.Location = New System.Drawing.Point(215, 28)
        Me.lblWakeCount.Name = "lblWakeCount"
        Me.lblWakeCount.Size = New System.Drawing.Size(150, 25)
        Me.lblWakeCount.TabIndex = 2
        Me.lblWakeCount.Text = "Characters: "
        Me.lblWakeCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWake
        '
        Me.lblWake.Location = New System.Drawing.Point(3, 28)
        Me.lblWake.Name = "lblWake"
        Me.lblWake.Size = New System.Drawing.Size(150, 25)
        Me.lblWake.TabIndex = 0
        Me.lblWake.Text = "Wake key:"
        Me.lblWake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabLog
        '
        Me.tabLog.Controls.Add(Me.log)
        Me.tabLog.Location = New System.Drawing.Point(4, 26)
        Me.tabLog.Name = "tabLog"
        Me.tabLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLog.Size = New System.Drawing.Size(930, 356)
        Me.tabLog.TabIndex = 1
        Me.tabLog.Text = "Log"
        Me.tabLog.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.log.FormattingEnabled = True
        Me.log.ItemHeight = 17
        Me.log.Location = New System.Drawing.Point(3, 3)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(924, 350)
        Me.log.TabIndex = 0
        '
        'tabAuth
        '
        Me.tabAuth.Controls.Add(Me.btnAdd)
        Me.tabAuth.ForeColor = System.Drawing.Color.Black
        Me.tabAuth.Location = New System.Drawing.Point(4, 26)
        Me.tabAuth.Name = "tabAuth"
        Me.tabAuth.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAuth.Size = New System.Drawing.Size(930, 356)
        Me.tabAuth.TabIndex = 10
        Me.tabAuth.Text = "Invite to server"
        Me.tabAuth.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(233, 90)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(465, 180)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add to Discord"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.TableLayoutPanel1)
        Me.tabHelp.Location = New System.Drawing.Point(4, 26)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHelp.Size = New System.Drawing.Size(930, 356)
        Me.tabHelp.TabIndex = 2
        Me.tabHelp.Text = "Help List"
        Me.tabHelp.UseVisualStyleBackColor = True
        '
        'tblTop
        '
        Me.tblTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.tblTop.ColumnCount = 2
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTop.Controls.Add(Me.flowTop, 0, 0)
        Me.tblTop.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.tblTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTop.Location = New System.Drawing.Point(3, 3)
        Me.tblTop.Name = "tblTop"
        Me.tblTop.RowCount = 1
        Me.tblTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTop.Size = New System.Drawing.Size(938, 51)
        Me.tblTop.TabIndex = 5
        '
        'flowTop
        '
        Me.flowTop.Controls.Add(Me.picProfile)
        Me.flowTop.Controls.Add(Me.lblUname)
        Me.flowTop.Controls.Add(Me.picBot)
        Me.flowTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowTop.Location = New System.Drawing.Point(3, 3)
        Me.flowTop.Name = "flowTop"
        Me.flowTop.Size = New System.Drawing.Size(463, 45)
        Me.flowTop.TabIndex = 5
        '
        'picProfile
        '
        Me.picProfile.Image = Global.TheOneBot.My.Resources.Resources.none
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
        Me.picBot.Image = Global.TheOneBot.My.Resources.Resources.bot
        Me.picBot.Location = New System.Drawing.Point(143, 3)
        Me.picBot.Name = "picBot"
        Me.picBot.Size = New System.Drawing.Size(50, 30)
        Me.picBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBot.TabIndex = 5
        Me.picBot.TabStop = False
        Me.picBot.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblPing)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(472, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(463, 45)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'lblPing
        '
        Me.lblPing.AutoSize = True
        Me.lblPing.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPing.Location = New System.Drawing.Point(401, 0)
        Me.lblPing.Name = "lblPing"
        Me.lblPing.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lblPing.Size = New System.Drawing.Size(59, 39)
        Me.lblPing.TabIndex = 2
        Me.lblPing.Text = "0ms"
        Me.lblPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Check
        '
        Me.Check.Enabled = True
        Me.Check.Interval = 500
        '
        'Loader
        '
        Me.Loader.Enabled = True
        Me.Loader.Interval = 1000
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(924, 350)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.txtHelp.Size = New System.Drawing.Size(898, 207)
        Me.txtHelp.TabIndex = 0
        Me.txtHelp.Text = resources.GetString("txtHelp.Text")
        Me.txtHelp.WordWrap = False
        '
        'panHelp
        '
        Me.panHelp.Controls.Add(Me.txtHelp)
        Me.panHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHelp.Location = New System.Drawing.Point(3, 3)
        Me.panHelp.Name = "panHelp"
        Me.panHelp.Padding = New System.Windows.Forms.Padding(10)
        Me.panHelp.Size = New System.Drawing.Size(918, 227)
        Me.panHelp.TabIndex = 1
        '
        'panHelpAdm
        '
        Me.panHelpAdm.Controls.Add(Me.txtHelpAdmin)
        Me.panHelpAdm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHelpAdm.Location = New System.Drawing.Point(3, 236)
        Me.panHelpAdm.Name = "panHelpAdm"
        Me.panHelpAdm.Padding = New System.Windows.Forms.Padding(10)
        Me.panHelpAdm.Size = New System.Drawing.Size(918, 111)
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
        Me.txtHelpAdmin.Size = New System.Drawing.Size(898, 91)
        Me.txtHelpAdmin.TabIndex = 0
        Me.txtHelpAdmin.Text = resources.GetString("txtHelpAdmin.Text")
        Me.txtHelpAdmin.WordWrap = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.tblMain)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "main"
        Me.Text = "Serverhost"
        Me.tblMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.secondlast.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabLog.ResumeLayout(False)
        Me.tabAuth.ResumeLayout(False)
        Me.tabHelp.ResumeLayout(False)
        Me.tblTop.ResumeLayout(False)
        Me.flowTop.ResumeLayout(False)
        Me.flowTop.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.panHelp.ResumeLayout(False)
        Me.panHelp.PerformLayout()
        Me.panHelpAdm.ResumeLayout(False)
        Me.panHelpAdm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents btnCon As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents Check As Timer
    Friend WithEvents Loader As Timer
    Friend WithEvents tblTop As TableLayoutPanel
    Friend WithEvents flowTop As FlowLayoutPanel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblUname As Label
    Friend WithEvents picBot As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblPing As Label
    Friend WithEvents secondlast As TabControl
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents txtWake As TextBox
    Friend WithEvents bckWake As Panel
    Friend WithEvents lblWakeCount As Label
    Friend WithEvents lblWake As Label
    Friend WithEvents tabLog As TabPage
    Friend WithEvents log As ListBox
    Friend WithEvents tabAuth As TabPage
    Friend WithEvents btnAdd As Button
    Friend WithEvents tabHelp As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents panHelp As Panel
    Friend WithEvents txtHelp As TextBox
    Friend WithEvents panHelpAdm As Panel
    Friend WithEvents txtHelpAdmin As TextBox
End Class
