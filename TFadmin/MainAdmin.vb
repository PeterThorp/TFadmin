
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Sockets
Imports System.Threading

Public Class MainAdmin
    '    Public sqlConString As String = "Data Source=10.101.19.30\TRYFAN;Initial Catalog=TRYFANdb;Persist Security Info=True;User ID=sa;Password=tryfansaaccount"
    Public sqlConString As String = "Data Source=10.101.19.30\TRYFAN;Initial Catalog=TRYFANdb;Persist Security Info=True;User ID=sa;Password=tryfansaaccount"

    Public ActionTag As String
    Public previewBitmap As Bitmap
    Public myBmp As Bitmap
    Public WelcomeText As String
    Public DisplayPage As String
    Public EditMode As String
    Public EditNo As Integer
    Public AllowDROPupdates As Boolean

    Public CurrentCam As Integer
    Public CurrentPreviewCamNo As Integer = 0
    Public CurrentCamMileName As String
    Public CurrentEngineName As String

    Dim DBnoAreas As Integer
    Dim DBareaNo(500) As Integer
    Dim DBareaName(500) As String
    Dim DBareaFile(500) As String

    Dim serverName As String
    Dim engCount As Integer
    Dim engName As String
    Dim camCount As Integer
    Dim MilestoneUser As String
    Dim MilestonePass As String
    Dim MilestoneIP As String

    Dim DBNoCams As Integer
    Dim DBcamNo(500) As Integer
    Dim DBcamArea(500) As Integer
    Dim DBcamX(500) As Integer
    Dim DBcamY(500) As Integer
    Dim DBcamNames(500) As String
    Dim DBcamMileName(500) As String
    Dim DBCamXML(500) As String
    Dim DBCamEngineName(500) As String

    Dim DBNoZones As Integer
    Dim DBzoneNo(500) As Integer
    Dim DBzoneName(500) As String
    Dim DBzoneType(500) As Integer
    Dim DBzoneArea(500) As Integer
    Dim DBzoneCam(500) As Integer

    Private Sub MainAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load

        'start up camera objects
        EngineManager.Init()
        ImageViewer.Init()
        ImageViewer.SetOnConnectResponseReceivedEventStatus(True)
        ImageViewer.SetOnImageReceivedEventStatus(False)
        ImageViewer.SetOnAviInfoReceivedEventStatus(1)
        ImageViewer.SetOnExportCompletedEventStatus(1)
        EngineManager.SetAuthentication(0)

        'Load Data
        Try
            LoadParameters()
            LoadAllAreas()
            LoadAllCams()
            LoadAllzones()
        Catch
            Beep()
            MessageBox.Show("FAILED TO CONNECT TO TRYFAN DATABASE SERVER" + vbCrLf + "Check Network & Firewall Settings")
            Application.Exit()
            End
        End Try
        MilestoneUser = MileUser.Text
        MilestonePass = MilePass.Text
        MilestoneIP = MileIP.Text
        serverName = EngineManager.QueryEngineAsynchronous(MilestoneUser, MilestonePass, MilestoneIP + "/systeminfo.xml")

        'Display Welcome Page
        AreaBox.Cursor = Cursors.Default
        DisplayPage = "WelcomePage" : WelcomeText = "" : EditMode = "View"
        DisplayPannel()
    End Sub

    Private Sub EnableEdit_CheckedChanged(sender As Object, e As EventArgs) Handles EnableEdit.CheckedChanged
        If EnableEdit.Enabled = False Then Exit Sub
        If EnableEdit.Checked = True Then
            EditMode = "Edit"
        Else
            EditMode = "View"
        End If
        DisplayPannel()
    End Sub

    Private Sub MainTree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles MainTree.AfterSelect
        Select Case Strings.Left(e.Node.Tag + "        ", 8)
            Case "Welcome "
                DisplayPage = "WelcomePage" : WelcomeText = "" : EditMode = "View"
                DisplayPannel()
            Case "sysParam"
                DisplayPage = "sysParam" : EditMode = "View"
                DisplayPannel()
            Case "---Area:"
                Dim Newtag As String
                Newtag = e.Node.Tag
                EditNo = Val(Strings.Right(Newtag, Strings.Len(Newtag) - 8))
                LoadSingleArea()
                DisplayPage = "areaPage" : EditMode = "View"
                DisplayPannel()
            Case "----Cam:"
                Dim Newtag As String
                Newtag = e.Node.Tag
                EditNo = Val(Strings.Right(Newtag, Strings.Len(Newtag) - 8))
                LoadSingleCam()
                DisplayPage = "cameraPage" : EditMode = "View"
                DisplayPannel()
                CameraPreview(EditNo)
            Case "---Zone:"
                Dim Newtag As String
                Newtag = e.Node.Tag
                EditNo = Val(Strings.Right(Newtag, Strings.Len(Newtag) - 8))
                LoadSingleZone()
                DisplayPage = "zonePage" : EditMode = "View"
                DisplayPannel()
        End Select
    End Sub

    Private Sub DisplayPannel()
        'hide all pannels
        WelcomePage.Visible = False
        sysParamsPage.Visible = False
        AreaPage.Visible = False
        CameraPage.Visible = False
        zonePage.Visible = False

        Select Case DisplayPage
            Case "WelcomePage"
                WelcomePage.Visible = True
                WelcomePage.Location = New Point(225, 32)
                WelcomePage.Size = New Size(627, 561)
                PanelName.Text = "Welcome"
                If WelcomeText = "" Then WelcomeLbl.Text = "Welcome to Tryfan System Admin" Else WelcomeLbl.Text = WelcomeText
                WelcomePage.Enabled = False
                EditMode = "View"
                CamIcon.Visible = False
                ZoneIcon.Visible = False
            Case "cameraPage"
                CameraPage.Visible = True
                CameraPage.Location = New Point(225, 32)
                CameraPage.Size = New Size(627, 561)
                PanelName.Text = "Camera Setup"
                ZoneIcon.Visible = False
                If EditMode = "View" Then
                    CameraPage.Enabled = False
                Else 'Enable edit of Camera
                    CameraPage.Enabled = True
                End If
            Case "zonePage"
                zonePage.Visible = True
                zonePage.Location = New Point(225, 32)
                zonePage.Size = New Size(627, 561)
                PanelName.Text = "Zone Setup"
                If EditMode = "View" Then
                    zonePage.Enabled = False
                Else 'Enable edit of Camera
                    zonePage.Enabled = True
                End If
            Case "areaPage"
                AreaPage.Visible = True
                AreaPage.Location = New Point(225, 32)
                AreaPage.Size = New Size(627, 561)
                PanelName.Text = "Define Area"
                If EditMode = "View" Then
                    AreaPage.Enabled = False
                Else 'Enable edit of area
                    AreaPage.Enabled = True
                End If
                CamIcon.Visible = False
                ZoneIcon.Visible = False
            Case "sysParam"
                sysParamsPage.Visible = True
                sysParamsPage.Location = New Point(225, 32)
                sysParamsPage.Size = New Size(627, 561)
                PanelName.Text = "System Parameters"
                If EditMode = "View" Then
                    sysParamsPage.Enabled = False
                Else 'Enable edit of sysParams
                    sysParamsPage.Enabled = True
                End If
                CamIcon.Visible = False
                ZoneIcon.Visible = False
        End Select
        If EditMode = "View" Then
            MainTree.Enabled = True
            EnableEdit.Enabled = True
            EnableEdit.Checked = False
            If DisplayPage = "WelcomePage" Then EnableEdit.Enabled = False
        Else
            MainTree.Enabled = False
            EnableEdit.Enabled = False
            EnableEdit.Checked = True
        End If
    End Sub

#Region "ParametersPage"

    Private Sub LoadParameters()
        Try
            Dim sqlConn As New SqlConnection(sqlConString)
            sqlConn.Open()
            Dim cmd As New SqlCommand("SELECT top 1 * FROM sysParams", sqlConn)
            Dim rs As SqlDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                Do While rs.Read
                    MileIP.Text = rs("MileIP")
                    MileUser.Text = rs("MileUser")
                    MilePass.Text = rs("MilePass")
                    AlarmIP.Text = rs("AlarmIP")
                    AlarmPort.Text = rs("AlarmPort")
                    AlarmPass.Text = rs("AlarmPass")
                    Net2IP.Text = rs("Net2IP")
                    Net2Port.Text = rs("Net2Port")
                    Net2User.Text = rs("Net2User")
                    Net2Pass.Text = rs("Net2Pass")
                Loop
            End If
            sqlConn.Close()
        Catch
        End Try
    End Sub


    Private Sub CancelParams_Click(sender As Object, e As EventArgs) Handles CancelParams.Click
        LoadParameters() 'reload parameters
        EditMode = "View"
        DisplayPannel()
    End Sub

    Private Sub saveParams_Click(sender As Object, e As EventArgs) Handles saveParams.Click
        Try
            Dim sqlConn As New SqlConnection(sqlConString)
            sqlConn.Open()
            Dim upS = "update sysParams SET MileIP=@MileIP, MileUser=@MileUser, MilePass=@MilePass,AlarmIP=@AlarmIP,AlarmPort=@AlarmPort,AlarmPass=@AlarmPass,Net2IP=@Net2IP," & _
                "Net2Port=@Net2Port,Net2User=@Net2User,Net2Pass=@Net2Pass"
            Dim cmd = New SqlCommand(upS, sqlConn)
            cmd.Parameters.Add(New SqlParameter("MileIP", MileIP.Text))
            cmd.Parameters.Add(New SqlParameter("MileUser", MileUser.Text))
            cmd.Parameters.Add(New SqlParameter("MilePass", MilePass.Text))
            cmd.Parameters.Add(New SqlParameter("AlarmIP", AlarmIP.Text))
            cmd.Parameters.Add(New SqlParameter("AlarmPort", AlarmPort.Text))
            cmd.Parameters.Add(New SqlParameter("AlarmPass", AlarmPass.Text))
            cmd.Parameters.Add(New SqlParameter("Net2IP", Net2IP.Text))
            cmd.Parameters.Add(New SqlParameter("Net2Port", Net2Port.Text))
            cmd.Parameters.Add(New SqlParameter("Net2User", Net2User.Text))
            cmd.Parameters.Add(New SqlParameter("Net2Pass", Net2Pass.Text))
            Dim NoRec As Integer
            NoRec = cmd.ExecuteNonQuery()
            Debug.Print("Records Updated: " & NoRec)
            sqlConn.Close()
            EditMode = "View"
            DisplayPannel()
        Catch ex As Exception
            MessageBox.Show("Unable to Save Details, Check Fields are valid", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "AreaPage"

    Private Sub AddAreaAdd_Click(sender As Object, e As EventArgs) Handles AddAreaAdd.Click
        AreaNo.Text = ""
        AreaName.Text = ""
        AreaFile.Text = ""
        AreaBox.Image = Nothing
        AreaPreLbl.Text = "Set file name to load preview"
        '        Try
        Dim sqlConn As New SqlConnection(sqlConString)
        sqlConn.Open()
        Dim cmd As New SqlCommand("SELECT max(areaNo) as MaxNo FROM TFarea", sqlConn)
        Dim rs As SqlDataReader
        rs = cmd.ExecuteReader
        AreaNo.Text = "1"
        If rs.HasRows Then
            rs.Read()
            If IsDBNull(rs("MaxNO")) Then
                AreaNo.Text = "1"
            Else
                AreaNo.Text = rs("MaxNo") + 1
            End If
        End If
        sqlConn.Close()
        'Catch
        'End Try

        DisplayPage = "areaPage"
        EditMode = "New"
        EditNo = -1
        DisplayPannel()
        AreaName.Focus()
    End Sub

    Private Sub LoadSingleArea()
        AreaNo.Text = ""
        AreaName.Text = ""
        AreaFile.Text = ""
        AreaBox.Image = Nothing
        AreaPreLbl.Text = "Set file name to load preview"
        Dim sqlConn As New SqlConnection(sqlConString)
        sqlConn.Open()
        Dim cmd As New SqlCommand("SELECT * from TFarea where AreaNo=" & EditNo, sqlConn)
        Dim rs As SqlDataReader
        rs = cmd.ExecuteReader
        If rs.HasRows Then
            rs.Read()
            AreaNo.Text = "" & rs("AreaNo")
            AreaName.Text = rs("AreaName")
            AreaFile.Text = rs("AreaFile")
        End If
        sqlConn.Close()
        LoadPreviewFile()
    End Sub

    Private Sub LoadAllAreas()

        Dim MyNode() As TreeNode
        MyNode = MainTree.Nodes.Find("SysAreas", True)
        MyNode(0).Nodes.Clear()

        Dim sqlConn As New SqlConnection(sqlConString)
        sqlConn.Open()
        Dim cmd As New SqlCommand("SELECT * FROM TFarea order by AreaNo", sqlConn)
        Dim rs As SqlDataReader
        rs = cmd.ExecuteReader
        DBnoAreas = 0
        If rs.HasRows Then
            Do While rs.Read
                DBnoAreas = DBnoAreas + 1
                DBareaNo(DBnoAreas) = rs("AreaNo")
                DBareaName(DBnoAreas) = rs("AreaName")
                DBareaFile(DBnoAreas) = rs("AreaFile")

                Dim nod As New TreeNode()
                nod.Name = "" & rs("AreaNo") & ". " & rs("AreaName")
                nod.Text = "" & rs("AreaNo") & ". " & rs("AreaName")
                nod.Tag = "---Area: " & rs("AreaNo")
                nod.ContextMenuStrip = DeleteArea
                MyNode(0).Nodes.Add(nod)
            Loop
        End If
        sqlConn.Close()
    End Sub

    Private Sub BrowseFile_Click(sender As Object, e As EventArgs) Handles BrowseFile.Click
        OpenFile.Title = "Open File Dialog"
        OpenFile.InitialDirectory = "C:\"
        OpenFile.Filter = "Flash Files (*.swf)|*.swf"
        OpenFile.FilterIndex = 2
        OpenFile.RestoreDirectory = True
        If OpenFile.ShowDialog() = DialogResult.OK Then
            AreaFile.Text = OpenFile.FileName
            LoadPreviewFile()
        End If
    End Sub
    Private Sub LoadPreviewFile()
        Dim bmpName As String
        AreaBox.Image = Nothing
        Try
            bmpName = Strings.Left(AreaFile.Text, AreaFile.Text.Length - 3) + "bmp"
            Debug.Print(bmpName)
            Dim bm As New Bitmap(bmpName)
            AreaBox.Image = bm
            AreaPreLbl.Text = "Area Preview: " + AreaName.Text
        Catch ex As Exception
            AreaPreLbl.Text = "Area Preview Failed"
        End Try
    End Sub

    Private Sub saveAreaBtn_Click(sender As Object, e As EventArgs) Handles saveAreaBtn.Click
        Dim sqlConn As New SqlConnection(sqlConString)

        If Not IsNumeric(AreaNo.Text) Or AreaName.Text = "" Or AreaFile.Text = "" Then
            MessageBox.Show("Unable to Save Details, Check Fields are valid", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End If
        If Val(AreaNo.Text) < 1 Then
            MessageBox.Show("Unable to Save Details, Check Fields are valid", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End If
        If EditMode = "Edit" And EditNo = Val(AreaNo.Text) Then
            'no need to see if areaNo already exists, we are saving the orgional
        Else
            'see if we are trying to overwrite an existing area
            sqlConn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM TFarea where areaNo=" & AreaNo.Text, sqlConn)
            Dim rs As SqlDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                sqlConn.Close()
                MessageBox.Show("Area Number already exists. Delete or renumber existing area first", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            Else
                sqlConn.Close()
            End If
        End If
        If EditMode = "New" Then
            sqlConn.Open()
            Dim upS = "insert into TFarea (AreaNo, AreaName, AreaFile) values (@AreaNo,@AreaName,@AreaFile)"
            Dim cmd = New SqlCommand(upS, sqlConn)
            cmd.Parameters.Add(New SqlParameter("AreaNo", Val(AreaNo.Text)))
            cmd.Parameters.Add(New SqlParameter("AreaName", AreaName.Text))
            cmd.Parameters.Add(New SqlParameter("AreaFile", AreaFile.Text))
            Dim NoRec As Integer
            NoRec = cmd.ExecuteNonQuery()
            Debug.Print("Records Updated: " & NoRec)
            sqlConn.Close()
            EditNo = Val(AreaNo.Text)
            EditMode = "View"
            DisplayPannel()
            LoadAllAreas()
        Else 'update old record
            sqlConn.Open()
            Dim upS = "Update TFarea set AreaNo=@AreaNo, AreaName=@AreaName, AreaFile=@AreaFile where AreaNo=" & EditNo
            Dim cmd = New SqlCommand(upS, sqlConn)
            cmd.Parameters.Add(New SqlParameter("AreaNo", Val(AreaNo.Text)))
            cmd.Parameters.Add(New SqlParameter("AreaName", AreaName.Text))
            cmd.Parameters.Add(New SqlParameter("AreaFile", AreaFile.Text))
            Dim NoRec As Integer
            NoRec = cmd.ExecuteNonQuery()
            Debug.Print("Records Updated: " & NoRec)
            sqlConn.Close()
            EditNo = Val(AreaNo.Text)
            EditMode = "View"
            DisplayPannel()
            LoadAllAreas()
        End If
    End Sub

    Private Sub CancelArea_Click(sender As Object, e As EventArgs) Handles CancelSaveArea.Click
        If EditMode = "New" Then
            DisplayPage = "WelcomePage" : WelcomeText = "Define New Area Cancelled"
            EditMode = "View"
            DisplayPannel()
        Else
            EditMode = "View" : LoadSingleArea()
            DisplayPannel()
        End If
    End Sub

    Private Sub DoDeleteArea_Click(sender As Object, e As EventArgs) Handles DoDeleteArea.Click
        Dim sqlConn As New SqlConnection(sqlConString)
        EditNo = Val(Strings.Right(DeleteArea.Tag, Strings.Len(DeleteArea.Tag) - 8))
        Dim DelAreaName = ""
        Dim lop
        For lop = 1 To DBnoAreas
            If DBareaNo(lop) = EditNo Then DelAreaName = "" & EditNo & ". " & DBareaName(lop) : Exit For
        Next
        If DelAreaName = "" Then Exit Sub
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete Area: " & DelAreaName, "Warning Delete Area", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = 6 Then
            'go ahead delete the area
            EditNo = Val(Strings.Right(DeleteArea.Tag, Strings.Len(DeleteArea.Tag) - 8))
            sqlConn.Open()
            Dim upS = "Delete from TFarea where AreaNo=" & EditNo
            Dim cmd = New SqlCommand(upS, sqlConn)
            Dim NoRec As Integer
            NoRec = cmd.ExecuteNonQuery()
            Debug.Print("Records Updated: " & NoRec)
            sqlConn.Close()
            LoadAllAreas()
            DisplayPage = "WelcomePage"
            WelcomeText = "Area Deleted"
            EditMode = "View"
            DisplayPannel()
        End If
    End Sub

#End Region

#Region "CameraPage"

    Private Sub ImportCams_Click(sender As Object, e As EventArgs) Handles ImportCams.Click
        Dim mydialogbox As New ImportCams
        mydialogbox.ShowDialog()
        LoadAllCams()
    End Sub

    Private Sub LoadSingleCam()
        CamNo.Text = ""
        CamName.Text = ""
        CamMileName.Text = ""
        AreaBox.Image = Nothing
        AreaPreLbl.Text = "Select Area"

        Dim sqlConn As New SqlConnection(sqlConString)
        sqlConn.Open()
        Dim cmd As New SqlCommand("SELECT * from TFcams where CamNo=" & EditNo, sqlConn)
        Dim rs As SqlDataReader
        rs = cmd.ExecuteReader
        If rs.HasRows Then
            rs.Read()
            CamNo.Text = "" & rs("CamNo")
            CamName.Text = rs("CamName")
            CamMileName.Text = rs("CamMileName")
            If rs("CamMileValid") = "Y" Then CamValid.Text = "Valid" Else CamValid.Text = "Not Valid"

            CameraArea.Items.Clear()
            CameraArea.Items.Add("No Area Assigned")
            CameraArea.SelectedIndex = 0
            If DBnoAreas > 0 Then
                For lop = 1 To DBnoAreas
                    CameraArea.Items.Add("" & DBareaNo(lop) & ". " & DBareaName(lop))
                    If rs("CamArea") = DBareaNo(lop) Then CameraArea.SelectedIndex = lop
                Next
            End If
            If rs("CamX") > 0 And rs("CamY") > 0 Then
                CamX.Text = Str(rs("CamX")) : CamY.Text = Str(rs("CamY"))
            Else
                CamX.Text = "" : CamY.Text = ""
            End If
        End If
        sqlConn.Close()
        CamSetEnable.Checked = False

        If CameraArea.SelectedIndex = 0 Then
            CamSetEnable.Visible = False
            CamSetlbl1.Visible = False
            CamSetLbl3.Visible = False
            CamSetEnable.Checked = False
            CamX.Visible = False
            CamY.Visible = False
        Else
            CamSetEnable.Visible = True
            CamSetlbl1.Visible = True
            CamSetLbl3.Visible = True
            CamX.Visible = True
            CamY.Visible = True
        End If
        If CamSetEnable.Checked = True Then
            CamSetLbl2.Visible = True
            AreaBox.Cursor = Cursors.Cross
        Else
            CamSetLbl2.Visible = False
            AreaBox.Cursor = Cursors.Default
        End If

        UpdatePreview()

    End Sub

    Private Sub CamSetEnable_CheckedChanged(sender As Object, e As EventArgs) Handles CamSetEnable.CheckedChanged
        If CamSetEnable.Checked = True Then
            CamSetLbl2.Visible = True
            AreaBox.Cursor = Cursors.Cross
        Else
            CamSetLbl2.Visible = False
            AreaBox.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub CameraArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CameraArea.SelectedIndexChanged
        ChangeArea()
    End Sub

    Private Sub ChangeArea()

        If CameraArea.SelectedIndex = 0 Then
            CamSetEnable.Visible = False
            CamSetlbl1.Visible = False
            CamSetLbl3.Visible = False
            CamSetEnable.Checked = False
            CamX.Visible = False
            CamY.Visible = False
            AreaBox.Image = Nothing
            AreaPreLbl.Text = "Select Area"
        Else
            CamSetEnable.Visible = True
            CamSetlbl1.Visible = True
            CamSetLbl3.Visible = True
            CamSetEnable.Checked = True
            CamX.Text = "" : CamY.Text = ""
            CamX.Visible = True
            CamY.Visible = True
        End If
        If CamSetEnable.Checked = True Then
            CamSetLbl2.Visible = True
            AreaBox.Cursor = Cursors.Cross
        Else
            CamSetLbl2.Visible = False
            AreaBox.Cursor = Cursors.Default
        End If
        UpdatePreview()
    End Sub
    Private Sub AreaBox_MouseDown(sender As Object, e As MouseEventArgs) Handles AreaBox.MouseDown
        If DisplayPage = "cameraPage" And CamSetEnable.Checked = True Then
            CamX.Text = e.X.ToString : CamY.Text = e.Y.ToString
            CamIcon.Parent = AreaBox
            CamIcon.Left = e.X - 10
            CamIcon.Top = e.Y - 10
            CamIcon.Visible = True
        End If
        If DisplayPage = "zonePage" And zoneSetEnable.Checked = True Then
            zoneX.Text = e.X.ToString : zoneY.Text = e.Y.ToString
            ZoneIcon.Parent = AreaBox
            ZoneIcon.Left = e.X - 10
            ZoneIcon.Top = e.Y - 10
            ZoneIcon.Visible = True
        End If
    End Sub

    Private Sub UpdatePreview()
        Dim bmpName As String
        ZoneIcon.Visible = False

        If CameraArea.SelectedIndex = 0 Then
            AreaBox.Image = Nothing
            AreaPreLbl.Text = "Select Area"
            CamIcon.Visible = False
        Else
            Try
                bmpName = DBareaFile(CameraArea.SelectedIndex)
                bmpName = Strings.Left(bmpName, Len(bmpName) - 3) + "bmp"
                Dim bm As New Bitmap(bmpName)
                AreaBox.Image = bm
                AreaPreLbl.Text = "Area Preview: " + DBareaName(CameraArea.SelectedIndex)

                If Val(CamX.Text) > 0 And Val(CamY.Text) > 0 Then
                    CamIcon.Parent = AreaBox
                    CamIcon.Left = Val(CamX.Text) - 10
                    CamIcon.Top = Val(CamY.Text) - 10
                    CamIcon.Visible = True
                Else
                    CamIcon.Visible = False
                End If
            Catch ex As Exception
                AreaPreLbl.Text = "Area Preview Failed"
                CamIcon.Visible = False
            End Try
        End If
    End Sub

    Private Sub LoadAllCams()

        Dim MyNode() As TreeNode
        MyNode = MainTree.Nodes.Find("SysCams", True)
        MyNode(0).Nodes.Clear()
        'Try
        Dim sqlConn As New SqlConnection(sqlConString)
        sqlConn.Open()
        Dim cmd As New SqlCommand("SELECT * FROM TFcams order by CamNo", sqlConn)
        Dim rs As SqlDataReader
        rs = cmd.ExecuteReader
        DBNoCams = 0
        If rs.HasRows Then
            Do While rs.Read
                If rs("CamMileValid") = "Y" Then
                    DBNoCams = DBNoCams + 1
                    DBcamNo(DBNoCams) = rs("CamNo")
                    DBcamNames(DBNoCams) = rs("CamName")
                    DBcamArea(DBNoCams) = rs("CamArea")
                    DBcamX(DBNoCams) = rs("CamX")
                    DBcamY(DBNoCams) = rs("CamY")
                    DBcamMileName(DBNoCams) = rs("CamMileName")
                    DBCamXML(DBNoCams) = rs("CamMileXML")
                    DBCamEngineName(DBNoCams) = rs("CamMileEngineName")
                End If
                Dim nod As New TreeNode()
                nod.Name = "" & rs("CamNo") & ". " & rs("CamName")
                nod.Text = "" & rs("CamNo") & ". " & rs("CamName")
                nod.Tag = "----Cam: " & rs("CamNo")
                MyNode(0).Nodes.Add(nod)
            Loop
        End If
        sqlConn.Close()
    End Sub

    Private Sub CancelCamera_Click(sender As Object, e As EventArgs) Handles CancelCamera.Click
        EditMode = "View" : LoadSingleCam()
        DisplayPannel()
    End Sub
    Private Sub SaveCamera_Click(sender As Object, e As EventArgs) Handles SaveCamera.Click
        Dim sqlConn As New SqlConnection(sqlConString)

        If Not IsNumeric(CamNo.Text) Or CamName.Text = "" Then
            MessageBox.Show("Unable to Save Details, Check Fields are valid", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End If
        If Val(CamNo.Text) < 1 Then
            MessageBox.Show("Unable to Save Details, Check Fields are valid", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End If

        Dim cmd As New SqlCommand("SELECT * FROM TFcams where CamNo=" & CamNo.Text, sqlConn)

        If EditMode = "Edit" And EditNo = Val(CamNo.Text) Then
            'no need to see if areaNo already exists, we are saving the orgional
        Else
            'see if we are trying to overwrite an existing area
            sqlConn.Open()
            Dim rs As SqlDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                sqlConn.Close()
                MessageBox.Show("Camera Number already exists. Delete or renumber existing Camera first", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            Else
                sqlConn.Close()
            End If
        End If
        'update old record
        DBareaNo(0) = 0
        sqlConn.Open()
        Dim upS = "Update TFcams set CamNo=@CamNo, CamName=@CamName,CamArea=@CamArea,CamX=@CamX,CamY=@CamY where CamNo=" & EditNo
        cmd = New SqlCommand(upS, sqlConn)
        cmd.Parameters.Add(New SqlParameter("CamNo", Val(CamNo.Text)))
        cmd.Parameters.Add(New SqlParameter("CamName", CamName.Text))
        cmd.Parameters.Add(New SqlParameter("CamArea", DBareaNo(CameraArea.SelectedIndex)))
        cmd.Parameters.Add(New SqlParameter("CamX", Val(CamX.Text)))
        cmd.Parameters.Add(New SqlParameter("CamY", Val(CamY.Text)))
        Dim NoRec As Integer
        NoRec = cmd.ExecuteNonQuery()
        EditNo = Val(CamNo.Text)
        sqlConn.Close()

        CamSetEnable.Checked = False
        CamSetLbl2.Visible = False
        AreaBox.Cursor = Cursors.Default

        EditMode = "View"
        DisplayPannel()
        LoadAllCams()
    End Sub

#End Region

#Region "Camera Preview"

    Private Sub MainTree_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles MainTree.NodeMouseClick
        MainTree.SelectedNode = e.Node
        DeleteArea.Tag = e.Node.Tag
        DeleteZone.Tag = e.Node.Tag
    End Sub

    Private Sub CameraPreview(PreviewCamNo As Integer)
        If PreviewCamNo = 0 Then
            ImageViewer.Visible = False
            CamPreviewLbl.Text = "Camera Preview: (No Camera Selected)"
            Exit Sub
        End If
        If PreviewCamNo = CurrentPreviewCamNo Then Exit Sub 'exit if already Previewing requested camera

        CurrentPreviewCamNo = PreviewCamNo
        Dim lop
        For lop = 1 To DBNoCams
            If DBcamNo(lop) = PreviewCamNo Then
                'Camera Details found
                CamPreviewLbl.Text = "Camera Preview: " & DBcamNames(lop)

                CurrentCamMileName = DBcamMileName(lop)
                CurrentEngineName = DBCamEngineName(lop)
                ImageViewer.Visible = True
                DBCamXML(lop) = EngineManager.GetCameraConfigurationXml(DBCamEngineName(lop), DBcamMileName(lop))
                ImageViewer.SetXmlEncoding(EngineManager.GetEncoding())
                '                ImageViewer.ConnectUsingCameraConfigurationXml("admin", "468346", DBCamXML(lop))
                ImageViewer.ConnectUsingCameraConfigurationXml(MileUser.Text, MilePass.Text, DBCamXML(lop))
                Exit Sub
            End If
        Next
        'Unable to find Camera Details
        ImageViewer.Visible = False
        CamPreviewLbl.Text = "Camera Preview: Unable to find Camera"
    End Sub

    Private Sub ImageViewer_onConnectResponseReceived(sender As Object, e As AxImageViewerLib._DImageViewerEvents_onConnectResponseReceivedEvent) Handles ImageViewer.onConnectResponseReceived
        If e.bConnectionGranted = 1 Then ImageViewer.LiveStart()
        Debug.Print("connect response:" & e.bConnectionGranted)
    End Sub

    Private Sub EngineManager_onLoginTokenChanged(sender As Object, e As AxEngineManagerLib._DEngineManagerEvents_onLoginTokenChangedEvent) Handles EngineManager.onLoginTokenChanged
        Debug.Print("Login Token event")
        Dim Xml As String
        Dim engineName As String
        engineName = EngineManager.GetEngineName(0)
        Xml = EngineManager.GetCameraConfigurationXml(engineName, CurrentCamMileName)
        ImageViewer.SetCameraConfigurationXml(Xml)
    End Sub

    Private Sub EngineManager_onAsynchronousEngineQueryComplete(sender As Object, e As AxEngineManagerLib._DEngineManagerEvents_onAsynchronousEngineQueryCompleteEvent) Handles EngineManager.onAsynchronousEngineQueryComplete
        Debug.Print("Asyn return")
        engCount = EngineManager.GetEngineCount()
        engName = EngineManager.GetEngineName(0)
        camCount = EngineManager.GetCameraCount(engName)
        '        For lop = 0 To camCount - 1
        'CamNames(lop) = EngineManager.GetCameraName(engName, lop)
        'CamXML(lop) = EngineManager.GetCameraConfigurationXml(engName, CamNames(lop))
        'CamEngineName(lop) = engName
        'Next
    End Sub

    'Private Sub EngineManager_onAsynchronousEngineQueryComplete(sender As Object, e As AxEngineManagerLib._DEngineManagerEvents_onAsynchronousEngineQueryCompleteEvent) Handles EngineManager.onAsynchronousEngineQueryComplete
    '    Dim CamNames(500) As String
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

    '    CurrentEngineName = engName : CurrentCamMileName = CamNames(1)
    '    ImageViewer.Visible = True
    '    Dim Xml = EngineManager.GetCameraConfigurationXml(engName, CamNames(1))
    '    ImageViewer.SetXmlEncoding(EngineManager.GetEncoding())
    '    ImageViewer.ConnectUsingCameraConfigurationXml("admin", "468346", Xml)
    'End Sub

#End Region

#Region "Zones"
    Private Sub AddZoneAdd_Click(sender As Object, e As EventArgs) Handles AddZoneAdd.Click
        DisplayPage = "zonePage"
        EditMode = "New"
        EditNo = -1
        LoadSingleZone()
        DisplayPannel()
        ZoneNo.Focus()
    End Sub

    Private Sub LoadSingleZone()
        AllowDROPupdates = False

        ZoneNo.Text = ""
        ZoneName.Text = ""
        ZoneType.SelectedIndex = 0
        zoneX.Text = "" : zoneY.Text = ""

        zoneArea.Items.Clear()
        zoneArea.Items.Add("No Area Assigned")
        zoneArea.SelectedIndex = 0
        If DBnoAreas > 0 Then
            For lop = 1 To DBnoAreas
                zoneArea.Items.Add("" & DBareaNo(lop) & ". " & DBareaName(lop))
            Next
        End If
        ZoneCamera.Items.Clear()
        ZoneCamera.Items.Add("Not Linked")
        ZoneCamera.SelectedIndex = 0
        For lop = 1 To DBNoCams
            ZoneCamera.Items.Add("" & DBcamNo(lop) & ". " & DBcamNames(lop))
        Next

        AreaBox.Image = Nothing
        AreaPreLbl.Text = "Select Area"

        Dim sqlConn As New SqlConnection(sqlConString)
        sqlConn.Open()
        Dim cmd As New SqlCommand("SELECT * from TFzones where ZoneNo=" & EditNo, sqlConn)
        Dim rs As SqlDataReader
        rs = cmd.ExecuteReader
        If rs.HasRows Then
            rs.Read()
            ZoneNo.Text = "" & rs("ZoneNo")
            ZoneName.Text = rs("ZoneName")
            ZoneType.SelectedIndex = rs("ZoneType")

            If DBNoCams > 0 Then
                For lop = 1 To DBNoCams
                    If rs("ZoneCam") = DBcamNo(lop) Then ZoneCamera.SelectedIndex = lop
                Next
            End If

            If DBnoAreas > 0 Then
                For lop = 1 To DBnoAreas
                    If rs("ZoneArea") = DBareaNo(lop) Then zoneArea.SelectedIndex = lop
                Next
            End If

            If rs("zoneX") > 0 And rs("zoneY") > 0 Then
                zoneX.Text = Str(rs("zoneX")) : zoneY.Text = Str(rs("zoneY"))
            Else
                zoneX.Text = "" : zoneY.Text = ""
            End If
        End If
        sqlConn.Close()
        If EditMode = "View" Or EditMode = "Edit" Then
            zoneSetEnable.Checked = False
        Else
            zoneSetEnable.Checked = True
        End If

        SetVisableItems()
        AllowDROPupdates = True

        CameraPreview(DBcamNo(ZoneCamera.SelectedIndex))

        UpdateZonePreview()

    End Sub

    Private Sub UpdateZonePreview()
        Dim bmpName As String

        If zoneArea.SelectedIndex = 0 Then
            AreaBox.Image = Nothing
            AreaPreLbl.Text = "Select Area"
            CamIcon.Visible = False
            ZoneIcon.Visible = False
        Else
            Try
                bmpName = DBareaFile(zoneArea.SelectedIndex)
                bmpName = Strings.Left(bmpName, Len(bmpName) - 3) + "bmp"
                Dim bm As New Bitmap(bmpName)
                AreaBox.Image = bm
                AreaPreLbl.Text = "Area Preview: " + DBareaName(zoneArea.SelectedIndex)

                If ZoneType.SelectedIndex = 0 Or ZoneType.SelectedIndex = 3 Then
                    ZoneIcon.Visible = False
                Else
                    If Val(zoneX.Text) > 0 And Val(zoneY.Text) > 0 Then
                        ZoneIcon.Parent = AreaBox
                        ZoneIcon.Left = Val(zoneX.Text) - 10
                        ZoneIcon.Top = Val(zoneY.Text) - 10
                        ZoneIcon.Visible = True
                    Else
                        ZoneIcon.Visible = False
                    End If
                End If

                CamIcon.Visible = False

                If ZoneCamera.SelectedIndex = 0 Then
                    CamIcon.Visible = False
                Else
                    If DBareaNo(zoneArea.SelectedIndex) = DBcamArea(ZoneCamera.SelectedIndex) Then
                        If DBcamX(ZoneCamera.SelectedIndex) > 0 And DBcamY(ZoneCamera.SelectedIndex) > 0 Then
                            CamIcon.Parent = AreaBox
                            CamIcon.Left = DBcamX(ZoneCamera.SelectedIndex) - 10
                            CamIcon.Top = DBcamY(ZoneCamera.SelectedIndex) - 10
                            CamIcon.Visible = True
                        Else
                            CamIcon.Visible = False
                        End If
                    End If
                End If
            Catch ex As Exception
                AreaPreLbl.Text = "Area Preview Failed"
                CamIcon.Visible = False
            End Try
        End If
    End Sub

    Private Sub ZoneType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ZoneType.SelectedIndexChanged
        If AllowDROPupdates = False Then Exit Sub
        UpdateZonePreview()
        SetVisableItems()
    End Sub

    Private Sub ZoneCamera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ZoneCamera.SelectedIndexChanged
        If AllowDROPupdates = False Then Exit Sub
        Dim CamAreaNo As Integer
        If ZoneCamera.SelectedIndex <> 0 Then
            CamAreaNo = DBcamArea(ZoneCamera.SelectedIndex) 'get Area of camera selected
            If CamAreaNo <> 0 Then
                'Camera has an area defined. Default Zone area to camera area
                AllowDROPupdates = False
                If DBnoAreas > 0 Then
                    For lop = 1 To DBnoAreas
                        If DBareaNo(lop) = CamAreaNo Then zoneArea.SelectedIndex = lop : Exit For
                    Next
                End If
                AllowDROPupdates = True
            End If
        End If
        CameraPreview(DBcamNo(ZoneCamera.SelectedIndex))
        UpdateZonePreview()
        SetVisableItems()
    End Sub

    Private Sub zoneArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zoneArea.SelectedIndexChanged
        If AllowDROPupdates = False Then Exit Sub
        If zoneArea.SelectedIndex = 0 Then
            zoneSetEnable.Checked = False
        Else
            zoneSetEnable.Checked = True
            zoneX.Text = "" : zoneY.Text = ""
        End If
        UpdateZonePreview()
        SetVisableItems()
    End Sub

    Private Sub zoneSetEnable_CheckedChanged(sender As Object, e As EventArgs) Handles zoneSetEnable.CheckedChanged
        If AllowDROPupdates = False Then Exit Sub
        SetVisableItems()
    End Sub

    Private Sub SetVisableItems()

        If ZoneType.SelectedIndex = 0 Or ZoneType.SelectedIndex = 3 Then
            'all off
            zoneSetEnable.Visible = False
            zoneSetLbl1.Visible = False
            zoneSetLbl2.Visible = False
            ZoneSetLbl3.Visible = False
            zoneX.Visible = False
            zoneY.Visible = False
            zoneArea.Visible = False
            ZoneAreaLbl.Visible = False
            AreaBox.Cursor = Cursors.Default
            Exit Sub
        End If

        If zoneArea.SelectedIndex = 0 Then
            'all off except select area
            zoneSetEnable.Visible = False
            zoneSetLbl1.Visible = False
            zoneSetLbl2.Visible = False
            ZoneSetLbl3.Visible = False
            zoneX.Visible = False
            zoneY.Visible = False
            zoneArea.Visible = True
            ZoneAreaLbl.Visible = True
            AreaBox.Cursor = Cursors.Default
            Exit Sub
        End If

        'all on
        zoneSetEnable.Visible = True
        zoneSetLbl1.Visible = True
        ZoneSetLbl3.Visible = True
        zoneX.Visible = True
        zoneY.Visible = True
        zoneArea.Visible = True
        ZoneAreaLbl.Visible = True
        If zoneSetEnable.Checked = True Then
            zoneSetLbl2.Visible = True
            AreaBox.Cursor = Cursors.Cross
        Else
            zoneSetLbl2.Visible = False
            AreaBox.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub LoadAllzones()

        Dim MyNode() As TreeNode
        MyNode = MainTree.Nodes.Find("SysZones", True)
        MyNode(0).Nodes.Clear()

        Dim sqlConn As New SqlConnection(sqlConString)
        sqlConn.Open()
        Dim cmd As New SqlCommand("SELECT * FROM TFzones order by zoneNo", sqlConn)
        Dim rs As SqlDataReader
        rs = cmd.ExecuteReader
        DBNoZones = 0
        If rs.HasRows Then
            Do While rs.Read
                DBNoZones = DBNoZones + 1
                DBzoneNo(DBNoZones) = rs("ZoneNo")
                DBzoneName(DBNoZones) = rs("ZoneName")
                DBzoneType(DBNoZones) = rs("ZoneType")
                DBzoneArea(DBNoZones) = rs("ZoneArea")
                DBzoneCam(DBNoZones) = rs("ZoneCam")

                Dim nod As New TreeNode()
                nod.Name = "" & rs("ZoneNo") & ". " & rs("ZoneName")
                nod.Text = "" & rs("ZoneNo") & ". " & rs("ZoneName")
                nod.Tag = "---Zone: " & rs("ZoneNo")
                nod.ContextMenuStrip = DeleteZone
                MyNode(0).Nodes.Add(nod)
            Loop
        End If
        sqlConn.Close()
    End Sub


    Private Sub cancelZoneSave_Click(sender As Object, e As EventArgs) Handles cancelZoneSave.Click
        If EditMode = "New" Then
            DisplayPage = "WelcomePage" : WelcomeText = "Define New Zone Cancelled"
            EditMode = "View"
            DisplayPannel()
        Else
            EditMode = "View" : LoadSingleZone()
            DisplayPannel()
        End If
    End Sub


    Private Sub saveZoneBtn_Click(sender As Object, e As EventArgs) Handles saveZoneBtn.Click
        Dim sqlConn As New SqlConnection(sqlConString)

        If Not IsNumeric(ZoneNo.Text) Or ZoneName.Text = "" Then
            MessageBox.Show("Unable to Save Details, Check Fields are valid", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End If
        If Val(ZoneNo.Text) < 1 Then
            MessageBox.Show("Unable to Save Details, Check Fields are valid", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End If

        Dim cmd As New SqlCommand("SELECT * FROM TFzones where zoneNo=" & ZoneNo.Text, sqlConn)

        If EditMode = "Edit" And EditNo = Val(ZoneNo.Text) Then
            'no need to see if areaNo already exists, we are saving the orgional
        Else
            'see if we are trying to overwrite an existing area
            sqlConn.Open()
            Dim rs As SqlDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                sqlConn.Close()
                MessageBox.Show("Zone Number already exists. Delete or renumber existing Zone first", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            Else
                sqlConn.Close()
            End If
        End If
        'update old record
        DBareaNo(0) = 0 : DBcamNo(0) = 0
        sqlConn.Open()
        Dim upS As String
        If EditMode = "New" Then
            upS = "Insert into TFzones (ZoneNo,ZoneName,ZoneType,ZoneCam,ZoneArea,ZoneX,ZoneY) values (@ZoneNo,@ZoneName,@ZoneType,@ZoneCam,@ZoneArea,@ZoneX,@ZoneY)"
        Else
            upS = "Update TFzones set ZoneNo=@ZoneNo,ZoneName=@ZoneName,ZoneType=@ZoneType,ZoneCam=@ZoneCam,ZoneArea=@ZoneArea,ZoneX=@ZoneX,ZoneY=@ZoneY where ZoneNo=" & EditNo
        End If
        cmd = New SqlCommand(upS, sqlConn)
        cmd.Parameters.Add(New SqlParameter("ZoneNo", Val(ZoneNo.Text)))
        cmd.Parameters.Add(New SqlParameter("ZoneName", ZoneName.Text))
        cmd.Parameters.Add(New SqlParameter("ZoneType", ZoneType.SelectedIndex))
        cmd.Parameters.Add(New SqlParameter("ZoneCam", DBcamNo(ZoneCamera.SelectedIndex)))
        cmd.Parameters.Add(New SqlParameter("ZoneArea", DBareaNo(zoneArea.SelectedIndex)))
        cmd.Parameters.Add(New SqlParameter("ZoneX", Val(zoneX.Text)))
        cmd.Parameters.Add(New SqlParameter("ZoneY", Val(zoneY.Text)))
        Dim NoRec As Integer
        NoRec = cmd.ExecuteNonQuery()
        EditNo = Val(ZoneNo.Text)
        sqlConn.Close()

        zoneSetEnable.Checked = False
        zoneSetLbl2.Visible = False
        AreaBox.Cursor = Cursors.Default

        EditMode = "View"
        DisplayPannel()
        LoadAllzones()
    End Sub

    Private Sub DoDeleteZone_Click(sender As Object, e As EventArgs) Handles DoDeleteZone.Click
        Dim sqlConn As New SqlConnection(sqlConString)
        Dim DelZoneNo = Val(Strings.Right(DeleteZone.Tag, Strings.Len(DeleteZone.Tag) - 8))
        Dim DelZoneName = ""
        Dim lop
        For lop = 1 To DBNoZones
            If DBzoneNo(lop) = DelZoneNo Then DelZoneName = "" & DelZoneNo & ". " & DBzoneName(lop) : Exit For
        Next
        If DelZoneName = "" Then Exit Sub
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete Zone: " & DelZoneName, "Warning Delete Zone", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = 6 Then
            'go ahead delete the zone
            sqlConn.Open()
            Dim upS = "Delete from TFzones where ZoneNo=" & DelZoneNo
            Dim cmd = New SqlCommand(upS, sqlConn)
            Dim NoRec As Integer
            NoRec = cmd.ExecuteNonQuery()
            Debug.Print("Records Updated: " & NoRec)
            sqlConn.Close()
            LoadAllzones()
            DisplayPage = "WelcomePage"
            WelcomeText = "Zone Deleted"
            EditMode = "View"
            DisplayPannel()
        End If
    End Sub

#End Region

End Class
