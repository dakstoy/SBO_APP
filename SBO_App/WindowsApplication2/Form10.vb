Public Class Form10

    Shared random As New Random()

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If CheckBox1.Checked = True Then

            Form9.Panel1.Visible = False
            Form9.Panel2.Visible = False

            Form9.Label15.Text = "Please support and like our page at https://www.facebook.com/shohoq4268/"
            Form9.Label14.Text = ""
            Form9.Label13.ForeColor = Color.Black
            Form9.Label12.Text = ""

            Form9.Timer6.Start()
            Form9.Panel6.Visible = True

        End If


    End Sub

    Public Sub wait2(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            Timer1.Start()

        Else

            Form9.Panel1.Visible = True
            Form9.Panel2.Visible = True

            Form9.Label15.Text = ", please support and like our page at https://www.facebook.com/shohoq4268/"
            Form9.Label14.Text = "End of"
            Form9.Label13.ForeColor = Color.White
            Form9.Label12.Text = "Period"

            Form9.Timer6.Stop()
            Form9.Panel6.Visible = False

            Timer1.Stop()

        End If

    End Sub
End Class