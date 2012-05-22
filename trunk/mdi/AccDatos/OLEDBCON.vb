Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

''' <summary>
''' 'Clase Que permite agilizar el acceso a la base de datos
''' </summary>
Public Class OLEDBCON
#Region "Propiedades"
    ''' <summary>
    ''' ConnectionString, datos necesarios para conectarse a la BBDD
    ''' </summary>
    Private connectionString As String = loadConnectionString()

#End Region
#Region "Getters"
    ''' <summary>
    ''' Metodo que hace una consulta y devuelve solamente el nombre de los campos auna BBDD MYSql
    ''' </summary>
    ''' <param name="nTable">Nombre de la tabla a la que se va a hacer la consulta</param>
    ''' <returns>Devuelve un Dataset </returns>
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
    ''' <summary>
    ''' Metodo que hace una consulta y devuelve todos los registros de una tabla  MYSql  ''' 
    ''' </summary>
    ''' <param name="nTable">Nombre de la tabla a la que se va a hacer la conslta</param>
    ''' <returns>Devuelve un DataSet con los datos.</returns>
    Public Function ObtenerTabla(ByVal nTable As String) As DataSet
        Dim dtaset As DataSet
        Dim connection As New MySqlConnection(connectionString)

        dtaset = LanzarQuery("select * from " & nTable, connection)
        Return dtaset
    End Function
    ''' <summary>
    ''' Metodo que hace una consulta a la BBDD OLEDB
    ''' </summary>
    ''' <param name="campos">Campos que queremos recojer de la BBDD</param>
    ''' <param name="nTable">Tabla a la que se va hacer la consulta</param>
    ''' <returns>Devuelve un DataSet</returns>
    Public Function ObtenerCampos(ByVal campos As String, ByVal nTable As String) As DataSet
        Dim connection As New OleDbConnection(connectionString)
        Dim dataset = LanzarQuery("select " & campos & " from " & nTable, connection)
        Return dataset
    End Function


    ''' <summary>
    ''' Metodo que lanza una consulta a MYSql
    ''' </summary>
    ''' <param name="query">Consulta completa que se va a lanzar</param>
    ''' <returns>Devuelve un Dataset</returns>
    Public Function LanzarConsulta(ByVal query As String) As DataSet
        Dim connection As New MySqlConnection(connectionString)
        Dim dataset = LanzarQuery(query, connection)
        Return dataset
    End Function

    ''' <summary>
    ''' Metodo que lanza una consulta a MYSql 
    ''' </summary>
    ''' <param name="query">Consulta completa que se va a lanzar</param>
    ''' <returns>Devuelve un DataTable</returns>
    Public Function LanzarConsultaT(ByVal query As String) As DataTable
        Dim connection As New MySqlConnection(connectionString)
        Dim dataset = LanzarQueryT(query, connection)
        Return dataset
    End Function



    ''' <summary>
    ''' Metodo que lanza una consulta a MYSql 
    ''' </summary>
    ''' <param name="query">Consulta completa que se va a lanzar</param>
    ''' <returns>Devuelve un DataSet</returns>
    Public Function LanzarQueryT(ByVal query As String) As DataSet
        Dim connection As New MySqlConnection(connectionString)
        Dim dtSet As New DataSet
        connection.Open()
        Dim adapter = New MySqlDataAdapter(query, connection)
        adapter.Fill(dtSet)
        adapter.Dispose()
        connection.Close()
        Return dtSet
    End Function

#End Region
#Region "Helpers"
    ''' <summary>
    ''' Metodo de soporte, lo utilizan la mayoria de los otros metodos en est clase, se utiliza para
    ''' ejecutar las consultas.
    ''' </summary>
    ''' <param name="query">Consulta que va a ser lanzada</param>
    ''' <param name="connection">Conexion OLEDB utilizada para acceder a la BBDD</param>
    ''' <returns>Devuelve un DataSet</returns>
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


    ''' <summary>
    ''' Metodo de soporte, lo utilizan la mayoria de los otros metodos en est clase, se utiliza para
    ''' ejecutar las consultas.
    ''' </summary>
    ''' <param name="query">Consulta que va a ser lanzada</param>
    ''' <param name="connection">Conexion MYSQL utilizada para acceder a la BBDD</param>
    ''' <returns>Devuelve un DataSet</returns>
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


    ''' <summary>
    ''' Metodo de soporte, lo utilizan la mayoria de los otros metodos en est clase, se utiliza para
    ''' ejecutar las consultas.
    ''' </summary>
    ''' <param name="query">Consulta que va a ser lanzada</param>
    ''' <param name="connection">Conexion MYSQL utilizada para acceder a la BBDD</param>
    ''' <returns>Devuelve una DataTable</returns>
    Private Function LanzarQueryT(ByVal query As String, ByVal connection As MySqlConnection) As DataTable
        Dim dtSet As New DataTable
        connection.Open()
        Dim adapter = New MySqlDataAdapter(query, connection)
        adapter.Fill(dtSet)
        adapter.Dispose()
        connection.Close()
        Return dtSet
    End Function

#End Region
#Region "Setters"
    ''' <summary>
    ''' Metodo que lanza una consulta a MYSql 
    ''' </summary>
    ''' <param name="query">Consulta completa que se va a lanzar</param>7
    ''' <param name="dataset">Dataset que se va a enviar a la BBDD MYSQL</param>
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


    ''' <summary>
    ''' Metodo que ejecuta un Procedimiento Almacenado
    ''' </summary>
    ''' <param name="connectionString">Conexion a la BBDD mediante OLEDB</param>
    ''' <param name="nomSP">Nombre del Procedimiento Almacenado</param>
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

    ''' <summary>
    ''' Metodo que ejecuta un Update/Insert
    ''' </summary>
    ''' <param name="query">COnsulta Completa que se vaa lanzar</param>
    Public Sub Ejecutar(ByVal query As String)
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim myCommand = New MySqlCommand(query, connection)
        myCommand.ExecuteNonQuery()
        connection.Close()
    End Sub
#End Region
#Region "ConnectionString"
    ''' <summary>
    ''' Metodo que carga la connectionString desde un archivo XML ubicado en la carpeta de ejecucion del Programa
    ''' </summary>
    ''' <returns>Devuelve la ConnectionString en formato de cadena de texto</returns>
    Public Function loadConnectionString() As String
        Dim ds As New DataSet

        ds.ReadXml(System.AppDomain.CurrentDomain.BaseDirectory & "ConnectionString.xml")
        Dim connection = ds.Tables(0).Rows(0).Item("path")
        Return connection
    End Function
#End Region
End Class



