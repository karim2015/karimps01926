Imports System.Data.SqlClient
Public Class frmdangnhap

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim chuoiketnoi As String = "workstation id=rimk200.mssql.somee.com;packet size=4096;user id=karim2015;pwd=Aa9971441;data source=rimk200.mssql.somee.com;persist security info=False;initial catalog=rimk200"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien where tendangnhap='" & txtname.Text & "' and matkhau='" & txtpass.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công")
                frmmain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        End
    End Sub

    Private Sub frmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
