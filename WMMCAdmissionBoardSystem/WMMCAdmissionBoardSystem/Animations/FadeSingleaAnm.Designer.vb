<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FadeSingleaAnm
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
        Me.components = New System.ComponentModel.Container()
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.waitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.picture = New System.Windows.Forms.PictureBox()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'animationTimer
        '
        Me.animationTimer.Interval = 20
        '
        'waitTimer
        '
        Me.waitTimer.Interval = 8000
        '
        'picture
        '
        Me.picture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picture.Location = New System.Drawing.Point(0, 0)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(1286, 624)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture.TabIndex = 2
        Me.picture.TabStop = False
        '
        'FadeSingleaAnm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 624)
        Me.ControlBox = False
        Me.Controls.Add(Me.picture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FadeSingleaAnm"
        Me.Opacity = 0.01R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents animationTimer As Timer
    Friend WithEvents waitTimer As Timer
    Friend WithEvents picture As PictureBox
End Class
