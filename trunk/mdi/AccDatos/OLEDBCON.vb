Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class OLEDBCON
    Private connectionString As String = loadConnectionString()

    Public Function ObtenerTablaVacia(ByVal nTable As String) As DataSet
        Dim dtaset As DataSet
        Try
            Dim connection As New MySqlConnection(connectionString)
            dtaset = LanzarQuery("select * from " & nTable + " where 2=1", connection)
            Return dtaset
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function ObtenerTabla(ByVal nTable As String) As DataSet
        Dim dtaset As DataSet
        Dim connection As New MySqlConnection(connectionString)

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
    Public Function LanzarConsultaT(ByVal query As String) As DataTable
        Dim connection As New MySqlConnection(connectionString)

        Dim dataset = LanzarQueryT(query, connection)
        Return dataset
    End Function

    Public Sub Ejecutar(ByVal query As String)
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim myCommand = New MySqlCommand(query, connection)
        myCommand.ExecuteNonQuery()
        connection.Close()
    End Sub
 

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

    Private Function LanzarQueryT(ByVal query As String, ByVal connection As MySqlConnection) As DataTable
        Dim dtSet As New DataTable
        connection.Open()
        Dim adapter = New MySqlDataAdapter(query, connection)
        'adapter.FillSchema(dtSet, SchemaType.Source)
        adapter.Fill(dtSet)
        adapter.Dispose()
        connection.Close()
        Return dtSet
    End Function
    Public Function LanzarQueryT(ByVal query As String) As DataSet
        Dim connection As New MySqlConnection(connectionString)
        Dim dtSet As New DataSet
        connection.Open()
        Dim adapter = New MySqlDataAdapter(query, connection)
        'adapter.FillSchema(dtSet, SchemaType.Source)
        adapter.Fill(dtSet)
        adapter.Dispose()
        connection.Close()
        Return dtSet
    End Function

    Public Sub UpdateDB(ByVal dataset As DataSet, ByVal query As String)
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim adapter As New MySqlDataAdapter(query, connectionString)
        Dim Construct As New MySqlCommandBuilder(adapter)
        Try
            adapter.Update(dataset)
        Catch ex As MySqlException
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

        ds.ReadXml(System.AppDomain.CurrentDomain.BaseDirectory & "ConnectionString.xml")
        Dim connection = ds.Tables(0).Rows(0).Item("path")
        Return connection
    End Function
End Class



