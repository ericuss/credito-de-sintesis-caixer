Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class OLEDBCON
    Private connectionString As String = loadConnectionString()

    Public Function ObtenerTablaVacia(ByVal nTable As String) As DataSet
        Dim dtaset As DataSet
        Try

            Dim connection As New OleDbConnection(connectionString)

            dtaset = LanzarQuery("select * from " & nTable + " where 2=1", connection)
            Return dtaset
        Catch ex As Exception

        End Try

    End Function

    Public Function ObtenerTabla(ByVal nTable As String) As DataSet
        Dim dtaset As DataSet
        Dim connection As New OleDbConnection(connectionString)

        dtaset = LanzarQuery("select * from " & nTable, connection)
        Return dtaset
    End Function

    Public Function ObtenerCampos(ByVal campos As String, ByVal nTable As String) As DataSet
        Dim connection As New OleDbConnection(connectionString)
        Dim dataset = LanzarQuery("select " & campos & " from " & nTable, connection)
        Return dataset
    End Function

    Public Function LanzarConsulta(ByVal query As String) As DataSet
        Dim connection As New MySqlConnection(connectionString)

        Dim dataset = LanzarQuery(query, connection)
        Return dataset
    End Function

   

    Private Function LanzarQuery(ByVal query As String, ByVal connection As OleDbConnection) As DataSet
        Dim dtSet As New DataSet
        connection.Open()
        Dim adapter = New OleDbDataAdapter(query, connection)
        adapter.FillSchema(dtSet, SchemaType.Source)
        adapter.Fill(dtSet)
        adapter.Dispose()
        connection.Close()
        Return dtSet
    End Function

    Private Function LanzarQuery(ByVal query As String, ByVal connection As MySqlConnection) As DataSet
        Dim dtSet As New DataSet
        connection.Open()
        Dim adapter = New MySqlDataAdapter(query, connection)
        adapter.FillSchema(dtSet, SchemaType.Source)
        adapter.Fill(dtSet)
        adapter.Dispose()
        connection.Close()
        Return dtSet
    End Function


    Public Sub UpdateDB(ByVal dataset As DataSet, ByVal query As String)
        Dim connection As New OleDbConnection(connectionString)
        connection.Open()
        Dim adapter As New OleDbDataAdapter(query, connectionString)
        Dim Construct As New OleDbCommandBuilder(adapter)
        Try
            adapter.Update(dataset)
        Catch ex As OleDbException
        End Try
        adapter.Dispose()
        connection.Close()
    End Sub

    Public Sub ExecProcedure(ByVal connectionString As String, ByVal nomSP As String)
        Dim command As New OleDbCommand()
        Dim connection As New OleDbConnection(connectionString)
        connection.Open()

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = nomSP
        Dim i As Integer = command.ExecuteNonQuery

        connection.Close()
    End Sub

    Public Function loadConnectionString() As String
        Dim ds As New DataSet
        ds.ReadXml("C:\temp\ConnectionString.xml")
        Dim connection = ds.Tables(0).Rows(0).Item("path")
        Return connection
    End Function
End Class



