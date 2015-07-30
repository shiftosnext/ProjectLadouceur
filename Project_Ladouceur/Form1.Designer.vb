<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ActionMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBar = New System.Windows.Forms.ToolStrip()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LogText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportVBCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BootScreenEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetadataEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlpreview = New System.Windows.Forms.Panel()
        Me.btnaddnew = New System.Windows.Forms.ToolStripButton()
        Me.CTRLRightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetForeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetBackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionMenu.SuspendLayout()
        Me.ToolBar.SuspendLayout()
        Me.Status.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.CTRLRightClickMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActionMenu
        '
        Me.ActionMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectToolStripMenuItem})
        Me.ActionMenu.Location = New System.Drawing.Point(0, 0)
        Me.ActionMenu.Name = "ActionMenu"
        Me.ActionMenu.Size = New System.Drawing.Size(529, 24)
        Me.ActionMenu.TabIndex = 2
        Me.ActionMenu.Text = "MenuStrip3"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.ToolStripMenuItem2, Me.OpenProjectToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExportVBCodeToolStripMenuItem, Me.ToolStripMenuItem4, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolBar
        '
        Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnaddnew})
        Me.ToolBar.Location = New System.Drawing.Point(0, 24)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(529, 25)
        Me.ToolBar.TabIndex = 3
        Me.ToolBar.Text = "ToolStrip1"
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LogText})
        Me.Status.Location = New System.Drawing.Point(0, 329)
        Me.Status.Name = "Status"
        Me.Status.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.Status.Size = New System.Drawing.Size(529, 22)
        Me.Status.TabIndex = 4
        Me.Status.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(30, 17)
        Me.ToolStripStatusLabel1.Text = "Log:"
        '
        'LogText
        '
        Me.LogText.Name = "LogText"
        Me.LogText.Size = New System.Drawing.Size(121, 17)
        Me.LogText.Text = "ToolStripStatusLabel2"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        '
        'OpenProjectToolStripMenuItem
        '
        Me.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem"
        Me.OpenProjectToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OpenProjectToolStripMenuItem.Text = "Open Project"
        '
        'SaveProjectToolStripMenuItem
        '
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        Me.SaveProjectToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveProjectToolStripMenuItem.Text = "Save Project"
        '
        'ExportVBCodeToolStripMenuItem
        '
        Me.ExportVBCodeToolStripMenuItem.Name = "ExportVBCodeToolStripMenuItem"
        Me.ExportVBCodeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExportVBCodeToolStripMenuItem.Text = "Export VB Code"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 6)
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BootScreenEditorToolStripMenuItem, Me.MetadataEditorToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'BootScreenEditorToolStripMenuItem
        '
        Me.BootScreenEditorToolStripMenuItem.Name = "BootScreenEditorToolStripMenuItem"
        Me.BootScreenEditorToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.BootScreenEditorToolStripMenuItem.Text = "Boot Screen Editor"
        Me.BootScreenEditorToolStripMenuItem.ToolTipText = resources.GetString("BootScreenEditorToolStripMenuItem.ToolTipText")
        '
        'MetadataEditorToolStripMenuItem
        '
        Me.MetadataEditorToolStripMenuItem.Name = "MetadataEditorToolStripMenuItem"
        Me.MetadataEditorToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.MetadataEditorToolStripMenuItem.Text = "Metadata editor"
        Me.MetadataEditorToolStripMenuItem.ToolTipText = resources.GetString("MetadataEditorToolStripMenuItem.ToolTipText")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlpreview)
        Me.SplitContainer1.Size = New System.Drawing.Size(529, 280)
        Me.SplitContainer1.SplitterDistance = 191
        Me.SplitContainer1.TabIndex = 5
        '
        'pnlpreview
        '
        Me.pnlpreview.BackColor = System.Drawing.Color.White
        Me.pnlpreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlpreview.Location = New System.Drawing.Point(0, 0)
        Me.pnlpreview.Name = "pnlpreview"
        Me.pnlpreview.Size = New System.Drawing.Size(334, 280)
        Me.pnlpreview.TabIndex = 0
        '
        'btnaddnew
        '
        Me.btnaddnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnaddnew.Image = CType(resources.GetObject("btnaddnew.Image"), System.Drawing.Image)
        Me.btnaddnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(42, 22)
        Me.btnaddnew.Text = "Add..."
        '
        'CTRLRightClickMenu
        '
        Me.CTRLRightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetForeColorToolStripMenuItem, Me.SetBackColorToolStripMenuItem, Me.SetTextToolStripMenuItem, Me.SetSizeToolStripMenuItem, Me.SetLocationToolStripMenuItem})
        Me.CTRLRightClickMenu.Name = "CTRLRightClickMenu"
        Me.CTRLRightClickMenu.Size = New System.Drawing.Size(153, 136)
        '
        'SetForeColorToolStripMenuItem
        '
        Me.SetForeColorToolStripMenuItem.Name = "SetForeColorToolStripMenuItem"
        Me.SetForeColorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SetForeColorToolStripMenuItem.Text = "Set ForeColor"
        '
        'SetBackColorToolStripMenuItem
        '
        Me.SetBackColorToolStripMenuItem.Name = "SetBackColorToolStripMenuItem"
        Me.SetBackColorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SetBackColorToolStripMenuItem.Text = "Set BackColor"
        '
        'SetTextToolStripMenuItem
        '
        Me.SetTextToolStripMenuItem.Name = "SetTextToolStripMenuItem"
        Me.SetTextToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SetTextToolStripMenuItem.Text = "Set Text"
        '
        'SetSizeToolStripMenuItem
        '
        Me.SetSizeToolStripMenuItem.Name = "SetSizeToolStripMenuItem"
        Me.SetSizeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SetSizeToolStripMenuItem.Text = "Set Size"
        '
        'SetLocationToolStripMenuItem
        '
        Me.SetLocationToolStripMenuItem.Name = "SetLocationToolStripMenuItem"
        Me.SetLocationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SetLocationToolStripMenuItem.Text = "Set Location"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(529, 351)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.ActionMenu)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Project Ladouceur"
        Me.ActionMenu.ResumeLayout(False)
        Me.ActionMenu.PerformLayout()
        Me.ToolBar.ResumeLayout(False)
        Me.ToolBar.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.CTRLRightClickMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActionMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBar As System.Windows.Forms.ToolStrip
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LogText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportVBCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BootScreenEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetadataEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnaddnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlpreview As System.Windows.Forms.Panel
    Friend WithEvents CTRLRightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SetForeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetBackColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
