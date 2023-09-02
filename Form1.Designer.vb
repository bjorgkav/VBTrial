<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.inputBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.historyBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buttonDot = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.button0 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.buttonDivide = New System.Windows.Forms.Button()
        Me.buttonMultiply = New System.Windows.Forms.Button()
        Me.buttonSubtract = New System.Windows.Forms.Button()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.btnClearHistory = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(565, 335)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(210, 98)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "="
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'inputBox1
        '
        Me.inputBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.inputBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputBox1.Location = New System.Drawing.Point(16, 77)
        Me.inputBox1.Multiline = True
        Me.inputBox1.Name = "inputBox1"
        Me.inputBox1.ReadOnly = True
        Me.inputBox1.Size = New System.Drawing.Size(541, 77)
        Me.inputBox1.TabIndex = 0
        Me.inputBox1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 49)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Calculator"
        '
        'historyBox1
        '
        Me.historyBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historyBox1.Location = New System.Drawing.Point(565, 77)
        Me.historyBox1.Multiline = True
        Me.historyBox1.Name = "historyBox1"
        Me.historyBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.historyBox1.Size = New System.Drawing.Size(210, 201)
        Me.historyBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(556, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 49)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "History"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.buttonDot)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.button0)
        Me.Panel1.Controls.Add(Me.button9)
        Me.Panel1.Controls.Add(Me.button8)
        Me.Panel1.Controls.Add(Me.button6)
        Me.Panel1.Controls.Add(Me.button5)
        Me.Panel1.Controls.Add(Me.button7)
        Me.Panel1.Controls.Add(Me.button3)
        Me.Panel1.Controls.Add(Me.button4)
        Me.Panel1.Controls.Add(Me.button2)
        Me.Panel1.Controls.Add(Me.button1)
        Me.Panel1.Location = New System.Drawing.Point(16, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 286)
        Me.Panel1.TabIndex = 6
        '
        'buttonDot
        '
        Me.buttonDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDot.Location = New System.Drawing.Point(123, 213)
        Me.buttonDot.Name = "buttonDot"
        Me.buttonDot.Size = New System.Drawing.Size(115, 65)
        Me.buttonDot.TabIndex = 11
        Me.buttonDot.Text = "."
        Me.buttonDot.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(242, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 65)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'button0
        '
        Me.button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button0.Location = New System.Drawing.Point(5, 213)
        Me.button0.Name = "button0"
        Me.button0.Size = New System.Drawing.Size(115, 65)
        Me.button0.TabIndex = 10
        Me.button0.Text = "0"
        Me.button0.UseVisualStyleBackColor = True
        '
        'button9
        '
        Me.button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button9.Location = New System.Drawing.Point(242, 146)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(115, 65)
        Me.button9.TabIndex = 9
        Me.button9.Text = "9"
        Me.button9.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button8.Location = New System.Drawing.Point(123, 146)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(115, 65)
        Me.button8.TabIndex = 8
        Me.button8.Text = "8"
        Me.button8.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.Location = New System.Drawing.Point(242, 75)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(115, 65)
        Me.button6.TabIndex = 6
        Me.button6.Text = "6"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.Location = New System.Drawing.Point(123, 75)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(115, 65)
        Me.button5.TabIndex = 5
        Me.button5.Text = "5"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button7.Location = New System.Drawing.Point(5, 146)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(115, 65)
        Me.button7.TabIndex = 7
        Me.button7.Text = "7"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(242, 4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(115, 65)
        Me.button3.TabIndex = 3
        Me.button3.Text = "3"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(5, 75)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(115, 65)
        Me.button4.TabIndex = 4
        Me.button4.Text = "4"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(123, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(115, 65)
        Me.button2.TabIndex = 2
        Me.button2.Text = "2"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(115, 65)
        Me.button1.TabIndex = 1
        Me.button1.Text = "1"
        Me.button1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.buttonDivide)
        Me.FlowLayoutPanel1.Controls.Add(Me.buttonMultiply)
        Me.FlowLayoutPanel1.Controls.Add(Me.buttonSubtract)
        Me.FlowLayoutPanel1.Controls.Add(Me.buttonAdd)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(379, 160)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(178, 277)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'buttonDivide
        '
        Me.buttonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDivide.Location = New System.Drawing.Point(8, 196)
        Me.buttonDivide.Name = "buttonDivide"
        Me.buttonDivide.Size = New System.Drawing.Size(162, 68)
        Me.buttonDivide.TabIndex = 16
        Me.buttonDivide.Text = "/"
        Me.buttonDivide.UseVisualStyleBackColor = True
        '
        'buttonMultiply
        '
        Me.buttonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMultiply.Location = New System.Drawing.Point(8, 122)
        Me.buttonMultiply.Name = "buttonMultiply"
        Me.buttonMultiply.Size = New System.Drawing.Size(162, 68)
        Me.buttonMultiply.TabIndex = 15
        Me.buttonMultiply.Text = "x"
        Me.buttonMultiply.UseVisualStyleBackColor = True
        '
        'buttonSubtract
        '
        Me.buttonSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSubtract.Location = New System.Drawing.Point(8, 48)
        Me.buttonSubtract.Name = "buttonSubtract"
        Me.buttonSubtract.Size = New System.Drawing.Size(162, 68)
        Me.buttonSubtract.TabIndex = 14
        Me.buttonSubtract.Text = "-"
        Me.buttonSubtract.UseVisualStyleBackColor = True
        '
        'buttonAdd
        '
        Me.buttonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdd.Location = New System.Drawing.Point(8, 3)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(162, 39)
        Me.buttonAdd.TabIndex = 13
        Me.buttonAdd.Text = "+"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'btnClearHistory
        '
        Me.btnClearHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearHistory.Location = New System.Drawing.Point(565, 284)
        Me.btnClearHistory.Name = "btnClearHistory"
        Me.btnClearHistory.Size = New System.Drawing.Size(210, 45)
        Me.btnClearHistory.TabIndex = 17
        Me.btnClearHistory.Text = "Clear History"
        Me.btnClearHistory.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClearHistory)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.historyBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.inputBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Calculator in VB .NET"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents inputBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents historyBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents button0 As Button
    Friend WithEvents button9 As Button
    Friend WithEvents button8 As Button
    Friend WithEvents button6 As Button
    Friend WithEvents button5 As Button
    Friend WithEvents button7 As Button
    Friend WithEvents button3 As Button
    Friend WithEvents button4 As Button
    Friend WithEvents button2 As Button
    Friend WithEvents button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents buttonDivide As Button
    Friend WithEvents buttonMultiply As Button
    Friend WithEvents buttonSubtract As Button
    Friend WithEvents buttonAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents buttonDot As Button
    Friend WithEvents btnClearHistory As Button
End Class
