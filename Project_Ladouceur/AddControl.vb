Public Class AddControl

    Public base As Object

    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Dim newctrl As Object
        Dim cancel As Boolean = False
        Select Case cmbctrltype.SelectedItem
            Case "Button"
                newctrl = New Button()
            Case "Menu Bar"
                newctrl = New MenuStrip()
            Case "Tool Bar"
                newctrl = New ToolStrip()
            Case "Panel"
                newctrl = New Panel()
            Case "Icon View"
                newctrl = New ListView()
            Case Else
                MsgBox("Control type can't be null.")
                Cancel = True
        End Select
        If cancel = False Then
            If Not ctrlid.Text = "" Then
                newctrl.name = ctrlid.Text
                newctrl.location = New Point(4, 4)
                Select Case cmbctrltype.SelectedItem
                    Case "Button"
                        newctrl.Text = "Text"
                End Select
                newctrl.ForeColor = Color.Black
                base.Controls.Add(newctrl)
                newctrl.tag = cmbctrltype.SelectedItem
                newctrl.show()
                Form1.addcontrolhandlers()
            Else
                MsgBox("Control ID cannot be null, according to the Visual Basic compiler.")
                cancel = True
            End If
        Else
            Me.Close()
        End If

    End Sub




End Class