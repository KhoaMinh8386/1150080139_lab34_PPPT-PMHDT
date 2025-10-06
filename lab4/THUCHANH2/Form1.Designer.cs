namespace THUCHANH2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btnTrang1 = new System.Windows.Forms.Button();
            this.btnTrang2 = new System.Windows.Forms.Button();
            this.btnTrang3 = new System.Windows.Forms.Button();
            this.btnTrang4 = new System.Windows.Forms.Button();
            this.btnTrang5 = new System.Windows.Forms.Button();

            this.panelCountSV = new System.Windows.Forms.Panel();
            this.btnCount = new System.Windows.Forms.Button();

            this.panelThongTin = new System.Windows.Forms.Panel();
            this.txtNhapMaSV = new System.Windows.Forms.TextBox();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();

            this.panelDanhSach = new System.Windows.Forms.Panel();
            this.btnListView = new System.Windows.Forms.Button();
            this.lsvList = new System.Windows.Forms.ListView();

            this.panelLop = new System.Windows.Forms.Panel();
            this.txtNhapTenKhoa = new System.Windows.Forms.TextBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.lsvDanhSach = new System.Windows.Forms.ListView();

            this.panelApDung = new System.Windows.Forms.Panel();
            this.txtNhapMaLop = new System.Windows.Forms.TextBox();
            this.btnXemTheoLop = new System.Windows.Forms.Button();
            this.lsvSVTheoLop = new System.Windows.Forms.ListView();

            this.SuspendLayout();

            // MENU
            this.btnTrang1.Text = "Đếm SV";
            this.btnTrang1.Location = new System.Drawing.Point(10, 10);
            this.btnTrang1.Click += new System.EventHandler(this.btnTrang1_Click);

            this.btnTrang2.Text = "1 SV";
            this.btnTrang2.Location = new System.Drawing.Point(100, 10);
            this.btnTrang2.Click += new System.EventHandler(this.btnTrang2_Click);

            this.btnTrang3.Text = "DS Sinh viên";
            this.btnTrang3.Location = new System.Drawing.Point(190, 10);
            this.btnTrang3.Click += new System.EventHandler(this.btnTrang3_Click);

            this.btnTrang4.Text = "DS Lớp";
            this.btnTrang4.Location = new System.Drawing.Point(300, 10);
            this.btnTrang4.Click += new System.EventHandler(this.btnTrang4_Click);

            this.btnTrang5.Text = "Áp dụng";
            this.btnTrang5.Location = new System.Drawing.Point(400, 10);
            this.btnTrang5.Click += new System.EventHandler(this.btnTrang5_Click);

            // Panel 1
            this.panelCountSV.Location = new System.Drawing.Point(10, 50);
            this.panelCountSV.Size = new System.Drawing.Size(600, 350);
            this.btnCount.Text = "Đếm SV";
            this.btnCount.Location = new System.Drawing.Point(200, 100);
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            this.panelCountSV.Controls.Add(this.btnCount);

            // Panel 2
            this.panelThongTin.Location = new System.Drawing.Point(10, 50);
            this.panelThongTin.Size = new System.Drawing.Size(600, 350);
            this.txtNhapMaSV.Location = new System.Drawing.Point(20, 20);
            this.btnXemThongTin.Text = "Xem";
            this.btnXemThongTin.Location = new System.Drawing.Point(200, 20);
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            this.txtTenSV.Location = new System.Drawing.Point(20, 70);
            this.txtGioiTinh.Location = new System.Drawing.Point(20, 100);
            this.txtNgaySinh.Location = new System.Drawing.Point(20, 130);
            this.txtQueQuan.Location = new System.Drawing.Point(20, 160);
            this.txtMaLop.Location = new System.Drawing.Point(20, 190);
            this.panelThongTin.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtNhapMaSV,this.btnXemThongTin,this.txtTenSV,
                this.txtGioiTinh,this.txtNgaySinh,this.txtQueQuan,this.txtMaLop
            });

            // Panel 3
            this.panelDanhSach.Location = new System.Drawing.Point(10, 50);
            this.panelDanhSach.Size = new System.Drawing.Size(600, 350);
            this.btnListView.Text = "Xem";
            this.btnListView.Location = new System.Drawing.Point(20, 20);
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            this.lsvList.Location = new System.Drawing.Point(20, 60);
            this.lsvList.Size = new System.Drawing.Size(550, 250);
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.Columns.Add("Mã SV", 80);
            this.lsvList.Columns.Add("Tên SV", 120);
            this.lsvList.Columns.Add("Giới tính", 80);
            this.lsvList.Columns.Add("Ngày sinh", 100);
            this.lsvList.Columns.Add("Quê quán", 100);
            this.lsvList.Columns.Add("Mã lớp", 80);
            this.panelDanhSach.Controls.Add(this.btnListView);
            this.panelDanhSach.Controls.Add(this.lsvList);

            // Panel 4
            this.panelLop.Location = new System.Drawing.Point(10, 50);
            this.panelLop.Size = new System.Drawing.Size(600, 350);
            this.txtNhapTenKhoa.Location = new System.Drawing.Point(20, 20);
            this.btnXemDS.Text = "Xem lớp";
            this.btnXemDS.Location = new System.Drawing.Point(200, 20);
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            this.lsvDanhSach.Location = new System.Drawing.Point(20, 60);
            this.lsvDanhSach.Size = new System.Drawing.Size(500, 250);
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.Columns.Add("Mã lớp", 100);
            this.lsvDanhSach.Columns.Add("Tên lớp", 200);
            this.panelLop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtNhapTenKhoa,this.btnXemDS,this.lsvDanhSach
            });

            // Panel 5
            this.panelApDung.Location = new System.Drawing.Point(10, 50);
            this.panelApDung.Size = new System.Drawing.Size(600, 350);
            this.txtNhapMaLop.Location = new System.Drawing.Point(20, 20);
            this.btnXemTheoLop.Text = "Xem SV theo lớp";
            this.btnXemTheoLop.Location = new System.Drawing.Point(200, 20);
            this.btnXemTheoLop.Click += new System.EventHandler(this.btnXemTheoLop_Click);
            this.lsvSVTheoLop.Location = new System.Drawing.Point(20, 60);
            this.lsvSVTheoLop.Size = new System.Drawing.Size(500, 250);
            this.lsvSVTheoLop.View = System.Windows.Forms.View.Details;
            this.lsvSVTheoLop.Columns.Add("Mã SV", 100);
            this.lsvSVTheoLop.Columns.Add("Tên SV", 200);
            this.panelApDung.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtNhapMaLop,this.btnXemTheoLop,this.lsvSVTheoLop
            });

            // Form
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnTrang1,this.btnTrang2,this.btnTrang3,this.btnTrang4,this.btnTrang5,
                this.panelCountSV,this.panelThongTin,this.panelDanhSach,this.panelLop,this.panelApDung
            });
            this.Text = "Quản lý Sinh Viên";

            this.panelCountSV.Visible = true;
            this.panelThongTin.Visible = false;
            this.panelDanhSach.Visible = false;
            this.panelLop.Visible = false;
            this.panelApDung.Visible = false;

            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Button btnTrang1;
        private System.Windows.Forms.Button btnTrang2;
        private System.Windows.Forms.Button btnTrang3;
        private System.Windows.Forms.Button btnTrang4;
        private System.Windows.Forms.Button btnTrang5;

        private System.Windows.Forms.Panel panelCountSV;
        private System.Windows.Forms.Button btnCount;

        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.TextBox txtNhapMaSV;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtMaLop;

        private System.Windows.Forms.Panel panelDanhSach;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.ListView lsvList;

        private System.Windows.Forms.Panel panelLop;
        private System.Windows.Forms.TextBox txtNhapTenKhoa;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.ListView lsvDanhSach;

        private System.Windows.Forms.Panel panelApDung;
        private System.Windows.Forms.TextBox txtNhapMaLop;
        private System.Windows.Forms.Button btnXemTheoLop;
        private System.Windows.Forms.ListView lsvSVTheoLop;
    }
}
