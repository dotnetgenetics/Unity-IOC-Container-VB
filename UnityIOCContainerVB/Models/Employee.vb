Public Class Employee

    Private m_FirstName As String
    Public Property FirstName() As String
        Get
            Return m_FirstName
        End Get
        Set(value As String)
            m_FirstName = value
        End Set
    End Property

    Private m_LastName As String
    Public Property LastName() As String
        Get
            Return m_LastName
        End Get
        Set(value As String)
            m_LastName = value
        End Set
    End Property

    Private m_EmailAddress As String
    Public Property EmailAddress() As String
        Get
            Return m_EmailAddress
        End Get
        Set(value As String)
            m_EmailAddress = value
        End Set
    End Property
End Class