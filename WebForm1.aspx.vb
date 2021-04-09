Public Class WebForm1
    Inherits System.Web.UI.Page
    Private PlayerA(51) As Card
    Private logicPA As Integer = 26
    Private PlayedA = False
    Private PlayerB(51) As Card
    Private logicPB As Integer = 26
    Private PlayedB = False
    Private shuffed = False

    Private Sub Shuffle()
        Dim randGen As New Random
        Dim intNumbers() As Integer = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}
        Dim intCounter As Integer = 51
        Dim intCountA As Integer = 25
        Dim intCountB As Integer = 25

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

    Private Sub Fight()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For i As Integer = 0 To 51
            PlayerA(i) = New Card
            PlayerB(i) = New Card
        Next
        If Not shuffed Then
            Shuffle()
            shuffed = True
        End If

    End Sub

    Protected Sub btnPlayerA_Click(sender As Object, e As EventArgs) Handles btnPlayerA.Click
        If PlayedA = False Then
            PlayedA = True
            lblAPlay.Text = PlayerA(logicPA - 1).CardRank
            btnPlayerB
            If PlayedA And PlayedB Then
                Fight()
            End If
        End If
    End Sub

    Protected Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click

        btnPlayerA.Enabled = True
        btnPlayerB.Enabled = True
        For i As Integer = 0 To logicPA - 1
            Debug.Write(PlayerA(i).CardRank & ", ")
            Debug.WriteLine(PlayerB(i).CardRank)
        Next
    End Sub
End Class