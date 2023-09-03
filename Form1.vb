Public Class Form1

    Dim input1, input2, temp As Double?
    Dim repeatOperationFlag As Boolean
    Dim operation As String
    Dim history As String


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim output As Double = calculate()

        If output = 0 And (inputBox1.Text Is Nothing Or {"0", "-0"}.Contains(inputBox1.Text)) Then
            history += "0" & vbNewLine
            historyBox1.Text = history
        ElseIf Not output = Nothing And operation Is Nothing Then
            history += output & vbNewLine
            historyBox1.Text = history
        Else
            inputBox1.Text = output
            history += String.Format("{0} {1} {2} = {3}", input1, operation, input2, inputBox1.Text) + vbNewLine
            historyBox1.Text = history

            repeatOperationFlag = True
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        inputAdd(1)
    End Sub

    Private Sub button0_Click(sender As Object, e As EventArgs) Handles button0.Click
        inputAdd(0)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        inputAdd(2)
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        inputAdd(3)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        inputAdd(4)
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        inputAdd(5)
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        inputAdd(6)
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        inputAdd(7)
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        inputAdd(8)
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        inputAdd(9)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        inputBox1.Text = "0"
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
        If inputBox1.Text = "0" Or inputBox1.Text = "-0" Then
            inputBox1.Text = "-"
        Else
            operation = "-"
            setInput1()
            inputBox1.Text = ""
            repeatOperationFlag = False
        End If
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
        If inputBox1.Text = "0" Then
            inputBox1.Text = toAdd.ToString()
        Else
            inputBox1.Text += toAdd.ToString()
        End If
        repeatOperationFlag = False
        'use Sub if you dont want to return a value (eq. to void functions)
    End Sub

    Private Sub handleKeypress(sender As Object, e As KeyEventArgs)
        Dim numberKeys As Object() = {Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.D0}

        If numberKeys.Contains(e.KeyCode) And Not e.Modifiers = Keys.Shift Then
            handleNumkeyPresses(sender, e)
        Else
            handleOtherPresses(sender, e)
        End If
    End Sub

    Private Sub handleOtherPresses(sender As Object, e As KeyEventArgs)
        Select Case e.KeyData
            Case (Keys.Oemplus + Keys.Shift)
                buttonAdd_Click(sender, e)
            Case (Keys.D8 + Keys.Shift)
                buttonMultiply_Click(sender, e)
            Case (Keys.OemMinus)
                buttonSubtract_Click(sender, e)
            Case (Keys.OemPeriod)
                buttonDot_Click(sender, e)
            Case (Keys.OemQuestion)
                buttonDivide_Click(sender, e)
            Case (Keys.Enter)
                btnCalculate_Click(sender, e)
            Case (Keys.Back)
                If Not inputBox1.Text = "" Then inputBox1.Text = inputBox1.Text.Substring(0, inputBox1.Text.Length - 1)
            Case Else

        End Select
    End Sub

    Private Sub handleNumkeyPresses(sender As Object, e As KeyEventArgs)
        Dim number As Integer
        Select Case e.KeyCode
            Case Keys.D1
                number = 1
            Case Keys.D2
                number = 2
            Case Keys.D3
                number = 3
            Case Keys.D4
                number = 4
            Case Keys.D5
                number = 5
            Case Keys.D6
                number = 6
            Case Keys.D7
                number = 7
            Case Keys.D8
                number = 8
            Case Keys.D9
                number = 9
            Case Keys.D0
                number = 0
            Case Else
                number = Nothing
        End Select

        inputAdd(number)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        handleKeypress(sender, e)
    End Sub

    Private Sub btnClearHistory_Click(sender As Object, e As EventArgs) Handles btnClearHistory.Click
        historyBox1.Text = ""
        history = ""
        repeatOperationFlag = False
    End Sub

    Private Function calculate()
        If inputBox1.Text Is Nothing Or {"0", "-0"}.Contains(inputBox1.Text) Then
            Return 0
        End If

        If inputBox1.Text IsNot Nothing And operation Is Nothing Then
            Return inputBox1.Text
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
