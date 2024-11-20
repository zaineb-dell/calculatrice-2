Public Class frmCalculatrice
    Dim op As Char

    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click
        Op = "+"
    End Sub

    Private Sub Btn_moins_Click(sender As Object, e As EventArgs) Handles Btn_moins.Click
        Op = "-"
    End Sub

    Private Sub Byn_fois_Click(sender As Object, e As EventArgs) Handles Byn_fois.Click
        Op = "*"
    End Sub

    Private Sub Btn_div_Click(sender As Object, e As EventArgs) Handles Btn_div.Click
        Op = "/"
    End Sub

    Private Sub Btn_equal_Click(sender As Object, e As EventArgs) Handles Btn_equal.Click
        If IsNumeric(val_a.Text) And IsNumeric(val_b.Text) Then
        End If
        Dim a = Integer.Parse(val_a.Text)
        Dim b = Integer.Parse(val_b.Text)
        Dim rest As Double
        Dim test = True
        If op = "+" Then
            rest = a + b
        ElseIf op = "-" Then
            rest = a - b
        ElseIf op = "*" Then
            rest = a * b
        ElseIf op = "/" And Not b = 0 Then
            rest = a / b
            test = False
        Else
            MessageBox.Show("veuillez verifier si b!=0 et que v avez choisit l operateur")
            test = False
        End If
        If test Then
            res.Text = a.ToString + "" + op + "" + b.ToString + "=" + rest.ToString
        End If
    End Sub
End Class

