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
        Me.DigitalClockCtrl1 = New SriClocks.DigitalClockCtrl
        Me.gbSetAlarm = New System.Windows.Forms.GroupBox
        Me.tbAlarmTime = New System.Windows.Forms.TextBox
        Me.btnSetAlarm = New System.Windows.Forms.Button
        Me.gbAlarmSound = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAlarmSound = New System.Windows.Forms.Button
        Me.tbAlarmSound = New System.Windows.Forms.TextBox
        Me.diaOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.btnSnooze = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnStop = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAbout = New System.Windows.Forms.Button
        Me.cbBlackout = New System.Windows.Forms.CheckBox
        Me.cbScreenAlarm = New System.Windows.Forms.CheckBox
        Me.gbSetAlarm.SuspendLayout()
        Me.gbAlarmSound.SuspendLayout()
        Me.SuspendLayout()
        '
        'DigitalClockCtrl1
        '
        Me.DigitalClockCtrl1.BackColor = System.Drawing.Color.Black
        Me.DigitalClockCtrl1.CountDownTime = 10000
        Me.DigitalClockCtrl1.Location = New System.Drawing.Point(0, 0)
        Me.DigitalClockCtrl1.Name = "DigitalClockCtrl1"
        Me.DigitalClockCtrl1.SetClockType = SriClocks.ClockType.DigitalClock
        Me.DigitalClockCtrl1.Size = New System.Drawing.Size(586, 103)
        Me.DigitalClockCtrl1.TabIndex = 0
        '
        'gbSetAlarm
        '
        Me.gbSetAlarm.Controls.Add(Me.tbAlarmTime)
        Me.gbSetAlarm.Controls.Add(Me.btnSetAlarm)
        Me.gbSetAlarm.Location = New System.Drawing.Point(12, 166)
        Me.gbSetAlarm.Name = "gbSetAlarm"
        Me.gbSetAlarm.Size = New System.Drawing.Size(291, 64)
        Me.gbSetAlarm.TabIndex = 1
        Me.gbSetAlarm.TabStop = False
        Me.gbSetAlarm.Text = "Set Alarm"
        '
        'tbAlarmTime
        '
        Me.tbAlarmTime.Location = New System.Drawing.Point(6, 24)
        Me.tbAlarmTime.Name = "tbAlarmTime"
        Me.tbAlarmTime.Size = New System.Drawing.Size(198, 20)
        Me.tbAlarmTime.TabIndex = 1
        '
        'btnSetAlarm
        '
        Me.btnSetAlarm.Location = New System.Drawing.Point(210, 23)
        Me.btnSetAlarm.Name = "btnSetAlarm"
        Me.btnSetAlarm.Size = New System.Drawing.Size(75, 23)
        Me.btnSetAlarm.TabIndex = 0
        Me.btnSetAlarm.Text = "Set Alarm"
        Me.btnSetAlarm.UseVisualStyleBackColor = True
        '
        'gbAlarmSound
        '
        Me.gbAlarmSound.Controls.Add(Me.Label1)
        Me.gbAlarmSound.Controls.Add(Me.btnAlarmSound)
        Me.gbAlarmSound.Controls.Add(Me.tbAlarmSound)
        Me.gbAlarmSound.Location = New System.Drawing.Point(310, 167)
        Me.gbAlarmSound.Name = "gbAlarmSound"
        Me.gbAlarmSound.Size = New System.Drawing.Size(262, 73)
        Me.gbAlarmSound.TabIndex = 2
        Me.gbAlarmSound.TabStop = False
        Me.gbAlarmSound.Text = "Set Alarm Sound"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Powered by MeaMod Playme & OCDSe"
        Me.Label1.UseMnemonic = False
        '
        'btnAlarmSound
        '
        Me.btnAlarmSound.Location = New System.Drawing.Point(181, 22)
        Me.btnAlarmSound.Name = "btnAlarmSound"
        Me.btnAlarmSound.Size = New System.Drawing.Size(75, 23)
        Me.btnAlarmSound.TabIndex = 1
        Me.btnAlarmSound.Text = "Set Sound"
        Me.btnAlarmSound.UseVisualStyleBackColor = True
        '
        'tbAlarmSound
        '
        Me.tbAlarmSound.Location = New System.Drawing.Point(6, 24)
        Me.tbAlarmSound.Name = "tbAlarmSound"
        Me.tbAlarmSound.Size = New System.Drawing.Size(168, 20)
        Me.tbAlarmSound.TabIndex = 0
        '
        'diaOpenFile
        '
        Me.diaOpenFile.AutoUpgradeEnabled = False
        Me.diaOpenFile.Title = "Open File - LightAlarm"
        '
        'btnSnooze
        '
        Me.btnSnooze.Enabled = False
        Me.btnSnooze.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnooze.Location = New System.Drawing.Point(12, 109)
        Me.btnSnooze.Name = "btnSnooze"
        Me.btnSnooze.Size = New System.Drawing.Size(560, 43)
        Me.btnSnooze.TabIndex = 4
        Me.btnSnooze.Text = "Snooze"
        Me.btnSnooze.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(9, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 1)
        Me.Panel1.TabIndex = 5
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(12, 279)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(477, 23)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop Alarm"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(9, 262)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 1)
        Me.Panel2.TabIndex = 7
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(495, 279)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 8
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'cbBlackout
        '
        Me.cbBlackout.AutoSize = True
        Me.cbBlackout.Location = New System.Drawing.Point(12, 236)
        Me.cbBlackout.Name = "cbBlackout"
        Me.cbBlackout.Size = New System.Drawing.Size(104, 17)
        Me.cbBlackout.TabIndex = 9
        Me.cbBlackout.Text = "Enable Blackout"
        Me.cbBlackout.UseVisualStyleBackColor = True
        '
        'cbScreenAlarm
        '
        Me.cbScreenAlarm.AutoSize = True
        Me.cbScreenAlarm.Location = New System.Drawing.Point(137, 236)
        Me.cbScreenAlarm.Name = "cbScreenAlarm"
        Me.cbScreenAlarm.Size = New System.Drawing.Size(122, 17)
        Me.cbScreenAlarm.TabIndex = 10
        Me.cbScreenAlarm.Text = "Enable ScreenAlarm"
        Me.cbScreenAlarm.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 316)
        Me.Controls.Add(Me.cbScreenAlarm)
        Me.Controls.Add(Me.cbBlackout)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSnooze)
        Me.Controls.Add(Me.gbAlarmSound)
        Me.Controls.Add(Me.gbSetAlarm)
        Me.Controls.Add(Me.DigitalClockCtrl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "LightAlarm"
        Me.gbSetAlarm.ResumeLayout(False)
        Me.gbSetAlarm.PerformLayout()
        Me.gbAlarmSound.ResumeLayout(False)
        Me.gbAlarmSound.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DigitalClockCtrl1 As SriClocks.DigitalClockCtrl
    Friend WithEvents gbSetAlarm As System.Windows.Forms.GroupBox
    Friend WithEvents tbAlarmTime As System.Windows.Forms.TextBox
    Friend WithEvents btnSetAlarm As System.Windows.Forms.Button
    Friend WithEvents gbAlarmSound As System.Windows.Forms.GroupBox
    Friend WithEvents btnAlarmSound As System.Windows.Forms.Button
    Friend WithEvents tbAlarmSound As System.Windows.Forms.TextBox
    Friend WithEvents diaOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSnooze As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents cbBlackout As System.Windows.Forms.CheckBox
    Friend WithEvents cbScreenAlarm As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
