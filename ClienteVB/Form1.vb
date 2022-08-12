Public Class Form1
    Dim Servicio As New ServiceReference1.WebService1SoapClient
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim Nro1, Nro2, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Nro2 = Double.Parse(tb_nro2.Text)
        Resultado = Servicio.Suma(Nro1, Nro2)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim Nro1, Nro2, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Nro2 = Double.Parse(tb_nro2.Text)
        Resultado = Servicio.Resta(Nro1, Nro2)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim Nro1, Nro2, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Nro2 = Double.Parse(tb_nro2.Text)
        Resultado = Servicio.Multiplicar(Nro1, Nro2)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim Nro1, Nro2, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Nro2 = Double.Parse(tb_nro2.Text)
        Resultado = Servicio.Dividir(Nro1, Nro2)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        Dim Nro1, Nro2, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Nro2 = Double.Parse(tb_nro2.Text)
        Resultado = Servicio.Potencia(Nro1, Nro2)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        Dim Nro1, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Resultado = Servicio.Radicacion(Nro1)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnPorcentaje_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click
        Dim Nro1, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Resultado = Servicio.Porcentaje(Nro1)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Dim Nro1, Nro2, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Resultado = Servicio.fact(Nro1)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnSeno_Click(sender As Object, e As EventArgs) Handles btnSeno.Click
        Dim Nro1, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Resultado = Servicio.Seno(Nro1)
        tb_resultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnCoseno_Click(sender As Object, e As EventArgs) Handles btnCoseno.Click
        Dim Nro1, Resultado As Double
        Nro1 = Double.Parse(tb_nro1.Text)
        Resultado = Servicio.Coseno(Nro1)
        tb_resultado.Text = Resultado.ToString()
    End Sub
End Class
