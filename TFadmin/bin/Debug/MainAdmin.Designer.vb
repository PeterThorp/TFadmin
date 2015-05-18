<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Parameters")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Areas")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cameras")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Zones")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doors")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Setup", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Users")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tryfan", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainAdmin))
        Me.AddArea = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddAreaAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddZone = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddZoneAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionPoint = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTree = New System.Windows.Forms.TreeView()
        Me.sysParamsPage = New System.Windows.Forms.Panel()
        Me.CancelParams = New System.Windows.Forms.Button()
        Me.ImportCams = New System.Windows.Forms.Button()
        Me.saveParams = New System.Windows.Forms.Button()
        Me.Net2Pass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Net2User = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Net2Port = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Net2IP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AlarmPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AlarmPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AlarmIP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MilePass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MileUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MileIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AreaPreLbl = New System.Windows.Forms.Label()
        Me.AreaPreAll = New System.Windows.Forms.CheckBox()
        Me.PanelName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CamPreviewLbl = New System.Windows.Forms.Label()
        Me.EnableEdit = New System.Windows.Forms.CheckBox()
        Me.AreaBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WelcomePage = New System.Windows.Forms.Panel()
        Me.WelcomeLbl = New System.Windows.Forms.Label()
        Me.AreaPage = New System.Windows.Forms.Panel()
        Me.BrowseFile = New System.Windows.Forms.Button()
        Me.CancelSaveArea = New System.Windows.Forms.Button()
        Me.saveAreaBtn = New System.Windows.Forms.Button()
        Me.AreaFile = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.AreaName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.AreaNo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.DeleteArea = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DoDeleteArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.CameraPage = New System.Windows.Forms.Panel()
        Me.CamSetLbl2 = New System.Windows.Forms.Label()
        Me.CamValid = New System.Windows.Forms.Label()
        Me.CameraArea = New System.Windows.Forms.ComboBox()
        Me.CamY = New System.Windows.Forms.TextBox()
        Me.CamX = New System.Windows.Forms.TextBox()
        Me.CamSetLbl3 = New System.Windows.Forms.Label()
        Me.CamSetEnable = New System.Windows.Forms.CheckBox()
        Me.CamSetlbl1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CancelCamera = New System.Windows.Forms.Button()
        Me.SaveCamera = New System.Windows.Forms.Button()
        Me.CamMileName = New System.Windows.Forms.TextBox()
        Me.CamName = New System.Windows.Forms.TextBox()
        Me.CamNo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CamIcon = New System.Windows.Forms.Button()
        Me.EngineManager = New AxEngineManagerLib.AxEngineManager()
        Me.ImageViewer = New AxImageViewerLib.AxImageViewerDotNet()
        Me.zonePage = New System.Windows.Forms.Panel()
        Me.ZoneCamera = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ZoneType = New System.Windows.Forms.ComboBox()
        Me.zoneSetLbl2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.zoneArea = New System.Windows.Forms.ComboBox()
        Me.zoneY = New System.Windows.Forms.TextBox()
        Me.zoneX = New System.Windows.Forms.TextBox()
        Me.ZoneSetLbl3 = New System.Windows.Forms.Label()
        Me.zoneSetEnable = New System.Windows.Forms.CheckBox()
        Me.zoneSetLbl1 = New System.Windows.Forms.Label()
        Me.ZoneAreaLbl = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cancelZoneSave = New System.Windows.Forms.Button()
        Me.saveZoneBtn = New System.Windows.Forms.Button()
        Me.ZoneName = New System.Windows.Forms.TextBox()
        Me.ZoneNo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ZoneIcon = New System.Windows.Forms.Button()
        Me.DeleteZone = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DoDeleteZone = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AddArea.SuspendLayout()
        Me.AddZone.SuspendLayout()
        Me.ActionPoint.SuspendLayout()
        Me.sysParamsPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.WelcomePage.SuspendLayout()
        Me.AreaPage.SuspendLayout()
        Me.DeleteArea.SuspendLayout()
        Me.CameraPage.SuspendLayout()
        CType(Me.EngineManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.zonePage.SuspendLayout()
        Me.DeleteZone.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddArea
        '
        Me.AddArea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAreaAdd})
        Me.AddArea.Name = "AddArea"
        Me.AddArea.ShowImageMargin = False
        Me.AddArea.Size = New System.Drawing.Size(156, 30)
        '
        'AddAreaAdd
        '
        Me.AddAreaAdd.Name = "AddAreaAdd"
        Me.AddAreaAdd.Size = New System.Drawing.Size(155, 26)
        Me.AddAreaAdd.Text = "Add New Area"
        '
        'AddZone
        '
        Me.AddZone.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddZoneAdd})
        Me.AddZone.Name = "AddArea"
        Me.AddZone.ShowImageMargin = False
        Me.AddZone.Size = New System.Drawing.Size(123, 30)
        '
        'AddZoneAdd
        '
        Me.AddZoneAdd.Name = "AddZoneAdd"
        Me.AddZoneAdd.Size = New System.Drawing.Size(122, 26)
        Me.AddZoneAdd.Text = "Add Zone"
        '
        'ActionPoint
        '
        Me.ActionPoint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ActionPoint.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ActionPoint.Name = "ActionPoint"
        Me.ActionPoint.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ActionPoint.ShowCheckMargin = True
        Me.ActionPoint.ShowImageMargin = False
        Me.ActionPoint.Size = New System.Drawing.Size(140, 30)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Checked = True
        Me.ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(139, 26)
        Me.ToolStripMenuItem1.Text = "TestItem"
        '
        'MainTree
        '
        Me.MainTree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTree.Location = New System.Drawing.Point(12, 32)
        Me.MainTree.Name = "MainTree"
        TreeNode17.Name = "sysParams"
        TreeNode17.Tag = "sysParams"
        TreeNode17.Text = "System Parameters"
        TreeNode18.ContextMenuStrip = Me.AddArea
        TreeNode18.Name = "sysAreas"
        TreeNode18.Text = "Areas"
        TreeNode19.Name = "sysCams"
        TreeNode19.Text = "Cameras"
        TreeNode20.ContextMenuStrip = Me.AddZone
        TreeNode20.Name = "sysZones"
        TreeNode20.Text = "Zones"
        TreeNode21.Name = "sysDoors"
        TreeNode21.Text = "Doors"
        TreeNode22.Name = "SystemSetup"
        TreeNode22.Text = "System Setup"
        TreeNode23.Name = "sysUsers"
        TreeNode23.Text = "Users"
        TreeNode24.Name = "Root"
        TreeNode24.Tag = "Welcome"
        TreeNode24.Text = "Tryfan"
        Me.MainTree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode24})
        Me.MainTree.Size = New System.Drawing.Size(207, 561)
        Me.MainTree.TabIndex = 3
        '
        'sysParamsPage
        '
        Me.sysParamsPage.AutoScroll = True
        Me.sysParamsPage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.sysParamsPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sysParamsPage.Controls.Add(Me.Button2)
        Me.sysParamsPage.Controls.Add(Me.Button1)
        Me.sysParamsPage.Controls.Add(Me.CancelParams)
        Me.sysParamsPage.Controls.Add(Me.ImportCams)
        Me.sysParamsPage.Controls.Add(Me.saveParams)
        Me.sysParamsPage.Controls.Add(Me.Net2Pass)
        Me.sysParamsPage.Controls.Add(Me.Label10)
        Me.sysParamsPage.Controls.Add(Me.Net2User)
        Me.sysParamsPage.Controls.Add(Me.Label7)
        Me.sysParamsPage.Controls.Add(Me.Net2Port)
        Me.sysParamsPage.Controls.Add(Me.Label8)
        Me.sysParamsPage.Controls.Add(Me.Net2IP)
        Me.sysParamsPage.Controls.Add(Me.Label9)
        Me.sysParamsPage.Controls.Add(Me.AlarmPass)
        Me.sysParamsPage.Controls.Add(Me.Label4)
        Me.sysParamsPage.Controls.Add(Me.AlarmPort)
        Me.sysParamsPage.Controls.Add(Me.Label5)
        Me.sysParamsPage.Controls.Add(Me.AlarmIP)
        Me.sysParamsPage.Controls.Add(Me.Label6)
        Me.sysParamsPage.Controls.Add(Me.MilePass)
        Me.sysParamsPage.Controls.Add(Me.Label3)
        Me.sysParamsPage.Controls.Add(Me.MileUser)
        Me.sysParamsPage.Controls.Add(Me.Label2)
        Me.sysParamsPage.Controls.Add(Me.MileIP)
        Me.sysParamsPage.Controls.Add(Me.Label1)
        Me.sysParamsPage.Enabled = False
        Me.sysParamsPage.Location = New System.Drawing.Point(12, 223)
        Me.sysParamsPage.Name = "sysParamsPage"
        Me.sysParamsPage.Size = New System.Drawing.Size(627, 561)
        Me.sysParamsPage.TabIndex = 5
        '
        'CancelParams
        '
        Me.CancelParams.Location = New System.Drawing.Point(318, 519)
        Me.CancelParams.Name = "CancelParams"
        Me.CancelParams.Size = New System.Drawing.Size(164, 25)
        Me.CancelParams.TabIndex = 21
        Me.CancelParams.Text = "Cancel"
        Me.CancelParams.UseVisualStyleBackColor = True
        '
        'ImportCams
        '
        Me.ImportCams.Location = New System.Drawing.Point(405, 90)
        Me.ImportCams.Name = "ImportCams"
        Me.ImportCams.Size = New System.Drawing.Size(164, 25)
        Me.ImportCams.TabIndex = 40
        Me.ImportCams.TabStop = False
        Me.ImportCams.Text = "Import Cameras"
        Me.ImportCams.UseVisualStyleBackColor = True
        '
        'saveParams
        '
        Me.saveParams.Location = New System.Drawing.Point(148, 519)
        Me.saveParams.Name = "saveParams"
        Me.saveParams.Size = New System.Drawing.Size(164, 25)
        Me.saveParams.TabIndex = 20
        Me.saveParams.Text = "Save Parameters"
        Me.saveParams.UseVisualStyleBackColor = True
        '
        'Net2Pass
        '
        Me.Net2Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net2Pass.Location = New System.Drawing.Point(235, 332)
        Me.Net2Pass.Name = "Net2Pass"
        Me.Net2Pass.Size = New System.Drawing.Size(164, 22)
        Me.Net2Pass.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(70, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(159, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Access Server Password"
        '
        'Net2User
        '
        Me.Net2User.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net2User.Location = New System.Drawing.Point(235, 304)
        Me.Net2User.Name = "Net2User"
        Me.Net2User.Size = New System.Drawing.Size(164, 22)
        Me.Net2User.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(162, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Access Server Username"
        '
        'Net2Port
        '
        Me.Net2Port.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net2Port.Location = New System.Drawing.Point(235, 276)
        Me.Net2Port.Name = "Net2Port"
        Me.Net2Port.Size = New System.Drawing.Size(75, 22)
        Me.Net2Port.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(106, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(123, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Access Server Port"
        '
        'Net2IP
        '
        Me.Net2IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net2IP.Location = New System.Drawing.Point(235, 248)
        Me.Net2IP.Name = "Net2IP"
        Me.Net2IP.Size = New System.Drawing.Size(164, 22)
        Me.Net2IP.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(165, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Access Server IP Address"
        '
        'AlarmPass
        '
        Me.AlarmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmPass.Location = New System.Drawing.Point(235, 197)
        Me.AlarmPass.Name = "AlarmPass"
        Me.AlarmPass.Size = New System.Drawing.Size(164, 22)
        Me.AlarmPass.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(127, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Alarm Access Code"
        '
        'AlarmPort
        '
        Me.AlarmPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmPort.Location = New System.Drawing.Point(235, 170)
        Me.AlarmPort.Name = "AlarmPort"
        Me.AlarmPort.Size = New System.Drawing.Size(75, 22)
        Me.AlarmPort.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Alarm Port"
        '
        'AlarmIP
        '
        Me.AlarmIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmIP.Location = New System.Drawing.Point(235, 142)
        Me.AlarmIP.Name = "AlarmIP"
        Me.AlarmIP.Size = New System.Drawing.Size(164, 22)
        Me.AlarmIP.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Alarm IP Address"
        '
        'MilePass
        '
        Me.MilePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilePass.Location = New System.Drawing.Point(235, 91)
        Me.MilePass.Name = "MilePass"
        Me.MilePass.Size = New System.Drawing.Size(164, 22)
        Me.MilePass.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(150, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CCTV Server Password"
        '
        'MileUser
        '
        Me.MileUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MileUser.Location = New System.Drawing.Point(235, 63)
        Me.MileUser.Name = "MileUser"
        Me.MileUser.Size = New System.Drawing.Size(164, 22)
        Me.MileUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(153, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CCTV Server Username"
        '
        'MileIP
        '
        Me.MileIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MileIP.Location = New System.Drawing.Point(235, 35)
        Me.MileIP.Name = "MileIP"
        Me.MileIP.Size = New System.Drawing.Size(164, 22)
        Me.MileIP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(156, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CCTV Server IP Address"
        '
        'AreaPreLbl
        '
        Me.AreaPreLbl.AutoSize = True
        Me.AreaPreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaPreLbl.Location = New System.Drawing.Point(9, 618)
        Me.AreaPreLbl.Name = "AreaPreLbl"
        Me.AreaPreLbl.Size = New System.Drawing.Size(88, 16)
        Me.AreaPreLbl.TabIndex = 6
        Me.AreaPreLbl.Text = "Area Preview"
        '
        'AreaPreAll
        '
        Me.AreaPreAll.AutoSize = True
        Me.AreaPreAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaPreAll.Location = New System.Drawing.Point(712, 617)
        Me.AreaPreAll.Name = "AreaPreAll"
        Me.AreaPreAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AreaPreAll.Size = New System.Drawing.Size(140, 20)
        Me.AreaPreAll.TabIndex = 7
        Me.AreaPreAll.Text = "Display All Objects"
        Me.AreaPreAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AreaPreAll.UseVisualStyleBackColor = True
        Me.AreaPreAll.Visible = False
        '
        'PanelName
        '
        Me.PanelName.AutoSize = True
        Me.PanelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelName.Location = New System.Drawing.Point(222, 13)
        Me.PanelName.Name = "PanelName"
        Me.PanelName.Size = New System.Drawing.Size(126, 16)
        Me.PanelName.TabIndex = 8
        Me.PanelName.Text = "System Parameters"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(872, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 326)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'CamPreviewLbl
        '
        Me.CamPreviewLbl.AutoSize = True
        Me.CamPreviewLbl.BackColor = System.Drawing.Color.Transparent
        Me.CamPreviewLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamPreviewLbl.Location = New System.Drawing.Point(869, 13)
        Me.CamPreviewLbl.Name = "CamPreviewLbl"
        Me.CamPreviewLbl.Size = New System.Drawing.Size(247, 16)
        Me.CamPreviewLbl.TabIndex = 12
        Me.CamPreviewLbl.Text = "Camera Preview: (No Camera Selected)"
        '
        'EnableEdit
        '
        Me.EnableEdit.AutoSize = True
        Me.EnableEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableEdit.Location = New System.Drawing.Point(756, 12)
        Me.EnableEdit.Name = "EnableEdit"
        Me.EnableEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EnableEdit.Size = New System.Drawing.Size(96, 20)
        Me.EnableEdit.TabIndex = 14
        Me.EnableEdit.Text = "Enable Edit"
        Me.EnableEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EnableEdit.UseVisualStyleBackColor = True
        '
        'AreaBox
        '
        Me.AreaBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AreaBox.Location = New System.Drawing.Point(0, 0)
        Me.AreaBox.Name = "AreaBox"
        Me.AreaBox.Size = New System.Drawing.Size(840, 170)
        Me.AreaBox.TabIndex = 10
        Me.AreaBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AreaBox)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Panel1.Location = New System.Drawing.Point(12, 637)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 170)
        Me.Panel1.TabIndex = 15
        '
        'WelcomePage
        '
        Me.WelcomePage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WelcomePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WelcomePage.Controls.Add(Me.WelcomeLbl)
        Me.WelcomePage.Location = New System.Drawing.Point(206, 76)
        Me.WelcomePage.Name = "WelcomePage"
        Me.WelcomePage.Size = New System.Drawing.Size(627, 561)
        Me.WelcomePage.TabIndex = 17
        '
        'WelcomeLbl
        '
        Me.WelcomeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLbl.Location = New System.Drawing.Point(3, 23)
        Me.WelcomeLbl.Name = "WelcomeLbl"
        Me.WelcomeLbl.Size = New System.Drawing.Size(623, 123)
        Me.WelcomeLbl.TabIndex = 0
        Me.WelcomeLbl.Text = "Welcome to Tryfan System Admin"
        Me.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AreaPage
        '
        Me.AreaPage.AutoScroll = True
        Me.AreaPage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AreaPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AreaPage.Controls.Add(Me.BrowseFile)
        Me.AreaPage.Controls.Add(Me.CancelSaveArea)
        Me.AreaPage.Controls.Add(Me.saveAreaBtn)
        Me.AreaPage.Controls.Add(Me.AreaFile)
        Me.AreaPage.Controls.Add(Me.Label20)
        Me.AreaPage.Controls.Add(Me.AreaName)
        Me.AreaPage.Controls.Add(Me.Label21)
        Me.AreaPage.Controls.Add(Me.AreaNo)
        Me.AreaPage.Controls.Add(Me.Label22)
        Me.AreaPage.Enabled = False
        Me.AreaPage.Location = New System.Drawing.Point(907, 461)
        Me.AreaPage.Name = "AreaPage"
        Me.AreaPage.Size = New System.Drawing.Size(627, 561)
        Me.AreaPage.TabIndex = 18
        '
        'BrowseFile
        '
        Me.BrowseFile.Location = New System.Drawing.Point(488, 90)
        Me.BrowseFile.Name = "BrowseFile"
        Me.BrowseFile.Size = New System.Drawing.Size(109, 23)
        Me.BrowseFile.TabIndex = 4
        Me.BrowseFile.Text = "Browse"
        Me.BrowseFile.UseVisualStyleBackColor = True
        '
        'CancelSaveArea
        '
        Me.CancelSaveArea.Location = New System.Drawing.Point(318, 519)
        Me.CancelSaveArea.Name = "CancelSaveArea"
        Me.CancelSaveArea.Size = New System.Drawing.Size(164, 25)
        Me.CancelSaveArea.TabIndex = 21
        Me.CancelSaveArea.Text = "Cancel"
        Me.CancelSaveArea.UseVisualStyleBackColor = True
        '
        'saveAreaBtn
        '
        Me.saveAreaBtn.Location = New System.Drawing.Point(148, 519)
        Me.saveAreaBtn.Name = "saveAreaBtn"
        Me.saveAreaBtn.Size = New System.Drawing.Size(164, 25)
        Me.saveAreaBtn.TabIndex = 20
        Me.saveAreaBtn.Text = "Save Area"
        Me.saveAreaBtn.UseVisualStyleBackColor = True
        '
        'AreaFile
        '
        Me.AreaFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaFile.Location = New System.Drawing.Point(148, 91)
        Me.AreaFile.Name = "AreaFile"
        Me.AreaFile.ReadOnly = True
        Me.AreaFile.Size = New System.Drawing.Size(334, 22)
        Me.AreaFile.TabIndex = 3
        Me.AreaFile.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(23, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label20.Size = New System.Drawing.Size(119, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Area Graphics File"
        '
        'AreaName
        '
        Me.AreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaName.Location = New System.Drawing.Point(148, 63)
        Me.AreaName.Name = "AreaName"
        Me.AreaName.Size = New System.Drawing.Size(164, 22)
        Me.AreaName.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(65, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(77, 16)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Area Name"
        '
        'AreaNo
        '
        Me.AreaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaNo.Location = New System.Drawing.Point(148, 35)
        Me.AreaNo.Name = "AreaNo"
        Me.AreaNo.Size = New System.Drawing.Size(40, 22)
        Me.AreaNo.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(54, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Area Number"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'DeleteArea
        '
        Me.DeleteArea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoDeleteArea})
        Me.DeleteArea.Name = "DeleteArea"
        Me.DeleteArea.ShowImageMargin = False
        Me.DeleteArea.Size = New System.Drawing.Size(136, 30)
        '
        'DoDeleteArea
        '
        Me.DoDeleteArea.Name = "DoDeleteArea"
        Me.DoDeleteArea.Size = New System.Drawing.Size(135, 26)
        Me.DoDeleteArea.Text = "Delete Area"
        '
        'CameraPage
        '
        Me.CameraPage.AutoScroll = True
        Me.CameraPage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CameraPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CameraPage.Controls.Add(Me.CamSetLbl2)
        Me.CameraPage.Controls.Add(Me.CamValid)
        Me.CameraPage.Controls.Add(Me.CameraArea)
        Me.CameraPage.Controls.Add(Me.CamY)
        Me.CameraPage.Controls.Add(Me.CamX)
        Me.CameraPage.Controls.Add(Me.CamSetLbl3)
        Me.CameraPage.Controls.Add(Me.CamSetEnable)
        Me.CameraPage.Controls.Add(Me.CamSetlbl1)
        Me.CameraPage.Controls.Add(Me.Label14)
        Me.CameraPage.Controls.Add(Me.Label13)
        Me.CameraPage.Controls.Add(Me.Label12)
        Me.CameraPage.Controls.Add(Me.CancelCamera)
        Me.CameraPage.Controls.Add(Me.SaveCamera)
        Me.CameraPage.Controls.Add(Me.CamMileName)
        Me.CameraPage.Controls.Add(Me.CamName)
        Me.CameraPage.Controls.Add(Me.CamNo)
        Me.CameraPage.Controls.Add(Me.Label24)
        Me.CameraPage.Enabled = False
        Me.CameraPage.Location = New System.Drawing.Point(1000, 369)
        Me.CameraPage.Name = "CameraPage"
        Me.CameraPage.Size = New System.Drawing.Size(627, 561)
        Me.CameraPage.TabIndex = 19
        '
        'CamSetLbl2
        '
        Me.CamSetLbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamSetLbl2.Location = New System.Drawing.Point(256, 193)
        Me.CamSetLbl2.Name = "CamSetLbl2"
        Me.CamSetLbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CamSetLbl2.Size = New System.Drawing.Size(347, 16)
        Me.CamSetLbl2.TabIndex = 50
        Me.CamSetLbl2.Text = "Click Area Preview to Set Camera Location"
        '
        'CamValid
        '
        Me.CamValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamValid.Location = New System.Drawing.Point(405, 94)
        Me.CamValid.Name = "CamValid"
        Me.CamValid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CamValid.Size = New System.Drawing.Size(198, 16)
        Me.CamValid.TabIndex = 49
        '
        'CameraArea
        '
        Me.CameraArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CameraArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CameraArea.FormattingEnabled = True
        Me.CameraArea.Location = New System.Drawing.Point(235, 142)
        Me.CameraArea.Name = "CameraArea"
        Me.CameraArea.Size = New System.Drawing.Size(164, 24)
        Me.CameraArea.TabIndex = 4
        '
        'CamY
        '
        Me.CamY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamY.Location = New System.Drawing.Point(277, 242)
        Me.CamY.Name = "CamY"
        Me.CamY.ReadOnly = True
        Me.CamY.Size = New System.Drawing.Size(35, 22)
        Me.CamY.TabIndex = 48
        Me.CamY.TabStop = False
        Me.CamY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CamX
        '
        Me.CamX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamX.Location = New System.Drawing.Point(235, 242)
        Me.CamX.Name = "CamX"
        Me.CamX.ReadOnly = True
        Me.CamX.Size = New System.Drawing.Size(35, 22)
        Me.CamX.TabIndex = 47
        Me.CamX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CamSetLbl3
        '
        Me.CamSetLbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamSetLbl3.Location = New System.Drawing.Point(31, 245)
        Me.CamSetLbl3.Name = "CamSetLbl3"
        Me.CamSetLbl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CamSetLbl3.Size = New System.Drawing.Size(198, 16)
        Me.CamSetLbl3.TabIndex = 46
        Me.CamSetLbl3.Text = "Location X,Y"
        '
        'CamSetEnable
        '
        Me.CamSetEnable.AutoSize = True
        Me.CamSetEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamSetEnable.Location = New System.Drawing.Point(235, 195)
        Me.CamSetEnable.Name = "CamSetEnable"
        Me.CamSetEnable.Size = New System.Drawing.Size(15, 14)
        Me.CamSetEnable.TabIndex = 5
        Me.CamSetEnable.UseVisualStyleBackColor = True
        '
        'CamSetlbl1
        '
        Me.CamSetlbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamSetlbl1.Location = New System.Drawing.Point(31, 193)
        Me.CamSetlbl1.Name = "CamSetlbl1"
        Me.CamSetlbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CamSetlbl1.Size = New System.Drawing.Size(198, 16)
        Me.CamSetlbl1.TabIndex = 44
        Me.CamSetlbl1.Text = "Enable Set Location"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 145)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label14.Size = New System.Drawing.Size(198, 16)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Assign Area"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(198, 16)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Name In Milestone"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(198, 16)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Camera Name"
        '
        'CancelCamera
        '
        Me.CancelCamera.Location = New System.Drawing.Point(318, 519)
        Me.CancelCamera.Name = "CancelCamera"
        Me.CancelCamera.Size = New System.Drawing.Size(164, 25)
        Me.CancelCamera.TabIndex = 21
        Me.CancelCamera.Text = "Cancel"
        Me.CancelCamera.UseVisualStyleBackColor = True
        '
        'SaveCamera
        '
        Me.SaveCamera.Location = New System.Drawing.Point(148, 519)
        Me.SaveCamera.Name = "SaveCamera"
        Me.SaveCamera.Size = New System.Drawing.Size(164, 25)
        Me.SaveCamera.TabIndex = 20
        Me.SaveCamera.Text = "Save Camera"
        Me.SaveCamera.UseVisualStyleBackColor = True
        '
        'CamMileName
        '
        Me.CamMileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamMileName.Location = New System.Drawing.Point(235, 91)
        Me.CamMileName.Name = "CamMileName"
        Me.CamMileName.ReadOnly = True
        Me.CamMileName.Size = New System.Drawing.Size(164, 22)
        Me.CamMileName.TabIndex = 3
        '
        'CamName
        '
        Me.CamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamName.Location = New System.Drawing.Point(235, 63)
        Me.CamName.Name = "CamName"
        Me.CamName.Size = New System.Drawing.Size(164, 22)
        Me.CamName.TabIndex = 2
        '
        'CamNo
        '
        Me.CamNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamNo.Location = New System.Drawing.Point(235, 35)
        Me.CamNo.Name = "CamNo"
        Me.CamNo.Size = New System.Drawing.Size(35, 22)
        Me.CamNo.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(31, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label24.Size = New System.Drawing.Size(198, 16)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Camera No"
        '
        'CamIcon
        '
        Me.CamIcon.BackColor = System.Drawing.Color.Chartreuse
        Me.CamIcon.BackgroundImage = Global.TFadmin.My.Resources.Resources.CamIcon
        Me.CamIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CamIcon.Enabled = False
        Me.CamIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CamIcon.Location = New System.Drawing.Point(884, 537)
        Me.CamIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.CamIcon.Name = "CamIcon"
        Me.CamIcon.Size = New System.Drawing.Size(20, 20)
        Me.CamIcon.TabIndex = 20
        Me.CamIcon.TabStop = False
        Me.CamIcon.UseVisualStyleBackColor = False
        '
        'EngineManager
        '
        Me.EngineManager.Enabled = True
        Me.EngineManager.Location = New System.Drawing.Point(872, 379)
        Me.EngineManager.Name = "EngineManager"
        Me.EngineManager.OcxState = CType(resources.GetObject("EngineManager.OcxState"), System.Windows.Forms.AxHost.State)
        Me.EngineManager.Size = New System.Drawing.Size(100, 50)
        Me.EngineManager.TabIndex = 21
        Me.EngineManager.Visible = False
        '
        'ImageViewer
        '
        Me.ImageViewer.Enabled = True
        Me.ImageViewer.Location = New System.Drawing.Point(872, 33)
        Me.ImageViewer.Name = "ImageViewer"
        Me.ImageViewer.OcxState = CType(resources.GetObject("ImageViewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImageViewer.Size = New System.Drawing.Size(400, 325)
        Me.ImageViewer.TabIndex = 22
        Me.ImageViewer.TabStop = False
        Me.ImageViewer.Visible = False
        '
        'zonePage
        '
        Me.zonePage.AutoScroll = True
        Me.zonePage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.zonePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.zonePage.Controls.Add(Me.ZoneCamera)
        Me.zonePage.Controls.Add(Me.Label26)
        Me.zonePage.Controls.Add(Me.ZoneType)
        Me.zonePage.Controls.Add(Me.zoneSetLbl2)
        Me.zonePage.Controls.Add(Me.Label15)
        Me.zonePage.Controls.Add(Me.zoneArea)
        Me.zonePage.Controls.Add(Me.zoneY)
        Me.zonePage.Controls.Add(Me.zoneX)
        Me.zonePage.Controls.Add(Me.ZoneSetLbl3)
        Me.zonePage.Controls.Add(Me.zoneSetEnable)
        Me.zonePage.Controls.Add(Me.zoneSetLbl1)
        Me.zonePage.Controls.Add(Me.ZoneAreaLbl)
        Me.zonePage.Controls.Add(Me.Label19)
        Me.zonePage.Controls.Add(Me.Label23)
        Me.zonePage.Controls.Add(Me.cancelZoneSave)
        Me.zonePage.Controls.Add(Me.saveZoneBtn)
        Me.zonePage.Controls.Add(Me.ZoneName)
        Me.zonePage.Controls.Add(Me.ZoneNo)
        Me.zonePage.Controls.Add(Me.Label25)
        Me.zonePage.Enabled = False
        Me.zonePage.Location = New System.Drawing.Point(225, 33)
        Me.zonePage.Name = "zonePage"
        Me.zonePage.Size = New System.Drawing.Size(627, 561)
        Me.zonePage.TabIndex = 23
        '
        'ZoneCamera
        '
        Me.ZoneCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ZoneCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneCamera.FormattingEnabled = True
        Me.ZoneCamera.Location = New System.Drawing.Point(235, 121)
        Me.ZoneCamera.Name = "ZoneCamera"
        Me.ZoneCamera.Size = New System.Drawing.Size(164, 24)
        Me.ZoneCamera.TabIndex = 52
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(31, 124)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(198, 16)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Linked Camera"
        '
        'ZoneType
        '
        Me.ZoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ZoneType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneType.FormattingEnabled = True
        Me.ZoneType.Items.AddRange(New Object() {"Not Defined", "Deck Sensor", "PIR", "VMD", "Door Contact"})
        Me.ZoneType.Location = New System.Drawing.Point(235, 91)
        Me.ZoneType.Name = "ZoneType"
        Me.ZoneType.Size = New System.Drawing.Size(164, 24)
        Me.ZoneType.TabIndex = 51
        '
        'zoneSetLbl2
        '
        Me.zoneSetLbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zoneSetLbl2.Location = New System.Drawing.Point(256, 225)
        Me.zoneSetLbl2.Name = "zoneSetLbl2"
        Me.zoneSetLbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.zoneSetLbl2.Size = New System.Drawing.Size(347, 16)
        Me.zoneSetLbl2.TabIndex = 50
        Me.zoneSetLbl2.Text = "Click Area Preview to Set Zone Location"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(405, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(198, 16)
        Me.Label15.TabIndex = 49
        '
        'zoneArea
        '
        Me.zoneArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.zoneArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zoneArea.FormattingEnabled = True
        Me.zoneArea.Location = New System.Drawing.Point(235, 177)
        Me.zoneArea.Name = "zoneArea"
        Me.zoneArea.Size = New System.Drawing.Size(164, 24)
        Me.zoneArea.TabIndex = 4
        '
        'zoneY
        '
        Me.zoneY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zoneY.Location = New System.Drawing.Point(277, 270)
        Me.zoneY.Name = "zoneY"
        Me.zoneY.ReadOnly = True
        Me.zoneY.Size = New System.Drawing.Size(35, 22)
        Me.zoneY.TabIndex = 48
        Me.zoneY.TabStop = False
        Me.zoneY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'zoneX
        '
        Me.zoneX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zoneX.Location = New System.Drawing.Point(235, 270)
        Me.zoneX.Name = "zoneX"
        Me.zoneX.ReadOnly = True
        Me.zoneX.Size = New System.Drawing.Size(35, 22)
        Me.zoneX.TabIndex = 47
        Me.zoneX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ZoneSetLbl3
        '
        Me.ZoneSetLbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneSetLbl3.Location = New System.Drawing.Point(31, 273)
        Me.ZoneSetLbl3.Name = "ZoneSetLbl3"
        Me.ZoneSetLbl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ZoneSetLbl3.Size = New System.Drawing.Size(198, 16)
        Me.ZoneSetLbl3.TabIndex = 46
        Me.ZoneSetLbl3.Text = "Location X,Y"
        '
        'zoneSetEnable
        '
        Me.zoneSetEnable.AutoSize = True
        Me.zoneSetEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zoneSetEnable.Location = New System.Drawing.Point(235, 227)
        Me.zoneSetEnable.Name = "zoneSetEnable"
        Me.zoneSetEnable.Size = New System.Drawing.Size(15, 14)
        Me.zoneSetEnable.TabIndex = 5
        Me.zoneSetEnable.UseVisualStyleBackColor = True
        '
        'zoneSetLbl1
        '
        Me.zoneSetLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zoneSetLbl1.Location = New System.Drawing.Point(31, 225)
        Me.zoneSetLbl1.Name = "zoneSetLbl1"
        Me.zoneSetLbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.zoneSetLbl1.Size = New System.Drawing.Size(198, 16)
        Me.zoneSetLbl1.TabIndex = 44
        Me.zoneSetLbl1.Text = "Enable Set Location"
        '
        'ZoneAreaLbl
        '
        Me.ZoneAreaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneAreaLbl.Location = New System.Drawing.Point(31, 180)
        Me.ZoneAreaLbl.Name = "ZoneAreaLbl"
        Me.ZoneAreaLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ZoneAreaLbl.Size = New System.Drawing.Size(198, 16)
        Me.ZoneAreaLbl.TabIndex = 43
        Me.ZoneAreaLbl.Text = "Assign Area"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(31, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(198, 16)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Zone Type"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(31, 66)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label23.Size = New System.Drawing.Size(198, 16)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Zone Name"
        '
        'cancelZoneSave
        '
        Me.cancelZoneSave.Location = New System.Drawing.Point(318, 519)
        Me.cancelZoneSave.Name = "cancelZoneSave"
        Me.cancelZoneSave.Size = New System.Drawing.Size(164, 25)
        Me.cancelZoneSave.TabIndex = 21
        Me.cancelZoneSave.Text = "Cancel"
        Me.cancelZoneSave.UseVisualStyleBackColor = True
        '
        'saveZoneBtn
        '
        Me.saveZoneBtn.Location = New System.Drawing.Point(148, 519)
        Me.saveZoneBtn.Name = "saveZoneBtn"
        Me.saveZoneBtn.Size = New System.Drawing.Size(164, 25)
        Me.saveZoneBtn.TabIndex = 20
        Me.saveZoneBtn.Text = "Save Zone"
        Me.saveZoneBtn.UseVisualStyleBackColor = True
        '
        'ZoneName
        '
        Me.ZoneName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneName.Location = New System.Drawing.Point(235, 63)
        Me.ZoneName.Name = "ZoneName"
        Me.ZoneName.Size = New System.Drawing.Size(164, 22)
        Me.ZoneName.TabIndex = 2
        '
        'ZoneNo
        '
        Me.ZoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneNo.Location = New System.Drawing.Point(235, 35)
        Me.ZoneNo.Name = "ZoneNo"
        Me.ZoneNo.Size = New System.Drawing.Size(35, 22)
        Me.ZoneNo.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(31, 38)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label25.Size = New System.Drawing.Size(198, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Zone No"
        '
        'ZoneIcon
        '
        Me.ZoneIcon.BackColor = System.Drawing.Color.OrangeRed
        Me.ZoneIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ZoneIcon.Enabled = False
        Me.ZoneIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ZoneIcon.Location = New System.Drawing.Point(872, 503)
        Me.ZoneIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.ZoneIcon.Name = "ZoneIcon"
        Me.ZoneIcon.Size = New System.Drawing.Size(20, 20)
        Me.ZoneIcon.TabIndex = 24
        Me.ZoneIcon.TabStop = False
        Me.ZoneIcon.UseVisualStyleBackColor = False
        Me.ZoneIcon.Visible = False
        '
        'DeleteZone
        '
        Me.DeleteZone.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoDeleteZone})
        Me.DeleteZone.Name = "DeleteArea"
        Me.DeleteZone.ShowImageMargin = False
        Me.DeleteZone.Size = New System.Drawing.Size(139, 30)
        '
        'DoDeleteZone
        '
        Me.DoDeleteZone.Name = "DoDeleteZone"
        Me.DoDeleteZone.Size = New System.Drawing.Size(138, 26)
        Me.DoDeleteZone.Text = "Delete Zone"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 25)
        Me.Button1.TabIndex = 41
        Me.Button1.TabStop = False
        Me.Button1.Text = "Import Zones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(405, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 25)
        Me.Button2.TabIndex = 42
        Me.Button2.TabStop = False
        Me.Button2.Text = "Import Doors"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 819)
        Me.Controls.Add(Me.sysParamsPage)
        Me.Controls.Add(Me.ZoneIcon)
        Me.Controls.Add(Me.zonePage)
        Me.Controls.Add(Me.CamPreviewLbl)
        Me.Controls.Add(Me.CameraPage)
        Me.Controls.Add(Me.ImageViewer)
        Me.Controls.Add(Me.EngineManager)
        Me.Controls.Add(Me.CamIcon)
        Me.Controls.Add(Me.EnableEdit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelName)
        Me.Controls.Add(Me.AreaPreAll)
        Me.Controls.Add(Me.AreaPreLbl)
        Me.Controls.Add(Me.AreaPage)
        Me.Controls.Add(Me.MainTree)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WelcomePage)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tryfan Admin"
        Me.AddArea.ResumeLayout(False)
        Me.AddZone.ResumeLayout(False)
        Me.ActionPoint.ResumeLayout(False)
        Me.sysParamsPage.ResumeLayout(False)
        Me.sysParamsPage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreaBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.WelcomePage.ResumeLayout(False)
        Me.AreaPage.ResumeLayout(False)
        Me.AreaPage.PerformLayout()
        Me.DeleteArea.ResumeLayout(False)
        Me.CameraPage.ResumeLayout(False)
        Me.CameraPage.PerformLayout()
        CType(Me.EngineManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.zonePage.ResumeLayout(False)
        Me.zonePage.PerformLayout()
        Me.DeleteZone.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActionPoint As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainTree As System.Windows.Forms.TreeView
    Friend WithEvents sysParamsPage As System.Windows.Forms.Panel
    Friend WithEvents AreaPreLbl As System.Windows.Forms.Label
    Friend WithEvents AreaPreAll As System.Windows.Forms.CheckBox
    Friend WithEvents PanelName As System.Windows.Forms.Label
    Friend WithEvents MileUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MileIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MilePass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AlarmPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AlarmPort As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AlarmIP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Net2User As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Net2Port As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Net2IP As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ImportCams As System.Windows.Forms.Button
    Friend WithEvents saveParams As System.Windows.Forms.Button
    Friend WithEvents Net2Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CamPreviewLbl As System.Windows.Forms.Label
    Friend WithEvents EnableEdit As System.Windows.Forms.CheckBox
    Friend WithEvents CancelParams As System.Windows.Forms.Button
    Friend WithEvents AreaBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AddArea As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddAreaAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WelcomePage As System.Windows.Forms.Panel
    Friend WithEvents WelcomeLbl As System.Windows.Forms.Label
    Friend WithEvents AreaPage As System.Windows.Forms.Panel
    Friend WithEvents BrowseFile As System.Windows.Forms.Button
    Friend WithEvents CancelSaveArea As System.Windows.Forms.Button
    Friend WithEvents saveAreaBtn As System.Windows.Forms.Button
    Friend WithEvents AreaFile As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents AreaName As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents AreaNo As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DeleteArea As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DoDeleteArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CameraPage As System.Windows.Forms.Panel
    Friend WithEvents CameraArea As System.Windows.Forms.ComboBox
    Friend WithEvents CamY As System.Windows.Forms.TextBox
    Friend WithEvents CamX As System.Windows.Forms.TextBox
    Friend WithEvents CamSetLbl3 As System.Windows.Forms.Label
    Friend WithEvents CamSetEnable As System.Windows.Forms.CheckBox
    Friend WithEvents CamSetlbl1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CancelCamera As System.Windows.Forms.Button
    Friend WithEvents SaveCamera As System.Windows.Forms.Button
    Friend WithEvents CamMileName As System.Windows.Forms.TextBox
    Friend WithEvents CamName As System.Windows.Forms.TextBox
    Friend WithEvents CamNo As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CamValid As System.Windows.Forms.Label
    Friend WithEvents CamSetLbl2 As System.Windows.Forms.Label
    Friend WithEvents CamIcon As System.Windows.Forms.Button
    Friend WithEvents EngineManager As AxEngineManagerLib.AxEngineManager
    Friend WithEvents ImageViewer As AxImageViewerLib.AxImageViewerDotNet
    Friend WithEvents zonePage As System.Windows.Forms.Panel
    Friend WithEvents ZoneCamera As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ZoneType As System.Windows.Forms.ComboBox
    Friend WithEvents zoneSetLbl2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents zoneArea As System.Windows.Forms.ComboBox
    Friend WithEvents zoneY As System.Windows.Forms.TextBox
    Friend WithEvents zoneX As System.Windows.Forms.TextBox
    Friend WithEvents ZoneSetLbl3 As System.Windows.Forms.Label
    Friend WithEvents zoneSetEnable As System.Windows.Forms.CheckBox
    Friend WithEvents zoneSetLbl1 As System.Windows.Forms.Label
    Friend WithEvents ZoneAreaLbl As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cancelZoneSave As System.Windows.Forms.Button
    Friend WithEvents saveZoneBtn As System.Windows.Forms.Button
    Friend WithEvents ZoneName As System.Windows.Forms.TextBox
    Friend WithEvents ZoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents AddZone As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddZoneAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoneIcon As System.Windows.Forms.Button
    Friend WithEvents DeleteZone As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DoDeleteZone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
