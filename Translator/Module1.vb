Imports System.Data.OleDb
Imports System.Data
Module Module1
    Public civilLetter = "B.1." '
    Public electricLetter = "B.2." '
    Public networkLetter = "B.3." '
    Public multimediaLetter = "B.4." '
    Public osLetter = "B.5." '
    Public programmingLetter = "B.6." '
    Public repairLetter = "B.7." '
    Public toothLetter = "B.8." '
    Public webLetter = "B.9." '
    Public securityLetter = "B.0."

    '******************* NO field of Tabels ***********

    Public connectionString As String = "Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;data source = " & Application.StartupPath & "\Database1.sdf"
    Public sqlTabel As New DataTable
    Public Civil, programming, web, multimedia, network, tooth, os, electric, security, repair As Boolean
    Public DeleteString As String = "Do you Want to Delete "
    Public ExitString As String = "Do you Realy Want to Exit ?"

    Public Function dbInsert(tbl As String, no As String, name As String, trans As String)
        Using con As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand(Nothing, con)
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                cmd.CommandText = "Insert into " & tbl & " (no , name , translate) values ('" & no & "','" & name & "','" & trans & "')"
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Return 0
    End Function
    Public Function seqTbl(txt As String)
        Dim table As New DataTable
        Try
            Using conn As New OleDbConnection(connectionString)
                Dim sqlAdp As New OleDb.OleDbDataAdapter("select * from " & txt, conn)
                sqlAdp.Fill(table)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function
    Public Function sqlqryTable(txt As String) As DataTable
        Dim table As New DataTable
        Try
            Using conn As New OleDbConnection(connectionString)
                Dim sqlAdp As New OleDb.OleDbDataAdapter(sqlGen(txt), conn)
                sqlAdp.Fill(table)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function
    Public Sub Jarves(txt As String) 'البتاع حق أيرون مان هههههه
        Dim Jarves
        Jarves = CreateObject("sapi.spvoice")
        Jarves.speak(txt)
    End Sub
    Public Function sqlGen(txt As String) As String
        Dim sqlSat As String
        sqlSat = "select name as Word, Translate as Translation from "
        Dim sett As New Settings
        sett.loadSettings()
        For Each table In {sett.civilChk, sett.webchk, sett.osChk, sett.progChk, sett.mdachk, sett.netChk, sett.scuChk, sett.toothChk, sett.rprchk, sett.electChk}
            If table.Checked = True Then
                Select Case table.Text
                    Case "Civil"
                        sqlSat += "civil where name like '" & txt & "%'"
                    Case "Web"
                        sqlSat += "web where name like '" & txt & "%'"
                    Case "OS"
                        sqlSat += "os where name like '" & txt & "%'"
                    Case "Programming"
                        sqlSat += "programming where name like '" & txt & "%'"
                    Case "Multimedia"
                        sqlSat += "multimedia where name like '" & txt & "%'"
                    Case "Network"
                        sqlSat += "network where name like '" & txt & "%'"
                    Case "Security"
                        sqlSat += "security where name like '" & txt & "%'"
                    Case "Tooth"
                        sqlSat += "TOOTH where name like '" & txt & "%'"
                    Case "Repair"
                        sqlSat += "repair where name like '" & txt & "%'"
                    Case "Electric"
                        sqlSat += "electric where name like '" & txt & "%'"
                End Select
                sqlSat += " union select name , translate from " 'length is 36
            End If
        Next
        sqlSat = LSet(sqlSat, sqlSat.Length - 35) ' this line deletes the last union statment not needed from generated SQLStatment
        Return sqlSat
    End Function
    Public Function seqGen(letter As String, table As DataTable) As String
        Dim no As String
        no = letter & table.Rows.Count + 1
        Return no
    End Function
End Module
