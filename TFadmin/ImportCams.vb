Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Sockets
Imports System.Threading

Public Class ImportCams

    Dim serverName As String
    Dim engCount As Integer
    Dim engName As String
    Dim camCount As Integer
    Dim CamNames(500) As String
    Dim CamXML(500) As String
    Dim CamEngineName(500) As String

    Dim MilestoneUser As String
    Dim MilestonePass As String
    Dim MilestoneIP As String

    Dim slp As Integer = 1500


    Private Sub EngineManager_onAsynchronousEngineQueryComplete(sender As Object, e As AxEngineManagerLib._DEngineManagerEvents_onAsynchronousEngineQueryCompleteEvent) Handles EngineManager.onAsynchronousEngineQueryComplete
        Dim sqlConn As New SqlConnection(MainAdmin.sqlConString)

        Debug.Print("Asyn return")
        engCount = EngineManager.GetEngineCount()
        If engCount = 0 Then
            Beep()
            Status.Text = "Failed to Connect to Milestone"
            ExitBtn.Enabled = True
            Exit Sub 'no server engines
        End If
        engName = EngineManager.GetEngineName(0)
        camCount = EngineManager.GetCameraCount(engName)
        If camCount = 0 Then
            Beep()
            Status.Text = "Failed to find any Cameras"
            ExitBtn.Enabled = True
            Exit Sub 'no cameras reported
        End If

        Status.Text = "Getting Camera Details"
        Me.Update() : System.Threading.Thread.Sleep(slp)

        For lop = 0 To camCount - 1
            CamNames(lop) = EngineManager.GetCameraName(engName, lop)
            CamXML(lop) = EngineManager.GetCameraConfigurationXml(engName, CamNames(lop))
            CamEngineName(lop) = engName
        Next
        Debug.Print("eng:" & engCount & " cams:" & camCount)

        '        Dim Xml = EngineManager.GetCameraConfigurationXml(engName, CamNames(1))

        Status.Text = "Got " & camCount & " Cameras from Milestone Server"
        Me.Update() : System.Threading.Thread.Sleep(slp)

        Status.Text = "Saving Camera Details"
        Me.Update() : System.Threading.Thread.Sleep(slp)

        sqlConn.Open()
        Dim upS = "Update TFcams set CamMileValid='N'"
        Dim cmd = New SqlCommand(upS, sqlConn)
        Dim NoRec As Integer
        NoRec = cmd.ExecuteNonQuery()
        Debug.Print("Records CamsFlagged invalid: " & NoRec)
        sqlConn.Close()
        Dim NoUpdated As Integer = 0
        Dim NoAdded As Integer = 0
        Dim MaxNo As Integer

        sqlConn.Open()
        Dim rs As SqlDataReader
        cmd = New SqlCommand("SELECT max(CamNo) as MaxNO FROM TFcams", sqlConn)
        rs = cmd.ExecuteReader
        If rs.HasRows Then
            rs.Read()
            If IsDBNull(rs("MaxNO")) Then
                MaxNo = 1
            Else
                MaxNo = rs("MaxNo") + 1
            End If
        End If
        rs.Close()
        rs = Nothing
        sqlConn.Close()

        For lop = 0 To camCount - 1
            sqlConn.Open()
            upS = "Update TFcams set CamMileValid='Y',CamMileXML=@CamMileXML,CamMileEngineName=@CamMileEngineName where CamMileName=@CamMileName"
            cmd = New SqlCommand(upS, sqlConn)
            cmd.Parameters.Add(New SqlParameter("@CamMileXML", CamXML(lop)))
            cmd.Parameters.Add(New SqlParameter("@CamMileName", CamNames(lop)))
            cmd.Parameters.Add(New SqlParameter("@CamMileEngineName", CamEngineName(lop)))
            NoRec = cmd.ExecuteNonQuery()
            sqlConn.Close()
            If NoRec > 0 Then NoUpdated = NoUpdated + 1
            If NoRec = 0 Then
                sqlConn.Open()
                NoAdded = NoAdded + 1
                upS = "Insert into TFcams (CamNo,CamName,CamMileName,CamMileXML,CamMileEngineName,CamArea,CamX,CamY,CamMileValid,CamFault) values (@CamNo,@CamName,@CamMileName,@CamMileXML,@CamMileEngineName,0,0,0,'Y','')"
                cmd = New SqlCommand(upS, sqlConn)
                cmd.Parameters.Add(New SqlParameter("@CamNo", MaxNo))
                cmd.Parameters.Add(New SqlParameter("@CamName", CamNames(lop)))
                cmd.Parameters.Add(New SqlParameter("@CamMileName", CamNames(lop)))
                cmd.Parameters.Add(New SqlParameter("@CamMileXML", CamXML(lop)))
                cmd.Parameters.Add(New SqlParameter("@CamMileEngineName", CamEngineName(lop)))
                MaxNo = MaxNo + 1
                NoRec = cmd.ExecuteNonQuery()
                sqlConn.Close()
            End If
        Next

        Status.Text = "Camera Import Successful" + vbCrLf & NoAdded & " Records Added. " & NoUpdated & " Records Updated."
        ExitBtn.Enabled = True

        '        ImageViewer.SetXmlEncoding(EngineManager.GetEncoding())
        '        ImageViewer.ConnectUsingCameraConfigurationXml("admin", "468346", Xml)
    End Sub

    'Private Sub ImageViewer_onConnectResponseReceived(sender As Object, e As AxImageViewerLib._DImageViewerEvents_onConnectResponseReceivedEvent) Handles ImageViewer.onConnectResponseReceived
    '    If e.bConnectionGranted = 1 Then ImageViewer.LiveStart()
    '    Debug.Print("connect response:" & e.bConnectionGranted)
    'End Sub

    Private Sub ImportCams_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Status.Text = "Connecting to Milestone"
        Me.Update()
        System.Threading.Thread.Sleep(slp)

        Try
            EngineManager.Init()
            ImageViewer.Init()
            ImageViewer.SetOnConnectResponseReceivedEventStatus(True)
            ImageViewer.SetOnImageReceivedEventStatus(False)
            'imageViewer.SetOnAlarmsReceivedEventStatus(true)
            ImageViewer.SetOnAviInfoReceivedEventStatus(1)
            ImageViewer.SetOnExportCompletedEventStatus(1)

            EngineManager.SetAuthentication(0)
            serverName = "test"

            MilestoneUser = MainAdmin.MileUser.Text
            MilestonePass = MainAdmin.MilePass.Text
            MilestoneIP = MainAdmin.MileIP.Text
            serverName = EngineManager.QueryEngineAsynchronous(MilestoneUser, MilestonePass, MilestoneIP + "/systeminfo.xml")
        Catch
            Beep()
            Status.Text = "Failed to Connect to Milestone"
            ExitBtn.Enabled = True
        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ImageViewer_onConnectResponseReceived(sender As Object, e As AxImageViewerLib._DImageViewerEvents_onConnectResponseReceivedEvent) Handles ImageViewer.onConnectResponseReceived
        If e.bConnectionGranted = 1 Then ImageViewer.LiveStart()
        Debug.Print("connect response:" & e.bConnectionGranted)
    End Sub


End Class

'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
'    Debug.Print("hello")
'    EngineManager.Init()
'    ImageViewer.Init()
'    ImageViewer.SetOnConnectResponseReceivedEventStatus(True)
'    ImageViewer.SetOnImageReceivedEventStatus(False)
'    ImageViewer.SetOnAviInfoReceivedEventStatus(1)
'    ImageViewer.SetOnExportCompletedEventStatus(1)

'    EngineManager.SetAuthentication(0)
'    serverName = "test"
'    serverName = EngineManager.QueryEngineAsynchronous("admin", "468346", "http://192.168.40.131" + "/systeminfo.xml")
'    Debug.Print(serverName)
'End Sub

'Private Sub EngineManager_onAsynchronousEngineQueryComplete(sender As Object, e As AxEngineManagerLib._DEngineManagerEvents_onAsynchronousEngineQueryCompleteEvent) Handles EngineManager.onAsynchronousEngineQueryComplete
'    Debug.Print("Asyn return")
'    engCount = EngineManager.GetEngineCount()
'    If engCount = 0 Then Exit Sub 'no server engines
'    engName = EngineManager.GetEngineName(0)
'    camCount = EngineManager.GetCameraCount(engName)
'    If camCount = 0 Then Exit Sub 'no cameras reported
'    For lop = 0 To camCount - 1
'        CamNames(lop) = EngineManager.GetCameraName(engName, lop)
'    Next
'    Debug.Print("eng:" & engCount & " cams:" & camCount)

'    Dim Xml = EngineManager.GetCameraConfigurationXml(engName, CamNames(1))
'    ImageViewer.SetXmlEncoding(EngineManager.GetEncoding())
'    ImageViewer.ConnectUsingCameraConfigurationXml("admin", "468346", Xml)
'End Sub

