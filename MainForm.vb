
Option Strict On

Public Class MainForm

    Private intNumGuess As Integer
    Private intCount As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application
        Me.Close()

    End Sub

    Private Sub btnGuessNum_Click(sender As Object, e As EventArgs) Handles btnGuessNum.Click
        Dim randGen As New Random
        Dim intNum As Integer
        Dim intNumGuess As Integer
        Dim strPrompt As String = "Guess A Number between 1-50:"
        Dim strTitle As String = "Guess Number"
        Dim strPromptWin As String = "You guessed right!"
        Dim strPromptLow As String = "Number is Greater!"
        Dim strPromptHigh As String = "Number is Lower!"


        ' assign random number from 1-50
        intNum = randGen.Next(1, 51)
        intNumGuess = CInt(InputBox(strPrompt, strTitle))
        ' Loop through the game 10 times
        For intCount As Integer = 0 To 9 Step 1
            intNumGuess = CInt(InputBox(strPrompt, strTitle))
            If intNumGuess = intNum Then
                InputBox(strPromptWin, strTitle)
                Exit Sub
            ElseIf intNumGuess > intNum Then
                InputBox(strPromptHigh, CStr(intCount))

            ElseIf intNumGuess < intNum Then
                InputBox(strPromptLow, CStr(intCount))

            End If


        Next intCount
        ' Show user the correct number after failed attempts
        MessageBox.Show("The correct number was " & intNum)



    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        MessageBox.Show("Press Guess if you'd like to play a game...")
    End Sub

End Class
