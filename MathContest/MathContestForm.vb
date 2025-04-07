'Jason Permann
'Spring 2025
'RCET2265
'Math Contest
'https://github.com/JaceFoxman/MathContest.git

Option Compare Text
Option Strict On
Option Explicit On

Public Class MathContestForm
    ''' <summary>
    ''' On first load set these pararameters.
    ''' </summary>
    Sub SetDefaults()
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        StudentAnswerTextBox.Enabled = False
        AddRadioButton.Checked = True
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
        ClearButton.Enabled = True
        SummeryButton.Enabled = False
        SubmitButton.Enabled = False
    End Sub
    ''' <summary>
    ''' keeps track of correct answers and total attempts then displays
    ''' </summary>
    Sub Summary()
        Dim _Summary As String
        _Summary = $"{NameTextBox.Text} got {ScoreCounter(, True)} out of {AttemptCounter(, True)}"
        MsgBox(_Summary, MsgBoxStyle.Information, "Total Score")
    End Sub
    ''' <summary>
    ''' Checks to see if student answer is correct or incoorect then displays meesage box depending on outcome
    ''' </summary>
    Sub StudentAnswer()
        Dim message As String
        Dim errormessage As String
        If StudentAnswerTextBox.Enabled = True Then
            If IsNumeric(StudentAnswerTextBox.Text) = False Then
                errormessage = "Must provide numeric value"
                MsgBox(errormessage, MsgBoxStyle.Critical, "Error")
            ElseIf IsNumeric(AgeTextBox.Text) = True Then
                If CInt(StudentAnswerTextBox.Text) = MathProblem() Then
                    message = "Your answer was correct!"
                    MsgBox(message, MsgBoxStyle.Exclamation, "Congradulations!")
                ElseIf CInt(StudentAnswerTextBox.Text) <> MathProblem() Then

                    message = $"Sorry the correct answer is {MathProblem()}"
                    MsgBox(message, MsgBoxStyle.Question, "Better Luck Next Time.")
                End If
            End If
            StudentAnswerTextBox.Focus()
        End If
    End Sub
    ''' <summary>
    ''' Keeps track of current score witout running submit code
    ''' </summary>
    ''' <param name="clear"></param>
    ''' <param name="CurrentScore"></param>
    ''' <returns></returns>
    Function ScoreCounter(Optional clear As Boolean = False, Optional CurrentScore As Boolean = False) As Integer
        Static score As Integer
        Dim errormessage As String
        If StudentAnswerTextBox.Enabled = True Then
            If IsNumeric(StudentAnswerTextBox.Text) = False Then
                StudentAnswerTextBox.Focus()
                errormessage = "Must provide numeric value"
                MsgBox(errormessage, MsgBoxStyle.Critical, "Error")
            ElseIf IsNumeric(AgeTextBox.Text) = True Then
                If clear = False And CurrentScore = False Then
                    If CInt(StudentAnswerTextBox.Text) = MathProblem() Then
                        score += 1
                    ElseIf CInt(StudentAnswerTextBox.Text) <> MathProblem() Then
                        score += 0
                    End If
                ElseIf clear = True Then
                    score = 0
                End If
                Return score
            End If
        End If
    End Function
    ''' <summary>
    ''' Keeps track of current attempts without running submit code
    ''' </summary>
    ''' <param name="clear"></param>
    ''' <param name="CurrentAttempt"></param>
    ''' <returns></returns>
    Function AttemptCounter(Optional clear As Boolean = False, Optional CurrentAttempt As Boolean = False) As Integer
        Static attempts As Integer
        Dim errormessage As String

        If StudentAnswerTextBox.Enabled = True Then
            If IsNumeric(StudentAnswerTextBox.Text) = False Then
                StudentAnswerTextBox.Focus()
                errormessage = "Must provide numeric value"
                MsgBox(errormessage, MsgBoxStyle.Critical, "Error")
            ElseIf IsNumeric(AgeTextBox.Text) = True Then
                If clear = False And CurrentAttempt = False Then
                    If CInt(StudentAnswerTextBox.Text) = MathProblem() Then
                        attempts += 1
                    ElseIf CInt(StudentAnswerTextBox.Text) <> MathProblem() Then
                        attempts += 1
                    End If
                ElseIf clear = True Then
                    attempts = 0
                End If
                Return attempts
            End If
        End If
    End Function
    ''' <summary>
    ''' Checks user input to make sure values are correct
    ''' </summary>
    ''' <returns></returns>
    Function UserInput() As Boolean
        Dim checkPassed As Boolean = True
        Dim errormessage As String
        If IsNumeric(AgeTextBox.Text) = False Then
            checkPassed = False
            AgeTextBox.Focus()
            errormessage &= "Student must be between the ages of 7-11 to compete." & vbNewLine
        ElseIf CInt(AgeTextBox.Text) < 7 Or CInt(AgeTextBox.Text) > 11 Then
            checkPassed = False
            AgeTextBox.Focus()
            errormessage &= "Student must be between the ages of 7-11 to compete." & vbNewLine
        End If

        If IsNumeric(GradeTextBox.Text) = False Then
            checkPassed = False
            GradeTextBox.Focus()
            errormessage &= "Student must be in between grade 1-4 to compete." & vbNewLine

        ElseIf CInt(GradeTextBox.Text) < 1 Or CInt(GradeTextBox.Text) > 4 Then
            checkPassed = False
            GradeTextBox.Focus()
            errormessage &= "Student must be in between grade 1-4 to compete." & vbNewLine
        End If

        If NameTextBox.Text = "" Then
            checkPassed = False
            NameTextBox.Focus()
            errormessage &= "Please enter the student's Name."
        End If

        If Not checkPassed Then
            MsgBox(errormessage, MsgBoxStyle.Critical, "Student not eligible to compete")
        End If
        Return checkPassed
    End Function
    ''' <summary>
    ''' Runs math function with both RNG numbers
    ''' </summary>
    ''' <returns></returns>
    Function MathProblem() As Integer
        Dim answer As Integer
        If AddRadioButton.Checked = True Then
            answer = Add()
        ElseIf SubtractRadioButton.Checked = True Then
            answer = Subtract()
        ElseIf MultiplyRadioButton.Checked = True Then
            answer = Multiply()
        ElseIf DivideRadioButton.Checked = True Then
            answer = Divide()
        End If
        Return answer
    End Function
    'Math Operators__________________________________________________________________________
    Function Add() As Integer
        Dim sum As Integer
        Dim number1 As Integer
        Dim number2 As Integer

        number1 = CInt(FirstNumberTextBox.Text)
        number2 = CInt(SecondNumberTextBox.Text)
        sum = (number1 + number2)

        Return sum
    End Function
    Function Subtract() As Integer
        Dim difference As Integer
        Dim number1 As Integer
        Dim number2 As Integer

        number1 = CInt(FirstNumberTextBox.Text)
        number2 = CInt(SecondNumberTextBox.Text)
        difference = (number1 - number2)

        Return difference
    End Function
    Function Multiply() As Integer
        Dim product As Integer
        Dim number1 As Integer
        Dim number2 As Integer

        number1 = CInt(FirstNumberTextBox.Text)
        number2 = CInt(SecondNumberTextBox.Text)
        product = (number1 * number2)

        Return product
    End Function
    Function Divide() As Integer
        Dim quotient As Integer
        Dim number1 As Integer
        Dim number2 As Integer

        number1 = CInt(FirstNumberTextBox.Text)
        number2 = CInt(SecondNumberTextBox.Text)
        quotient = (number1 \ number2)


        Return quotient
    End Function
    ''' <summary>
    ''' Generates random number
    ''' </summary>
    ''' <param name="min"></param>
    ''' <param name="max"></param>
    ''' <returns></returns>
    Function RNG(min As Integer, max As Integer) As Integer
        Dim value As Single
        Randomize()
        value = Rnd()
        value *= max - min
        value += min
        Return CInt(Math.Ceiling(value))
    End Function

    'Event Handelers___________________________________________________________________________
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If UserInput() = True Then
            StudentAnswer()
            AttemptCounter()
            ScoreCounter()
            SummeryButton.Enabled = True
            FirstNumberTextBox.Text = $"{(RNG(1, 20))}"
            SecondNumberTextBox.Text = $"{(RNG(1, 20))}"
            StudentAnswerTextBox.Enabled = True
            AddRadioButton.Enabled = True
            SubtractRadioButton.Enabled = True
            MultiplyRadioButton.Enabled = True
            DivideRadioButton.Enabled = True
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        ScoreCounter(True)
        AttemptCounter(True)
        FirstNumberTextBox.Text = $"{(RNG(1, 20))}"
        SecondNumberTextBox.Text = $"{(RNG(1, 20))}"

    End Sub
    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        Summary()
    End Sub
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    'Radio Button Swapping_____________________________________________________________________
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        If StudentAnswerTextBox.Enabled = True Then
            FirstNumberTextBox.Text = $"{(RNG(1, 20))}"
            SecondNumberTextBox.Text = $"{(RNG(1, 20))}"
        ElseIf StudentAnswerTextBox.Enabled = False Then
        End If
    End Sub
    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        FirstNumberTextBox.Text = $"{(RNG(1, 20))}"
        SecondNumberTextBox.Text = $"{(RNG(1, 20))}"
    End Sub
    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        FirstNumberTextBox.Text = $"{(RNG(1, 20))}"
        SecondNumberTextBox.Text = $"{(RNG(1, 20))}"
    End Sub
    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        FirstNumberTextBox.Text = $"{(RNG(1, 20))}"
        SecondNumberTextBox.Text = $"{(RNG(1, 20))}"
    End Sub
    ''' <summary>
    ''' initializes submit button when text is added
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        SubmitButton.Enabled = True
    End Sub
End Class