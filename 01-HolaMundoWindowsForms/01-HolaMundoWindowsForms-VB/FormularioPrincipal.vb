Imports Entidades

Public Class FormularioPrincipal
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnsaludar_Click(sender As Object, e As EventArgs) Handles btnsaludar.Click
        Dim obPersona As New clsPersona
        obPersona.nombre = txtnombre.Text
        If (String.IsNullOrEmpty(obPersona.nombre)) Then
            lblerror.Text = "Introduce un nombre"
        Else
            MsgBox("Hola " + obPersona.nombre)
            lblerror.Text = ""
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblApellido.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
