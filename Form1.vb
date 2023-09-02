Public Class Form1

    Dim input1, input2, temp As Double?
    Dim repeatOperationFlag As Boolean
    Dim operation As String
    Dim history As String


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim output As Double = calculate()
        inputBox1.Text = output
        history += String.Format("{0} {1} {2} = {3}", input1, operation, input2, inputBox1.Text) + vbNewLine
        historyBox1.Text = history

        repeatOperationFlag = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        inputAdd(1)
        repeatOperationFlag = False
    End Sub

    Private Sub button0_Click(sender As Object, e As EventArgs) Handles button0.Click
        inputAdd(0)
        repeatOperationFlag = False
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        inputAdd(2)
        repeatOperationFlag = False
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        inputAdd(3)
        repeatOperationFlag = False
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        inputAdd(4)
        repeatOperationFlag = False
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        inputAdd(5)
        repeatOperationFlag = False
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        inputAdd(6)
        repeatOperationFlag = False
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        inputAdd(7)
        repeatOperationFlag = False
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        inputAdd(8)
        repeatOperationFlag = False
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        inputAdd(9)
        repeatOperationFlag = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        inputBox1.Text = ""
        input1 = Nothing
        input2 = Nothing
        repeatOperationFlag = False
    End Sub

    Private Sub buttonDot_Click(sender As Object, e As EventArgs) Handles buttonDot.Click
        inputBox1.Text += "."
    End Sub
    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        operation = "+"
        setInput1()
        inputBox1.Text = ""
        repeatOperationFlag = False
    End Sub

    Private Sub buttonSubtract_Click(sender As Object, e As EventArgs) Handles buttonSubtract.Click
        operation = "-"
        setInput1()
        inputBox1.Text = ""
        repeatOperationFlag = False
    End Sub

    Private Sub buttonMultiply_Click(sender As Object, e As EventArgs) Handles buttonMultiply.Click
        operation = "*"
        setInput1()
        inputBox1.Text = ""
        repeatOperationFlag = False
    End Sub

    Private Sub buttonDivide_Click(sender As Object, e As EventArgs) Handles buttonDivide.Click
        operation = "/"
        setInput1()
        inputBox1.Text = ""
        repeatOperationFlag = False
    End Sub

    Private Sub setInput1()
        Try
            input1 = CDbl(inputBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid input")
        End Try
    End Sub

    Private Sub setInput2()
        Try
            input2 = CDbl(inputBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid input")
        End Try
    End Sub
    Private Sub inputAdd(toAdd As Integer)
        inputBox1.Text += toAdd.ToString()
        'use Sub if you dont want to return a value (eq. to void functions)
    End Sub

    Private Sub btnClearHistory_Click(sender As Object, e As EventArgs) Handles btnClearHistory.Click
        historyBox1.Text = ""
        history = ""
        repeatOperationFlag = False
    End Sub

    Private Function calculate()
        If inputBox1.Text Is Nothing Then
            Throw New Exception("Invalid Input")
            Return -1
        End If

        If repeatOperationFlag Then
            setInput1()
            input2 = input2
        Else
            setInput2()
        End If

        Dim output As Double
        Select Case operation
            Case "+"
                output = input1 + input2
            Case "-"
                output = input1 - input2
            Case "*"
                output = input1 * input2
            Case "/"
                output = input1 / input2
        End Select

        Return Math.Round(output, 4)
    End Function

End Class
