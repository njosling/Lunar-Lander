Public Class Form1
    Dim moveright As Boolean
    Dim moveleft As Boolean
    Dim thrust As Integer
    Dim gravity As Integer
    Dim fuel As Single
    Dim speed As Integer
    Dim username As String
    Dim landerx As Integer
    Dim landery As Integer
    Dim score As String
    Dim minvalue As Integer
    Dim padx As Integer
    Dim pady As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrMoveLander.Stop()                                    'stop timer movelnader so the lander dosent fall before the start button has been pressed
        lblfuel.Visible = True
        Txtfuel.Visible = True
        txtintro.Visible = True
        txtusername.Visible = True
        lblusername.Visible = True
        btnstart.Visible = True
        Piclanderpad.Visible = False
        picpad.Visible = False
        lblfuelleft.Visible = False
        lblspeed.Visible = False
        lblthrust.Visible = False
        lblxcoordinate.Visible = False
        lblycoordinate.Visible = False
        txtfuelleft.Visible = False
        Txtspeed.Visible = False
        txtxcoordinate.Visible = False
        txtycoordinate.Visible = False
        trkthrust.Visible = False
        lblsuccess.Visible = False
        piclander.Visible = False
        lblcrashed.Visible = False
        txtthrust.Visible = False
        lblthrust2.Visible = False
        piccrahsedlanderpad.Visible = False
        picsmashedlander.Visible = False

        '--------------------------------------------

        speed = 5                                                'set speed to 5 
        gravity = 2                                              'set gravity to 2 
        Me.KeyPreview = True                                     'enable keyboard 
        Randomize()                                              'randomize sub 
        landerx = Int(Rnd() * 634)                               'get random x posiotion between 0 and 634 for lander
        landery = -50                                            'set landers y position to - 50 
        padx = Int(Rnd() * 634)                                  'get random x position between 0 and 634 for lander pad 
        pady = 400                                               'sey lander pads y position to 400
        picpad.Left = padx                                       'assign padx to left 
       
    End Sub

    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        If txtfuel.Text = "" Then
            MessageBox.Show("please enter fuel")
        Else
            If txtusername.Text = "" Then
                MessageBox.Show("please enter username")
            Else
                If txtusername.Text.Length > 19 Then
                    MessageBox.Show("please enter a shorter name")
                Else
                    If txtfuel.Text > 5000 Then
                        MessageBox.Show("please enter a valid number")
                    Else
                        tmrMoveLander.Start()                                   'start the timermovelander sub 
                        txtintro.Visible = False                                'showing the textboxes and labels after the start button has been pressed:
                        lblfuel.Visible = False
                        lblfuelleft.Visible = True
                        lblspeed.Visible = True
                        lblthrust.Visible = True
                        lblxcoordinate.Visible = True
                        lblycoordinate.Visible = True
                        txtfuel.Visible = False
                        txtfuelleft.Visible = True
                        Txtspeed.Visible = True
                        txtxcoordinate.Visible = True
                        txtycoordinate.Visible = True
                        trkthrust.Visible = True
                        btnstart.Visible = False
                        txtusername.Visible = False
                        lblusername.Visible = False
                        piclander.Visible = True
                        picpad.Visible = True
                        lblthrust2.Visible = True
                        txtthrust.Visible = True
                        fuel = Convert.ToSingle(txtfuel.Text)                    'convert fuel from a single to a string so it can be displayed in the textbox
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Right
                moveright = True                                  'if right key is pressed then move lander right,if left key is pressed then move lander left
            Case Keys.Left
                moveleft = True
        End Select
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        Select Case e.KeyCode
            Case Keys.Right
                moveright = False                                 'if right key is released then stop lander moving, if left key is released then stop moving lander 
            Case Keys.Left
                moveleft = False
        End Select

    End Sub

    Private Sub tmrMoveLander_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveLander.Tick

        speed += gravity
        speed -= thrust / 10
        landery += speed / 40
        fuel -= thrust

        '--------------------------------------------

        If moveright = True Then
            landerx += 3
        ElseIf moveleft = True Then                                'if right key is pressed then + speed to x co-ordinate, if left key is pressed then - speed from x co-ordinate
            landerx -= 3
        End If

        '--------------------------------------------

        If fuel < 0 Then                                            'when fuel is empty:
            fuel = 0                                                'fuel = 0
            thrust = 0                                              'thrust = 0
            piclander.Image = imllander.Images.Item(0)              'change the piclander image with thrust to the one without thrust 
        End If

        '--------------------------------------------

        If moveleft = True Then                                     'if the left key is pressed then show the image of the left lander
            piclander.Image = imllander.Images.Item(2)
        ElseIf moveright = True Then                                'if the right key is pressed then show the image of the right lander
            piclander.Image = imllander.Images.Item(4)
        End If
        If trkthrust.Value > 1 And moveleft = True Then             'if the left key is pressed and thrust is bigger than 1 then show the image of the left lander with thrust
            piclander.Image = imllander.Images.Item(3)
        ElseIf trkthrust.Value > 1 And moveright = True Then        'if the right key is pressed and thrust is bigger than 1 then show the image of the right lander with thrust 
            piclander.Image = imllander.Images.Item(5)
        End If

        '--------------------------------------------

        piclander.Left = landerx                                    'assign landerx to left 
        piclander.Top += 1                                          '
        piclander.Top = landery                                     'assign landery to top
        Txtspeed.Text = speed                                       'show speed in speeed textbox
        txtxcoordinate.Text = landerx                               'show x coordinate in x coordinate textbox 
        txtycoordinate.Text = landery                               'show y coordinate in y coordinate textbox 
        txtthrust.Text = trkthrust.Value                            'get the value of trackbar thrust and display in thrust textbox
        txtfuelleft.Text = fuel                                     'show how much fuel is left in fuel left text box 

        '--------------------------------------------

        If Collision(piclander, picpad) Then                        'if the lander hits the lander pad and speed is lower than 150 then:
            If speed < 150 Then
                lblsuccess.Visible = True                           'show the success message 
                piclander.Image = Piclanderonpad.Image              'change the piclander image to the lander on pad image 
                picpad.Visible = False                              'hide the image of the lander pad
                tmrMoveLander.Stop()                                'stop the timermovelander

            ElseIf speed >= 150 Then                                'if the lander hits the lander pad and the speed is higher than 150 then:
                lblcrashed.Visible = True                           'show the crashed message 
                piclander.Image = piccrahsedlanderpad.Image         'change the piclander image to the crashed on pad image 
                picpad.Visible = False                              'hide the image of the lander pad 
                tmrMoveLander.Stop()                                'stop the timer movelander 
            End If
        End If

        '--------------------------------------------

        If landery >= 500 Then                                      'if landers Y position is bigger or equal to 500 then stop timermove lander show crashed message and show crashed lander image 
            tmrMoveLander.Stop()
            lblcrashed.Visible = True
            piclander.Image = picsmashedlander.Image                '

        End If

    End Sub

    Public Overloads Function Collision(ByVal Obj1 As Object, ByVal Obj2 As Object, _
    Optional ByVal HorizTolerance1 As Integer = 0, Optional ByVal VertTolerance1 As Integer = 0, _
    Optional ByVal HorizTolerance2 As Integer = 0, Optional ByVal VertTolerance2 As Integer = 0) As Boolean
        Return (Obj1.Top + Obj1.Height - VertTolerance1 >= Obj2.Top + VertTolerance2) _
        And (Obj2.Top + Obj2.Height - VertTolerance2 >= Obj1.Top + VertTolerance1) _
        And (Obj1.Left + Obj1.Width - HorizTolerance1 >= Obj2.Left + HorizTolerance2) _
        And (Obj2.Left + Obj2.Width - HorizTolerance2 >= Obj1.Left + HorizTolerance1) _
        And Obj1.Visible And Obj2.Visible
    End Function

    Private Sub trkthrust_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkthrust.ValueChanged

        thrust = trkthrust.Value                                    'assign thrust to trackbar thrust 
        If trkthrust.Value < 1 Then                                 'if the value of trackbar is smaller than 1 then show picllander without thrust 
            piclander.Image = imllander.Images.Item(0)              'if the value of trackbar is bigger than 1 then show piclander with thrust 
        ElseIf trkthrust.Value > 1 Then
            piclander.Image = imllander.Images.Item(1)
        End If
    End Sub


   
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class



















