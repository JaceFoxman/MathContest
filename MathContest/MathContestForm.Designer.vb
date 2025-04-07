<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StudentInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentMathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SubmitButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClearButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SummeryButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExitButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddRadioButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SubtractRadioButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MultiplyRadioToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DivideRadioButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentTextBoxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SecondNumberTextBoxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FirstNumberTextBoxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NameTextBoxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AgeTextBoxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GradeTextBoxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentInformationGroupBox.SuspendLayout()
        Me.CurrentMathProblemGroupBox.SuspendLayout()
        Me.MathProblemTypeGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInformationGroupBox
        '
        Me.StudentInformationGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInformationGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInformationGroupBox.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.StudentInformationGroupBox.Location = New System.Drawing.Point(10, 16)
        Me.StudentInformationGroupBox.Name = "StudentInformationGroupBox"
        Me.StudentInformationGroupBox.Size = New System.Drawing.Size(533, 100)
        Me.StudentInformationGroupBox.TabIndex = 0
        Me.StudentInformationGroupBox.TabStop = False
        Me.StudentInformationGroupBox.Text = "Student Information"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.GradeLabel.Location = New System.Drawing.Point(434, 36)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(77, 28)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.AgeLabel.Location = New System.Drawing.Point(342, 36)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(51, 28)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.NameLabel.Location = New System.Drawing.Point(6, 28)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(64, 28)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(439, 59)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(72, 31)
        Me.GradeTextBox.TabIndex = 2
        Me.GradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GradeTextBoxToolTip.SetToolTip(Me.GradeTextBox, "Enter Students Grade level here.")
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(347, 59)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(43, 31)
        Me.AgeTextBox.TabIndex = 1
        Me.AgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AgeTextBoxToolTip.SetToolTip(Me.AgeTextBox, "Enter Students Age Here")
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 59)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(252, 31)
        Me.NameTextBox.TabIndex = 0
        Me.NameTextBoxToolTip.SetToolTip(Me.NameTextBox, "Enter Students Name here.")
        '
        'CurrentMathProblemGroupBox
        '
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.CurrentMathProblemGroupBox.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.CurrentMathProblemGroupBox.Location = New System.Drawing.Point(10, 146)
        Me.CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        Me.CurrentMathProblemGroupBox.Size = New System.Drawing.Size(279, 292)
        Me.CurrentMathProblemGroupBox.TabIndex = 1
        Me.CurrentMathProblemGroupBox.TabStop = False
        Me.CurrentMathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 207)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(194, 28)
        Me.StudentAnswerLabel.TabIndex = 5
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.SecondNumberLabel.Location = New System.Drawing.Point(6, 129)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(142, 28)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.FirstNumberLabel.Location = New System.Drawing.Point(6, 41)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(142, 28)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(6, 238)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(252, 31)
        Me.StudentAnswerTextBox.TabIndex = 2
        Me.StudentTextBoxToolTip.SetToolTip(Me.StudentAnswerTextBox, "Enter Student answer here")
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Enabled = False
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(6, 160)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(252, 31)
        Me.SecondNumberTextBox.TabIndex = 1
        Me.SecondNumberTextBoxToolTip.SetToolTip(Me.SecondNumberTextBox, "This number is used last in math operation.")
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Enabled = False
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(6, 72)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(252, 31)
        Me.FirstNumberTextBox.TabIndex = 0
        Me.FirstNumberTextBoxToolTip.SetToolTip(Me.FirstNumberTextBox, "This number is used first in math operation")
        '
        'MathProblemTypeGroupBox
        '
        Me.MathProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathProblemTypeGroupBox.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.MathProblemTypeGroupBox.Location = New System.Drawing.Point(318, 146)
        Me.MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        Me.MathProblemTypeGroupBox.Size = New System.Drawing.Size(225, 292)
        Me.MathProblemTypeGroupBox.TabIndex = 2
        Me.MathProblemTypeGroupBox.TabStop = False
        Me.MathProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DivideRadioButton.Location = New System.Drawing.Point(6, 232)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(115, 32)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButtonToolTip.SetToolTip(Me.DivideRadioButton, "Math function set to produce the quotient of 1st Number and 2nd Number")
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(6, 179)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(141, 32)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioToolTip.SetToolTip(Me.MultiplyRadioButton, "Math function set to produce the product of 1st Number and 2nd Number")
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.SubtractRadioButton.Location = New System.Drawing.Point(6, 125)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(141, 32)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButtonToolTip.SetToolTip(Me.SubtractRadioButton, "Math function set to produce the difference of 1st Number and 2nd Number")
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRadioButton.Location = New System.Drawing.Point(6, 72)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(76, 32)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButtonToolTip.SetToolTip(Me.AddRadioButton, "Math function set to produce the sum of 1st Number and 2nd Number")
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.SummeryButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(562, 16)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(226, 422)
        Me.ButtonGroupBox.TabIndex = 3
        Me.ButtonGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ExitButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.ExitButton.Location = New System.Drawing.Point(6, 309)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(214, 71)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SummeryButton
        '
        Me.SummeryButton.BackColor = System.Drawing.Color.LemonChiffon
        Me.SummeryButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.SummeryButton.Location = New System.Drawing.Point(6, 216)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(214, 71)
        Me.SummeryButton.TabIndex = 2
        Me.SummeryButton.Text = "&Summery"
        Me.SummeryButtonToolTip.SetToolTip(Me.SummeryButton, "Shows how many questions the student has gotten correct")
        Me.SummeryButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClearButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.ClearButton.Location = New System.Drawing.Point(6, 126)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(214, 73)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButtonToolTip.SetToolTip(Me.ClearButton, "Clears all text fields.")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.RosyBrown
        Me.SubmitButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.SubmitButton.Location = New System.Drawing.Point(6, 36)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(214, 73)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButtonToolTip.SetToolTip(Me.SubmitButton, "Runs program to see if student's answer is correct.")
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.MathProblemTypeGroupBox)
        Me.Controls.Add(Me.CurrentMathProblemGroupBox)
        Me.Controls.Add(Me.StudentInformationGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.StudentInformationGroupBox.ResumeLayout(False)
        Me.StudentInformationGroupBox.PerformLayout()
        Me.CurrentMathProblemGroupBox.ResumeLayout(False)
        Me.CurrentMathProblemGroupBox.PerformLayout()
        Me.MathProblemTypeGroupBox.ResumeLayout(False)
        Me.MathProblemTypeGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInformationGroupBox As GroupBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents SubmitButtonToolTip As ToolTip
    Friend WithEvents ClearButtonToolTip As ToolTip
    Friend WithEvents SummeryButtonToolTip As ToolTip
    Friend WithEvents ExitButtonToolTip As ToolTip
    Friend WithEvents AddRadioButtonToolTip As ToolTip
    Friend WithEvents SubtractRadioButtonToolTip As ToolTip
    Friend WithEvents MultiplyRadioToolTip As ToolTip
    Friend WithEvents DivideRadioButtonToolTip As ToolTip
    Friend WithEvents StudentTextBoxToolTip As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SecondNumberTextBoxToolTip As ToolTip
    Friend WithEvents GradeTextBoxToolTip As ToolTip
    Friend WithEvents AgeTextBoxToolTip As ToolTip
    Friend WithEvents NameTextBoxToolTip As ToolTip
    Friend WithEvents FirstNumberTextBoxToolTip As ToolTip
End Class
