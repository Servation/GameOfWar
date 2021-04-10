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

    Protected Sub Fight()
        Static tempA As Integer = PlayerA(logicalA - 1).CardVal
        Static tempB As Integer = PlayerB(logicalB - 1).CardVal
        If tempA > tempB Then
            lblResults.Text = PlayerA(logicalA - 1).CardRank & "  >  " & PlayerB(logicalB - 1).CardRank
            For i As Integer = logicalA + 1 To 1 Step -1
                PlayerA(i + 1).CardVal = PlayerA(i - 1).CardVal
            Next
            PlayerA(0).CardVal = tempB
            PlayerA(1).CardVal = tempA
            logicalA += 1
            logicalB -= 1
            lblANum.Text = logicalA
            lblBNum.Text = logicalB
            PlayedA = False
            PlayedB = False
            tester()
        ElseIf tempB > tempA Then
            lblResults.Text = PlayerA(logicalA - 1).CardRank & "  <  " & PlayerB(logicalB - 1).CardRank
            For i As Integer = logicalB + 1 To 1 Step -1
                PlayerB(i + 1).CardVal = PlayerB(i - 1).CardVal
            Next
            PlayerB(0).CardVal = tempA
            PlayerB(1).CardVal = tempB
            logicalA -= 1
            logicalB += 1
            lblANum.Text = logicalA
            lblBNum.Text = logicalB
            PlayedA = False
            PlayedB = False
            tester()
        Else
            lblResults.Text = "War"
            War(tempA, tempB)
            lblANum.Text = logicalA
            lblBNum.Text = logicalB
            PlayedA = False
            PlayedB = False
            tester()
        End If
    End Sub

    Protected Sub tester()
        For i As Integer = 0 To logicalA - 1
            Debug.Write(PlayerA(i).CardRank & " ")
        Next
        Debug.WriteLine(" ------ " & logicalA)
        For n As Integer = 0 To logicalB - 1
            Debug.Write(PlayerB(n).CardRank & " ")
        Next
        Debug.WriteLine(" ------ " & logicalB)
        Debug.WriteLine("")
    End Sub
    Protected Sub War(tA As Integer, tB As Integer)
        If logicalA - 4 > 0 Or logicalB - 4 > 0 Then
            Static tempA As Integer = PlayerA(logicalA - 2).CardVal
            Static tempB As Integer = PlayerB(logicalB - 2).CardVal
            Static tempAA As Integer = PlayerA(logicalA - 3).CardVal
            Static tempBB As Integer = PlayerB(logicalB - 3).CardVal
            Static tempAAA As Integer = PlayerA(logicalA - 4).CardVal
            Static tempBBB As Integer = PlayerB(logicalB - 4).CardVal
            If tempA = tempB Then
                lblAAPlay.Text = PlayerA(logicalA - 2).CardVal
                lblBBPlay.Text = PlayerB(logicalB - 2).CardVal
                lblAAAPlay.Text = PlayerA(logicalA - 3).CardVal
                lblBBBPlay.Text = PlayerB(logicalB - 3).CardVal
                If tempAA > tempBB Then
                    For i As Integer = logicalA + 7 To 5 Step -1
                        PlayerA(i + 3).CardVal = PlayerA(i - 5).CardVal
                    Next
                    PlayerA(0).CardVal = tA
                    PlayerA(1).CardVal = tB
                    PlayerA(2).CardVal = tempB
                    PlayerA(3).CardVal = tempA
                    PlayerA(4).CardVal = tempBB
                    PlayerA(5).CardVal = tempAA
                    PlayerA(6).CardVal = tempBBB
                    PlayerA(7).CardVal = tempAAA
                    logicalA += 4
                    logicalB -= 4
                ElseIf tempBB > tempAA Then
                    For i As Integer = logicalB + 7 To 5 Step -1
                        PlayerB(i + 3).CardVal = PlayerB(i - 5).CardVal
                    Next
                    PlayerB(0).CardVal = tA
                    PlayerB(1).CardVal = tB
                    PlayerB(2).CardVal = tempB
                    PlayerB(3).CardVal = tempA
                    PlayerB(4).CardVal = tempBB
                    PlayerB(5).CardVal = tempAA
                    PlayerB(6).CardVal = tempBBB
                    PlayerB(7).CardVal = tempAAA
                    logicalA -= 4
                    logicalB += 4
                End If
            Else
                lblAAPlay.Text = PlayerA(logicalA - 2).CardVal
                lblBBPlay.Text = PlayerB(logicalB - 2).CardVal
                If tempA > tempB Then
                    For i As Integer = logicalA + 7 To 5 Step -1
                        PlayerA(i + 3).CardVal = PlayerA(i - 5).CardVal
                    Next
                    PlayerA(0).CardVal = tA
                    PlayerA(1).CardVal = tB
                    PlayerA(2).CardVal = tempB
                    PlayerA(3).CardVal = tempA
                    PlayerA(4).CardVal = tempBB
                    PlayerA(5).CardVal = tempAA
                    PlayerA(6).CardVal = tempBBB
                    PlayerA(7).CardVal = tempAAA
                    logicalA += 4
                    logicalB -= 4
                ElseIf tempB > tempA Then
                    For i As Integer = logicalB + 7 To 5 Step -1
                        PlayerB(i + 3).CardVal = PlayerB(i - 5).CardVal
                    Next
                    PlayerB(0).CardVal = tA
                    PlayerB(1).CardVal = tB
                    PlayerB(2).CardVal = tempB
                    PlayerB(3).CardVal = tempA
                    PlayerB(4).CardVal = tempBB
                    PlayerB(5).CardVal = tempAA
                    PlayerB(6).CardVal = tempBBB
                    PlayerB(7).CardVal = tempAAA
                    logicalA -= 4
                    logicalB += 4
                End If
            End If
        Else
        End If

    End Sub

    Protected Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        lblResults.Text = ""
        logicalA = 26
        logicalB = 26
        PlayedA = False
        PlayedB = False
        Shuffle()
        lblANum.Text = logicalA
        lblBNum.Text = logicalB
        lblAPlay.Text = ""
        lblBPlay.Text = ""

        lblAAPlay.Text = ""
        lblBBPlay.Text = ""
        lblAAAPlay.Text = ""
        lblBBBPlay.Text = ""
    End Sub
    Protected Sub btnPlayerA_Click(sender As Object, e As EventArgs) Handles btnPlayerA.Click
        lblAAPlay.Text = ""
        lblBBPlay.Text = ""
        lblAAAPlay.Text = ""
        lblBBBPlay.Text = ""
        lblResults.Text = ""
        If PlayedA = False Then
            PlayedA = True
            lblAPlay.Text = PlayerA(logicalA - 1).CardRank
            If PlayedA And PlayedB Then
                Fight()
            End If
        End If
    End Sub
    Protected Sub btnPlayerB_Click(sender As Object, e As EventArgs) Handles btnPlayerB.Click
        lblAAPlay.Text = ""
        lblBBPlay.Text = ""
        lblAAAPlay.Text = ""
        lblBBBPlay.Text = ""
        lblResults.Text = ""
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