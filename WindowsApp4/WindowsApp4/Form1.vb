Public Class Form1
    Dim res As String
    Dim cont = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + " "
        S1()

    End Sub
    Sub S1()
        If TextBox1.Text(cont) = "1" Then
            res += "1"
            cont += 1
            Label1.Text = res
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            MsgBox("Encuentra 1, se mantiene igual, se mueve a la dercha")
            S1()

        ElseIf TextBox1.Text(cont) = "0" Then
            res += "0"
            cont += 1
            Label1.Text = res
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            MsgBox("Encuentra 0, se mantiene igual, se mueve a la dercha")

            S1()
        ElseIf TextBox1.Text(cont) = " " Then
            res += " "
            cont -= 1
            Label1.Text = res
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            MsgBox("Encuentra b, se mantiene igual, se mueve a la izquierda")
            S2()
        End If
    End Sub
    Sub S2()
        If TextBox1.Text(cont) = "1" Then
            res = res.Remove(cont, 1).Insert(cont, "0")
            cont -= 1
            Label1.Text = res
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            MsgBox("Encuentra 1, se cambia a 0, se mueve a la izquierda")
            S2()
        ElseIf TextBox1.Text(cont) = "0" Then
            res = res.Remove(cont, 1).Insert(cont, "1")
            cont -= 1
            Label1.Text = res
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = True
            MsgBox("Encuentra 0, se cambia a 1, se mueve a la izquierda")
            S3()
        ElseIf TextBox1.Text(cont) = " " Then
            res = res.Remove(cont, 1).Insert(cont, "1")
            PictureBox1.Image = ImageList1.Images(1)
            Label1.Text = res
            cont = 0
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            MsgBox("Estado final")
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
        End If
    End Sub

    Sub S3()
        If cont >= 0 Then
            If TextBox1.Text(cont) = "0" Then
                res = res.Remove(cont, 1).Insert(cont, "0")

                cont -= 1
                Label1.Text = res
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = False
                PictureBox5.Visible = True
                MsgBox("Encuentra 0, se mantiene igual, se mueve a la izquierda")
                S3()
            ElseIf TextBox1.Text(cont) = "1" Then
                res = res.Remove(cont, 1).Insert(cont, "1")
                cont -= 1
                Label1.Text = res
                Label1.Text = res
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = False
                PictureBox5.Visible = True
                MsgBox("Encuentra 1, se mantiene igual, se mueve a la izquierda")
                S3()
            ElseIf TextBox1.Text(cont) = "" Then
                Label1.Text = res
                cont = 0
                Label1.Text = res
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = True
                PictureBox5.Visible = False
                MsgBox("Estado final")
            End If
        Else
            Label1.Text = res
            cont = 0
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            MsgBox("Estado final")
        End If
    End Sub

End Class
