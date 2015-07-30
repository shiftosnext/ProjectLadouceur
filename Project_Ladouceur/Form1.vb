Public Class Form1

    Public selectedctrl As Object

    Public Sub Log(text As String)
        LogText.Text = "[" & Now.TimeOfDay.ToString & "] " & text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripManager.Renderer = New LadouceurDark.Renderer
        Log("Session loaded.")
        MsgBox("Hey there, everyone. Michael here, developer of this editor prototype. Currently it does NOT support the creation and generation of the files required for a Visual Studio 2013 solution to be created. It can only assist in the creation of the Visual Basic code files. You'll have to create, and compile the project yourself.", MsgBoxStyle.Exclamation, "Word of advice from the developer")
        pnlpreview.ContextMenuStrip = CTRLRightClickMenu
    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        AddControl.base = pnlpreview
        AddControl.ShowDialog()
    End Sub

    Public Sub PreviewClick(sender As Object, e As MouseEventArgs)
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                selectedCTRL = sender
            Case Windows.Forms.MouseButtons.Right
                selectedCTRL = sender
                pnlpreview.ContextMenuStrip.Show(e.Location)
        End Select
    End Sub

    Public Sub addcontrolhandlers()
        For Each CTRL As Control In pnlpreview.Controls
            AddHandler CTRL.MouseDown, AddressOf PreviewClick
        Next
    End Sub

    Private Sub SetForeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetForeColorToolStripMenuItem.Click
        Dim colpick As New ColorDialog
        If colpick.ShowDialog() = Windows.Forms.DialogResult.OK Then
            selectedctrl.ForeColor = colpick.Color
        End If
    End Sub

    Private Sub SetBackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetBackColorToolStripMenuItem.Click
        Dim colpick As New ColorDialog
        If colpick.ShowDialog() = Windows.Forms.DialogResult.OK Then
            selectedctrl.BackColor = colpick.Color
            Select Case selectedctrl.Tag
                Case "Button"
                    selectedctrl.FlatStyle = FlatStyle.Flat

            End Select
        End If
    End Sub
End Class
