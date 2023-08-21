Imports CapaDominioCSharp

Public Class CalculatorView

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        'Variables
        Dim x = txt_num1.Text
        Dim y = txt_num2.Text
        Dim operation = cbx_operaciones.Text

        Dim arg() As Object = {x, y, operation}

        'calular operacion C#
        Dim objectoCSharp As New CapaDominioCSharp.ClaseOperacion_CSharp() 'Instancia
        Dim resultCSharp = objectoCSharp.Calcular(arg)
        lbl_resultadoCSharp.Text = "El resultado es: " &
            resultCSharp.ToString() & vbCrLf &
            "Respuesta desdce C#"

        'calular operacion F#
        Dim resultFSharp = CapaDominioFSharp.Operacion_FSharp.Calcular(x, y, operation)
        lbl_resultadoFSharp.Text = "El resultado es: " &
            resultFSharp.ToString() & vbCrLf &
            "Respuesta desdce F#"
    End Sub
End Class
