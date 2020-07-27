Imports System.Data.SqlClient

Public Class DBDatabase
    Dim sqlcnn As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Public Sub New()
        Dim cnnStr As String
        cnnStr = "server=DESKTOP-C6DM4DR;database=QLCHUYENBAY;Integrated security = true"
        sqlcnn = New SqlConnection(cnnStr)
    End Sub

    Public Function Execute(ByVal sqlquery As String) As DataTable
        da = New SqlDataAdapter(sqlquery, sqlcnn)
        ds = New DataSet()
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
    Public Sub ExecuteNonQuery(ByVal sqlquery As String)

        Dim sqlCM As SqlCommand
        sqlCM = New SqlCommand(sqlquery, sqlcnn)
        sqlcnn.Open()
        sqlCM.ExecuteNonQuery()
        sqlcnn.Close()
    End Sub
End Class
