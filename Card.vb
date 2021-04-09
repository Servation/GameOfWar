Public Class Card
    Private intVal As Integer
    Private strVal As String
    Private strLoc As String
    Public Property CardVal As Integer
        Get
            Return intVal
        End Get
        Set(value As Integer)
            Select Case value
                Case 2 To 10
                    intVal = value
                    strVal = value.ToString
                Case 11
                    intVal = value
                    strVal = "J"
                Case 12
                    intVal = value
                    strVal = "Q"
                Case 13
                    intVal = value
                    strVal = "K"
                Case 14
                    intVal = value
                    strVal = "A"
            End Select
        End Set
    End Property
    Public ReadOnly Property CardRank As String
        Get
            Return strVal
        End Get
    End Property
End Class
