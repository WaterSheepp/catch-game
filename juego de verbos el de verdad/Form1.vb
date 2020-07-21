Public Class Form1


    Private Sub mainGameTimer(sender As Object, e As EventArgs)




    End Sub



    Private Sub KeylsDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            rightMover.Start()

        End If

        If e.KeyCode = Keys.Left Then
            leftMover.Start()


        End If


    End Sub

    Private Sub KeylsUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        rightMover.Stop()
        leftMover.Stop()



    End Sub

    Private Sub rightMover_Tick(sender As Object, e As EventArgs) Handles rightMover.Tick
        If (basket.Location.X < 511) Then

            basket.Left += 5

        End If

    End Sub

    Private Sub leftMover_Tick(sender As Object, e As EventArgs) Handles leftMover.Tick

        If (basket.Location.X > 17) Then
            basket.Left -= 5
        End If

    End Sub

    Private Sub verb1_Tick(sender As Object, e As EventArgs) Handles verb1.Tick


        PictureBox1.Top += 5
        If PictureBox1.Top >= Me.Height Then
            PictureBox1.Top = -(CInt(Math.Ceiling(Rnd() * 102)) + PictureBox1.Height)
            PictureBox1.Left = CInt(Math.Ceiling(Rnd() * 524)) + 0
        End If
    End Sub

    Private Sub verb2_Tick(sender As Object, e As EventArgs) Handles verb2.Tick
        PictureBox2.Top += 5
        If PictureBox2.Top >= Me.Height Then
            PictureBox2.Top = -(CInt(Math.Ceiling(Rnd() * 102)) + PictureBox2.Height)
            PictureBox2.Left = CInt(Math.Ceiling(Rnd() * 524)) + 0
        End If
    End Sub

    Private Sub verb3_Tick(sender As Object, e As EventArgs) Handles verb3.Tick
        PictureBox3.Top += 5
        If PictureBox3.Top >= Me.Height Then
            PictureBox3.Top = -(CInt(Math.Ceiling(Rnd() * 102)) + PictureBox3.Height)
            PictureBox3.Left = CInt(Math.Ceiling(Rnd() * 524)) + 0
        End If
    End Sub

    Private Sub verb4_Tick(sender As Object, e As EventArgs) Handles verb4.Tick
        PictureBox4.Top += 5
        If PictureBox4.Top >= Me.Height Then
            PictureBox4.Top = -(CInt(Math.Ceiling(Rnd() * 102)) + PictureBox4.Height)
            PictureBox4.Left = CInt(Math.Ceiling(Rnd() * 524)) + 0
        End If

    End Sub

    Private Sub boom1_Tick(sender As Object, e As EventArgs) Handles boom1.Tick
        bomb1.Top += 5
        If bomb1.Top >= Me.Height Then
            bomb1.Top = -(CInt(Math.Ceiling(Rnd() * 102)) + bomb1.Height)
            bomb1.Left = CInt(Math.Ceiling(Rnd() * 524)) + 0
        End If
    End Sub

    Private Sub boom2_Tick(sender As Object, e As EventArgs) Handles boom2.Tick
        bomb2.Top += 5
        If bomb2.Top >= Me.Height Then
            bomb2.Top = -(CInt(Math.Ceiling(Rnd() * 102)) + bomb2.Height)
            bomb2.Left = CInt(Math.Ceiling(Rnd() * 524)) + 0
        End If
    End Sub

    Private Sub basket_Click(sender As Object, e As EventArgs) Handles basket.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
