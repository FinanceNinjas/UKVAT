Imports System.Data.SqlClient
Public Class Form1
    Dim LotList As String
    Dim VOLCATDataTable As New DataTable
    Dim VATDASHDataTable As New DataTable
    Dim VATDASH1DataTable As New DataTable
    Dim VATDASH2DataTable As New DataTable
    Dim VATDASH3DataTable As New DataTable
    Dim VATDASH4DataTable As New DataTable

    Dim DKDASH7DataTable As New DataTable
    Dim DKDASH71DataTable As New DataTable
    Dim DKDASH72CDataTable As New DataTable
    Dim DKDASH72FDataTable As New DataTable

    Dim CDTripDataTable As New DataTable

    Private Sub BuildLotList()
        Try
            LotList = String.Empty
            For Each RowItem As DataGridViewRow In VOLCATGrid.Rows
                LotList = LotList & VOLCATGrid.Item(1, RowItem.Index).Value & ","
            Next
            LotList = Mid(LotList, 1, LotList.Length - 1)
        Catch ex As Exception
            MessageBox.Show("1:" & ex.Message)
        End Try
    End Sub


    Private Function GetThisSunday(CurrentDate As Date) As Date
        Select Case CurrentDate.DayOfWeek
            Case DayOfWeek.Sunday
                Return CurrentDate
            Case DayOfWeek.Monday
                Return CurrentDate.AddDays(-1)
            Case DayOfWeek.Tuesday
                Return CurrentDate.AddDays(-2)
            Case DayOfWeek.Wednesday
                Return CurrentDate.AddDays(-3)
            Case DayOfWeek.Thursday
                Return CurrentDate.AddDays(-4)
            Case DayOfWeek.Friday
                Return CurrentDate.AddDays(-5)
            Case DayOfWeek.Saturday
                Return CurrentDate.AddDays(-6)
            Case Else
                Return CurrentDate
        End Select
    End Function

    Private Function GetPriorMonday(CurrentDate As Date) As Date
        Select Case CurrentDate.DayOfWeek
            Case DayOfWeek.Sunday
                Return CurrentDate.AddDays(-6)
            Case DayOfWeek.Monday
                Return CurrentDate.AddDays(-7)
            Case DayOfWeek.Tuesday
                Return CurrentDate.AddDays(-8)
            Case DayOfWeek.Wednesday
                Return CurrentDate.AddDays(-9)
            Case DayOfWeek.Thursday
                Return CurrentDate.AddDays(-10)
            Case DayOfWeek.Friday
                Return CurrentDate.AddDays(-11)
            Case DayOfWeek.Saturday
                Return CurrentDate.AddDays(-12)
            Case Else
                Return CurrentDate
        End Select
    End Function

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            If My.Settings.DSN.Length > 0 Then txtDSN.Text = My.Settings.DSN
            If My.Settings.UserID.Length > 0 Then txtUserID.Text = My.Settings.UserID
            If My.Settings.Password.Length > 0 Then txtPassword.Text = My.Settings.Password
            txtStartDate.Text = GetPriorMonday(Date.Today)
            txtEndDate.Text = GetThisSunday(Date.Today)
            Me.SecondStepData.Enabled = False

        Catch ex As Exception
            MessageBox.Show("4:" & ex.Message)
        End Try
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            My.Settings.DSN = txtDSN.Text
            My.Settings.UserID = txtUserID.Text
            My.Settings.Password = txtPassword.Text
        Catch ex As Exception
            MessageBox.Show("5:" & ex.Message)
        End Try
    End Sub

    Private Sub GetVOLCATData()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading VOLCAT Data..."
            SQLStatement = GetResourceContent("DKVOLCAT.sql")
            SQLStatement = Replace(SQLStatement, "StartDate", GetYYYYMMDD(txtStartDate.Text))
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            VOLCATDataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(VOLCATGrid, VOLCATDataTable)
            StatusLabel.Text = "VOLCAT Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "6: " & ex.Message
        End Try
    End Sub

    Private Sub GetVATDASHData()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading VATDASH-0 Data..."
            SQLStatement = GetResourceContent("DKVATDASH.sql")
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            VATDASHDataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(VATDASHGrid, VATDASHDataTable)
            StatusLabel.Text = "VATDASH-0 Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "7: " & ex.Message
        End Try
    End Sub

    Private Sub GetVATDASH1Data()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading VATDASH1 Data..."
            SQLStatement = GetResourceContent("DKVATDASH1.sql")
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            VATDASH1DataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(VATDASH1Grid, VATDASH1DataTable)
            StatusLabel.Text = "VATDASH1 Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "8: " & ex.Message
        End Try
    End Sub

    Private Sub GetVATDASH2Data()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading VATDASH2 Data..."
            SQLStatement = GetResourceContent("DKVATDASH2.sql")
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            VATDASH2DataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(VATDASH2Grid, VATDASH2DataTable)
            StatusLabel.Text = "VATDASH2 Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "9: " & ex.Message
        End Try
    End Sub

    Private Sub GetVATDASH3Data()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading VATDASH3 Data..."
            SQLStatement = GetResourceContent("DKVATDASH3.sql")
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            VATDASH3DataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(VATDASH3Grid, VATDASH3DataTable)
            StatusLabel.Text = "VATDASH3 Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "10: " & ex.Message
        End Try
    End Sub

    Private Sub GetVATDASH4Data()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading VATDASH4 Data..."
            SQLStatement = GetResourceContent("DKVATDASH4.sql")
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            VATDASH4DataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(VATDASH4Grid, VATDASH4DataTable)
            StatusLabel.Text = "VATDASH4 Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "11: " & ex.Message
        End Try
    End Sub

    Delegate Sub SetDataGrid_Delegate(ByVal TheDataGrid As DataGridView, ByVal TheDataTable As DataTable)

    Public Sub SetDataGrid_ThreadSafe(ByVal TheDataGrid As DataGridView, ByVal TheDataTable As DataTable)
        Try
            If TheDataGrid.InvokeRequired Then
                Dim MyDelegate As New SetDataGrid_Delegate(AddressOf SetDataGrid_ThreadSafe)
                TheDataGrid.Invoke(MyDelegate, New Object() {TheDataGrid, TheDataTable})
            Else
                TheDataGrid.DataSource = TheDataTable
            End If
        Catch ex As Exception
            MessageBox.Show("13: " & ex.Message)
        End Try
    End Sub

    Private Sub GetData_Click(sender As System.Object, e As System.EventArgs) Handles GetData.Click
        Try
            Me.BGGetInitialData.RunWorkerAsync()


        Catch ex As Exception
            MessageBox.Show("14: " & ex.Message)
        End Try
    End Sub

    Private Sub BGGetInitialData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGGetInitialData.DoWork
        Try
            Me.GetVOLCATData()
            Me.SaveDKVOLCATDataToSQL()
            If chkVATDASH.Checked = True Then
                Me.GetVATDASHData()
                Me.SaveVATDASHDataToSQL("DKVATDASH", VATDASHDataTable)
                Me.GetVATDASH1Data()
                Me.SaveVATDASHDataToSQL("DKVATDASH1", VATDASH1DataTable)
                Me.GetVATDASH2Data()
                Me.SaveVATDASHDataToSQL("DKVATDASH2", VATDASH2DataTable)
                Me.GetVATDASH3Data()
                Me.SaveVATDASHDataToSQL("DKVATDASH3", VATDASH3DataTable)
                Me.GetVATDASH4Data()
                Me.SaveVATDASHDataToSQL("DKVATDASH4", VATDASH4DataTable)
            End If

        Catch ex As Exception
            MessageBox.Show("15: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveVOLCATDataToAS400()
        Dim conn As New Odbc.OdbcConnection("Dsn=" & My.Settings.DSN & ";uid=" & My.Settings.UserID & ";pwd=" & My.Settings.Password)
        Dim cmd As New Odbc.OdbcCommand
        Dim TheDataType As New Odbc.OdbcType
        Dim FullTableName As String
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandTimeout = 600000
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            StatusLabel.Text = "Saving VOLCAT Records to AS/400 Table..."
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                cmd.CommandText = "DELETE FROM MISMLM.BKVOLCAT WHERE 1=1"
                cmd.ExecuteNonQuery()
                FullTableName = "MISMLM.BKVOLCAT"
                'Add parameters for each column.

                For Each RowItem As DataGridViewRow In VOLCATGrid.Rows
                    cmd.Parameters.Add("YRD", Odbc.OdbcType.Int)
                    cmd.Parameters.Add("LOT", Odbc.OdbcType.Int)
                    cmd.Parameters.Add("HIBID", Odbc.OdbcType.Decimal)
                    cmd.Parameters.Add("BUYFEE", Odbc.OdbcType.Decimal)
                    cmd.Parameters.Add("SELLFEE", Odbc.OdbcType.Decimal)
                    cmd.Parameters.Add("CPN", Odbc.OdbcType.Char)
                    cmd.Parameters.Add("CODE", Odbc.OdbcType.Char)
                    cmd.Parameters.Add("CONTRACT", Odbc.OdbcType.Char)
                    cmd.Parameters.Add("NBR", Odbc.OdbcType.Int)
                    cmd.Parameters.Add("INVDATE", Odbc.OdbcType.Decimal)
                    cmd.Parameters.Add("PROGRAM", Odbc.OdbcType.Decimal)
                    cmd.Parameters.Add("TOW", Odbc.OdbcType.Decimal)
                    cmd.Parameters.Add("PURCHASE", Odbc.OdbcType.Decimal)
                    cmd.Parameters.Add("VATFLAG", Odbc.OdbcType.Char)
                    cmd.Parameters.Add("CAT", Odbc.OdbcType.Char)
                    cmd.CommandText = "INSERT INTO MISMLM.BKVOLCAT (YRD, LOT, HIBID, BUYFEE, SELLFEE, CPN, CODE, CONTRACT, NBR, INVDATE, PROGRAM, TOW, PURCHASE, VATFLAG, CAT) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                    cmd.Parameters(0).Value = VOLCATGrid.Item(0, RowItem.Index).Value
                    cmd.Parameters(1).Value = VOLCATGrid.Item(1, RowItem.Index).Value
                    cmd.Parameters(2).Value = VOLCATGrid.Item(2, RowItem.Index).Value
                    cmd.Parameters(3).Value = VOLCATGrid.Item(3, RowItem.Index).Value
                    cmd.Parameters(4).Value = VOLCATGrid.Item(4, RowItem.Index).Value
                    cmd.Parameters(5).Value = VOLCATGrid.Item(5, RowItem.Index).Value
                    cmd.Parameters(6).Value = VOLCATGrid.Item(6, RowItem.Index).Value
                    cmd.Parameters(7).Value = VOLCATGrid.Item(7, RowItem.Index).Value
                    cmd.Parameters(8).Value = VOLCATGrid.Item(8, RowItem.Index).Value
                    cmd.Parameters(9).Value = VOLCATGrid.Item(9, RowItem.Index).Value
                    cmd.Parameters(10).Value = VOLCATGrid.Item(10, RowItem.Index).Value
                    cmd.Parameters(11).Value = VOLCATGrid.Item(11, RowItem.Index).Value
                    cmd.Parameters(12).Value = VOLCATGrid.Item(12, RowItem.Index).Value
                    cmd.Parameters(13).Value = VOLCATGrid.Item(13, RowItem.Index).Value
                    cmd.Parameters(14).Value = VOLCATGrid.Item(14, RowItem.Index).Value
                    cmd.Prepare()
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                Next
            End If
            StatusLabel.Text = "VOLCAT Records Saved to AS/400."
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub SaveVATDASHDataToAS400(TableName As String, TheDataGrid As DataGridView)
        Dim conn As New Odbc.OdbcConnection("Dsn=" & My.Settings.DSN & ";uid=" & My.Settings.UserID & ";pwd=" & My.Settings.Password)
        Dim cmd As New Odbc.OdbcCommand
        Dim TheDataType As New Odbc.OdbcType
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandTimeout = 600000
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            StatusLabel.Text = "Saving " & TheDataGrid.Name & " Records to AS/400 Table " & TableName & "..."
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                cmd.CommandText = "DELETE FROM " & TableName & " WHERE 1=1"
                cmd.ExecuteNonQuery()
                'Add parameters for each column.

                For Each RowItem As DataGridViewRow In TheDataGrid.Rows
                    cmd.Parameters.Add("LOT", Odbc.OdbcType.Int)
                    cmd.Parameters.Add("AMOUNT", Odbc.OdbcType.Decimal)
                    cmd.CommandText = "INSERT INTO " & TableName & " (LOT, AMOUNT) VALUES (?,?)"
                    cmd.Parameters(0).Value = TheDataGrid.Item(0, RowItem.Index).Value
                    cmd.Parameters(1).Value = TheDataGrid.Item(1, RowItem.Index).Value
                    cmd.Prepare()
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                Next
            End If
            StatusLabel.Text = TableName & " Records Saved to AS/400."
        Catch ex As Exception
            MessageBox.Show("17:" & ex.Message)

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub SaveVATDASHDataToSQL(SQLTableName As String, TheDataTable As DataTable)
        Dim VATSQLCommand As New SqlCommand
        Try
            If TheDataTable.Rows.Count > 0 Then
                SqlConnection.Open()
                VATSQLCommand.Connection = SqlConnection
                VATSQLCommand.CommandTimeout = 0
                VATSQLCommand.CommandText = "DELETE FROM " & SQLTableName
                VATSQLCommand.ExecuteNonQuery()
                Dim VATBulkCopy As SqlBulkCopy = New SqlBulkCopy(SqlConnection)
                VATBulkCopy.DestinationTableName = SQLTableName
                VATBulkCopy.BulkCopyTimeout = 0
                Dim LOTMapping As New SqlBulkCopyColumnMapping("LOT", "LOT")
                Dim AMOUNTMapping As New SqlBulkCopyColumnMapping("AMOUNT", "AMOUNT")
                VATBulkCopy.ColumnMappings.Add(LOTMapping)
                VATBulkCopy.ColumnMappings.Add(AMOUNTMapping)
                VATBulkCopy.WriteToServer(TheDataTable)
                TheDataTable = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("18:" & ex.Message)
        Finally
            SqlConnection.Close()
        End Try
    End Sub

    Private Sub BGGetSecondStepData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGGetSecondStepData.DoWork
        Try
            Me.GetDKDASH7Data()
            FillInOtherRevDKDASH7()
            FillInDKDASH71DataTable()
            Me.GetDKDASH72CData()
            Me.GetDKDASH72FData()
            Me.GetCDTripData()
            Me.SaveDKDASH7DataToSQL()
            Me.SaveDKDASH71DataToSQL()
            Me.SaveDKDASH72CDataToSQL()
            Me.SaveDKDASH72FDataToSQL()
            Me.SaveCDTripDataToSQL()
        Catch ex As Exception
            MessageBox.Show("19:" & ex.Message)
        End Try
    End Sub

    Private Sub GetDKDASH7Data()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading DKDASH7 Data..."
            SQLStatement = GetResourceContent("DKDASH7.sql")
            SQLStatement = Replace(SQLStatement, "StartDate", GetYYYYMMDD(txtStartDate.Text))
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            DKDASH7DataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(DKDASH7Grid, DKDASH7DataTable)
            StatusLabel.Text = "DKDASH7 Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "20: " & ex.Message
        End Try
    End Sub

    Private Sub GetDKDASH72CData()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading DKDASH72C Data..."
            SQLStatement = GetResourceContent("DKDASH72C.sql")
            SQLStatement = Replace(SQLStatement, "StartDate", GetYYYYMMDD(txtStartDate.Text))
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            DKDASH72CDataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(DKDASH72CGrid, DKDASH72CDataTable)
            StatusLabel.Text = "DKDASH72C Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "21: " & ex.Message
        End Try
    End Sub

    Private Sub GetDKDASH72FData()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading DKDASH72F Data..."
            SQLStatement = GetResourceContent("DKDASH72F.sql")
            SQLStatement = Replace(SQLStatement, "StartDate", GetYYYYMMDD(txtStartDate.Text))
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            DKDASH72CDataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(DKDASH72FGrid, DKDASH72FDataTable)
            StatusLabel.Text = "DKDASH72F Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "22: " & ex.Message
        End Try
    End Sub

    Private Sub GetCDTripData()
        Try
            Dim SQLStatement As String
            StatusLabel.Text = "Loading CDTrip Data..."
            SQLStatement = GetResourceContent("GBRCDTripData.sql")
            SQLStatement = Replace(SQLStatement, "StartDate", GetYYYYMMDD(txtStartDate.Text))
            SQLStatement = Replace(SQLStatement, "EndDate", GetYYYYMMDD(txtEndDate.Text))
            CDTripDataTable = QueryAS400(SQLStatement)
            SetDataGrid_ThreadSafe(TripsGrid, CDTripDataTable)
            StatusLabel.Text = "CDTrip Data Load Complete."
        Catch ex As Exception
            StatusLabel.Text = "22b: " & ex.Message
        End Try
    End Sub

    Private Function GetVATDASHAmount(SQLTableName As String, LOTNumber As Integer) As Double
        Dim VATSQLCommand As New SqlCommand
        Dim VATSQLConnection As New SqlConnection
        Dim TheResult As Double
        Try
            Dim VATSQLReader As SqlDataReader
            VATSQLConnection.ConnectionString = SqlConnection.ConnectionString
            VATSQLConnection.Open()
            VATSQLCommand.Connection = VATSQLConnection
            VATSQLCommand.CommandText = "SELECT Amount FROM " & SQLTableName & " WHERE LOT=" & LOTNumber
            VATSQLReader = VATSQLCommand.ExecuteReader
            If VATSQLReader.HasRows = True Then
                While VATSQLReader.Read
                    TheResult = VATSQLReader.Item(0)
                End While
            Else
                TheResult = 0
            End If
            Return TheResult
        Catch ex As Exception
            Return 0
            MessageBox.Show("23:" & ex.Message)
        Finally
            VATSQLConnection.Close()
        End Try
    End Function

    Private Function GetDKDASH7OtherRev(SellFee As Double, ProgRev As Double, TheLotNumber As Integer) As Double
        Try
            Dim TheResult As Double
            TheResult = SellFee - ProgRev - GetVATDASHAmount("DKVATDASH", TheLotNumber) - GetVATDASHAmount("DKVATDASH3", TheLotNumber)
            Return TheResult
        Catch ex As Exception
            Return 0
            MessageBox.Show("24:" & ex.Message)
        End Try
    End Function

    Private Sub FillInOtherRevDKDASH7()
        Try
            StatusLabel.Text = "Filling In Other Revenue..."
            For Each RowItem As DataRow In DKDASH7DataTable.Rows
                'MessageBox.Show(RowItem.Item(7))
                RowItem.Item(6) = GetDKDASH7OtherRev(RowItem.Item(4), RowItem.Item(5), RowItem.Item(1))
            Next
            StatusLabel.Text = "Other Revenue Calculations Completed."
        Catch ex As Exception
            MessageBox.Show("25:" & ex.Message)
        End Try
    End Sub

    Private Sub FillInDKDASH71DataTable()
        Try
            StatusLabel.Text = "Loading DKDASH71 Data..."
            DKDASH71DataTable = DKDASH7DataTable.Clone()
            For Each RowItem As DataRow In DKDASH7DataTable.Rows
                If RowItem.Item(6) > 150 Then
                    DKDASH71DataTable.Rows.Add(RowItem.Item(0), RowItem.Item(1), RowItem.Item(2), RowItem.Item(3), RowItem.Item(4), RowItem.Item(5), RowItem.Item(6), RowItem.Item(7), RowItem.Item(8))
                End If
            Next
            SetDataGrid_ThreadSafe(DKDASH71Grid, DKDASH71DataTable)
            StatusLabel.Text = "DKDASH71 Data Loaded."
        Catch ex As Exception
            MessageBox.Show("26:" & ex.Message)

        End Try
    End Sub


    Private Sub SaveDKDASH7DataToSQL()
        Dim DKDASH7SQLCommand As New SqlCommand
        Try
            If DKDASH7DataTable.Rows.Count > 0 Then
                StatusLabel.Text = "sAVING DKDASH7 Data..."
                SqlConnection.Open()
                DKDASH7SQLCommand.Connection = SqlConnection
                DKDASH7SQLCommand.CommandText = "DELETE FROM DKDASH7"
                DKDASH7SQLCommand.ExecuteNonQuery()
                Dim VATBulkCopy As SqlBulkCopy = New SqlBulkCopy(SqlConnection)
                VATBulkCopy.DestinationTableName = "DKDASH7"
                VATBulkCopy.BulkCopyTimeout = 600000
                Dim YARDMapping As New SqlBulkCopyColumnMapping("YARD", "YARD")
                Dim LOTMapping As New SqlBulkCopyColumnMapping("LOT", "LOT")
                Dim VATFLAGMapping As New SqlBulkCopyColumnMapping("VATFLAG", "VATFLAG")
                Dim HIBIDMapping As New SqlBulkCopyColumnMapping("HIBID", "HIBID")
                Dim SELLFEEMapping As New SqlBulkCopyColumnMapping("SELLFEE", "SELLFEE")
                Dim PROGREVMapping As New SqlBulkCopyColumnMapping("PROGREV", "PROGREV")
                Dim OTHERREVMapping As New SqlBulkCopyColumnMapping("OTHERREV", "OTHERREV")
                Dim TITLEMapping As New SqlBulkCopyColumnMapping("TITLE", "TITLE")
                Dim SELLERMapping As New SqlBulkCopyColumnMapping("SELLER", "SELLER")

                VATBulkCopy.ColumnMappings.Add(YARDMapping)
                VATBulkCopy.ColumnMappings.Add(LOTMapping)
                VATBulkCopy.ColumnMappings.Add(VATFLAGMapping)
                VATBulkCopy.ColumnMappings.Add(HIBIDMapping)
                VATBulkCopy.ColumnMappings.Add(SELLFEEMapping)
                VATBulkCopy.ColumnMappings.Add(PROGREVMapping)
                VATBulkCopy.ColumnMappings.Add(OTHERREVMapping)
                VATBulkCopy.ColumnMappings.Add(TITLEMapping)
                VATBulkCopy.ColumnMappings.Add(SELLERMapping)
                VATBulkCopy.WriteToServer(DKDASH7DataTable)
                DKDASH7DataTable = Nothing
                StatusLabel.Text = "DKDASH7 Data Saved."
            End If
        Catch ex As Exception
            MessageBox.Show("27:" & ex.Message)
        Finally
            SqlConnection.Close()
        End Try
    End Sub

    Private Sub SaveDKDASH71DataToSQL()
        Dim DKDASH71SQLCommand As New SqlCommand
        Try
            StatusLabel.Text = "Saving DKDASH71 Data..."
            If DKDASH71DataTable.Rows.Count > 0 Then
                SqlConnection.Open()
                DKDASH71SQLCommand.Connection = SqlConnection
                DKDASH71SQLCommand.CommandText = "DELETE FROM DKDASH71"
                DKDASH71SQLCommand.ExecuteNonQuery()
                Dim VATBulkCopy As SqlBulkCopy = New SqlBulkCopy(SqlConnection)
                VATBulkCopy.DestinationTableName = "DKDASH71"
                VATBulkCopy.BulkCopyTimeout = 600000
                Dim YARDMapping As New SqlBulkCopyColumnMapping("YARD", "YARD")
                Dim LOTMapping As New SqlBulkCopyColumnMapping("LOT", "LOT")
                Dim VATFLAGMapping As New SqlBulkCopyColumnMapping("VATFLAG", "VATFLAG")
                Dim HIBIDMapping As New SqlBulkCopyColumnMapping("HIBID", "HIBID")
                Dim SELLFEEMapping As New SqlBulkCopyColumnMapping("SELLFEE", "SELLFEE")
                Dim PROGREVMapping As New SqlBulkCopyColumnMapping("PROGREV", "PROGREV")
                Dim OTHERREVMapping As New SqlBulkCopyColumnMapping("OTHERREV", "OTHERREV")
                Dim TITLEMapping As New SqlBulkCopyColumnMapping("TITLE", "TITLE")
                VATBulkCopy.ColumnMappings.Add(YARDMapping)
                VATBulkCopy.ColumnMappings.Add(LOTMapping)
                VATBulkCopy.ColumnMappings.Add(VATFLAGMapping)
                VATBulkCopy.ColumnMappings.Add(HIBIDMapping)
                VATBulkCopy.ColumnMappings.Add(SELLFEEMapping)
                VATBulkCopy.ColumnMappings.Add(PROGREVMapping)
                VATBulkCopy.ColumnMappings.Add(OTHERREVMapping)
                VATBulkCopy.ColumnMappings.Add(TITLEMapping)
                VATBulkCopy.WriteToServer(DKDASH71DataTable)
                DKDASH71DataTable = Nothing
            End If
            StatusLabel.Text = "DKDASH71 Data Saved."
        Catch ex As Exception
            MessageBox.Show("28:" & ex.Message)
        Finally
            SqlConnection.Close()
        End Try
    End Sub

    Private Sub SaveDKDASH72CDataToSQL()
        Dim DKDASH72CSQLCommand As New SqlCommand
        StatusLabel.Text = "Saving DKDASH72C Data..."
        Try
            If DKDASH72CDataTable.Rows.Count > 0 Then
                SqlConnection.Open()
                DKDASH72CSQLCommand.Connection = SqlConnection
                DKDASH72CSQLCommand.CommandText = "DELETE FROM DKDASH72C"
                DKDASH72CSQLCommand.ExecuteNonQuery()
                Dim VATBulkCopy As SqlBulkCopy = New SqlBulkCopy(SqlConnection)
                VATBulkCopy.DestinationTableName = "DKDASH72C"
                VATBulkCopy.BulkCopyTimeout = 600000
                Dim YARDMapping As New SqlBulkCopyColumnMapping("YARD", "YARD")
                Dim SELLERMapping As New SqlBulkCopyColumnMapping("SELLER", "SELLER")
                Dim LOTMapping As New SqlBulkCopyColumnMapping("LOT", "LOT")
                Dim HIBIDMapping As New SqlBulkCopyColumnMapping("HIBID", "HIBID")
                Dim PROGREVMapping As New SqlBulkCopyColumnMapping("PROGREV", "PROGREV")
                Dim LOTMODELMapping As New SqlBulkCopyColumnMapping("LOTMODEL", "LOTMODEL")

                VATBulkCopy.ColumnMappings.Add(YARDMapping)
                VATBulkCopy.ColumnMappings.Add(SELLERMapping)
                VATBulkCopy.ColumnMappings.Add(LOTMapping)
                VATBulkCopy.ColumnMappings.Add(HIBIDMapping)
                VATBulkCopy.ColumnMappings.Add(PROGREVMapping)
                VATBulkCopy.ColumnMappings.Add(LOTMODELMapping)
                VATBulkCopy.WriteToServer(DKDASH72CDataTable)
                DKDASH72CDataTable = Nothing
            End If
            StatusLabel.Text = "DKDASH72C Data Saved."
        Catch ex As Exception
            MessageBox.Show("29:" & ex.Message)
        Finally
            SqlConnection.Close()
        End Try
    End Sub

    Private Sub SaveDKDASH72FDataToSQL()
        Dim DKDASH72FSQLCommand As New SqlCommand
        Try
            StatusLabel.Text = "Saving DKDASH72F Data..."
            If DKDASH72FDataTable.Rows.Count > 0 Then
                SqlConnection.Open()
                DKDASH72FSQLCommand.Connection = SqlConnection
                DKDASH72FSQLCommand.CommandText = "DELETE FROM DKDASH72F"
                DKDASH72FSQLCommand.ExecuteNonQuery()
                Dim VATBulkCopy As SqlBulkCopy = New SqlBulkCopy(SqlConnection)
                VATBulkCopy.DestinationTableName = "DKDASH72F"
                VATBulkCopy.BulkCopyTimeout = 600000
                Dim YARDMapping As New SqlBulkCopyColumnMapping("YARD", "YARD")
                Dim SELLERMapping As New SqlBulkCopyColumnMapping("SELLER", "SELLER")
                Dim LOTMapping As New SqlBulkCopyColumnMapping("LOT", "LOT")
                Dim HIBIDMapping As New SqlBulkCopyColumnMapping("HIBID", "HIBID")
                Dim PROGREVMapping As New SqlBulkCopyColumnMapping("PROGREV", "PROGREV")
                Dim LOTMODELMapping As New SqlBulkCopyColumnMapping("LOTMODEL", "LOTMODEL")

                VATBulkCopy.ColumnMappings.Add(YARDMapping)
                VATBulkCopy.ColumnMappings.Add(SELLERMapping)
                VATBulkCopy.ColumnMappings.Add(LOTMapping)
                VATBulkCopy.ColumnMappings.Add(HIBIDMapping)
                VATBulkCopy.ColumnMappings.Add(PROGREVMapping)
                VATBulkCopy.ColumnMappings.Add(LOTMODELMapping)
                VATBulkCopy.WriteToServer(DKDASH72FDataTable)
                DKDASH72FDataTable = Nothing
            End If
            StatusLabel.Text = "DKDASH72F Data Saved."
        Catch ex As Exception
            MessageBox.Show("30:" & ex.Message)
        Finally
            SqlConnection.Close()
        End Try
    End Sub

    Private Sub SaveDKVOLCATDataToSQL()
        Dim DKVOLCATSQLCommand As New SqlCommand
        Try
            StatusLabel.Text = "Saving DKVOLCAT Data..."
            If VOLCATDataTable.Rows.Count > 0 Then
                SqlConnection.Open()
                DKVOLCATSQLCommand.Connection = SqlConnection
                DKVOLCATSQLCommand.CommandText = "DELETE FROM DKVOLCAT"
                DKVOLCATSQLCommand.ExecuteNonQuery()
                Dim VATBulkCopy As SqlBulkCopy = New SqlBulkCopy(SqlConnection)
                VATBulkCopy.DestinationTableName = "DKVOLCAT"
                VATBulkCopy.BulkCopyTimeout = 600000
                Dim YARDMapping As New SqlBulkCopyColumnMapping("YARD", "YARD")
                Dim LOTMapping As New SqlBulkCopyColumnMapping("LOT", "LOT")
                Dim HIBIDMapping As New SqlBulkCopyColumnMapping("HIBID", "HIBID")
                Dim BUYFEEMapping As New SqlBulkCopyColumnMapping("BUYFEE", "BUYFEE")
                Dim SELLFEEMapping As New SqlBulkCopyColumnMapping("SELLFEE", "SELLFEE")
                Dim CPNMapping As New SqlBulkCopyColumnMapping("CPN", "CPN")
                Dim CODEMapping As New SqlBulkCopyColumnMapping("CODE", "CODE")
                Dim CONTRACTMapping As New SqlBulkCopyColumnMapping("CONTRACT", "CONTRACT")
                Dim NBRMapping As New SqlBulkCopyColumnMapping("NBR", "NBR")
                Dim INVDATEMapping As New SqlBulkCopyColumnMapping("INVDATE", "INVDATE")
                Dim PROGRAMMapping As New SqlBulkCopyColumnMapping("PROGRAM", "PROGRAM")
                Dim TOWMapping As New SqlBulkCopyColumnMapping("TOW", "TOW")
                Dim PURCHASEMapping As New SqlBulkCopyColumnMapping("PURCHASE", "PURCHASE")
                Dim VATFLAGMapping As New SqlBulkCopyColumnMapping("VATFLAG", "VATFLAG")
                Dim TITLEMapping As New SqlBulkCopyColumnMapping("TITLE", "TITLE")


                VATBulkCopy.ColumnMappings.Add(YARDMapping)
                VATBulkCopy.ColumnMappings.Add(LOTMapping)
                VATBulkCopy.ColumnMappings.Add(HIBIDMapping)
                VATBulkCopy.ColumnMappings.Add(BUYFEEMapping)
                VATBulkCopy.ColumnMappings.Add(SELLFEEMapping)
                VATBulkCopy.ColumnMappings.Add(CPNMapping)
                VATBulkCopy.ColumnMappings.Add(CODEMapping)
                VATBulkCopy.ColumnMappings.Add(CONTRACTMapping)
                VATBulkCopy.ColumnMappings.Add(NBRMapping)
                VATBulkCopy.ColumnMappings.Add(INVDATEMapping)
                VATBulkCopy.ColumnMappings.Add(PROGRAMMapping)
                VATBulkCopy.ColumnMappings.Add(TOWMapping)
                VATBulkCopy.ColumnMappings.Add(PURCHASEMapping)
                VATBulkCopy.ColumnMappings.Add(VATFLAGMapping)
                VATBulkCopy.ColumnMappings.Add(TITLEMapping)
                VATBulkCopy.WriteToServer(VOLCATDataTable)
                VOLCATDataTable = Nothing
            End If
            StatusLabel.Text = "DKVOLCAT Data Saved."
        Catch ex As Exception
            MessageBox.Show("29:" & ex.Message)
        Finally
            SqlConnection.Close()
        End Try
    End Sub

    Private Sub SaveCDTripDataToSQL()
        Dim TripDataSQLCommand As New SqlCommand
        Try
            StatusLabel.Text = "Saving CD Trip Data..."
            If CDTripDataTable.Rows.Count > 0 Then
                SqlConnection.Open()
                TripDataSQLCommand.Connection = SqlConnection
                TripDataSQLCommand.CommandText = "DELETE FROM TripLog"
                TripDataSQLCommand.ExecuteNonQuery()
                Dim VATBulkCopy As SqlBulkCopy = New SqlBulkCopy(SqlConnection)
                VATBulkCopy.DestinationTableName = "TripLog"
                VATBulkCopy.BulkCopyTimeout = 600000
                Dim LOTMapping As New SqlBulkCopyColumnMapping("LOT", "LOT")
                Dim SELLERMapping As New SqlBulkCopyColumnMapping("SELLER", "SELLER")
                Dim TYPEMapping As New SqlBulkCopyColumnMapping("TYPE", "TYPE")
                Dim DRIVERTYPEMapping As New SqlBulkCopyColumnMapping("DRIVERTYPE", "DRIVERTYPE")
                Dim TRIPZONEMapping As New SqlBulkCopyColumnMapping("TRIPZONE", "TRIPZONE")
                Dim COMMISSIONMapping As New SqlBulkCopyColumnMapping("COMMISSION", "COMMISSION")

                VATBulkCopy.ColumnMappings.Add(LOTMapping)
                VATBulkCopy.ColumnMappings.Add(SELLERMapping)
                VATBulkCopy.ColumnMappings.Add(TYPEMapping)
                VATBulkCopy.ColumnMappings.Add(DRIVERTYPEMapping)
                VATBulkCopy.ColumnMappings.Add(TRIPZONEMapping)
                VATBulkCopy.ColumnMappings.Add(COMMISSIONMapping)
                VATBulkCopy.WriteToServer(CDTripDataTable)
                CDTripDataTable = Nothing
            End If
            StatusLabel.Text = "CD Trip Data Saved."
        Catch ex As Exception
            MessageBox.Show("30:" & ex.Message)
        Finally
            SqlConnection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles SecondStepData.Click
        Try
            Me.BGGetSecondStepData.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BGGetInitialData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGGetInitialData.RunWorkerCompleted
        Try
            Me.SecondStepData.Enabled = True
            Me.GetData.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BGGetSecondStepData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGGetSecondStepData.RunWorkerCompleted
        Try
            Me.SecondStepData.Enabled = False
            StatusLabel.Text = "All Processes Complete."
        Catch ex As Exception

        End Try
    End Sub
End Class
