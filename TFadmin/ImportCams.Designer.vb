<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportCams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportCams))
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.EngineManager = New AxEngineManagerLib.AxEngineManager()
        Me.Status = New System.Windows.Forms.Label()
        Me.ImageViewer = New AxImageViewerLib.AxImageViewerDotNet()
        CType(Me.EngineManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitBtn
        '
        Me.ExitBtn.Enabled = False
        Me.ExitBtn.Location = New System.Drawing.Point(171, 131)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(112, 23)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'EngineManager
        '
        Me.EngineManager.Enabled = True
        Me.EngineManager.Location = New System.Drawing.Point(12, 12)
        Me.EngineManager.Name = "EngineManager"
        Me.EngineManager.OcxState = CType(resources.GetObject("EngineManager.OcxState"), System.Windows.Forms.AxHost.State)
        Me.EngineManager.Size = New System.Drawing.Size(100, 50)
        Me.EngineManager.TabIndex = 1
        Me.EngineManager.Visible = False
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(24, 21)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(401, 80)
        Me.Status.TabIndex = 2
        Me.Status.Text = "Connecting to Milestone"
        Me.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageViewer
        '
        Me.ImageViewer.Enabled = True
        Me.ImageViewer.Location = New System.Drawing.Point(12, 113)
        Me.ImageViewer.Name = "ImageViewer"
        Me.ImageViewer.OcxState = CType(resources.GetObject("ImageViewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImageViewer.Size = New System.Drawing.Size(100, 50)
        Me.ImageViewer.TabIndex = 3
        Me.ImageViewer.Visible = False
        '
        'ImportCams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.ImageViewer)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.EngineManager)
        Me.Controls.Add(Me.ExitBtn)
        Me.Name = "ImportCams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Cameras"
        CType(Me.EngineManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents EngineManager As AxEngineManagerLib.AxEngineManager
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents ImageViewer As AxImageViewerLib.AxImageViewerDotNet
End Class
