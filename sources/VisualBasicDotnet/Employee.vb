Namespace VisualBasicDotnet
    Public Class Employee
        Public Property Id() As Integer
        Public Property LastName() As String
        Public Property FirstName() As String
        Public Property MiddleName() As String
        Public Property Salary() As Decimal
        Public ReadOnly Property FullName() As String
            Get
                If String.IsNullOrEmpty(Me.MiddleName) Then
                    Return $"{Me.FirstName} {Me.LastName}"
                Else
                    Return $"{Me.FirstName} {Me.MiddleName} {Me.LastName}"
                End If
            End Get
        End Property
    End Class
End Namespace
