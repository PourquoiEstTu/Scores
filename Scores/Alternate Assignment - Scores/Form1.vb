Public Class Form1
    'Roshaan Q., Nov. 12, 2020, A make-up program for file access and formatting; a program for getting the scores of different teams and averaging them out
    Private Sub btnGetScore_Click(sender As Object, e As EventArgs) Handles btnGetScore.Click
        Dim reader As System.IO.StreamReader
        Dim line As String
        Dim teamScores() As String 'dynamic array
        Dim stringAverage As String 'created for number to string formatting
        Dim totalPointsAverage As Double
        Dim totalLeft As Integer
        Dim totalRight As Integer

        lstScores.Items.Clear()
        lstScores.Items.Add(String.Format("{0,-10}{1,13}", "Winners", "Total Points"))
        lstScores.Items.Add(String.Format("{0, -23}", "======================="))

        Try
            reader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\scores.csv")
            Do Until reader.EndOfStream
                totalRight = 0
                totalLeft = 0 'if they aren't reset, they will make ridiculously huge numbers
                line = reader.ReadLine
                teamScores = line.Split(",")
                For x = 1 To 5 'loops through first team's scores
                    totalLeft += Val(teamScores(x))
                Next
                For x = 7 To 11 'loops through second (right) team's scores
                    totalRight += Val(teamScores(x))
                Next
                If totalLeft > totalRight Then 'if statement for deciding which team's total scores to display
                    lstScores.Items.Add(String.Format("{0,-16}{1,7}", teamScores(0), totalLeft))
                    totalPointsAverage += totalLeft 'collects values to calculate average
                Else
                    lstScores.Items.Add(String.Format("{0,-16}{1,7}", teamScores(6), totalRight))
                    totalPointsAverage += totalRight 'collects values to calculate average
                End If
            Loop
            totalPointsAverage /= 5 'final average calculation as double/number
            stringAverage = totalPointsAverage.ToString("0.00") 'string conversion
            lstScores.Items.Add(" ")
            lstScores.Items.Add(String.Format("{0,-16}", "Average Total Score:"))
            lstScores.Items.Add(String.Format("{0,-16}", stringAverage))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
