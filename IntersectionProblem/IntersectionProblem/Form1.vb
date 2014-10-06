Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        If (B < A Or D < C) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        txtResult.Text = FindIntersection(A, B, C, D)
    End Sub

    Function FindIntersection(A As Double, B As Double, C As Double, D As Double) As String
        Dim result As String
        If (B < C) Or (D < A) Then
            result = "No intersection"
        Else
            Dim begPoint, endPoint As Double
            begPoint = Math.Max(A, C)
            endPoint = Math.Min(B, D)

            result = "There is an intersection from " & begPoint & " to " & endPoint
        End If

        Return result
    End Function

End Class
