Public Class frmmain

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        Me.Close()
        frmdangnhap.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Close()
        frmdangnhap.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
        Me.Close()
        frmquanly.Show()
    End Sub
End Class