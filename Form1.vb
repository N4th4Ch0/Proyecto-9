Public Class Form1
    Private Sub btnCompro_Click(sender As Object, e As EventArgs) Handles btnCompro.Click

        Dim peso As String

        peso = txtPeso.Text

        Select Case peso

            Case < 48.99

                lblCategoria.Text = "perteneces a la categoria Minimosca"
                lblCategoria.ForeColor = Color.Brown

            Case < 51.99

                lblCategoria.Text = "perteneces a la categoria mosca"
                lblCategoria.ForeColor = Color.Purple

            Case < 54.99

                lblCategoria.Text = "perteneces a la categoria gallo"
                lblCategoria.ForeColor = Color.DarkOrange

            Case < 57.99

                lblCategoria.Text = "perteneces a la categoria pluma"
                lblCategoria.ForeColor = Color.OrangeRed

            Case < 60.99

                lblCategoria.Text = "perteneces a la categoria ligero"
                lblCategoria.ForeColor = Color.Blue

            Case < 64.99

                lblCategoria.Text = "perteneces a la categoria superligero"
                lblCategoria.ForeColor = Color.BlueViolet

            Case < 69.99

                lblCategoria.Text = "perteneces a la categoria wélter"
                lblCategoria.ForeColor = Color.GreenYellow

            Case < 75.99

                lblCategoria.Text = "perteneces a la categoria mediano"
                lblCategoria.ForeColor = Color.Yellow

            Case < 81.99

                lblCategoria.Text = "perteneces a la categoria semi´pesado"
                lblCategoria.ForeColor = Color.Green

            Case < 91.99

                lblCategoria.Text = "perteneces a la categoria superpesado"
                lblCategoria.ForeColor = Color.Red

            Case > 92

                lblCategoria.Text = "Es mejor que no pelees xddd"

        End Select
    End Sub

    Private Sub cmdReini_Click(sender As Object, e As EventArgs) Handles cmdReini.Click
        lblCategoria.Text = " "
        txtPeso.Text = " "

    End Sub
End Class
