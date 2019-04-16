Imports VB = Microsoft.VisualBasic
Public Class Form6
    Dim rs As New Resizer
    Public totaltime = "30"
    Public totaltime2 = "60"
    Public totaltime3 = "120"
    Shared random As New Random()
    Private Declare Function music Lib “winmm.dll” Alias “mciSendStringA” (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private Sub Form6_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        rs.ResizeAllControls(Me)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label6.Text = Form1.Label4.Text
        Timer1.Enabled = True
        Timer5.Enabled = True
        rs.FindAllControls(Me)

        zzz = Form3.ListView1.Items.Count

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label8.Text = Form2.Label10.Text
        Label9.Text = Form2.Label8.Text
        Label10.Text = Form2.Label3.Text

        Label1.Text = VB.Left(Form2.Label4.Text, 3)

        Label5.Text = VB.Left(Form2.Label5.Text, 3)

        Label6.Text = AddZero(Form1.mins) & ":" & AddZero(Form1.secs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Label11.Text = ""

        If totaltime = 0 Then

            totaltime = 31
            Timer2.Enabled = False
            Form2.WindowState = FormWindowState.Maximized
            WindowState = FormWindowState.Minimized
            Form1.Focus()

        End If

        If Not totaltime = 0 Then
            totaltime -= 1
        End If

        Label4.Text = totaltime

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        On Error Resume Next

        If totaltime2 = 59 Then

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, Form1.zzz)

            FileName = Chr(34) & (Form3.TextBox32.Text & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\What_Ive_Done.wav")

        End If

        If totaltime2 = 0 Then

            Label6.Text = AddZero(Form3.NumericUpDown1.Value) & ":" & AddZero(Form3.NumericUpDown2.Value)
            totaltime2 = 61
            Timer3.Enabled = False
            Form2.WindowState = FormWindowState.Maximized
            WindowState = FormWindowState.Minimized
            Form1.Label10.Text = CDbl(Form1.Label10.Text) + 1

            If Form1.CheckBox1.Checked = True Then

                Form1.CheckBox2.Checked = True

            Else

                Form1.CheckBox1.Checked = True

            End If

            Form1.Focus()

        End If

        If Not totaltime2 = 0 Then
            totaltime2 -= 1
        End If

        Label4.Text = totaltime2

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        On Error Resume Next

        Form9.Timer6.Start()

        If CInt(Form9.Label4.Text) > CInt(Form9.Label11.Text) Then

            Form9.Label4.ForeColor = Color.Blue
            Form9.Label11.ForeColor = Color.Red

        Else

            If CInt(Form9.Label4.Text) = CInt(Form9.Label11.Text) Then

                Form9.Label4.ForeColor = Color.Gray
                Form9.Label11.ForeColor = Color.Gray

            Else

                Form9.Label4.ForeColor = Color.Red
                Form9.Label11.ForeColor = Color.Blue

            End If

        End If

        If totaltime3 = 59 Then

            Form9.PictureBox10.Visible = True
            Form9.PictureBox10.Image = My.Resources.ty

        ElseIf totaltime3 = 55 Then

            Form9.PictureBox10.Image = My.Resources.VDrink

        ElseIf totaltime3 = 49 Then

            Form9.PictureBox10.Image = My.Resources.CSAS

        ElseIf totaltime3 = 43 Then

            Form9.PictureBox10.Image = My.Resources.emar

        ElseIf totaltime3 = 37 Then

            Form9.PictureBox10.Image = My.Resources.cyber_bellying

        ElseIf totaltime3 = 31 Then

            Form9.PictureBox10.Image = My.Resources.KCS

        ElseIf totaltime3 = 25 Then

            Form9.PictureBox10.Image = My.Resources.Blip2

        ElseIf totaltime3 = 19 Then

            Form9.PictureBox10.Image = My.Resources.Custom_Sports

        ElseIf totaltime3 = 13 Then

            Form9.PictureBox10.Image = My.Resources.Pocari_Sweat_logo

        ElseIf totaltime3 = 7 Then

            Form9.PictureBox10.Image = My.Resources.San_Remigio

        End If

        If totaltime3 = 119 Then

            Form9.PictureBox10.Visible = True
            Form9.PictureBox10.Image = My.Resources.halftime

            Form9.Panel6.Visible = True
            Form9.PictureBox9.Visible = False
            Form9.Panel1.Visible = False
            Form9.Panel2.Visible = False
            Form9.PictureBox17.Visible = True
            Form9.PictureBox18.Visible = True
            Form9.Label4.Visible = True
            Form9.Label11.Visible = True
            Form9.PictureBox20.Visible = True

            Dim FileName As String
            Dim a As Integer

            a = random.Next(1, Form1.zzz)

            FileName = Chr(34) & (Form3.TextBox32.Text & Form3.ListView1.Items(a).Text) & Chr(34)

            music(“open ” & FileName & ” alias myDevice”, Nothing, 0, 0)
            music(“play myDevice”, Nothing, 0, 0)

            'My.Computer.Audio.Play("C:\Users\Admin\Desktop\Dexter_Stuffs\Images\Leave_Out_All_The_Rest.wav")

        End If

        If totaltime3 = 0 Then

            Form9.Timer6.Stop()

            Form9.Panel6.Visible = False
            Form9.PictureBox9.Visible = True
            Form9.PictureBox10.Visible = False
            Form9.Panel1.Visible = True
            Form9.Panel2.Visible = True
            Form9.PictureBox17.Visible = False
            Form9.PictureBox18.Visible = False
            Form9.Label4.Visible = False
            Form9.Label11.Visible = False
            Form9.PictureBox20.Visible = False

            Label6.Text = AddZero(Form3.NumericUpDown1.Value) & ":" & AddZero(Form3.NumericUpDown2.Value)
            totaltime3 = 121
            Timer4.Enabled = False
            Form2.WindowState = FormWindowState.Maximized
            WindowState = FormWindowState.Minimized
            Form1.Label10.Text = CDbl(Form1.Label10.Text) + 1

            If Form1.CheckBox1.Checked = True Then

                Form1.CheckBox2.Checked = True

            Else

                Form1.CheckBox1.Checked = True

            End If

            Form1.Focus()

        End If

        If Not totaltime3 = 0 Then
            totaltime3 -= 1
        End If

        Label4.Text = totaltime3

    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Form2.Close()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If Timer2.Enabled = False Then

            totaltime = 30

        End If

    End Sub

End Class