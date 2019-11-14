<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Slide
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Slide))
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.slide1 = New System.Windows.Forms.PictureBox()
        Me.slide2 = New System.Windows.Forms.PictureBox()
        Me.waitTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.slide1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slide2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'animationTimer
        '
        Me.animationTimer.Interval = 1
        '
        'slide1
        '
        Me.slide1.Dock = System.Windows.Forms.DockStyle.Left
        Me.slide1.Image = CType(resources.GetObject("slide1.Image"), System.Drawing.Image)
        Me.slide1.Location = New System.Drawing.Point(0, 0)
        Me.slide1.Name = "slide1"
        Me.slide1.Size = New System.Drawing.Size(800, 450)
        Me.slide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slide1.TabIndex = 0
        Me.slide1.TabStop = False
        '
        'slide2
        '
        Me.slide2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.slide2.Image = CType(resources.GetObject("slide2.Image"), System.Drawing.Image)
        Me.slide2.Location = New System.Drawing.Point(800, 0)
        Me.slide2.Name = "slide2"
        Me.slide2.Size = New System.Drawing.Size(253, 450)
        Me.slide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slide2.TabIndex = 1
        Me.slide2.TabStop = False
        '
        'waitTimer
        '
        Me.waitTimer.Interval = 8000
        '
        'Slide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.slide2)
        Me.Controls.Add(Me.slide1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Slide"
        CType(Me.slide1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slide2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents animationTimer As Timer
    Friend WithEvents slide1 As PictureBox
    Friend WithEvents slide2 As PictureBox
    Friend WithEvents waitTimer As Timer
End Class
