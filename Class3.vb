Public Class Class3
    Private c3Boool As Boolean
    Public Property c3B() As Boolean
        Get
            Return c3Boool
        End Get
        Set(ByVal value As Boolean)
            c3Boool = value
        End Set
    End Property

    Private c3Datatable As DataTable
    Public Property c3Dt() As DataTable
        Get
            Return c3Datatable
        End Get
        Set(ByVal value As DataTable)
            c3Datatable = value
        End Set
    End Property


End Class
