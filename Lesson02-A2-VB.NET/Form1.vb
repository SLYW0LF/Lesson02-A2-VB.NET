Public Class Form1

    Private rand As Random = New Random()
    Private counter As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        counter = counter - 1
        Label1.Text = counter.ToString()

        If counter = 0 Then
            Timer1.Stop()
            Button1.Location = New Point(rand.Next(Label1.Location.X - Button1.Width), rand.Next(Size.Height - Button1.Height))
            Button1.Enabled = True
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        counter = 2 + rand.Next(8)

        Label1.Text = counter.ToString()
        Label2.Visible = True
        Button1.Enabled = False

        Timer1.Interval = 1000
        Timer1.Start()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
