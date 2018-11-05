Imports System.Data.SqlClient
Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Dim strConnectionString As String = "Data Source=hxdecoprodbls1;Initial Catalog=hxdb;Integrated Security=SSPI;"
    Dim WithEvents timerFetch As New Timer()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '5 mins
        timerFetch.Interval = 1000 * 5
    End Sub

    Private Sub fetchDB(ByVal a_strSql As String, ByVal a_strType As String)
        Dim dbadpter As SqlDataAdapter
        Dim dbconn As SqlConnection
        Dim dsTable As DataSet
        Dim blnHasData As Boolean = False
        Dim strRunTime As String = DateTime.Now.ToString("yyyMMddHHmmss")

        Dim objReturn As New Hashtable()
        objReturn.Add("Type", a_strType)

        Dim strJson As String = ""
        Dim strFilename As String = a_strType & " " & strRunTime & ".txt"
        Dim strMsg As String = a_strType


        Try
            dbconn = New SqlConnection(strConnectionString)
            dbconn.Open()
            dbadpter = New SqlDataAdapter(a_strSql, dbconn)
            dsTable = New DataSet()
            dbadpter.Fill(dsTable)

            If dsTable.Tables(0).Rows.Count > 0 Then
                blnHasData = True

                Dim arrCols(dsTable.Tables(0).Columns.Count - 1) As String
                Dim arrData(dsTable.Tables(0).Rows.Count - 1) As Hashtable

                Dim intIndex As Integer = 0
                For Each dtCol As DataColumn In dsTable.Tables(0).Columns
                    arrCols(intIndex) = dtCol.ColumnName
                    intIndex += 1
                Next
                'save data


                Dim intRowIndex As Integer = 0
                For intRowIndex = 0 To dsTable.Tables(0).Rows.Count - 1
                    Dim intColIndex As Integer = 0
                    Dim objData As New Hashtable()
                    For intColIndex = 0 To arrCols.Length - 1

                        objData.Add(arrCols(intColIndex), dsTable.Tables(0).Rows(intRowIndex).Item(intColIndex))
                    Next
                    arrData(intRowIndex) = objData
                Next
                objReturn.Add("Data",arrData)
                If arrData.Length Then

                    strJson = JsonConvert.SerializeObject(objReturn)
                    saveToFile(strFilename, strJson)
                    strMsg = " File:" & strFilename & " saved"

                Else
                    strMsg &= " data fetched, but cant convert into json"
                End If
            End If

            If blnHasData = False Then
                strMsg &= " no data fetched"
            End If
            txtHistory.AppendText(strMsg & vbNewLine)
            txtHistory.ScrollToCaret()
            dbconn.Close()
        Catch ex As Exception
            Dim strErr As String = ex.Message
            txtHistory.AppendText(strRunTime & " Exception: " & strErr & vbNewLine)
            txtHistory.ScrollToCaret()
        Finally
            If Not IsNothing(dbadpter) Then dbadpter.Dispose()
            If Not IsNothing(dsTable) Then dsTable.Dispose()
            If Not IsNothing(dbconn) Then dbconn.Dispose()
        End Try
    End Sub

    Private Function saveToFile(ByVal strFilename As String, ByVal strJson As String) As Boolean
        Dim strPath As String = "C:\Users\318172\Documents\Icon PRD Data Fetch Routing\From\" & strFilename
        Try
            Dim fs As FileStream = File.Create(strPath)
            Dim arrContent As Byte() = System.Text.Encoding.UTF8.GetBytes(strJson)
            fs.Write(arrContent, 0, arrContent.Length)
            fs.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Sub btnStartTimer_Click(sender As Object, e As EventArgs) Handles btnStartTimer.Click
        btnStartTimer.Enabled = False
        btnEndTimer.Enabled = True
        lblRunning.Text = "Running..."
        timerFetch.Start()
    End Sub

    Private Sub btnEndTimer_Click(sender As Object, e As EventArgs) Handles btnEndTimer.Click
        btnStartTimer.Enabled = True
        btnEndTimer.Enabled = False
        lblRunning.Text = ""
        timerFetch.Stop()
    End Sub

    Private Sub timerFetch_Tick(sender As Object, e As EventArgs) Handles timerFetch.Tick
        Dim strSql As String = "select top 2 * from MCS_MRHeader"
        fetchDB(strSql, "MR")
    End Sub
End Class
