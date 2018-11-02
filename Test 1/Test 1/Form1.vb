Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objWS As Test_Web_Service.WebService1 = New Test_Web_Service.WebService1()
        Dim intNum1 As Integer = 1
        Dim intNum2 As Integer = 4
        Dim intSum As Integer = objWS.HelloWorld(intNum1, intNum2)
        MessageBox.Show(intSum)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim svcdbMCS_MobilityLog As New dbsMCS_Global.dbMCS_MobilityLog()
        'Dim dsMCS_MobilityLog As dbsMCS_Global.dsMCS_MobilityLog

        'Try
        '    dsMCS_MobilityLog = svcdbMCS_MobilityLog.FillDataSet1("")
        '    Dim strText As String = ""
        '    MessageBox.Show(dsMCS_MobilityLog.MCS_MobilityLog.Rows.count)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        while true

        End While

        Dim dbConn As SqlConnection
        Dim cmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim strConn As String = "Data Source=hxdecoprodbls1;Initial Catalog=hxdb;Integrated Security=SSPI;"
        Try
            dbConn = New SqlConnection(strConn)
            cmd = dbConn.CreateCommand()
            cmd.CommandText = "select top 1 * from MCS_MRLine order by CreateDatetime desc"
            dbConn.Open()

            myReader = cmd.ExecuteReader()

            While myReader.Read()
                MessageBox.Show("mrNo:" & myReader.GetString(0))
            End While

            myReader.Close()
            dbConn.Close()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        






    End Sub
End Class
