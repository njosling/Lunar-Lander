<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnstart = New System.Windows.Forms.Button()
        Me.txtintro = New System.Windows.Forms.Label()
        Me.piclander = New System.Windows.Forms.PictureBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.imllander = New System.Windows.Forms.ImageList(Me.components)
        Me.lblfuel = New System.Windows.Forms.Label()
        Me.trkthrust = New System.Windows.Forms.TrackBar()
        Me.lblthrust = New System.Windows.Forms.Label()
        Me.lblspeed = New System.Windows.Forms.Label()
        Me.Txtspeed = New System.Windows.Forms.TextBox()
        Me.txtfuelleft = New System.Windows.Forms.TextBox()
        Me.txtycoordinate = New System.Windows.Forms.TextBox()
        Me.txtxcoordinate = New System.Windows.Forms.TextBox()
        Me.lblxcoordinate = New System.Windows.Forms.Label()
        Me.lblfuelleft = New System.Windows.Forms.Label()
        Me.lblycoordinate = New System.Windows.Forms.Label()
        Me.tmrMoveLander = New System.Windows.Forms.Timer(Me.components)
        Me.picpad = New System.Windows.Forms.PictureBox()
        Me.Piclanderpad = New System.Windows.Forms.PictureBox()
        Me.lblsuccess = New System.Windows.Forms.Label()
        Me.lblcrashed = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.MaskedTextBox()
        Me.txtfuel = New System.Windows.Forms.MaskedTextBox()
        Me.txtthrust = New System.Windows.Forms.TextBox()
        Me.lblthrust2 = New System.Windows.Forms.Label()
        Me.piccrahsedlanderpad = New System.Windows.Forms.PictureBox()
        Me.picsmashedlander = New System.Windows.Forms.PictureBox()
        Me.Piclanderonpad = New System.Windows.Forms.PictureBox()
        CType(Me.piclander, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkthrust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Piclanderpad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccrahsedlanderpad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsmashedlander, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Piclanderonpad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.Color.Transparent
        Me.btnstart.Location = New System.Drawing.Point(400, 181)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(105, 38)
        Me.btnstart.TabIndex = 1
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'txtintro
        '
        Me.txtintro.AllowDrop = True
        Me.txtintro.BackColor = System.Drawing.Color.Transparent
        Me.txtintro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtintro.ForeColor = System.Drawing.Color.Transparent
        Me.txtintro.Location = New System.Drawing.Point(153, 31)
        Me.txtintro.Name = "txtintro"
        Me.txtintro.Size = New System.Drawing.Size(619, 71)
        Me.txtintro.TabIndex = 6
        Me.txtintro.Text = resources.GetString("txtintro.Text")
        Me.txtintro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'piclander
        '
        Me.piclander.BackColor = System.Drawing.Color.Transparent
        Me.piclander.Image = Global.Lunar_Lander.My.Resources.Resources.uprightLander
        Me.piclander.Location = New System.Drawing.Point(404, -64)
        Me.piclander.Name = "piclander"
        Me.piclander.Size = New System.Drawing.Size(78, 81)
        Me.piclander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclander.TabIndex = 7
        Me.piclander.TabStop = False
        Me.piclander.Visible = False
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.White
        Me.lblusername.Location = New System.Drawing.Point(408, 239)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(85, 18)
        Me.lblusername.TabIndex = 11
        Me.lblusername.Text = "Username"
        '
        'imllander
        '
        Me.imllander.ImageStream = CType(resources.GetObject("imllander.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imllander.TransparentColor = System.Drawing.Color.Transparent
        Me.imllander.Images.SetKeyName(0, "uprightLander.png")
        Me.imllander.Images.SetKeyName(1, "uprightThrust.png")
        Me.imllander.Images.SetKeyName(2, "leftLander.png")
        Me.imllander.Images.SetKeyName(3, "leftThrust.png")
        Me.imllander.Images.SetKeyName(4, "rightLander.png")
        Me.imllander.Images.SetKeyName(5, "rightThrust.png")
        '
        'lblfuel
        '
        Me.lblfuel.AutoSize = True
        Me.lblfuel.BackColor = System.Drawing.Color.Transparent
        Me.lblfuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuel.ForeColor = System.Drawing.Color.White
        Me.lblfuel.Location = New System.Drawing.Point(397, 303)
        Me.lblfuel.Name = "lblfuel"
        Me.lblfuel.Size = New System.Drawing.Size(96, 18)
        Me.lblfuel.TabIndex = 13
        Me.lblfuel.Text = "Fuel 1-5000"
        '
        'trkthrust
        '
        Me.trkthrust.LargeChange = 0
        Me.trkthrust.Location = New System.Drawing.Point(843, 254)
        Me.trkthrust.Maximum = 40
        Me.trkthrust.Name = "trkthrust"
        Me.trkthrust.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkthrust.Size = New System.Drawing.Size(45, 199)
        Me.trkthrust.SmallChange = 0
        Me.trkthrust.TabIndex = 14
        '
        'lblthrust
        '
        Me.lblthrust.AutoSize = True
        Me.lblthrust.BackColor = System.Drawing.Color.Transparent
        Me.lblthrust.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthrust.ForeColor = System.Drawing.Color.White
        Me.lblthrust.Location = New System.Drawing.Point(832, 221)
        Me.lblthrust.Name = "lblthrust"
        Me.lblthrust.Size = New System.Drawing.Size(56, 18)
        Me.lblthrust.TabIndex = 15
        Me.lblthrust.Text = "Thrust"
        '
        'lblspeed
        '
        Me.lblspeed.AutoSize = True
        Me.lblspeed.BackColor = System.Drawing.Color.Transparent
        Me.lblspeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblspeed.ForeColor = System.Drawing.Color.White
        Me.lblspeed.Location = New System.Drawing.Point(780, 239)
        Me.lblspeed.Name = "lblspeed"
        Me.lblspeed.Size = New System.Drawing.Size(55, 18)
        Me.lblspeed.TabIndex = 17
        Me.lblspeed.Text = "Speed"
        '
        'Txtspeed
        '
        Me.Txtspeed.Location = New System.Drawing.Point(772, 260)
        Me.Txtspeed.Name = "Txtspeed"
        Me.Txtspeed.Size = New System.Drawing.Size(58, 20)
        Me.Txtspeed.TabIndex = 18
        '
        'txtfuelleft
        '
        Me.txtfuelleft.Location = New System.Drawing.Point(772, 389)
        Me.txtfuelleft.Name = "txtfuelleft"
        Me.txtfuelleft.Size = New System.Drawing.Size(58, 20)
        Me.txtfuelleft.TabIndex = 19
        '
        'txtycoordinate
        '
        Me.txtycoordinate.Location = New System.Drawing.Point(772, 348)
        Me.txtycoordinate.Name = "txtycoordinate"
        Me.txtycoordinate.Size = New System.Drawing.Size(58, 20)
        Me.txtycoordinate.TabIndex = 20
        '
        'txtxcoordinate
        '
        Me.txtxcoordinate.Location = New System.Drawing.Point(772, 304)
        Me.txtxcoordinate.Name = "txtxcoordinate"
        Me.txtxcoordinate.Size = New System.Drawing.Size(58, 20)
        Me.txtxcoordinate.TabIndex = 21
        '
        'lblxcoordinate
        '
        Me.lblxcoordinate.AutoSize = True
        Me.lblxcoordinate.BackColor = System.Drawing.Color.Transparent
        Me.lblxcoordinate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblxcoordinate.ForeColor = System.Drawing.Color.White
        Me.lblxcoordinate.Location = New System.Drawing.Point(733, 283)
        Me.lblxcoordinate.Name = "lblxcoordinate"
        Me.lblxcoordinate.Size = New System.Drawing.Size(110, 18)
        Me.lblxcoordinate.TabIndex = 22
        Me.lblxcoordinate.Text = "X co-ordinate"
        '
        'lblfuelleft
        '
        Me.lblfuelleft.AutoSize = True
        Me.lblfuelleft.BackColor = System.Drawing.Color.Transparent
        Me.lblfuelleft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuelleft.ForeColor = System.Drawing.Color.White
        Me.lblfuelleft.Location = New System.Drawing.Point(762, 371)
        Me.lblfuelleft.Name = "lblfuelleft"
        Me.lblfuelleft.Size = New System.Drawing.Size(68, 18)
        Me.lblfuelleft.TabIndex = 23
        Me.lblfuelleft.Text = "Fuel left"
        '
        'lblycoordinate
        '
        Me.lblycoordinate.AutoSize = True
        Me.lblycoordinate.BackColor = System.Drawing.Color.Transparent
        Me.lblycoordinate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblycoordinate.ForeColor = System.Drawing.Color.White
        Me.lblycoordinate.Location = New System.Drawing.Point(734, 327)
        Me.lblycoordinate.Name = "lblycoordinate"
        Me.lblycoordinate.Size = New System.Drawing.Size(109, 18)
        Me.lblycoordinate.TabIndex = 24
        Me.lblycoordinate.Text = "Y co-ordinate"
        '
        'tmrMoveLander
        '
        Me.tmrMoveLander.Enabled = True
        Me.tmrMoveLander.Interval = 30
        '
        'picpad
        '
        Me.picpad.BackColor = System.Drawing.Color.Transparent
        Me.picpad.Image = Global.Lunar_Lander.My.Resources.Resources.landingPad
        Me.picpad.Location = New System.Drawing.Point(351, 508)
        Me.picpad.Name = "picpad"
        Me.picpad.Size = New System.Drawing.Size(204, 39)
        Me.picpad.TabIndex = 29
        Me.picpad.TabStop = False
        '
        'Piclanderpad
        '
        Me.Piclanderpad.BackColor = System.Drawing.Color.Transparent
        Me.Piclanderpad.Image = Global.Lunar_Lander.My.Resources.Resources.LanderOnPad
        Me.Piclanderpad.Location = New System.Drawing.Point(351, 433)
        Me.Piclanderpad.Name = "Piclanderpad"
        Me.Piclanderpad.Size = New System.Drawing.Size(210, 119)
        Me.Piclanderpad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Piclanderpad.TabIndex = 30
        Me.Piclanderpad.TabStop = False
        '
        'lblsuccess
        '
        Me.lblsuccess.AutoSize = True
        Me.lblsuccess.BackColor = System.Drawing.Color.Transparent
        Me.lblsuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuccess.ForeColor = System.Drawing.Color.White
        Me.lblsuccess.Location = New System.Drawing.Point(247, 366)
        Me.lblsuccess.Name = "lblsuccess"
        Me.lblsuccess.Size = New System.Drawing.Size(452, 25)
        Me.lblsuccess.TabIndex = 31
        Me.lblsuccess.Text = "Congratulations you have succsesfully landed"
        Me.lblsuccess.Visible = False
        '
        'lblcrashed
        '
        Me.lblcrashed.AutoSize = True
        Me.lblcrashed.BackColor = System.Drawing.Color.Transparent
        Me.lblcrashed.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrashed.ForeColor = System.Drawing.Color.White
        Me.lblcrashed.Location = New System.Drawing.Point(341, 149)
        Me.lblcrashed.Name = "lblcrashed"
        Me.lblcrashed.Size = New System.Drawing.Size(220, 29)
        Me.lblcrashed.TabIndex = 32
        Me.lblcrashed.Text = "You Have Crashed "
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(399, 260)
        Me.txtusername.Mask = "???????????????????"
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(112, 20)
        Me.txtusername.TabIndex = 33
        '
        'txtfuel
        '
        Me.txtfuel.Location = New System.Drawing.Point(399, 324)
        Me.txtfuel.Mask = "0000"
        Me.txtfuel.Name = "txtfuel"
        Me.txtfuel.Size = New System.Drawing.Size(112, 20)
        Me.txtfuel.TabIndex = 34
        '
        'txtthrust
        '
        Me.txtthrust.Location = New System.Drawing.Point(772, 433)
        Me.txtthrust.Name = "txtthrust"
        Me.txtthrust.Size = New System.Drawing.Size(58, 20)
        Me.txtthrust.TabIndex = 35
        '
        'lblthrust2
        '
        Me.lblthrust2.AutoSize = True
        Me.lblthrust2.BackColor = System.Drawing.Color.Transparent
        Me.lblthrust2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthrust2.ForeColor = System.Drawing.Color.White
        Me.lblthrust2.Location = New System.Drawing.Point(762, 412)
        Me.lblthrust2.Name = "lblthrust2"
        Me.lblthrust2.Size = New System.Drawing.Size(61, 18)
        Me.lblthrust2.TabIndex = 36
        Me.lblthrust2.Text = "Thrust "
        '
        'piccrahsedlanderpad
        '
        Me.piccrahsedlanderpad.BackColor = System.Drawing.Color.Transparent
        Me.piccrahsedlanderpad.Image = Global.Lunar_Lander.My.Resources.Resources.SmashedLanderOnPad
        Me.piccrahsedlanderpad.Location = New System.Drawing.Point(38, -110)
        Me.piccrahsedlanderpad.Name = "piccrahsedlanderpad"
        Me.piccrahsedlanderpad.Size = New System.Drawing.Size(78, 81)
        Me.piccrahsedlanderpad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccrahsedlanderpad.TabIndex = 38
        Me.piccrahsedlanderpad.TabStop = False
        '
        'picsmashedlander
        '
        Me.picsmashedlander.BackColor = System.Drawing.Color.Transparent
        Me.picsmashedlander.Image = Global.Lunar_Lander.My.Resources.Resources.SmashedLander
        Me.picsmashedlander.Location = New System.Drawing.Point(210, -54)
        Me.picsmashedlander.Name = "picsmashedlander"
        Me.picsmashedlander.Size = New System.Drawing.Size(121, 56)
        Me.picsmashedlander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsmashedlander.TabIndex = 39
        Me.picsmashedlander.TabStop = False
        '
        'Piclanderonpad
        '
        Me.Piclanderonpad.BackColor = System.Drawing.Color.Transparent
        Me.Piclanderonpad.Image = Global.Lunar_Lander.My.Resources.Resources.LanderOnPad1
        Me.Piclanderonpad.Location = New System.Drawing.Point(488, -106)
        Me.Piclanderonpad.Name = "Piclanderonpad"
        Me.Piclanderonpad.Size = New System.Drawing.Size(181, 108)
        Me.Piclanderonpad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Piclanderonpad.TabIndex = 40
        Me.Piclanderonpad.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lunar_Lander.My.Resources.Resources.moonScape
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(900, 601)
        Me.Controls.Add(Me.Piclanderonpad)
        Me.Controls.Add(Me.picsmashedlander)
        Me.Controls.Add(Me.piccrahsedlanderpad)
        Me.Controls.Add(Me.lblthrust2)
        Me.Controls.Add(Me.txtthrust)
        Me.Controls.Add(Me.txtfuel)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblcrashed)
        Me.Controls.Add(Me.lblsuccess)
        Me.Controls.Add(Me.Piclanderpad)
        Me.Controls.Add(Me.picpad)
        Me.Controls.Add(Me.lblycoordinate)
        Me.Controls.Add(Me.lblfuelleft)
        Me.Controls.Add(Me.lblxcoordinate)
        Me.Controls.Add(Me.txtxcoordinate)
        Me.Controls.Add(Me.txtycoordinate)
        Me.Controls.Add(Me.txtfuelleft)
        Me.Controls.Add(Me.Txtspeed)
        Me.Controls.Add(Me.lblspeed)
        Me.Controls.Add(Me.lblthrust)
        Me.Controls.Add(Me.trkthrust)
        Me.Controls.Add(Me.lblfuel)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.piclander)
        Me.Controls.Add(Me.txtintro)
        Me.Controls.Add(Me.btnstart)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lunar Lander"
        CType(Me.piclander, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkthrust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Piclanderpad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccrahsedlanderpad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsmashedlander, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Piclanderonpad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents txtintro As System.Windows.Forms.Label
    Friend WithEvents piclander As System.Windows.Forms.PictureBox
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents imllander As System.Windows.Forms.ImageList
    Friend WithEvents lblfuel As System.Windows.Forms.Label
    Friend WithEvents trkthrust As System.Windows.Forms.TrackBar
    Friend WithEvents lblthrust As System.Windows.Forms.Label
    Friend WithEvents lblspeed As System.Windows.Forms.Label
    Friend WithEvents Txtspeed As System.Windows.Forms.TextBox
    Friend WithEvents txtfuelleft As System.Windows.Forms.TextBox
    Friend WithEvents txtycoordinate As System.Windows.Forms.TextBox
    Friend WithEvents txtxcoordinate As System.Windows.Forms.TextBox
    Friend WithEvents lblxcoordinate As System.Windows.Forms.Label
    Friend WithEvents lblfuelleft As System.Windows.Forms.Label
    Friend WithEvents lblycoordinate As System.Windows.Forms.Label
    Friend WithEvents tmrMoveLander As System.Windows.Forms.Timer
    Friend WithEvents picpad As System.Windows.Forms.PictureBox
    Friend WithEvents Piclanderpad As System.Windows.Forms.PictureBox
    Friend WithEvents lblsuccess As System.Windows.Forms.Label
    Friend WithEvents lblcrashed As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtfuel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtthrust As System.Windows.Forms.TextBox
    Friend WithEvents lblthrust2 As System.Windows.Forms.Label
    Friend WithEvents piccrahsedlanderpad As System.Windows.Forms.PictureBox
    Friend WithEvents picsmashedlander As System.Windows.Forms.PictureBox
    Friend WithEvents Piclanderonpad As System.Windows.Forms.PictureBox

End Class
