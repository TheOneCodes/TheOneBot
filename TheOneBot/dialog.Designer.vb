<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dialog))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblMore = New System.Windows.Forms.LinkLabel()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnIgnore = New System.Windows.Forms.Button()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.Location = New System.Drawing.Point(388, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(67, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(461, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Visible = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(13, 13)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(2248, 13)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = resources.GetString("lbl.Text")
        '
        'lblMore
        '
        Me.lblMore.AutoSize = True
        Me.lblMore.Location = New System.Drawing.Point(12, 40)
        Me.lblMore.Name = "lblMore"
        Me.lblMore.Size = New System.Drawing.Size(71, 13)
        Me.lblMore.TabIndex = 2
        Me.lblMore.TabStop = True
        Me.lblMore.Text = "More details"
        Me.lblMore.Visible = False
        '
        'txtInfo
        '
        Me.txtInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInfo.Location = New System.Drawing.Point(12, 56)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(531, 79)
        Me.txtInfo.TabIndex = 3
        Me.txtInfo.Text = resources.GetString("txtInfo.Text")
        Me.txtInfo.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOK)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnIgnore)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnRetry)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAbort)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 141)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(531, 29)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btnIgnore
        '
        Me.btnIgnore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIgnore.Location = New System.Drawing.Point(315, 3)
        Me.btnIgnore.Name = "btnIgnore"
        Me.btnIgnore.Size = New System.Drawing.Size(67, 23)
        Me.btnIgnore.TabIndex = 0
        Me.btnIgnore.Text = "Ignore"
        Me.btnIgnore.Visible = False
        '
        'btnRetry
        '
        Me.btnRetry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRetry.Location = New System.Drawing.Point(242, 3)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(67, 23)
        Me.btnRetry.TabIndex = 0
        Me.btnRetry.Text = "Retry"
        Me.btnRetry.Visible = False
        '
        'btnAbort
        '
        Me.btnAbort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAbort.Location = New System.Drawing.Point(169, 3)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(67, 23)
        Me.btnAbort.TabIndex = 0
        Me.btnAbort.Text = "Abort"
        Me.btnAbort.Visible = False
        '
        'dialog
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(555, 182)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.lblMore)
        Me.Controls.Add(Me.lbl)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 150)
        Me.Name = "dialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TheOneBot"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lbl As Label
    Friend WithEvents lblMore As LinkLabel
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAbort As Button
    Friend WithEvents btnRetry As Button
    Friend WithEvents btnIgnore As Button
End Class
