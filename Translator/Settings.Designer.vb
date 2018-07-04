<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.toothChk = New System.Windows.Forms.CheckBox()
        Me.rprchk = New System.Windows.Forms.CheckBox()
        Me.scuChk = New System.Windows.Forms.CheckBox()
        Me.progChk = New System.Windows.Forms.CheckBox()
        Me.osChk = New System.Windows.Forms.CheckBox()
        Me.netChk = New System.Windows.Forms.CheckBox()
        Me.webchk = New System.Windows.Forms.CheckBox()
        Me.mdachk = New System.Windows.Forms.CheckBox()
        Me.electChk = New System.Windows.Forms.CheckBox()
        Me.civilChk = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 191)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Settings"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(302, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(405, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Apply"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.toothChk)
        Me.GroupBox2.Controls.Add(Me.rprchk)
        Me.GroupBox2.Controls.Add(Me.scuChk)
        Me.GroupBox2.Controls.Add(Me.progChk)
        Me.GroupBox2.Controls.Add(Me.osChk)
        Me.GroupBox2.Controls.Add(Me.netChk)
        Me.GroupBox2.Controls.Add(Me.webchk)
        Me.GroupBox2.Controls.Add(Me.mdachk)
        Me.GroupBox2.Controls.Add(Me.electChk)
        Me.GroupBox2.Controls.Add(Me.civilChk)
        Me.GroupBox2.Location = New System.Drawing.Point(199, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 143)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Where To Look"
        '
        'toothChk
        '
        Me.toothChk.AutoSize = True
        Me.toothChk.Location = New System.Drawing.Point(168, 112)
        Me.toothChk.Name = "toothChk"
        Me.toothChk.Size = New System.Drawing.Size(54, 17)
        Me.toothChk.TabIndex = 9
        Me.toothChk.Text = "Tooth"
        Me.toothChk.UseVisualStyleBackColor = True
        '
        'rprchk
        '
        Me.rprchk.AutoSize = True
        Me.rprchk.Location = New System.Drawing.Point(39, 112)
        Me.rprchk.Name = "rprchk"
        Me.rprchk.Size = New System.Drawing.Size(57, 17)
        Me.rprchk.TabIndex = 8
        Me.rprchk.Text = "Repair"
        Me.rprchk.UseVisualStyleBackColor = True
        '
        'scuChk
        '
        Me.scuChk.AutoSize = True
        Me.scuChk.Location = New System.Drawing.Point(168, 89)
        Me.scuChk.Name = "scuChk"
        Me.scuChk.Size = New System.Drawing.Size(65, 17)
        Me.scuChk.TabIndex = 7
        Me.scuChk.Text = "Security"
        Me.scuChk.UseVisualStyleBackColor = True
        '
        'progChk
        '
        Me.progChk.AutoSize = True
        Me.progChk.Location = New System.Drawing.Point(168, 66)
        Me.progChk.Name = "progChk"
        Me.progChk.Size = New System.Drawing.Size(88, 17)
        Me.progChk.TabIndex = 6
        Me.progChk.Text = "Programming"
        Me.progChk.UseVisualStyleBackColor = True
        '
        'osChk
        '
        Me.osChk.AutoSize = True
        Me.osChk.Location = New System.Drawing.Point(168, 43)
        Me.osChk.Name = "osChk"
        Me.osChk.Size = New System.Drawing.Size(40, 17)
        Me.osChk.TabIndex = 5
        Me.osChk.Text = "OS"
        Me.osChk.UseVisualStyleBackColor = True
        '
        'netChk
        '
        Me.netChk.AutoSize = True
        Me.netChk.Location = New System.Drawing.Point(168, 20)
        Me.netChk.Name = "netChk"
        Me.netChk.Size = New System.Drawing.Size(66, 17)
        Me.netChk.TabIndex = 4
        Me.netChk.Text = "Network"
        Me.netChk.UseVisualStyleBackColor = True
        '
        'webchk
        '
        Me.webchk.AutoSize = True
        Me.webchk.Location = New System.Drawing.Point(39, 89)
        Me.webchk.Name = "webchk"
        Me.webchk.Size = New System.Drawing.Size(48, 17)
        Me.webchk.TabIndex = 3
        Me.webchk.Text = "Web"
        Me.webchk.UseVisualStyleBackColor = True
        '
        'mdachk
        '
        Me.mdachk.AutoSize = True
        Me.mdachk.Location = New System.Drawing.Point(39, 66)
        Me.mdachk.Name = "mdachk"
        Me.mdachk.Size = New System.Drawing.Size(76, 17)
        Me.mdachk.TabIndex = 2
        Me.mdachk.Text = "Multimedia"
        Me.mdachk.UseVisualStyleBackColor = True
        '
        'electChk
        '
        Me.electChk.AutoSize = True
        Me.electChk.Location = New System.Drawing.Point(39, 43)
        Me.electChk.Name = "electChk"
        Me.electChk.Size = New System.Drawing.Size(60, 17)
        Me.electChk.TabIndex = 1
        Me.electChk.Text = "Electric"
        Me.electChk.UseVisualStyleBackColor = True
        '
        'civilChk
        '
        Me.civilChk.AutoSize = True
        Me.civilChk.Location = New System.Drawing.Point(39, 20)
        Me.civilChk.Name = "civilChk"
        Me.civilChk.Size = New System.Drawing.Size(45, 17)
        Me.civilChk.TabIndex = 0
        Me.civilChk.Text = "Civil"
        Me.civilChk.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 207)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "         "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents toothChk As System.Windows.Forms.CheckBox
    Friend WithEvents rprchk As System.Windows.Forms.CheckBox
    Friend WithEvents scuChk As System.Windows.Forms.CheckBox
    Friend WithEvents progChk As System.Windows.Forms.CheckBox
    Friend WithEvents osChk As System.Windows.Forms.CheckBox
    Friend WithEvents netChk As System.Windows.Forms.CheckBox
    Friend WithEvents webchk As System.Windows.Forms.CheckBox
    Friend WithEvents mdachk As System.Windows.Forms.CheckBox
    Friend WithEvents electChk As System.Windows.Forms.CheckBox
    Friend WithEvents civilChk As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
