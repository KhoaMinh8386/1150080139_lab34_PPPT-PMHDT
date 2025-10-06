using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace THUCHANH2
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối SQL Server (sửa lại theo máy của bạn)
        // Kết nối SQL Server với Trusted Connection và bỏ qua chứng chỉ
        private string strCon = @"Data Source=DESKTOP-LGTP02P;Initial Catalog=QLSinhVien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        // ===== MENU (ẩn/hiện panel) =====
        private void btnTrang1_Click(object sender, EventArgs e)
        {
            panelCountSV.Visible = true;
            panelThongTin.Visible = false;
            panelDanhSach.Visible = false;
            panelLop.Visible = false;
            panelApDung.Visible = false;
        }

        private void btnTrang2_Click(object sender, EventArgs e)
        {
            panelCountSV.Visible = false;
            panelThongTin.Visible = true;
            panelDanhSach.Visible = false;
            panelLop.Visible = false;
            panelApDung.Visible = false;
        }

        private void btnTrang3_Click(object sender, EventArgs e)
        {
            panelCountSV.Visible = false;
            panelThongTin.Visible = false;
            panelDanhSach.Visible = true;
            panelLop.Visible = false;
            panelApDung.Visible = false;
        }

        private void btnTrang4_Click(object sender, EventArgs e)
        {
            panelCountSV.Visible = false;
            panelThongTin.Visible = false;
            panelDanhSach.Visible = false;
            panelLop.Visible = true;
            panelApDung.Visible = false;
        }

        private void btnTrang5_Click(object sender, EventArgs e)
        {
            panelCountSV.Visible = false;
            panelThongTin.Visible = false;
            panelDanhSach.Visible = false;
            panelLop.Visible = false;
            panelApDung.Visible = true;
        }

        // ===== 1. Đếm số lượng sinh viên =====
        private void btnCount_Click(object sender, EventArgs e)
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM SinhVien", sqlCon);
            int soLuongSV = (int)sqlCmd.ExecuteScalar();

            MessageBox.Show("Số lượng sinh viên là: " + soLuongSV);
        }

        // ===== 2. Lấy thông tin 1 sinh viên =====
        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            string maSV = txtNhapMaSV.Text.Trim();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM SinhVien WHERE MaSV=@maSV", sqlCon);
            sqlCmd.Parameters.AddWithValue("@maSV", maSV);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                txtTenSV.Text = reader.GetString(1);
                txtGioiTinh.Text = reader.GetString(2);
                txtNgaySinh.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                txtQueQuan.Text = reader.GetString(4);
                txtMaLop.Text = reader.GetString(5);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã " + maSV);
            }
            reader.Close();
        }

        // ===== 3. Hiển thị danh sách tất cả sinh viên =====
        private void btnListView_Click(object sender, EventArgs e)
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM SinhVien", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();

            lsvList.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0)); // MaSV
                lvi.SubItems.Add(reader.GetString(1)); // TenSV
                lvi.SubItems.Add(reader.GetString(2)); // GioiTinh
                lvi.SubItems.Add(reader.GetDateTime(3).ToString("dd/MM/yyyy")); // NgaySinh
                lvi.SubItems.Add(reader.GetString(4)); // QueQuan
                lvi.SubItems.Add(reader.GetString(5)); // MaLop
                lsvList.Items.Add(lvi);
            }
            reader.Close();
        }

        // ===== 4. Danh sách lớp theo Khoa =====
        private void btnXemDS_Click(object sender, EventArgs e)
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            string tenKhoa = txtNhapTenKhoa.Text.Trim();
            string maKhoa = "";

            if (tenKhoa == "Công nghệ thông tin") maKhoa = "CNTT";
            else if (tenKhoa == "Cơ khí") maKhoa = "CK";
            else if (tenKhoa == "Điện tử") maKhoa = "DT";
            else if (tenKhoa == "Kinh tế") maKhoa = "KT";

            SqlCommand sqlCmd = new SqlCommand("SELECT MaLop, TenLop FROM Lop WHERE MaKhoa=@maKhoa", sqlCon);
            sqlCmd.Parameters.AddWithValue("@maKhoa", maKhoa);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();

            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0)); // MaLop
                lvi.SubItems.Add(reader.GetString(1)); // TenLop
                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
        }

        // ===== 5. Danh sách sinh viên theo lớp =====
        private void btnXemTheoLop_Click(object sender, EventArgs e)
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            string maLop = txtNhapMaLop.Text.Trim();
            SqlCommand sqlCmd = new SqlCommand("SELECT MaSV, TenSV FROM SinhVien WHERE MaLop=@maLop", sqlCon);
            sqlCmd.Parameters.AddWithValue("@maLop", maLop);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvSVTheoLop.Items.Clear();

            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0)); // MaSV
                lvi.SubItems.Add(reader.GetString(1)); // TenSV
                lsvSVTheoLop.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
