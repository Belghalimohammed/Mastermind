Public Class Form3

    Public a As Integer
    Public b As Integer
    Private Sub DataGridView1_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (ProgressBar2.Value < 10) Then
            ProgressBar2.Value = ProgressBar2.Value + 1
            Roundbutt5.Text = ProgressBar2.Value
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (ProgressBar2.Value > 0) Then
            ProgressBar2.Value = ProgressBar2.Value - 1
            Roundbutt5.Text = ProgressBar2.Value
        End If
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ProgressBar1.Value < 20) Then
            ProgressBar1.Value = ProgressBar1.Value + 2
            Roundbutt4.Text = ProgressBar1.Value
        End If
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ProgressBar1.Value > 0) Then
            ProgressBar1.Value = ProgressBar1.Value - 2
            Roundbutt4.Text = ProgressBar1.Value
        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Roundbutt4.Text = ProgressBar1.Value
        Roundbutt5.Text = ProgressBar2.Value
    End Sub

    Private Sub Roundbutt4_Click(sender As Object, e As EventArgs) Handles Roundbutt4.Click

    End Sub

    Private Sub Roundbutt6_Click(sender As Object, e As EventArgs) Handles Roundbutt6.Click

        f1 = New Form1(ProgressBar1.Value, ProgressBar2.Value)
        f3.Hide()
        f1.ShowDialog()

    End Sub
End Class