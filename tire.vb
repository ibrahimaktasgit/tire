Imports System.Data.SqlClient

Public Class tire

    Private Sub btnMarka_Click(sender As Object, e As EventArgs) Handles btnMarka.Click
        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source = IBRAHIM;Initial Catalog=dbT;Integrated Security=True")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Marka (markaNo, markaAdi, markaDesen) 
VALUES ('" & txtNo.Text & "','" & txtAd.Text & "','" & comboDesen.SelectedText & "')"
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
    End Sub

    Private Sub btnUrun_Click(sender As Object, e As EventArgs) Handles btnUrun.Click
        Dim sqlConnection2 As New System.Data.SqlClient.SqlConnection("Data Source = IBRAHIM;Initial Catalog=dbT;Integrated Security=True")

        Dim cmmnd As New System.Data.SqlClient.SqlCommand
        cmmnd.CommandType = System.Data.CommandType.Text
        cmmnd.CommandText = "INSERT UrunTanimlama (urunNo,urunAdi,taban,yanak,jant,yapi,stokGrup,fiyat) 
VALUES ('" & txtUno.Text & "','" & txtUad.Text & "','" & txtTaban.Text & "','" & txtYanak.Text & "','" & txtJant.Text & "','" & txtYapi.Text & "','" & txtSgrup.Text & "','" & txtFiyat.Text & "')"
        cmmnd.Connection = sqlConnection2

        sqlConnection2.Open()
        cmmnd.ExecuteNonQuery()
        sqlConnection2.Close()
    End Sub

    Private Sub grupGiris_Enter(sender As Object, e As EventArgs) Handles grupGiris.Enter
        Dim connect As New System.Data.SqlClient.SqlConnection("Data Source = IBRAHIM;Initial Catalog=dbT;Integrated Security=True")
        Try
            Dim sql As String
            sql = "SELECT * FROM Marka"
            Dim da As New SqlDataAdapter(sql, connect)
            Dim ds As New DataSet
            da.Fill(ds)
            Dim datatable As DataTable = ds.Tables(0)
            cmbMarka.DataSource = ds.Tables(0)
            cmbMarka.DisplayMember = "markaAdi"
            cmbMarka.ValueMember = "markaID"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub cmbMarka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarka.SelectedIndexChanged
        Dim connect As New System.Data.SqlClient.SqlConnection("Data Source = IBRAHIM;Initial Catalog=dbT;Integrated Security=True")
        Try
            If (cmbMarka.SelectedIndex <> -1) Then
                Dim sql As String
                sql = "SELECT * FROM Marka WHERE markaAdi=" + cmbMarka.SelectedValue 'Hata veriyor, sorunu çözemedim
                Dim da As New SqlDataAdapter(sql, connect)
                Dim ds As New DataSet
                da.Fill(ds)
                Dim datatable As DataTable = ds.Tables(0)
                cmbDesen.DataSource = ds.Tables(0)
                cmbDesen.DisplayMember = "markaDesen"
                cmbDesen.ValueMember = "markaID"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub cmbDesen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDesen.SelectedIndexChanged

    End Sub

    Private Sub tire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        Dim sqlConnection3 As New System.Data.SqlClient.SqlConnection("Data Source = IBRAHIM;Initial Catalog=dbT;Integrated Security=True")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Islem (islemNo, islemTipi, islemUretilecek, islemAdet, islemUretimci) 
VALUES ('" & txtIslem.Text & "','" & txtTipi.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "')"
        cmd.Connection = sqlConnection3

        sqlConnection3.Open()
        cmd.ExecuteNonQuery()
        sqlConnection3.Close()
    End Sub
End Class