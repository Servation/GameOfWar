Public Class Card
    Private intVal As Integer
    Private strVal As String
    Public Property CardVal As Integer
        Get
            Return intVal
        End Get
        Set(value As Integer)
            intVal = value
            Select Case value
                Case 2 To 10
                    strVal = value.ToString
                Case 11
                    strVal = "J"
                Case 12
                    strVal = "Q"
                Case 13
                    strVal = "K"
                Case 14
                    strVal = "A"
            End Select
        End Set
    End Property
    Public ReadOnly Property CardRank As String
        Get
            Return strVal
        End Get
    End Property

    Public Sub New()
        CardVal = 1
    End Sub
End Class
