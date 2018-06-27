<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loader
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
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tblMid = New System.Windows.Forms.TableLayoutPanel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.Dots = New System.Windows.Forms.Timer(Me.components)
        Me.finish = New System.Windows.Forms.Timer(Me.components)
        Me.updateNow = New System.Windows.Forms.Timer(Me.components)
        Me.start = New System.Windows.Forms.Timer(Me.components)
        Me.pbDis = New System.Windows.Forms.PictureBox()
        Me.tblMain.SuspendLayout()
        Me.tblMid.SuspendLayout()
        CType(Me.pbDis, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tblMain.Size = New System.Drawing.Size(418, 229)
        Me.tblMain.TabIndex = 0
        '
        'tblMid
        '
        Me.tblMid.ColumnCount = 1
        Me.tblMid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMid.Controls.Add(Me.lblText, 0, 1)
        Me.tblMid.Controls.Add(Me.lblName, 0, 0)
        Me.tblMid.Controls.Add(Me.progress, 0, 2)
        Me.tblMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMid.Location = New System.Drawing.Point(122, 3)
        Me.tblMid.Name = "tblMid"
        Me.tblMid.RowCount = 3
        Me.tblMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblMid.Size = New System.Drawing.Size(293, 223)
        Me.tblMid.TabIndex = 1
        '
        'lblText
        '
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblText.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(3, 100)
        Me.lblText.Name = "lblText"
        Me.lblText.Padding = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.lblText.Size = New System.Drawing.Size(287, 98)
        Me.lblText.TabIndex = 7
        Me.lblText.Text = "Loading"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(3, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(287, 100)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "TheOneBot"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'progress
        '
        Me.progress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.progress.Location = New System.Drawing.Point(3, 201)
        Me.progress.Maximum = 1000
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(287, 19)
        Me.progress.TabIndex = 8
        Me.progress.UseWaitCursor = True
        Me.progress.Visible = False
        '
        'Dots
        '
        Me.Dots.Enabled = True
        '
        'finish
        '
        Me.finish.Interval = 2000
        '
        'updateNow
        '
        Me.updateNow.Interval = 2000
        '
        'start
        '
        Me.start.Interval = 1000
        '
        'pbDis
        '
        Me.pbDis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbDis.Image = Global.TheOneBot.My.Resources.Resources.side
        Me.pbDis.Location = New System.Drawing.Point(3, 3)
        Me.pbDis.Name = "pbDis"
        Me.pbDis.Size = New System.Drawing.Size(113, 223)
        Me.pbDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDis.TabIndex = 0
        Me.pbDis.TabStop = False
        '
        'loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(418, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.tblMain)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loader"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tblMain.ResumeLayout(False)
        Me.tblMid.ResumeLayout(False)
        CType(Me.pbDis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents pbDis As PictureBox
    Friend WithEvents tblMid As TableLayoutPanel
    Friend WithEvents lblName As Label
    Friend WithEvents lblText As Label
    Friend WithEvents progress As ProgressBar
    Friend WithEvents Dots As Timer
    Friend WithEvents finish As Timer
    Friend WithEvents updateNow As Timer
    Friend WithEvents start As Timer
End Class
