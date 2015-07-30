<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddControl
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
        Me.cmbctrltype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ctrlid = New System.Windows.Forms.TextBox()
        Me.btndone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbctrltype
        '
        Me.cmbctrltype.FormattingEnabled = True
        Me.cmbctrltype.Items.AddRange(New Object() {"Button", "Menu Bar", "Tool Bar", "Panel", "Icon View"})
        Me.cmbctrltype.Location = New System.Drawing.Point(13, 53)
        Me.cmbctrltype.Name = "cmbctrltype"
        Me.cmbctrltype.Size = New System.Drawing.Size(236, 21)
        Me.cmbctrltype.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Control ID (VB: control.name As String)"
        '
        'ctrlid
        '
        Me.ctrlid.Location = New System.Drawing.Point(13, 118)
        Me.ctrlid.Name = "ctrlid"
        Me.ctrlid.Size = New System.Drawing.Size(236, 20)
        Me.ctrlid.TabIndex = 4
        '
        'btndone
        '
        Me.btndone.Location = New System.Drawing.Point(178, 292)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(75, 23)
        Me.btndone.TabIndex = 5
        Me.btndone.Text = "Add"
        Me.btndone.UseVisualStyleBackColor = False
        '
        'AddControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(265, 327)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.ctrlid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbctrltype)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddControl"
        Me.Opacity = 0.75R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbctrltype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ctrlid As System.Windows.Forms.TextBox
    Friend WithEvents btndone As System.Windows.Forms.Button
End Class
