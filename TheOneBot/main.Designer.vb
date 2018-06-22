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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCon = New System.Windows.Forms.Button()
        Me.panTop = New System.Windows.Forms.Panel()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.tabBox = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.txtWake = New System.Windows.Forms.TextBox()
        Me.bckWake = New System.Windows.Forms.Panel()
        Me.lblWakeCount = New System.Windows.Forms.Label()
        Me.lblWake = New System.Windows.Forms.Label()
        Me.tabLog = New System.Windows.Forms.TabPage()
        Me.log = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Check = New System.Windows.Forms.Timer(Me.components)
        Me.Load = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panTop.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBox.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.panTop, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabBox, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1104, 471)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.btnCon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 423)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 44)
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
        Me.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCon.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCon.Location = New System.Drawing.Point(955, 4)
        Me.btnCon.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(137, 36)
        Me.btnCon.TabIndex = 0
        Me.btnCon.Text = "Connect"
        Me.btnCon.UseVisualStyleBackColor = True
        '
        'panTop
        '
        Me.panTop.BackColor = System.Drawing.SystemColors.Control
        Me.panTop.Controls.Add(Me.picProfile)
        Me.panTop.Controls.Add(Me.lblUname)
        Me.panTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTop.Location = New System.Drawing.Point(3, 3)
        Me.panTop.Name = "panTop"
        Me.panTop.Size = New System.Drawing.Size(1098, 46)
        Me.panTop.TabIndex = 3
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
        Me.lblUname.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUname.Location = New System.Drawing.Point(49, 3)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(207, 40)
        Me.lblUname.TabIndex = 2
        Me.lblUname.Text = "Offline"
        Me.lblUname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabBox
        '
        Me.tabBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabBox.Controls.Add(Me.tabGeneral)
        Me.tabBox.Controls.Add(Me.tabLog)
        Me.tabBox.Controls.Add(Me.TabPage1)
        Me.tabBox.Location = New System.Drawing.Point(3, 55)
        Me.tabBox.Name = "tabBox"
        Me.tabBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabBox.SelectedIndex = 0
        Me.tabBox.Size = New System.Drawing.Size(1098, 361)
        Me.tabBox.TabIndex = 4
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.txtWake)
        Me.tabGeneral.Controls.Add(Me.bckWake)
        Me.tabGeneral.Controls.Add(Me.lblWakeCount)
        Me.tabGeneral.Controls.Add(Me.lblWake)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 26)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(1090, 331)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'txtWake
        '
        Me.txtWake.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWake.Location = New System.Drawing.Point(162, 32)
        Me.txtWake.Name = "txtWake"
        Me.txtWake.Size = New System.Drawing.Size(44, 18)
        Me.txtWake.TabIndex = 1
        Me.txtWake.Text = "/"
        '
        'bckWake
        '
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
        Me.tabLog.Size = New System.Drawing.Size(1090, 331)
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
        Me.log.Size = New System.Drawing.Size(1084, 325)
        Me.log.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1090, 331)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Invite to server"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Check
        '
        Me.Check.Enabled = True
        Me.Check.Interval = 500
        '
        'Load
        '
        Me.Load.Enabled = True
        Me.Load.Interval = 1000
        '
        'connectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1104, 471)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "connectForm"
        Me.Text = "Serverhost"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.panTop.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBox.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabLog.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCon As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents Check As Timer
    Friend WithEvents lblUname As Label
    Friend WithEvents panTop As Panel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents tabBox As TabControl
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents tabLog As TabPage
    Friend WithEvents log As ListBox
    Friend WithEvents txtWake As TextBox
    Friend WithEvents lblWake As Label
    Friend WithEvents Load As Timer
    Friend WithEvents lblWakeCount As Label
    Friend WithEvents bckWake As Panel
    Friend WithEvents TabPage1 As TabPage
End Class
