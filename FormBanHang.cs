using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace BaiTap
{
    public partial class FormBanHang : Form
    {
        int banDangChon = 0;

        Dictionary<int, List<string>> nhoTenMon = new Dictionary<int, List<string>>();
        Dictionary<int, List<int>> nhoGiaTien = new Dictionary<int, List<int>>();
        Dictionary<int, int> nhoTongTien = new Dictionary<int, int>();
        public FormBanHang()
        {
            InitializeComponent();
            TrangTriBangHoaDon();
            BoTronGocPanel(form2, 20);

            BoTronGocPanel(flpDanhSachBan, 10);
            LoadDanhSachBan();
            LoadMenu();
        }
        private void LoadMenu()
        {
            flpMenu.Controls.Clear();
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaMon, TenMon, GiaTien FROM ThucDon";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tenMon = reader["TenMon"].ToString();
                                int giaTien = Convert.ToInt32(reader["GiaTien"]);
                                int maMon = Convert.ToInt32(reader["MaMon"]);

                                Button btnMon = new Button();
                                btnMon.Width = 110;
                                btnMon.Height = 110;
                                btnMon.Text = tenMon + Environment.NewLine + giaTien.ToString("N0") + "đ";
                                btnMon.BackColor = Color.LightSkyBlue;
                                btnMon.FlatStyle = FlatStyle.Flat;
                                btnMon.Font = new Font("Arial", 10, FontStyle.Bold);
                                btnMon.Tag = tenMon + "|" + giaTien;
                                btnMon.Click += BtnMon_Click;

                                flpMenu.Controls.Add(btnMon);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải menu: " + ex.Message);
                }
            }
        }

        private void LoadDanhSachBan()
        {
            flpDanhSachBan.Controls.Clear();

            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaBan, TenBan, TrangThai FROM BanCafe";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tenBan = reader["TenBan"].ToString();
                                string trangThai = reader["TrangThai"].ToString();
                                int maBan = Convert.ToInt32(reader["MaBan"]);

                                Button btnBan = new Button();
                                btnBan.Width = 90;
                                btnBan.Height = 90;
                                btnBan.Text = tenBan + Environment.NewLine + "(" + trangThai + ")";
                                btnBan.FlatStyle = FlatStyle.Flat;
                                btnBan.Font = new Font("Arial", 10, FontStyle.Bold);

                                btnBan.Tag = maBan;

                                if (trangThai == "Trống")
                                {
                                    btnBan.BackColor = Color.LightGreen;
                                }
                                else
                                {
                                    btnBan.BackColor = Color.LightCoral;
                                }

                                btnBan.Click += BtnBan_Click;

                                flpDanhSachBan.Controls.Add(btnBan);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách bàn: " + ex.Message);
                }
            }
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button banVuaChon = sender as Button;
            banDangChon = (int)banVuaChon.Tag;

            lblBanDangChon.Text = "Đang chọn: " + banVuaChon.Text.Replace("\n", " ").Replace("\r", "");
            lblBanDangChon.ForeColor = Color.Blue;

            dgvHoaDon.Rows.Clear();

            if (nhoTenMon.ContainsKey(banDangChon))
            {
                for (int i = 0; i < nhoTenMon[banDangChon].Count; i++)
                {
                    dgvHoaDon.Rows.Add(nhoTenMon[banDangChon][i], nhoGiaTien[banDangChon][i]);
                }
                lblTongTien.Text = "Tổng tiền: " + nhoTongTien[banDangChon].ToString("N0") + " VNĐ";
            }
            else
            {
                lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            }
        }

        private void BtnMon_Click(object sender, EventArgs e)
        {
            if (banDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn một Bàn bên trái trước khi gọi món!", "Cảnh báo");
                return;
            }

            Button monVuaChon = sender as Button;
            string data = monVuaChon.Tag.ToString();
            string[] parts = data.Split('|');
            string tenMonAn = parts[0];
            int giaCuaMon = int.Parse(parts[1]);

            dgvHoaDon.Rows.Add(tenMonAn, giaCuaMon);

            if (!nhoTenMon.ContainsKey(banDangChon))
            {
                nhoTenMon[banDangChon] = new List<string>();
                nhoGiaTien[banDangChon] = new List<int>();
                nhoTongTien[banDangChon] = 0;
            }

            nhoTenMon[banDangChon].Add(tenMonAn);
            nhoGiaTien[banDangChon].Add(giaCuaMon);
            nhoTongTien[banDangChon] += giaCuaMon;

            lblTongTien.Text = "Tổng tiền: " + nhoTongTien[banDangChon].ToString("N0") + " VNĐ";

            foreach (Control ctrl in flpDanhSachBan.Controls)
            {
                if (ctrl is Button && (int)ctrl.Tag == banDangChon)
                {
                    ctrl.BackColor = Color.LightCoral;
                    if (!ctrl.Text.Contains("Có người"))
                    {
                        ctrl.Text = ctrl.Text.Replace("Trống", "Có người");
                    }
                    break;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (banDangChon == 0) return;

            if (!nhoTongTien.ContainsKey(banDangChon) || nhoTongTien[banDangChon] == 0)
            {
                MessageBox.Show("Bàn này chưa gọi món nào, không thể thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacNhan = DialogResult.No;

            if (radTienMat.Checked)
            {
                picQRCode.Visible = false;

                xacNhan = MessageBox.Show(
                    "Xác nhận thu TIỀN MẶT Bàn số " + banDangChon + " với tổng cộng: " + nhoTongTien[banDangChon].ToString("N0") + " VNĐ?",
                    "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (radQR.Checked)
            {
                try
                {
                    string nganHang = "Techcombank";
                    string soTaiKhoan = "19035465998015";
                    string tenChu = "NGUYEN HOANG DUONG";

                    string tongTien = nhoTongTien[banDangChon].ToString();
                    string noiDung = "Thanh toan ban " + banDangChon;

                    string urlAPI = $"https://img.vietqr.io/image/{nganHang}-{soTaiKhoan}-compact2.png?amount={tongTien}&addInfo={noiDung}&accountName={tenChu}";

                    picQRCode.LoadAsync(urlAPI);
                    picQRCode.Visible = true;

                    xacNhan = MessageBox.Show(
                        "Đã tạo mã QR cho Bàn " + banDangChon + ".\n\nVui lòng đưa khách quét. CHỈ NHẤN [YES] SAU KHI ĐÃ NHẬN ĐƯỢC TIỀN CHUYỂN KHOẢN!",
                        "Chờ khách chuyển khoản...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo mã QR: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (xacNhan == DialogResult.Yes)
            {

                {
                    string hinhThuc = "Tiền mặt";
                    if (radQR.Checked == true)
                    {
                        hinhThuc = "Chuyển khoản QR";
                    }
                    string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string queryHD = "INSERT INTO HoaDon (MaBan, TongTien, NguoiBan, PhuongThuc) OUTPUT INSERTED.MaHD VALUES (@MaBan, @TongTien, @NguoiBan, @PhuongThuc)";
                        int maHDVuaTao = 0;
                        using (SqlCommand cmdHD = new SqlCommand(queryHD, conn))
                        {
                            cmdHD.Parameters.AddWithValue("@MaBan", banDangChon);
                            cmdHD.Parameters.AddWithValue("@TongTien", nhoTongTien[banDangChon]);
                            cmdHD.Parameters.AddWithValue("@NguoiBan", LuuThongTin.TenDangNhap);
                            cmdHD.Parameters.AddWithValue("@PhuongThuc", hinhThuc);
                            maHDVuaTao = (int)cmdHD.ExecuteScalar();
                        }

                        foreach (DataGridViewRow row in dgvHoaDon.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                string queryCT = "INSERT INTO ChiTietHoaDon (MaHD, TenMon, GiaTien) VALUES (@MaHD, @TenMon, @GiaTien)";
                                using (SqlCommand cmdCT = new SqlCommand(queryCT, conn))
                                {
                                    cmdCT.Parameters.AddWithValue("@MaHD", maHDVuaTao);
                                    cmdCT.Parameters.AddWithValue("@TenMon", row.Cells[0].Value.ToString());
                                    cmdCT.Parameters.AddWithValue("@GiaTien", Convert.ToInt32(row.Cells[1].Value));
                                    cmdCT.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    printPreviewDialog1.ShowDialog();

                    dgvHoaDon.Rows.Clear();
                    picQRCode.Visible = false;
                    nhoTenMon.Remove(banDangChon);
                    nhoGiaTien.Remove(banDangChon);
                    nhoTongTien.Remove(banDangChon);

                    lblTongTien.Text = "Tổng tiền: 0 VNĐ";

                    foreach (Control ctrl in flpDanhSachBan.Controls)
                    {
                        if (ctrl is Button && (int)ctrl.Tag == banDangChon)
                        {
                            ctrl.BackColor = Color.LightGreen;
                            ctrl.Text = ctrl.Text.Replace("Có người", "Trống");
                            break;
                        }
                    }

                    banDangChon = 0;
                    lblBanDangChon.Text = "Chưa chọn bàn";
                    lblBanDangChon.ForeColor = Color.Black;
                }
            }
            else
            {
                picQRCode.Visible = false;
            }
        }
        private void btnLichSu_Click(object sender, EventArgs e)
        {

            FormLichSu frm = new FormLichSu();
            frm.ShowDialog();
        }
        private void btnHuyMon_Click(object sender, EventArgs e)
        {
            if (banDangChon == 0) return;

            if (dgvHoaDon.CurrentRow == null || dgvHoaDon.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một món từ danh sách Hóa đơn để hủy!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int viTriXoa = dgvHoaDon.CurrentRow.Index;
            int giaTienBiTru = nhoGiaTien[banDangChon][viTriXoa];

            nhoTenMon[banDangChon].RemoveAt(viTriXoa);
            nhoGiaTien[banDangChon].RemoveAt(viTriXoa);
            nhoTongTien[banDangChon] -= giaTienBiTru;

            lblTongTien.Text = "Tổng tiền: " + nhoTongTien[banDangChon].ToString("N0") + " VNĐ";

            dgvHoaDon.Rows.RemoveAt(viTriXoa);

            if (nhoTenMon[banDangChon].Count == 0)
            {
                foreach (Control ctrl in flpDanhSachBan.Controls)
                {
                    if (ctrl is Button && (int)ctrl.Tag == banDangChon)
                    {
                        ctrl.BackColor = Color.LightGreen;
                        ctrl.Text = ctrl.Text.Replace("Có người", "Trống");
                        break;
                    }
                }
            }
        }

        private void TrangTriBangHoaDon()
        {

            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.BorderStyle = BorderStyle.None;
            dgvHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvHoaDon.RowHeadersVisible = false;

            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.IndianRed;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvHoaDon.ColumnHeadersHeight = 40;
            dgvHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvHoaDon.DefaultCellStyle.BackColor = Color.White;
            dgvHoaDon.DefaultCellStyle.ForeColor = Color.Black;
            dgvHoaDon.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvHoaDon.RowTemplate.Height = 35;

            dgvHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            dgvHoaDon.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dgvHoaDon.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void BoTronGocPanel(Panel pn, int radius)
        {
            Rectangle r = new Rectangle(0, 0, pn.Width, pn.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            int d = radius * 2;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            gp.CloseAllFigures();

            pn.Region = new Region(gp);
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            lblUserHienTai.Text = "Nhân viên: " + LuuThongTin.TenDangNhap;
            lblUserHienTai.ForeColor = Color.DarkBlue;
            if (LuuThongTin.Quyen != "Quản lý")
            {
                btnQuanLyMenu.Visible = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                LuuThongTin.TenDangNhap = "";

                Application.Restart();
            }
        }

        private void btnQuanLyMenu_Click(object sender, EventArgs e)
        {
            FormQuanLy frm = new FormQuanLy();
            frm.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 11, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10, FontStyle.Regular);
            Brush brush = Brushes.Black;

            int y = 20;
            int left = 10;

            g.DrawString("CÀ PHÊ DI SẢN", fontTitle, brush, new PointF(left + 50, y));
            y += 30;
            g.DrawString("HÓA ĐƠN THANH TOÁN", fontHeader, brush, new PointF(left + 45, y));
            y += 30;
            g.DrawString("Bàn: " + banDangChon, fontNormal, brush, new PointF(left, y));
            y += 20;
            g.DrawString("Giờ in: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontNormal, brush, new PointF(left, y));
            y += 30;
            g.DrawLine(new Pen(Color.Black, 1), left, y, 280, y);
            y += 10;

            g.DrawString("Tên món", fontHeader, brush, new PointF(left, y));
            g.DrawString("Giá tiền", fontHeader, brush, new PointF(200, y));
            y += 25;

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string tenMon = row.Cells[0].Value.ToString();
                    string giaTien = row.Cells[1].Value.ToString();

                    g.DrawString(tenMon, fontNormal, brush, new PointF(left, y));
                    g.DrawString(giaTien, fontNormal, brush, new PointF(200, y));
                    y += 20;
                }
            }

            y += 10;
            g.DrawLine(new Pen(Color.Black, 1), left, y, 280, y);
            y += 15;
            g.DrawString("TỔNG CỘNG:", fontHeader, brush, new PointF(left, y));
            g.DrawString(nhoTongTien[banDangChon].ToString("N0") + "đ", fontTitle, brush, new PointF(180, y - 5));
            y += 40;

            if (radQR.Checked == true && picQRCode.Image != null)
            {
                g.DrawString("Quét mã QR dưới đây để thanh toán:", fontNormal, brush, new PointF(left + 15, y));
                y += 20;

                g.DrawImage(picQRCode.Image, left + 60, y, 150, 150);
                y += 160;
            }

            g.DrawString("Cảm ơn quý khách và hẹn gặp lại!", fontNormal, brush, new PointF(left + 25, y));
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

