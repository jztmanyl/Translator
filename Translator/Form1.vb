Imports System.Data.OleDb
Imports System.Data
Public Class Main
    Public Sub resetDGV()
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Refresh()
    End Sub
    Public mainCon As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;data source = C:\Users\medo\Desktop\Hiba\project\Database1.sdf")

    Private Sub sqlQry()
        Try
            Dim per As Char = "%"
            Dim sqlSat As String
            sqlSat = "select * from "
            Dim sett As New Settings
            sett.loadSettings()
            For Each table In {sett.civilChk, sett.webchk, sett.osChk, sett.progChk, sett.mdachk, sett.netChk, sett.scuChk, sett.toothChk, sett.rprchk, sett.electChk}
                If table.Checked = True Then
                    Select Case table.Text
                        Case "Civil"
                            sqlSat += "civil where name like '" & Me.TextBox1.Text & "'%"
                        Case "Web"
                            sqlSat += "web where name like '" & Me.TextBox1.Text & "'%"
                        Case "OS"
                            sqlSat += "os where name like '" & Me.TextBox1.Text & "'%"
                        Case "Programming"
                            sqlSat += "programming where name like '" & Me.TextBox1.Text & "'%"
                        Case "Multimedia"
                            sqlSat += "multimedia where name like '" & Me.TextBox1.Text + per & "'"
                        Case "Network"
                            sqlSat += "network where name like '" & Me.TextBox1.Text & "'%"
                        Case "Security"
                            sqlSat += "security where name like '" & Me.TextBox1.Text & "'%"
                        Case "Tooth"
                            sqlSat += "TOOTH where name like '" & Me.TextBox1.Text & "'%"
                        Case "Repair"
                            sqlSat += "repair where name like '" & Me.TextBox1.Text & "'%"
                        Case "Electric"
                            sqlSat += "electric where name like '" & Me.TextBox1.Text & "'%"
                    End Select
                    sqlSat += " union select * from " '22

                End If
            Next
            sqlSat = LSet(sqlSat, sqlSat.Length - 22)
            MsgBox(sqlSat)
            Dim qrySet As New DataSet
            Dim qryAdp As New OleDb.OleDbDataAdapter(sqlSat, mainCon)
            Dim dbinding As New BindingSource
            Try
                If mainCon.State = ConnectionState.Open Then mainCon.Close()
                mainCon.Open()
                qrySet.Clear()
                qryAdp.Fill(qrySet)
                Me.DataGridView1.DataSource = qrySet
                DataGridView1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                mainCon.Close()
            End Try
        Catch e As Exception
            MsgBox("Translation Settings not set yet , Set it Now", vbOKOnly + vbExclamation, "Warning")
            Dim settingfrm As New Settings
            settingfrm.loadSettings()
            settingfrm.ShowDialog()
            sqlQry()
        End Try
    End Sub
    Private Function ExitConfirm(obj As FormClosingEventArgs) As FormClosingEventArgs
        Dim e As FormClosingEventArgs = obj
        If MsgBox("Are You Sure You Want To Close Translator ?", MsgBoxStyle.Question + vbYesNo, "Confirm Exit") = vbYes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
        Return e
    End Function
    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click, OptionsToolStripMenuItem.Click
        Dim sett As New Settings
        sett.ShowDialog()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click, NewToolStripMenuItem.Click
        Dim addFrm As New Add
        Add.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = ExitConfirm(e).Cancel
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resetDGV()
        If sqlqryTable(TextBox1.Text).Rows.Count >= 1 Then
            DataGridView1.DataSource = sqlqryTable(TextBox1.Text)
            DataGridView1.Refresh()
        Else
            resetDGV()
            DataGridView1.Columns.Add("clnWord", "Word")
            DataGridView1.Columns.Add("clnTrans", "Translation")
            Me.DataGridView1.Columns(1).Width = 165
            DataGridView1.Rows.Add("word not found", "translation not found")
            DataGridView1.Update()
            Jarves("Word you have Enter does not Exist , Please Add it To Translator Database .")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Trim <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.civil' table. You can move, or remove it, as needed.
        Me.CivilTableAdapter.Fill(Me.DataSet1.civil)

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If Me.DataGridView1.SelectedRows.Count >= 1 Then
            Dim sr As DataGridViewRow
            sr = Me.DataGridView1.SelectedRows(0)
            Jarves(sr.Cells(0).Value.ToString & " .")
        Else
            Jarves("There is No Rows or there is no row selected .")
        End If
    End Sub
End Class
