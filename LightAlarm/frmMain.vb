Public Class frmMain
    Friend ctlPlayer As New LibVLC.LibVlc

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        diaOpenFile.Filter = "All Files|*.*|OgO (*.ogo, *.ogoap, *.ogovp, *.ogop, *.ogoas)|*.ogo;*.ogoap;*.ogovp;*.ogop;*.ogoas|AVI (*.avi)|*.avi|MPEG (*.mpg, *.mpeg)|*.mpg;*.mpeg|mp3 (*.mp3)|*.mp3|MOV (*.mov)|*.mov|Flash video (*.flv)|*.flv|MPEG-4 Audio (*.m4a, *.m4b, *.m4p)|*.m4a;*.m4b;*.m4p|MPEG-4 (*.mp4)|*.mp4|NSV (*.nsv)|*.nsv|OGM (*.ogm)|*.ogm|Ogg (*.ogg)|*.ogg|PVA (*.pva)|*.pva|RealMedia (*.rm, *.ram, *.ra)|*.rm;*.ram;*.ra|WAV (*.wav)|*.wav|AAC (*.aac)|*.aac|AIFF (*.aiff)|*.aiff|ASF (*.asf)|*.asf|AU (*.au)|*.au|DTS (*.dts)|*.dts|Matroska (*.mkv, *.mka, *.mks)|*.mkv;*.mka;*.mks|Flac audio (.flac)|*.flac|DivX (.divx)|*.divx|WMV (.wmv)|*.wmv|WMA (*.wma)|*.wma|3gpp (*.3g, *.3gp, *.3gpp)|*.3g;*.3gp;*.3gpp|DV (*.dv)|*.dv|ac3/a52 (*.ac3, *.a52)|*.ac3;*.a52|XviD (*.xvid)|*.xvid|Misc. (*.pspmc, *.phonem, *.pvpvc, *.avlac)|*.pspmc;*.phonem;*.pvpvc;*.avlac"
        If String.IsNullOrEmpty(My.Settings.AlarmTime) Then
            tbAlarmTime.Text = DateTime.Now.ToString("G")
        Else
            tbAlarmTime.Text = My.Settings.AlarmTime
        End If
        tbAlarmSound.Text = My.Settings.OpenFile
        AddHandler DigitalClockCtrl1.RaiseAlarm, AddressOf OnRaiseAlarm
        If My.Settings.BlackOut = True Then
            cbBlackout.Checked = True
        ElseIf My.Settings.BlackOut = False Then
            cbBlackout.Checked = False
        End If
        If My.Settings.ScreenAlarm = True Then
            cbScreenAlarm.Checked = True
        ElseIf My.Settings.ScreenAlarm = False Then
            cbScreenAlarm.Checked = False
        End If
    End Sub

    Private Sub btnSetAlarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetAlarm.Click
        Try
            My.Settings.AlarmTime = DateTime.Parse(tbAlarmTime.Text)
            My.Settings.Save()
            DigitalClockCtrl1.AlarmTime = My.Settings.AlarmTime
            btnStop.Enabled = True
            frmAlert.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OnRaiseAlarm()
        My.Settings.Reload()
        OpnFile(My.Settings.OpenFile)
        btnAlarmSound.Enabled = False
        btnSetAlarm.Enabled = False
        btnSnooze.Enabled = True
        frmAlert.Show()
        frmAlert.TopMost = True
        Me.TopMost = True
        frmAlert.BackColor = Color.White
    End Sub

    Private Sub btnAlarmSound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlarmSound.Click
        Dim DidWork As Integer = diaOpenFile.ShowDialog()
        If DidWork = DialogResult.Cancel Then
        Else
            My.Settings.OpenFile = diaOpenFile.FileName
            My.Settings.Save()
            tbAlarmSound.Text = My.Settings.OpenFile
        End If
    End Sub

    Private Sub StopEvent()
        ctlPlayer.PlaylistClear()
        ctlPlayer.Stop()
        ctlPlayer.PlaylistClear()
        frmAlert.Close()
    End Sub

    Private Sub OpnFile(ByVal OpenFile As String)
        With ctlPlayer
            .Initialize()
            .AddTarget(OpenFile)
            .Play()
        End With
    End Sub

    Private Sub btnSnooze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnooze.Click
        btnAlarmSound.Enabled = True
        btnSetAlarm.Enabled = True
        btnSnooze.Enabled = False
        DigitalClockCtrl1.AlarmTime = DateTime.Now.AddMinutes(15).ToString("G")
        If My.Settings.BlackOut = True Then
            StopEvent()
            frmAlert.Show()
            frmAlert.BackColor = Color.Black
            Me.TopMost = False
        ElseIf My.Settings.BlackOut = False Then
            StopEvent()
        End If

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        btnAlarmSound.Enabled = True
        btnSetAlarm.Enabled = True
        btnSnooze.Enabled = False
        btnStop.Enabled = False
        Me.TopMost = False
        StopEvent()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub cbBlackout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlackout.CheckedChanged
        If cbBlackout.Checked = True Then
            My.Settings.BlackOut = True
        ElseIf cbBlackout.Checked = False Then
            My.Settings.BlackOut = False
        End If
    End Sub

    Private Sub cbScreenAlarm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbScreenAlarm.CheckedChanged
        If cbScreenAlarm.Checked = True Then
            My.Settings.ScreenAlarm = True
        ElseIf cbScreenAlarm.Checked = False Then
            My.Settings.ScreenAlarm = False
        End If
    End Sub
End Class
