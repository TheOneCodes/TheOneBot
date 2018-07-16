<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(update))
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pbDis = New System.Windows.Forms.PictureBox()
        Me.tblMid = New System.Windows.Forms.TableLayoutPanel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.tblText = New System.Windows.Forms.TableLayoutPanel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.flow = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.tblTop = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMini = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.Dots = New System.Windows.Forms.Timer(Me.components)
        Me.tblMain.SuspendLayout()
        CType(Me.pbDis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblMid.SuspendLayout()
        Me.tblText.SuspendLayout()
        Me.flow.SuspendLayout()
        Me.tblTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 2
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.4689!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.5311!))
        Me.tblMain.Controls.Add(Me.pbDis, 0, 0)
        Me.tblMain.Controls.Add(Me.tblMid, 1, 0)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(0, 0)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 1
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMain.Size = New System.Drawing.Size(420, 231)
        Me.tblMain.TabIndex = 1
        '
        'pbDis
        '
        Me.pbDis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbDis.Image = Global.TheOneBot.My.Resources.Resources.side
        Me.pbDis.Location = New System.Drawing.Point(3, 3)
        Me.pbDis.Name = "pbDis"
        Me.pbDis.Size = New System.Drawing.Size(113, 225)
        Me.pbDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDis.TabIndex = 0
        Me.pbDis.TabStop = False
        '
        'tblMid
        '
        Me.tblMid.ColumnCount = 1
        Me.tblMid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMid.Controls.Add(Me.lblName, 0, 1)
        Me.tblMid.Controls.Add(Me.progress, 0, 3)
        Me.tblMid.Controls.Add(Me.tblText, 0, 2)
        Me.tblMid.Controls.Add(Me.tblTop, 0, 0)
        Me.tblMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMid.Location = New System.Drawing.Point(122, 3)
        Me.tblMid.Name = "tblMid"
        Me.tblMid.RowCount = 4
        Me.tblMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tblMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblMid.Size = New System.Drawing.Size(295, 225)
        Me.tblMid.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(3, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(289, 60)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Updating"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'progress
        '
        Me.progress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.progress.Location = New System.Drawing.Point(3, 203)
        Me.progress.Maximum = 1000
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(289, 19)
        Me.progress.TabIndex = 8
        Me.progress.UseWaitCursor = True
        Me.progress.Visible = False
        '
        'tblText
        '
        Me.tblText.ColumnCount = 2
        Me.tblText.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblText.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tblText.Controls.Add(Me.lblText, 0, 0)
        Me.tblText.Controls.Add(Me.flow, 1, 0)
        Me.tblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblText.Location = New System.Drawing.Point(3, 103)
        Me.tblText.Name = "tblText"
        Me.tblText.RowCount = 1
        Me.tblText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblText.Size = New System.Drawing.Size(289, 94)
        Me.tblText.TabIndex = 9
        '
        'lblText
        '
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblText.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(3, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Padding = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.lblText.Size = New System.Drawing.Size(198, 94)
        Me.lblText.TabIndex = 9
        Me.lblText.Text = "Loading"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'flow
        '
        Me.flow.Controls.Add(Me.btnOK)
        Me.flow.Controls.Add(Me.btnLaunch)
        Me.flow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flow.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.flow.Location = New System.Drawing.Point(207, 3)
        Me.flow.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.flow.Name = "flow"
        Me.flow.Size = New System.Drawing.Size(79, 91)
        Me.flow.TabIndex = 10
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(3, 51)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 3, 13, 10)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(69, 30)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        Me.btnOK.Visible = False
        '
        'btnLaunch
        '
        Me.btnLaunch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLaunch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaunch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLaunch.ForeColor = System.Drawing.Color.Black
        Me.btnLaunch.Location = New System.Drawing.Point(3, 8)
        Me.btnLaunch.Margin = New System.Windows.Forms.Padding(3, 3, 13, 10)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(69, 30)
        Me.btnLaunch.TabIndex = 12
        Me.btnLaunch.Text = "Launch"
        Me.btnLaunch.UseVisualStyleBackColor = True
        Me.btnLaunch.Visible = False
        '
        'tblTop
        '
        Me.tblTop.ColumnCount = 3
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tblTop.Controls.Add(Me.btnMini, 1, 0)
        Me.tblTop.Controls.Add(Me.btnClose, 2, 0)
        Me.tblTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTop.Location = New System.Drawing.Point(3, 3)
        Me.tblTop.Name = "tblTop"
        Me.tblTop.RowCount = 1
        Me.tblTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTop.Size = New System.Drawing.Size(289, 34)
        Me.tblTop.TabIndex = 10
        '
        'btnMini
        '
        Me.btnMini.AutoSize = True
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMini.Font = New System.Drawing.Font("Segoe UI Black", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnMini.Image = Global.TheOneBot.My.Resources.Resources.minimize
        Me.btnMini.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMini.Location = New System.Drawing.Point(222, 0)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(29, 34)
        Me.btnMini.TabIndex = 1
        Me.btnMini.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(257, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 34)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "✖"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dots
        '
        Me.Dots.Enabled = True
        '
        'update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 231)
        Me.Controls.Add(Me.tblMain)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Updating"
        Me.tblMain.ResumeLayout(False)
        CType(Me.pbDis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblMid.ResumeLayout(False)
        Me.tblText.ResumeLayout(False)
        Me.flow.ResumeLayout(False)
        Me.tblTop.ResumeLayout(False)
        Me.tblTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents pbDis As PictureBox
    Friend WithEvents tblMid As TableLayoutPanel
    Friend WithEvents lblName As Label
    Friend WithEvents Dots As Timer
    Friend WithEvents progress As ProgressBar
    Friend WithEvents tblText As TableLayoutPanel
    Friend WithEvents lblText As Label
    Friend WithEvents flow As FlowLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnLaunch As Button
    Friend WithEvents tblTop As TableLayoutPanel
    Friend WithEvents btnClose As Label
    Friend WithEvents btnMini As Label
End Class
