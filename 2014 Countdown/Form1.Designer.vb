<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountdown
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblHalfSeconds = New System.Windows.Forms.Label()
        Me.picFireworks = New System.Windows.Forms.PictureBox()
        CType(Me.picFireworks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Moire ExtraBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(766, 38)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "2014 Countdown"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDays
        '
        Me.lblDays.ForeColor = System.Drawing.Color.White
        Me.lblDays.Location = New System.Drawing.Point(345, 63)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(100, 23)
        Me.lblDays.TabIndex = 1
        Me.lblDays.Text = "{Days}"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHours
        '
        Me.lblHours.ForeColor = System.Drawing.Color.White
        Me.lblHours.Location = New System.Drawing.Point(345, 86)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(100, 23)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "{Hours}"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinutes
        '
        Me.lblMinutes.ForeColor = System.Drawing.Color.White
        Me.lblMinutes.Location = New System.Drawing.Point(345, 109)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(100, 23)
        Me.lblMinutes.TabIndex = 3
        Me.lblMinutes.Text = "{Minutes}"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeconds
        '
        Me.lblSeconds.ForeColor = System.Drawing.Color.White
        Me.lblSeconds.Location = New System.Drawing.Point(345, 132)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(100, 23)
        Me.lblSeconds.TabIndex = 4
        Me.lblSeconds.Text = "{Seconds}"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Countdown
        '
        Me.Countdown.Enabled = True
        '
        'lblHalfSeconds
        '
        Me.lblHalfSeconds.ForeColor = System.Drawing.Color.White
        Me.lblHalfSeconds.Location = New System.Drawing.Point(345, 155)
        Me.lblHalfSeconds.Name = "lblHalfSeconds"
        Me.lblHalfSeconds.Size = New System.Drawing.Size(100, 23)
        Me.lblHalfSeconds.TabIndex = 5
        Me.lblHalfSeconds.Text = "{HalfSeconds}"
        Me.lblHalfSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picFireworks
        '
        Me.picFireworks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFireworks.Image = Global._2014_Countdown.My.Resources.Resources.animated_fireworks
        Me.picFireworks.Location = New System.Drawing.Point(0, 0)
        Me.picFireworks.Name = "picFireworks"
        Me.picFireworks.Size = New System.Drawing.Size(790, 187)
        Me.picFireworks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFireworks.TabIndex = 6
        Me.picFireworks.TabStop = False
        Me.picFireworks.Visible = False
        '
        'frmCountdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 187)
        Me.Controls.Add(Me.lblHalfSeconds)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picFireworks)
        Me.Name = "frmCountdown"
        Me.Text = "2014 Countdown"
        CType(Me.picFireworks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents Countdown As System.Windows.Forms.Timer
    Friend WithEvents lblHalfSeconds As System.Windows.Forms.Label
    Friend WithEvents picFireworks As System.Windows.Forms.PictureBox

End Class
