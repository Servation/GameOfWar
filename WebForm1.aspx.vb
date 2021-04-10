Public Class WebForm1
    Inherits Page
    Private Shared PlayerA(51) As Card
    Private Shared PlayerB(51) As Card
    Private Shared PlayedA As Boolean
    Private Shared PlayedB As Boolean
    Private Shared logicalA As Integer
    Private Shared logicalB As Integer
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

    Protected Function Fight() As Boolean
        Dim tempA As Integer = PlayerA(logicalA - 1).CardVal
        Dim tempB As Integer = PlayerB(logicalB - 1).CardVal
        If tempA > tempB Then
            For i As Integer = logicalA + 2 To 1 Step -1
                PlayerA(i + 1).CardVal = PlayerA(i - 1).CardVal
            Next
            PlayerA(0).CardVal = tempB
            PlayerA(1).CardVal = tempA
            logicalA += 1
            logicalB -= 1
            For i As Integer = 0 To logicalA - 1
                Debug.Write(PlayerA(i).CardRank & " ")
            Next
            Debug.WriteLine("")
            For i As Integer = 0 To logicalB - 1
                Debug.Write(PlayerB(i).CardRank & " ")
            Next
            Debug.WriteLine("")

            lblANum.Text = logicalA
            lblBNum.Text = logicalB
            PlayedA = False
            PlayedB = False
            Return logicalB >= 0
        ElseIf tempB > tempA Then
            For i As Integer = logicalB + 2 To 1 Step -1
                PlayerB(i + 1).CardVal = PlayerB(i - 1).CardVal
            Next
            PlayerB(0).CardVal = tempA
            PlayerB(1).CardVal = tempB
            logicalA -= 1
            logicalB += 1
            For i As Integer = 0 To logicalA - 1
                Debug.Write(PlayerA(i).CardRank & " ")
            Next
            Debug.WriteLine("")
            For i As Integer = 0 To logicalB - 1
                Debug.Write(PlayerB(i).CardRank & " ")
            Next
            Debug.WriteLine("")
            lblANum.Text = logicalA
            lblBNum.Text = logicalB
            PlayedA = False
            PlayedB = False
            Return logicalA >= 0
        Else
            lblANum.Text = logicalA
            lblBNum.Text = logicalB
            PlayedA = False
            PlayedB = False
            Return War(tempA, tempB)
        End If
    End Function

    Protected Function War(tA As Integer, tB As Integer) As Boolean
        If logicalA - 4 > 0 Or logicalB - 4 > 0 Then
            Dim tempA As Integer = PlayerA(logicalA - 2).CardVal
            Dim tempB As Integer = PlayerB(logicalB - 2).CardVal
            Dim tempAA As Integer = PlayerA(logicalA - 3).CardVal
            Dim tempBB As Integer = PlayerB(logicalB - 3).CardVal
            If tempA = tempB Then
                If tempAA > tempBB Then
                    For i As Integer = logicalA + 4 To 4 Step -1
                        PlayerA(i + 4).CardVal = PlayerA(i - 4).CardVal
                    Next
                    PlayerA(0).CardVal = tempB
                    PlayerA(1).CardVal = tempA
                    logicalA += 4
                    logicalB -= 4
                    Return logicalB > 0
                ElseIf tempBB > tempAA Then
                    For i As Integer = logicalB + 4 To 4 Step -1
                        PlayerB(i + 4).CardVal = PlayerB(i - 4).CardVal
                    Next
                    PlayerB(0).CardVal = tempA
                    PlayerB(1).CardVal = tempB
                    logicalA -= 4
                    logicalB += 4
                    Return logicalA > 0
                End If
            Else
                If tempA > tempB Then
                    For i As Integer = logicalA + 4 To 4 Step -1
                        PlayerA(i + 4).CardVal = PlayerA(i - 4).CardVal
                    Next
                    PlayerA(0).CardVal = tempB
                    PlayerA(1).CardVal = tempA
                    logicalA += 4
                    logicalB -= 4
                    Return logicalB > 0
                ElseIf tempB > tempA Then
                    For i As Integer = logicalB + 4 To 4 Step -1
                        PlayerB(i + 4).CardVal = PlayerB(i - 4).CardVal
                    Next
                    PlayerB(0).CardVal = tempA
                    PlayerB(1).CardVal = tempB
                    logicalA -= 4
                    logicalB += 4
                    Return logicalA > 0
                End If
            End If
            Return True
        Else
            Return False
        End If

    End Function

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
            lblAPlay.Text = PlayerA(logicalA - 1).CardRank
            If PlayedA And PlayedB Then
                Fight()
            End If
        End If
    End Sub
    Protected Sub btnPlayerB_Click(sender As Object, e As EventArgs) Handles btnPlayerB.Click
        If PlayedB = False Then
            PlayedB = True
            lblBPlay.Text = PlayerB(logicalB - 1).CardRank
            If PlayedA And PlayedB Then
                Fight()
            End If
            lblBNum.Text = logicalB
        End If
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