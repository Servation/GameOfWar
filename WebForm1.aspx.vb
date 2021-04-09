Public Class WebForm1
    Inherits Page
    Public PlayerA(51) As Card
    Public PlayerB(51) As Card
    Public PlayedA As Boolean
    Public PlayedB As Boolean
    Public logicalA As Integer
    Public logicalB As Integer
    Protected Sub Shuffle()
        Dim randGen As New Random
        Dim intNumbers() As Integer = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}
        Dim intCounter As Integer = 51
        Dim intCountA As Integer = 25
        Dim intCountB As Integer = 25
        For i As Integer = 0 To 51
            PlayerA(i) = New Card()
            PlayerB(i) = New Card()
        Next
        Do While intCounter > -1
            Dim intNum As Integer = randGen.Next(0, intCounter + 1)
            If intCounter Mod 2 = 0 Then
                PlayerA(intCountA).CardVal = intNumbers(intNum)
                intCountA -= 1
            Else
                PlayerB(intCountB).CardVal = intNumbers(intNum)
                intCountB -= 1
            End If
            For i As Integer = intNum To intCounter
                If i = intCounter Then
                    intNumbers(i) = 0
                Else
                    intNumbers(i) = intNumbers(i + 1)
                End If

            Next
            intCounter -= 1
        Loop
    End Sub

    Protected Sub Fight()
        If PlayerA(logicalA).CardVal > PlayerB(logicalB).CardVal Then
            For i As Integer = logicalA - 1 To 0
                If i = 0 Then
                    PlayerA(0).CardVal = PlayerB(logicalB).CardVal
                End If
            Next i
            logicalA += 1
            logicalB -= 1
        ElseIf PlayerA(logicalA).CardVal < PlayerB(logicalB).CardVal Then
            For i As Integer = logicalB - 1 To 0
                If i = 0 Then
                    PlayerB(0).CardVal = PlayerA(logicalA).CardVal
                End If
            Next i
            logicalA -= 1
            logicalB += 1
        End If
        lblANum.Text = logicalA
        lblBNum.Text = logicalB
        PlayedA = False
        PlayedB = False
    End Sub

    Protected Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click

        logicalA = 26
        logicalB = 26
        PlayedA = False
        PlayedB = False
        Shuffle()
        lblANum.Text = logicalA
        lblBNum.Text = logicalB
    End Sub
    Protected Sub btnPlayerA_Click(sender As Object, e As EventArgs) Handles btnPlayerA.Click
        If PlayedA = False Then
            PlayedA = True
            lblAPlay.Text = PlayerB(logicalA).CardRank
            If PlayedA And PlayedB Then
                Fight()
            End If
        End If
    End Sub
    Protected Sub btnPlayerB_Click(sender As Object, e As EventArgs) Handles btnPlayerB.Click

        If PlayedB = False Then
            PlayedB = True
            lblBPlay.Text = PlayerB(logicalB).CardRank
            If PlayedA And PlayedB Then
                Fight()
            End If
        End If
        Debug.WriteLine(logicalA)
    End Sub

    Protected Sub WebForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            logicalA = 26
            logicalB = 26
            PlayedA = False
            PlayedB = False
            Shuffle()
            lblANum.Text = logicalA
            lblBNum.Text = logicalB

        End If

    End Sub

End Class