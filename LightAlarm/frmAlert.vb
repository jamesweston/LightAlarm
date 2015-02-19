Public Class frmAlert

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Settings.BlackOut = True Then

        ElseIf My.Settings.BlackOut = False Then
            Me.Close()
        End If

        If My.Settings.ScreenAlarm = True Then
            If Me.BackColor = Color.White Then
                Me.BackColor = Color.Red
            ElseIf Me.BackColor = Color.Red Then
                Me.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub frmAlert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub frmAlert_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, MyBase.MouseClick
        frmMain.Show()
        frmMain.TopMost = True
    End Sub
End Class