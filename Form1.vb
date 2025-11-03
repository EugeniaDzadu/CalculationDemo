Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtFirstNum.Text = " "
        Me.txtSecondNum.Text = " "
        Me.lblResult.Text = " "

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.txtFirstNum.Text = 20

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblResult.Text = CInt(txtFirstNum.Text) + CInt(txtSecondNum.Text)


    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        lblResult.Text = CInt(txtFirstNum.Text) * CInt(txtSecondNum.Text)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblResult.Text = CInt(txtFirstNum.Text) - CInt(txtSecondNum.Text)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        lblResult.Text = CInt(txtFirstNum.Text) / CInt(txtSecondNum.Text)
    End Sub
End Class
