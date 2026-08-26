Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btntampilkan_Click(sender As Object, e As EventArgs) Handles btntampilkan.Click
        MessageBox.Show("Halo Dunia!" & vbCrLf &
            "Nama : " & txtnama.Text & vbCrLf &
            "NIM : " & txtnim.Text & vbCrLf &
            "KOM : " & txtkom.Text
        )
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        txtkom.Clear()
        txtnama.Clear()
        txtnim.Clear()
    End Sub
End Class
