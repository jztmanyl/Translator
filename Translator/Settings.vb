Public Class Settings
    Private settingsChange As Boolean
    Public Sub resetSettings()
        Civil = False
        programming = False
        web = False
        multimedia = False
        network = False
        tooth = False
        os = False
        electric = False
        security = False
        repair = False
    End Sub
    Public Sub loadSettings()
        Me.civilChk.Checked = Civil
        Me.progChk.Checked = programming
        Me.webchk.Checked = web
        Me.mdachk.Checked = multimedia
        Me.netChk.Checked = network
        Me.osChk.Checked = os
        Me.scuChk.Checked = security
        Me.rprchk.Checked = repair
        Me.toothChk.Checked = tooth
        Me.electChk.Checked = electric
    End Sub
    Public Sub saveSettings()
        electric = Me.electChk.Checked
        Civil = Me.civilChk.Checked
        programming = Me.progChk.Checked
        web = Me.webchk.Checked
        multimedia = Me.mdachk.Checked
        network = Me.netChk.Checked
        os = Me.osChk.Checked
        security = Me.scuChk.Checked
        repair = Me.rprchk.Checked
        tooth = Me.toothChk.Checked
    End Sub
    Public Function checkSettings() As Boolean
        Dim change As Boolean
        If Me.rprchk.Checked = repair And Me.scuChk.Checked = security And Me.webchk.Checked = web And Me.osChk.Checked = os And Me.progChk.Checked = programming And Me.civilChk.Checked = Civil And Me.netChk.Checked = network And Me.mdachk.Checked = multimedia And Me.electChk.Checked = electric And Me.toothChk.Checked = tooth Then
            Me.Button2.Enabled = False
            change = False
        Else
            Me.Button2.Enabled = True
            change = True
        End If
        Return change
    End Function
    Private Sub chkChange() Handles civilChk.Click, electChk.Click, mdachk.Click, netChk.Click, osChk.Click, progChk.Click, rprchk.Click, scuChk.Click, toothChk.Click, webchk.Click
        settingsChange = checkSettings()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If settingsChange Then
            If MsgBox("Exit Without Saving Settings ?", vbYesNo + MsgBoxStyle.Question, "Setting Changed !") = vbYes Then
                Me.Close()
            Else
                saveSettings()
                Me.Close()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSettings()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        saveSettings()
        settingsChange = False
        MsgBox("Settings Had Been Saved Seccessfuly ! ", vbOKOnly + MsgBoxStyle.Information, "Success")
        Button2.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        saveSettings()
        settingsChange = False
        Me.Close()
    End Sub
End Class