'Jason Permann
'Spring 2025
'RCET2265
'Math Contest
'https://github.com/JaceFoxman/MathContest.git

Option Compare Text
Option Strict On
Option Explicit On

Public Class MathContestForm
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function UserInput() As Boolean
        Dim checkPassed As Boolean = True
        Dim errormessage As String
        If IsNumeric(AgeTextBox.Text) = False Then
            checkPassed = False
            AgeTextBox.Focus()
            errormessage &= "Enter Age between 7-11." & vbNewLine
        End If

        If IsNumeric(GradeTextBox.Text) = False Then
            checkPassed = False
            GradeTextBox.Focus()
            errormessage &= "Enter Grade between 1-4." & vbNewLine
        End If

        If IsNumeric(StudentAnswerTextBox.Text) = False Then
            checkPassed = False
            StudentAnswerTextBox.Focus()
            errormessage &= "Please enter the students answer." & vbNewLine
        End If

        If NameTextBox.Text = "" Then
            checkPassed = False
            NameTextBox.Focus()
            errormessage &= "Please enter the students Name."
        End If

        Return checkPassed
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
