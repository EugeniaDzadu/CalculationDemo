Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtFirstNum.Text = " "
        Me.txtSecondNum.Text = " "
        Me.lblResult.Text = " "
        'txtFirstNum.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.txtFirstNum.Text = 20
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'lblResult.Text = CInt(txtFirstNum.Text) + CInt(txtSecondNum.Text)

        ' Step 1: Declare variables
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        ' Step 2: Check user input and convert(decision) and ' Step 3: Assign user input to variables
        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            firstNumber = CInt(txtFirstNum.Text)
            secondNumber = CInt(txtSecondNum.Text)
        Else
            MessageBox.Show("Please enter a numeric value")
            Exit Sub
        End If

        ' Step 4: Use variables in code
        result = firstNumber + secondNumber
        lblResult.Text = "The Final Answer = " & result.ToString()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'lblResult.Text = CInt(txtFirstNum.Text) * CInt(txtSecondNum.Text)

        ' Step 1: Declare variables
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        ' Step 2: Check user input and convert(decision) and ' Step 3: Assign user input to variables
        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            firstNumber = CInt(txtFirstNum.Text)
            secondNumber = CInt(txtSecondNum.Text)
        Else
            MessageBox.Show("Please enter a numeric value")
            Exit Sub
        End If

        ' Step 4: Use variables in code
        result = firstNumber * secondNumber
        lblResult.Text = "The Final Answer = " & result.ToString()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'lblResult.Text = CInt(txtFirstNum.Text) / CInt(txtSecondNum.Text)

        ' Step 1: Declare variables
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        ' Step 2: Check user input and convert(decision) and ' Step 3: Assign user input to variables
        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            firstNumber = CInt(txtFirstNum.Text)
            secondNumber = CInt(txtSecondNum.Text)
        Else
            MessageBox.Show("Please enter a numeric value")
            Exit Sub
        End If

        ' Step 4: Use variables in code
        result = firstNumber \ secondNumber
        lblResult.Text = "The Final Answer = " & result.ToString()
    End Sub

    Private Sub btnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
        ' Step 1: Declare variables
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        ' Step 2: Check user input and convert(decision) and ' Step 3: Assign user input to variables
        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            firstNumber = CInt(txtFirstNum.Text)
            secondNumber = CInt(txtSecondNum.Text)
        Else
            MessageBox.Show("Please enter a numeric value")
            Exit Sub
        End If

        ' Step 4: Use variables in code
        result = firstNumber - secondNumber
        lblResult.Text = "The Final Answer = " & result.ToString()
    End Sub

End Class
