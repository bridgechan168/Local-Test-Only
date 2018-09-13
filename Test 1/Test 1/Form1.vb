Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objWS As Test_Web_Service.WebService1 = New Test_Web_Service.WebService1()
        Dim intNum1 As Integer = 1
        Dim intNum2 As Integer = 4
        Dim intSum As Integer = objWS.HelloWorld(intNum1,intNum2)
        MessageBox.Show(intSum)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim svcdbMCS_MobilityLog As New dbsMCS_Global.dbMCS_MobilityLog()
        Dim dsMCS_MobilityLog As dbsMCS_Global.dsMCS_MobilityLog = svcdbMCS_MobilityLog.FillDataSet("","",0,"")
        Dim strText As String = ""
        
    End Sub
End Class
