<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtFirstNum = New TextBox()
        txtSecondNum = New TextBox()
        lblFirstNum = New Label()
        lblSecondNum = New Label()
        lblResult = New Label()
        btnAdd = New Button()
        btnClear = New Button()
        btnExit = New Button()
        btnSubstract = New Button()
        btnDivide = New Button()
        btnMultiply = New Button()
        SuspendLayout()
        ' 
        ' txtFirstNum
        ' 
        txtFirstNum.Location = New Point(318, 48)
        txtFirstNum.Name = "txtFirstNum"
        txtFirstNum.Size = New Size(314, 27)
        txtFirstNum.TabIndex = 0
        txtFirstNum.Text = "0"
        ' 
        ' txtSecondNum
        ' 
        txtSecondNum.Location = New Point(318, 138)
        txtSecondNum.Name = "txtSecondNum"
        txtSecondNum.Size = New Size(314, 27)
        txtSecondNum.TabIndex = 1
        ' 
        ' lblFirstNum
        ' 
        lblFirstNum.AutoSize = True
        lblFirstNum.Location = New Point(175, 55)
        lblFirstNum.Name = "lblFirstNum"
        lblFirstNum.Size = New Size(94, 20)
        lblFirstNum.TabIndex = 2
        lblFirstNum.Text = "First Number"
        ' 
        ' lblSecondNum
        ' 
        lblSecondNum.AutoSize = True
        lblSecondNum.Location = New Point(175, 138)
        lblSecondNum.Name = "lblSecondNum"
        lblSecondNum.Size = New Size(116, 20)
        lblSecondNum.TabIndex = 3
        lblSecondNum.Text = "Second Number"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.BackColor = SystemColors.ActiveCaption
        lblResult.Location = New Point(175, 224)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(49, 20)
        lblResult.TabIndex = 4
        lblResult.Text = "Result"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(238, 289)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(549, 289)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(549, 372)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSubstract
        ' 
        btnSubstract.Location = New Point(238, 372)
        btnSubstract.Name = "btnSubstract"
        btnSubstract.Size = New Size(94, 29)
        btnSubstract.TabIndex = 8
        btnSubstract.Text = "Substract"
        btnSubstract.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(388, 372)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(94, 29)
        btnDivide.TabIndex = 9
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(388, 289)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(94, 29)
        btnMultiply.TabIndex = 10
        btnMultiply.Text = "Multiply"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 508)
        Controls.Add(btnMultiply)
        Controls.Add(btnDivide)
        Controls.Add(btnSubstract)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(lblResult)
        Controls.Add(lblSecondNum)
        Controls.Add(lblFirstNum)
        Controls.Add(txtSecondNum)
        Controls.Add(txtFirstNum)
        Name = "Form1"
        Text = "Form1"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents lblFirstNum As Label
    Friend WithEvents lblSecondNum As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubstract As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button

End Class
