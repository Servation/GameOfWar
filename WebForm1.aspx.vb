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
            lblAPlay.Text += "<br>Wins"
            lblBPlay.Text += "<br>Loses"
            For i As Integer = logicalA + 1 To 1 Step -1
                PlayerA(i + 1).CardVal = PlayerA(i - 1).CardVal
            Next
            PlayerA(0).CardVal = tempB
            PlayerA(1).CardVal = tempA
            logicalA += 1
            logicalB -= 1
        ElseIf tempB > tempA Then
            lblResults.Text = PlayerA(logicalA - 1).CardRank & "  <  " & PlayerB(logicalB - 1).CardRank
            lblAPlay.Text += "<br>Loses"
            lblBPlay.Text += "<br>Wins"
            For i As Integer = logicalB + 1 To 1 Step -1
                PlayerB(i + 1).CardVal = PlayerB(i - 1).CardVal
            Next
            PlayerB(0).CardVal = tempA
            PlayerB(1).CardVal = tempB
            logicalA -= 1
            logicalB += 1
        Else
            lblResults.Text = "War"
            War(tempA, tempB)
        End If
        lblANum.Text = logicalA
        lblBNum.Text = logicalB
        PlayedA = False
        PlayedB = False
        tester()
        GameOver()
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
        If logicalA - 4 > 0 And logicalB - 4 > 0 Then
            Static tempA As Integer = PlayerA(logicalA - 2).CardVal
            Static tempB As Integer = PlayerB(logicalB - 2).CardVal
            Static tempAA As Integer = PlayerA(logicalA - 3).CardVal
            Static tempBB As Integer = PlayerB(logicalB - 3).CardVal
            Static tempAAA As Integer = PlayerA(logicalA - 4).CardVal
            Static tempBBB As Integer = PlayerB(logicalB - 4).CardVal
            If tempA = tempB Then
                lblAAPlay.Text = PlayerA(logicalA - 2).CardRank
                lblBBPlay.Text = PlayerB(logicalB - 2).CardRank
                lblAAAPlay.Text = PlayerA(logicalA - 3).CardRank
                lblBBBPlay.Text = PlayerB(logicalB - 3).CardRank
                imgAA.Width = 125
                imgAA.Visible = True
                imgAAA.Visible = True
                imgAA.ImageUrl = urlLinksA(PlayerA(logicalA - 2).CardVal)
                imgAAA.ImageUrl = urlLinksA(PlayerA(logicalA - 3).CardVal)
                imgBB.Width = 125
                imgBB.Visible = True
                imgBBB.Visible = True
                imgBB.ImageUrl = urlLinksB(PlayerB(logicalB - 2).CardVal)
                imgBBB.ImageUrl = urlLinksB(PlayerB(logicalB - 3).CardVal)
                If tempAA > tempBB Then
                    lblResults0.Text = PlayerA(logicalA - 3).CardRank & "  >  " & PlayerB(logicalB - 3).CardRank
                    lblAAAPlay.Text += Environment.NewLine & "Wins"
                    lblBBBPlay.Text += Environment.NewLine & "Loses"
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
                    lblResults0.Text = PlayerA(logicalA - 3).CardRank & "  <  " & PlayerB(logicalB - 3).CardRank
                    lblAAAPlay.Text += Environment.NewLine & "Loses"
                    lblBBBPlay.Text += Environment.NewLine & "Wins"
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
                Else
                    rotateCards()
                End If
            Else
                lblAAPlay.Text = PlayerA(logicalA - 2).CardRank
                lblBBPlay.Text = PlayerB(logicalB - 2).CardRank
                imgAA.Width = 200
                imgAA.Visible = True
                imgAA.ImageUrl = urlLinksA(PlayerA(logicalA - 2).CardVal)
                imgBB.Width = 200
                imgBB.Visible = True
                imgBB.ImageUrl = urlLinksB(PlayerB(logicalB - 2).CardVal)
                If tempA > tempB Then
                    lblResults0.Text = PlayerA(logicalA - 2).CardRank & "  >  " & PlayerB(logicalB - 2).CardRank
                    lblAAPlay.Text += Environment.NewLine & "Wins"
                    lblBBPlay.Text += Environment.NewLine & "Loses"
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
                    lblResults0.Text = PlayerA(logicalA - 2).CardRank & "  <  " & PlayerB(logicalB - 2).CardRank
                    lblAAPlay.Text += Environment.NewLine & "Loses"
                    lblBBPlay.Text += Environment.NewLine & "Wins"
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
            rotateCards()
        End If
    End Sub

    Protected Sub rotateCards()
        Static intTemp As Integer = PlayerA(logicalA - 1).CardVal
        For i As Integer = logicalA - 1 To 0 Step -1
            PlayerA(i).CardVal = PlayerA(i + 1).CardVal
        Next
        PlayerAStart()
        PlayerA(0).CardVal = intTemp
        Static intTemp1 As Integer = PlayerB(logicalB - 1).CardVal
        For n As Integer = logicalB - 1 To 0 Step -1
            PlayerB(n).CardVal = PlayerB(n + 1).CardVal
        Next
        PlayerB(0).CardVal = intTemp1
        PlayerBStart()
    End Sub

    Protected Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        lblResults.Text = ""
        logicalA = 26
        logicalB = 26
        PlayedA = False
        PlayedB = False
        btnPlayerB.Enabled = True
        btnPlayerA.Enabled = True
        Shuffle()
        lblANum.Text = logicalA
        lblBNum.Text = logicalB
        lblAPlay.Text = ""
        lblBPlay.Text = ""
        reset()
    End Sub
    Protected Sub reset()
        lblAPlay.Text = ""
        lblBPlay.Text = ""
        lblAAPlay.Text = ""
        lblBBPlay.Text = ""
        lblAAAPlay.Text = ""
        lblBBBPlay.Text = ""
        lblResults.Text = ""
        lblResults0.Text = ""
        imgA.Visible = False
        imgAA.Visible = False
        imgAAA.Visible = False
        imgB.Visible = False
        imgBB.Visible = False
        imgBBB.Visible = False
    End Sub
    Protected Sub PlayerAStart()
        reset()
        lblAPlay.Text = PlayerA(logicalA - 1).CardRank
        imgA.Visible = True
        imgA.ImageUrl = urlLinksA(PlayerA(logicalA - 1).CardVal)
        If PlayedA = False Then
            PlayedA = True
            btnPlayerA.Enabled = False
            If PlayedA And PlayedB Then
                lblBPlay.Text = PlayerB(logicalB - 1).CardRank
                imgB.Visible = True
                btnPlayerB.Enabled = True
                btnPlayerA.Enabled = True
                imgB.ImageUrl = urlLinksB(PlayerB(logicalB - 1).CardVal)
                Fight()
            End If
        End If
    End Sub
    Protected Sub btnPlayerA_Click(sender As Object, e As EventArgs) Handles btnPlayerA.Click
        PlayerAStart()
    End Sub
    Protected Sub PlayerBStart()
        reset()
        lblBPlay.Text = PlayerB(logicalB - 1).CardRank
        imgB.Visible = True
        imgB.ImageUrl = urlLinksB(PlayerB(logicalB - 1).CardVal)
        If PlayedB = False Then
            PlayedB = True
            btnPlayerB.Enabled = False
            If PlayedA And PlayedB Then
                lblAPlay.Text = PlayerA(logicalA - 1).CardRank
                imgA.Visible = True
                btnPlayerB.Enabled = True
                btnPlayerA.Enabled = True
                imgA.ImageUrl = urlLinksA(PlayerA(logicalA - 1).CardVal)
                Fight()
            End If
            lblBNum.Text = logicalB
        End If
    End Sub
    Protected Sub btnPlayerB_Click(sender As Object, e As EventArgs) Handles btnPlayerB.Click
        PlayerBStart()
    End Sub
    Protected Function GameOver() As Boolean
        If logicalB - 1 = 0 Then
            lblResults.Text = "Game Over"
            lblANum.Text = "WINNER"
            lblBNum.Text = "LOSER"
            btnPlayerB.Enabled = False
            btnPlayerA.Enabled = False
            Return False
        End If
        If logicalA - 1 = 0 Then
            lblResults.Text = "Game Over"
            lblANum.Text = "LOSER"
            lblBNum.Text = "WINNER"
            btnPlayerB.Enabled = False
            btnPlayerA.Enabled = False
            Return False
        End If
        Return True
    End Function
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