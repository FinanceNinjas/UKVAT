Module AS400
    Public Function QueryAS400(ByVal QueryText As String, ByVal ParamArray TheParameters As String()) As DataTable
        Dim conn As New Odbc.OdbcConnection("Dsn=" & My.Settings.DSN & ";uid=" & My.Settings.UserID & ";pwd=riker09")
        Dim cmd As New Odbc.OdbcCommand
        Dim FunctionDataTable As New DataTable
        cmd.CommandType = CommandType.Text
        cmd.CommandText = QueryText
        cmd.Connection = conn
        cmd.CommandTimeout = 0

        For Each Parameter In TheParameters
            Application.DoEvents()
            Dim param As New Odbc.OdbcParameter("?", Parameter)
            cmd.Parameters.Add(param)
        Next

        Dim TheDataReader As Odbc.OdbcDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            Application.DoEvents()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Application.DoEvents()
            TheDataReader = cmd.ExecuteReader
            Application.DoEvents()
            If TheDataReader.HasRows = True Then
                Application.DoEvents()
                FunctionDataTable.Load(TheDataReader)
            End If
            Return FunctionDataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return FunctionDataTable
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Function

    Public Function GetAS400Date(ByVal InputDate As Date) As String
        Try
            GetAS400Date = Format(InputDate, "yyyy-MM-dd")
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function GetResourceContent(ByVal filename As String) As String
        ' get the current assembly
        Dim asm As System.Reflection.[Assembly] = _
            System.Reflection.[Assembly].GetExecutingAssembly()
        ' resources are named using a fully qualified name
        Dim strm As System.IO.Stream = asm.GetManifestResourceStream(asm.GetName() _
            .Name + "." + filename)
        ' read the contents of the embedded file
        Dim reader As New System.IO.StreamReader(strm)
        GetResourceContent = reader.ReadToEnd()
        reader.Close()
    End Function

    Public Function GetYYYYMMDD(ByVal InputDate As Date) As Integer
        Try
            GetYYYYMMDD = Format(InputDate, "yyyyMMdd")
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Sub DeleteInsertAS400(ByVal QueryText As String)
        Dim conn As New Odbc.OdbcConnection("Dsn=" & My.Settings.DSN & ";uid=" & My.Settings.UserID & ";pwd=riker09")
        Dim cmd As New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = QueryText
        cmd.Connection = conn
        cmd.CommandTimeout = 600000
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            Application.DoEvents()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Application.DoEvents()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Public Function Getmmddyy(ByVal InputDate As Date) As String
        Try
            Getmmddyy = Format(InputDate, "MMddyy")
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
End Module
