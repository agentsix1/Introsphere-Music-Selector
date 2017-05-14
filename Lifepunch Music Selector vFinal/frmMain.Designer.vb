<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoCheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoAPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnabledToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisabledToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsernameHereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(470, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoCheckForUpdatesToolStripMenuItem, Me.AutoAPIToolStripMenuItem})
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AutoCheckForUpdatesToolStripMenuItem
        '
        Me.AutoCheckForUpdatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem, Me.DisabledToolStripMenuItem})
        Me.AutoCheckForUpdatesToolStripMenuItem.Name = "AutoCheckForUpdatesToolStripMenuItem"
        Me.AutoCheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AutoCheckForUpdatesToolStripMenuItem.Text = "Auto Check For Updates"
        '
        'EnabledToolStripMenuItem
        '
        Me.EnabledToolStripMenuItem.Checked = True
        Me.EnabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnabledToolStripMenuItem.Name = "EnabledToolStripMenuItem"
        Me.EnabledToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EnabledToolStripMenuItem.Text = "Enabled"
        '
        'DisabledToolStripMenuItem
        '
        Me.DisabledToolStripMenuItem.Name = "DisabledToolStripMenuItem"
        Me.DisabledToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DisabledToolStripMenuItem.Text = "Disabled"
        '
        'AutoAPIToolStripMenuItem
        '
        Me.AutoAPIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem1, Me.DisabledToolStripMenuItem1})
        Me.AutoAPIToolStripMenuItem.Name = "AutoAPIToolStripMenuItem"
        Me.AutoAPIToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AutoAPIToolStripMenuItem.Text = "Auto API"
        '
        'EnabledToolStripMenuItem1
        '
        Me.EnabledToolStripMenuItem1.Name = "EnabledToolStripMenuItem1"
        Me.EnabledToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.EnabledToolStripMenuItem1.Text = "Enabled"
        '
        'DisabledToolStripMenuItem1
        '
        Me.DisabledToolStripMenuItem1.Checked = True
        Me.DisabledToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DisabledToolStripMenuItem1.Name = "DisabledToolStripMenuItem1"
        Me.DisabledToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.DisabledToolStripMenuItem1.Text = "Disabled"
        '
        'ConsoleToolStripMenuItem
        '
        Me.ConsoleToolStripMenuItem.Name = "ConsoleToolStripMenuItem"
        Me.ConsoleToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ConsoleToolStripMenuItem.Text = "Console"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(88, 20)
        Me.ToolStripMenuItem1.Text = "                       "
        '
        'PrivateToolStripMenuItem
        '
        Me.PrivateToolStripMenuItem.Name = "PrivateToolStripMenuItem"
        Me.PrivateToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.PrivateToolStripMenuItem.Text = "Private:"
        '
        'UsernameHereToolStripMenuItem
        '
        Me.UsernameHereToolStripMenuItem.Name = "UsernameHereToolStripMenuItem"
        Me.UsernameHereToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.UsernameHereToolStripMenuItem.Text = "Username Here"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Song/Audio File List", "--------------------------------------------------------------------"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 67)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(470, 238)
        Me.ListBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Audio File"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(325, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "UP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(364, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "DOWN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(420, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "REMOVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(278, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "ADD"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(128, 66)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 24)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Change"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(203, 67)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Restore"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ofdBrowse
        '
        Me.ofdBrowse.Filter = "Audio Files|*.mp3;*.wav"
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Black
        Me.pbLogo.Image = Global.Lifepunch_Music_Selector_vFinal.My.Resources.Resources.lpico
        Me.pbLogo.Location = New System.Drawing.Point(12, 311)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(470, 88)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 12
        Me.pbLogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(470, 163)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 417)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(470, 163)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "asdfasdf"
        Me.TextBox1.Visible = False
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(396, 557)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(86, 23)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "View Full Log"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(494, 410)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Introsphere Music Selector v1.0 - By: Agentsix1"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoCheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnabledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisabledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoAPIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnabledToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DisabledToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents ConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ofdBrowse As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrivateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsernameHereToolStripMenuItem As ToolStripMenuItem
End Class
