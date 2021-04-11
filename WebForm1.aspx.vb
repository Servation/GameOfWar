Public Class WebForm1
    Inherits Page
    Private Shared PlayerA(57) As Card
    Private Shared PlayerB(57) As Card
    Private Shared PlayedA As Boolean
    Private Shared PlayedB As Boolean
    Private Shared logicalA As Integer
    Private Shared logicalB As Integer
    Private urlLinksA() As String = {"", "", "https://upload.wikimedia.org/wikipedia/en/0/0f/Wands02.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/f/ff/Wands03.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/a/a4/Wands04.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/9/9d/Wands05.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/3/3b/Wands06.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/e/e4/Wands07.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/6/6b/Wands08.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/e/e7/Wands09.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/0/0b/Wands10.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/1/16/Wands12.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/0/0d/Wands13.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/c/ce/Wands14.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/1/11/Wands01.jpg"}
    Private urlLinksB() As String = {"", "", "https://upload.wikimedia.org/wikipedia/en/9/9e/Swords02.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/0/02/Swords03.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/b/bf/Swords04.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/2/23/Swords05.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/2/29/Swords06.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/3/34/Swords07.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/a/a7/Swords08.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/2/2f/Swords09.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/d/d4/Swords10.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/b/b0/Swords12.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/d/d4/Swords13.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/3/33/Swords14.jpg",
                                            "https://upload.wikimedia.org/wikipedia/en/1/1a/Swords01.jpg"}
    Protected Sub Shuffle()
        Dim randGen As New Random
        Dim intNumbers() As Integer = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}
        Dim intCounter As Integer = 51
        Dim intCountA As Integer = 25
        Dim intCountB As Integer = 25
        For i As Integer = 0 To 57
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
            Debug.Write(PlayerA(i).CardRank & " | ")
        Next
        Debug.WriteLine(" ------ " & logicalA)
        For n As Integer = 0 To logicalB - 1
            Debug.Write(PlayerB(n).CardRank & " | ")
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
                imgA.Width = 100
                imgAA.Width = 100
                imgAA.Visible = True
                imgAAA.Visible = True
                imgAA.ImageUrl = urlLinksA(PlayerA(logicalA - 2).CardVal)
                imgAAA.ImageUrl = urlLinksA(PlayerA(logicalA - 3).CardVal)
                imgB.Width = 100
                imgBB.Width = 100
                imgBB.Visible = True
                imgAAA.Visible = True
                imgBB.ImageUrl = urlLinksB(PlayerB(logicalB - 2).CardVal)
                imgBBB.ImageUrl = urlLinksB(PlayerB(logicalB - 3).CardVal)
                If tempAA > tempBB Then
                    For i As Integer = logicalA + 7 To 8 Step -1
                        PlayerA(i).CardVal = PlayerA(i - 8).CardVal
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
                    For i As Integer = logicalB + 7 To 8 Step -1
                        PlayerB(i).CardVal = PlayerB(i - 8).CardVal
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
                imgA.Width = 150
                imgAA.Width = 150
                imgAA.Visible = True
                imgAA.ImageUrl = urlLinksA(PlayerA(logicalA - 2).CardVal)
                imgB.Width = 150
                imgBB.Width = 150
                imgBB.Visible = True
                imgBB.ImageUrl = urlLinksB(PlayerB(logicalB - 2).CardVal)
                If tempA > tempB Then
                    For i As Integer = logicalA + 7 To 8 Step -1
                        PlayerA(i).CardVal = PlayerA(i - 8).CardVal
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
                    For i As Integer = logicalB + 7 To 8 Step -1
                        PlayerB(i).CardVal = PlayerB(i - 8).CardVal
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
        btnPlayerB.Enabled = True
        btnPlayerA.Enabled = True
        imgA.Width = 300
        imgAA.Visible = False
        imgAAA.Visible = False
        imgB.Width = 300
        imgBB.Visible = False
        imgBBB.Visible = False
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
        imgA.Width = 300
        imgAA.Visible = False
        imgAAA.Visible = False
        If logicalA - 1 >= 0 Then
            If PlayedA = False Then
                PlayedA = True
                lblAPlay.Text = PlayerA(logicalA - 1).CardRank
                imgA.ImageUrl = urlLinksA(PlayerA(logicalA - 1).CardVal)
                If PlayedA And PlayedB Then
                    Fight()
                End If
            End If
        Else
            lblResults.Text = "Game Over"
            lblAPlay.Text = "Lost"
            lblBPlay.Text = "Won"
            btnPlayerB.Enabled = False
            btnPlayerA.Enabled = False
        End If

    End Sub
    Protected Sub btnPlayerB_Click(sender As Object, e As EventArgs) Handles btnPlayerB.Click
        lblAAPlay.Text = ""
        lblBBPlay.Text = ""
        lblAAAPlay.Text = ""
        lblBBBPlay.Text = ""
        lblResults.Text = ""
        imgB.Width = 300
        imgBB.Visible = False
        imgBBB.Visible = False
        If logicalB - 1 >= 0 Then
            If PlayedB = False Then
                PlayedB = True
                lblBPlay.Text = PlayerB(logicalB - 1).CardRank
                imgB.ImageUrl = urlLinksB(PlayerB(logicalB - 1).CardVal)
                If PlayedA And PlayedB Then
                    Fight()
                End If
                lblBNum.Text = logicalB
            End If
        Else
            lblResults.Text = "Game Over"
            lblAPlay.Text = "Won"
            lblBPlay.Text = "Lost"
            btnPlayerB.Enabled = False
            btnPlayerA.Enabled = False
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
            tester()
        End If
    End Sub

End Class