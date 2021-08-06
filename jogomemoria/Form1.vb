Public Class Form1
    Dim clicou As Boolean = False
    Dim imagem1, imagem2 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imagem1 = "1"
        imagem2 = "2"
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True

        PictureBox1.Image = My.Resources.allstargame
        PictureBox2.Image = My.Resources.allstargame
        PictureBox3.Image = My.Resources.allstargame
        PictureBox4.Image = My.Resources.allstargame
        PictureBox5.Image = My.Resources.allstargame
        PictureBox6.Image = My.Resources.allstargame

        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True

    End Sub
    Sub verificar()
        If imagem1 = imagem2 Then
            MsgBox("Parabéns, você acertou", MessageBoxIcon.Information)
            If imagem1 = "bulls" Then
                PictureBox1.Visible = False
                PictureBox5.Visible = False

            ElseIf imagem1 = "bu" Then
                PictureBox2.Visible = False
                PictureBox3.Visible = False
            ElseIf imagem1 = "76" Then
                PictureBox2.Visible = False
                PictureBox3.Visible = False
            End If

        Else
            MsgBox("Tente novamente", MessageBoxIcon.Error)
            PictureBox1.Image = My.Resources.allstargame
            PictureBox2.Image = My.Resources.allstargame
            PictureBox3.Image = My.Resources.allstargame
            PictureBox4.Image = My.Resources.allstargame
            PictureBox5.Image = My.Resources.allstargame
            PictureBox6.Image = My.Resources.allstargame

            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True




            PictureBox1.Image = My.Resources.allstargame
            PictureBox2.Image = My.Resources.allstargame
            PictureBox3.Image = My.Resources.allstargame
            PictureBox4.Image = My.Resources.allstargame
            PictureBox5.Image = My.Resources.allstargame
            PictureBox6.Image = My.Resources.allstargame



        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If clicou = False Then
            clicou = True
            PictureBox1.Image = My.Resources.bulls
            imagem1 = "bulls"
            PictureBox1.Enabled = False

        Else
            imagem2 = "bulls"
            clicou = False
            PictureBox1.Image = My.Resources.bulls
            verificar()


        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If clicou = False Then
            clicou = True
            PictureBox2.Image = My.Resources.bucks
            imagem1 = "bu"
            PictureBox2.Enabled = False
        Else
            imagem2 = "bu"
            clicou = False
            PictureBox2.Image = My.Resources.bucks
            verificar()


        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If clicou = False Then
            clicou = True
            PictureBox3.Image = My.Resources.bucks
            imagem1 = "bu"
            PictureBox3.Enabled = False
        Else
            imagem2 = "bu"
            clicou = False
            PictureBox3.Image = My.Resources.bucks
            verificar()


        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If clicou = False Then
            clicou = True
            PictureBox4.Image = My.Resources._76ers
            imagem1 = "76"
            PictureBox4.Enabled = False
        Else
            imagem2 = "76"
            clicou = False
            PictureBox4.Image = My.Resources._76ers
            verificar()


        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If clicou = False Then
            clicou = True
            PictureBox5.Image = My.Resources.bulls
            imagem1 = "bulls"
            PictureBox5.Enabled = False
        Else
            imagem2 = "bulls"
            clicou = False
            PictureBox5.Image = My.Resources.bulls
            verificar()


        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If clicou = False Then
            clicou = True
            PictureBox1.Image = My.Resources._76ers
            imagem1 = "76"
            PictureBox6.Enabled = False
        Else
            imagem2 = "76"
            clicou = False
            PictureBox1.Image = My.Resources._76ers
            verificar()


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
