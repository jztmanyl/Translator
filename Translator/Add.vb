Public Class Add
    Public multi As Boolean = False
    Public civilAdp As New OleDb.OleDbDataAdapter("Select * from civil", connectionString)
    Public webAdp As New OleDb.OleDbDataAdapter("Select * from web", connectionString)
    Public electAdp As New OleDb.OleDbDataAdapter("Select * from electric", connectionString)
    Public multimediaAdp As New OleDb.OleDbDataAdapter("Select * from multimedia", connectionString)
    Public toothAdp As New OleDb.OleDbDataAdapter("Select * from tooth", connectionString)
    Public repairAdp As New OleDb.OleDbDataAdapter("Select * from repair", connectionString)
    Public osAdp As New OleDb.OleDbDataAdapter("Select * from os", connectionString)
    Public secuAdp As New OleDb.OleDbDataAdapter("Select * from security", connectionString)
    Public progAdp As New OleDb.OleDbDataAdapter("Select * from programming", connectionString)
    Public netAdp As New OleDb.OleDbDataAdapter("Select * from network", connectionString)
    Private Sub resetForm()
        Me.TextBox1.Text = Nothing
        Me.TextBox2.Text = Nothing
        For Each n In Me.GroupBox2.Controls
            If TypeOf n Is CheckBox Then
                n.checked = False
            End If
        Next
    End Sub
    Private Sub addToDataBase(text As String, trans As String)
        For Each c In Me.GroupBox2.Controls
            If TypeOf c Is CheckBox Then
                If c.checked = True Then
                    Select Case c.text
                        Case "Civil"
                            dbInsert("civil", seqGen(civilLetter, seqTbl("civil")), text, trans)
                        Case "Electric"
                            dbInsert("Electric", seqGen(civilLetter, seqTbl("Electric")), text, trans)
                        Case "Multimedia"
                            dbInsert("Multimedia", seqGen(civilLetter, seqTbl("Multimedia")), text, trans)
                        Case "Web"
                            dbInsert("Web", seqGen(civilLetter, seqTbl("Web")), text, trans)
                        Case "Repair"
                            dbInsert("Repair", seqGen(civilLetter, seqTbl("Repair")), text, trans)
                        Case "Network"
                            dbInsert("Network", seqGen(civilLetter, seqTbl("Network")), text, trans)
                        Case "OS"
                            dbInsert("os", seqGen(civilLetter, seqTbl("os")), text, trans)
                        Case "Programming"
                            dbInsert("Programming", seqGen(civilLetter, seqTbl("Programming")), text, trans)
                        Case "Security"
                            dbInsert("Security", seqGen(civilLetter, seqTbl("Security")), text, trans)
                        Case "Tooth"
                            dbInsert("Tooth", seqGen(civilLetter, seqTbl("Tooth")), text, trans)
                        Case Else
                            MsgBox("not found", vbExclamation + vbOKOnly, "Erorr")
                    End Select
                End If
            End If
        Next
        resetForm()
        MsgBox("Data Saved Successfuly !", vbOKOnly + vbInformation, "Success")
    End Sub
    Private Sub addRow()
        For Each chk In Me.GroupBox2.Controls
            If TypeOf chk Is CheckBox Then
                If chk.checked = True Then
                    DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, chk.text)
                End If
            End If
        Next
        resetForm()
    End Sub
    Sub setMulti() Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            multiAdd.Visible = True
            Button1.Text = "Add"
            Me.Height = 466
            multi = True
        Else
            multiAdd.Visible = False
            Me.Height = 201
            multi = False
            Button1.Text = "Submit"
        End If
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Main.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setMulti()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text.Trim <> "") And (TextBox2.Text.Trim <> "") Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If (TextBox1.Text.Trim <> "") And (TextBox2.Text.Trim <> "") Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If multi = True Then
            addRow()
        Else
            addToDataBase(TextBox1.Text, TextBox2.Text)
        End If
    End Sub

    Private Sub CivilBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CivilBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub CivilBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub setMulti(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If Me.DataGridView1.RowCount <> 0 Then
            Dim saveDialog As New saveProgress
            saveDialog.amount = Me.DataGridView1.RowCount
            saveDialog.ShowDialog()
        Else
            MsgBox("There is no rows to add !", vbOKOnly + vbCritical, "Erorr")
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        resetdgv.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles resetdgv.Click
        DataGridView1.Rows.Clear()
        resetdgv.Enabled = False
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If DataGridView1.SelectedRows.Count >= 1 Then
            Dim SelectedRow As DataGridViewRow
            SelectedRow = DataGridView1.SelectedRows(0)
            Dim msgString As String = DeleteString & SelectedRow.Cells(0).Value
            Jarves(msgString)
            If MsgBox(msgString, vbYesNo + vbQuestion, "Delete Confirm") = vbYes Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows.Item(0))
            End If
        Else
            MsgBox("Select Row to Delete !", vbExclamation + vbOKOnly, "No Row Selected")
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim selectedRow As DataGridViewRow
        If DataGridView1.Rows.Count >= 1 Then
            selectedRow = DataGridView1.SelectedRows.Item(0)
            Jarves(selectedRow.Cells(0).Value)
        Else
            Jarves("There is no row selected , Please Select Row First")
        End If
    End Sub
End Class