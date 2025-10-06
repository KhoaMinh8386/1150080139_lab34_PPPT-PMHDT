using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;
        private Label lblTitle;
        private GroupBox groupBoxMenu;
        private ComboBox cboBan;
        private DataGridView dgvOrder;
        private Button btnXoa, btnOrder;

        public Form1()
        {
            InitializeComponent(); // gọi Designer
            SetupUI();             // thêm giao diện bằng code
        }

        private void SetupUI()
        {
            this.Text = "Quản lý Order";
            this.Size = new Size(650, 520);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Logo từ URL
            pictureBox = new PictureBox
            {
                Size = new Size(80, 80),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            string url = "https://bepos.io/wp-content/uploads/2023/06/logo-nha-hang-dep-7.jpg";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    using (var ms = new MemoryStream(wc.DownloadData(url)))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không tải được hình từ URL!");
            }

            this.Controls.Add(pictureBox);

            // Tiêu đề
            lblTitle = new Label
            {
                Text = "Quán ăn nhanh Hùng Thịnh",
                Font = new Font("Arial", 14, FontStyle.Bold),
                BackColor = Color.Green,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(100, 10),
                Size = new Size(520, 80)
            };
            this.Controls.Add(lblTitle);

            // GroupBox menu
            groupBoxMenu = new GroupBox
            {
                Text = "Danh sách món ăn:",
                Location = new Point(10, 100),
                Size = new Size(600, 170)
            };
            this.Controls.Add(groupBoxMenu);

            // Danh sách món ăn
            string[,] monAn =
            {
                { "Cơm chiên trứng", "Bánh mì ốp la", "Coca", "Lipton" },
                { "Ốc rang muối", "Khoai tây chiên", "7 Up", "Cam" },
                { "Mỳ xào hải sản", "Cá viên chiên", "Pepsi", "Cafe" },
                { "Burger bò nướng", "Đùi gà rán", "Bún bò Huế", "" }
            };

            int btnWidth = 130, btnHeight = 35, padding = 10;
            for (int r = 0; r < monAn.GetLength(0); r++)
            {
                for (int c = 0; c < monAn.GetLength(1); c++)
                {
                    if (string.IsNullOrEmpty(monAn[r, c])) continue;
                    Button btn = new Button
                    {
                        Text = monAn[r, c],
                        Size = new Size(btnWidth, btnHeight),
                        Location = new Point(10 + c * (btnWidth + padding), 20 + r * (btnHeight + padding))
                    };
                    btn.Click += (s, e) => ChonMon(btn.Text);
                    groupBoxMenu.Controls.Add(btn);
                }
            }

            // DataGridView
            dgvOrder = new DataGridView
            {
                Location = new Point(10, 280),
                Size = new Size(600, 150),
                AllowUserToAddRows = false
            };
            dgvOrder.ColumnCount = 2;
            dgvOrder.Columns[0].Name = "Tên món";
            dgvOrder.Columns[1].Name = "Số lượng";
            this.Controls.Add(dgvOrder);

            // Nút Xóa
            btnXoa = new Button
            {
                Text = "Xóa món",
                Location = new Point(10, 450),
                Size = new Size(80, 30)
            };
            btnXoa.Click += BtnXoa_Click;
            this.Controls.Add(btnXoa);

            // ComboBox bàn
            cboBan = new ComboBox
            {
                Location = new Point(120, 450),
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboBan.Items.AddRange(new string[] { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4" });
            this.Controls.Add(cboBan);

            // Nút Order
            btnOrder = new Button
            {
                Text = "Order",
                Location = new Point(300, 450),
                Size = new Size(80, 30)
            };
            btnOrder.Click += BtnOrder_Click;
            this.Controls.Add(btnOrder);
        }

        private void ChonMon(string tenMon)
        {
            bool found = false;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == tenMon)
                {
                    int soLuong = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[1].Value = soLuong + 1;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                dgvOrder.Rows.Add(tenMon, 1);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrder.SelectedRows)
            {
                dgvOrder.Rows.Remove(row);
            }
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            string filePath = "Order.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("------ " + cboBan.SelectedItem.ToString() + " ------");
                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        sw.WriteLine(row.Cells[0].Value + " - SL: " + row.Cells[1].Value);
                    }
                }
                sw.WriteLine("-------------------------\n");
            }

            MessageBox.Show("Đã order thành công!");
            dgvOrder.Rows.Clear();
        }
    }
}
