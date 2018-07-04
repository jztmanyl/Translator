Public Class saveProgress
    Public amount As Integer
    Public addAmount As Double = 0
    Dim counter As Integer = 0
    Public Function progressAddition() As Double
        Dim result As Double
        If amount > 100 Then
            ProgressBar1.Maximum = amount
            result = 1 / amount
        Else
            result = 100 / amount
        End If
        Return result
    End Function
    Public Sub addRowToDb()
        Dim s As DataGridView = Add.DataGridView1
        For i As Integer = 0 To amount - 1
            If counter < amount Then
                Select Case s.Rows(counter).Cells(2).Value
                    Case "Civil"
                        dbInsert("civil", seqGen(civilLetter, seqTbl("civil")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "Electric"
                        dbInsert("Electric", seqGen(civilLetter, seqTbl("Electric")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "Multimedia"
                        dbInsert("Multimedia", seqGen(civilLetter, seqTbl("Multimedia")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "Web"
                        dbInsert("Web", seqGen(civilLetter, seqTbl("Web")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "Repair"
                        dbInsert("Repair", seqGen(civilLetter, seqTbl("Repair")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "Network"
                        dbInsert("Network", seqGen(civilLetter, seqTbl("Network")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "OS"
                        dbInsert("os", seqGen(civilLetter, seqTbl("os")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "Programming"
                        dbInsert("Programming", seqGen(civilLetter, seqTbl("Programming")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "Security"
                        dbInsert("Security", seqGen(civilLetter, seqTbl("Security")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                    Case "Tooth"
                        dbInsert("Tooth", seqGen(civilLetter, seqTbl("Tooth")), s.Rows(counter).Cells(0).Value, s.Rows(counter).Cells(1).Value)
                End Select
                counter += 1
                ProgressBar1.Value += addAmount
                progresslbl.Text = counter & "/" & amount
            End If
        Next
        progresslbl.Text += " Completed !"
        Button1.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add.DataGridView1.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub saveProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        addAmount = progressAddition()
        addRowToDb()
        Timer1.Enabled = False
    End Sub
End Class