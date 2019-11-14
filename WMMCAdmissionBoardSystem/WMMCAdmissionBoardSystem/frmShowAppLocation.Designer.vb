<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowAppLocation
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
        Me.txtLoc = New System.Windows.Forms.RichTextBox()
        Me.btnCopyClipboard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(12, 12)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.ReadOnly = True
        Me.txtLoc.Size = New System.Drawing.Size(313, 79)
        Me.txtLoc.TabIndex = 0
        Me.txtLoc.Text = ""
        '
        'btnCopyClipboard
        '
        Me.btnCopyClipboard.BackColor = System.Drawing.Color.DarkGreen
        Me.btnCopyClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyClipboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyClipboard.ForeColor = System.Drawing.Color.White
        Me.btnCopyClipboard.Location = New System.Drawing.Point(88, 96)
        Me.btnCopyClipboard.Name = "btnCopyClipboard"
        Me.btnCopyClipboard.Size = New System.Drawing.Size(161, 31)
        Me.btnCopyClipboard.TabIndex = 1
        Me.btnCopyClipboard.Text = "Copy to Clipboard"
        Me.btnCopyClipboard.UseVisualStyleBackColor = False
        '
        'frmShowAppLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 135)
        Me.Controls.Add(Me.btnCopyClipboard)
        Me.Controls.Add(Me.txtLoc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShowAppLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Location"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtLoc As RichTextBox
    Friend WithEvents btnCopyClipboard As Button
End Class
