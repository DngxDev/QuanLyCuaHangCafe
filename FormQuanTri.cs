using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class FormQuanTri : Form
    {
        public FormQuanTri()
        {
            InitializeComponent();
        }

        private void FormQuanTri_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                TenDangNhap AS [Tên Nhân Viên], 
                                NgayLam AS [Ngày Làm Việc], 
                                GioVao AS [Giờ Vào Ca], 
                                GioRa AS [Giờ Tan Ca] 
                             FROM ChamCong 
                             ORDER BY NgayLam DESC, GioVao DESC";
                    string queryKho = @"SELECT 
                                  TenNguyenLieu AS [Tên Nguyên Liệu], 
                                  SoLuongTon AS [Số Lượng Tồn Kho], 
                                  DonViTinh AS [Đơn Vị],
                                  GiaNhap AS [Giá Nhập]
                                FROM KhoNguyenLieu";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvDanhSachChamCong.DataSource = dt;
                    }
                    using (SqlDataAdapter adapterKho = new SqlDataAdapter(queryKho, conn))
                    {
                        DataTable dtKho = new DataTable();
                        adapterKho.Fill(dtKho);
                        dgvNguyenLieu.DataSource = dtKho;
                        foreach (DataGridViewRow row in dgvNguyenLieu.Rows)
                        {
                            if (row.IsNewRow) continue;

                            double soLuong = Convert.ToDouble(row.Cells["Số Lượng Tồn Kho"].Value);

                            if (soLuong < 5)
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 228, 225);

                                row.DefaultCellStyle.ForeColor = Color.FromArgb(139, 0, 0);

                                row.DefaultCellStyle.Font = new Font(dgvNguyenLieu.Font, FontStyle.Bold);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu chấm công: " + ex.Message, "Lỗi SQL");
            }

            {
                DataTable dtCa = new DataTable();
                dgvXepCa.DataSource = dtCa;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnQuayLai1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            string chuoiKetNoi = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM KhoNguyenLieu WHERE TenNguyenLieu = @ten";
                    SqlCommand cmdCheck = new SqlCommand(checkQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@ten", txtTenNL.Text);

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        string updateQuery = "UPDATE KhoNguyenLieu SET SoLuongTon = SoLuongTon + @sl, GiaNhap = @gia, DonViTinh = @dv WHERE TenNguyenLieu = @ten";
                        SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn);
                        cmdUpdate.Parameters.AddWithValue("@sl", float.Parse(txtSoLuong.Text));
                        cmdUpdate.Parameters.AddWithValue("@gia", float.Parse(txtGiaNhap.Text));
                        cmdUpdate.Parameters.AddWithValue("@dv", txtDonVi.Text);
                        cmdUpdate.Parameters.AddWithValue("@ten", txtTenNL.Text);

                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Đã nhập thêm hàng vào nguyên liệu CŨ!", "Thành công");
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO KhoNguyenLieu (TenNguyenLieu, SoLuongTon, DonViTinh, GiaNhap) VALUES (@ten, @sl, @dv, @gia)";
                        SqlCommand cmdInsert = new SqlCommand(insertQuery, conn);
                        cmdInsert.Parameters.AddWithValue("@ten", txtTenNL.Text);
                        cmdInsert.Parameters.AddWithValue("@sl", float.Parse(txtSoLuong.Text));
                        cmdInsert.Parameters.AddWithValue("@dv", txtDonVi.Text);
                        cmdInsert.Parameters.AddWithValue("@gia", float.Parse(txtGiaNhap.Text));

                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Đã tạo nguyên liệu MỚI trong kho!", "Thành công");
                    }

                    FormQuanTri_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập hàng: " + ex.Message, "Lỗi SQL");
            }
        }

        private void btnSuaGia_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE KhoNguyenLieu SET GiaNhap = @gia WHERE TenNguyenLieu = @ten";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@gia", float.Parse(txtGiaNhap.Text));
                    cmd.Parameters.AddWithValue("@ten", txtTenNL.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật giá nhập mới!");
                    FormQuanTri_Load(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM KhoNguyenLieu WHERE TenNguyenLieu = @ten";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ten", txtTenNL.Text);

                        cmd.ExecuteNonQuery();
                        FormQuanTri_Load(null, null);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNguyenLieu.Rows[e.RowIndex];
                txtTenNL.Text = row.Cells["Tên Nguyên Liệu"].Value.ToString();
                txtGiaNhap.Text = row.Cells["Giá Nhập"].Value.ToString();
                txtDonVi.Text = row.Cells["Đơn Vị"].Value.ToString();
            }
        }

        private void btnDuyetCa_Click(object sender, EventArgs e)
        {
            if (dgvXepCa.CurrentRow != null)
            {
                string maDK = dgvXepCa.CurrentRow.Cells["MaDK"].Value.ToString();

                string chuoiKetNoi = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string query = "UPDATE DangKyCa SET TrangThai = N'ĐÃ XẾP CA (DUYỆT)' WHERE MaDK = @ma";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", maDK);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã duyệt ca làm cho nhân viên!");
                    LoadDanhSachCa();
                }
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgvXepCa.CurrentRow != null && !dgvXepCa.CurrentRow.IsNewRow)
            {
                DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn TỪ CHỐI ca làm này không?", "Xác nhận từ chối", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (xacNhan == DialogResult.Yes)
                {
                    string maDK = dgvXepCa.CurrentRow.Cells["MaDK"].Value.ToString();

                    string chuoiKetNoi = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                        {
                            conn.Open();
                            string query = "UPDATE DangKyCa SET TrangThai = N'TỪ CHỐI' WHERE MaDK = @ma";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ma", maDK);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Đã từ chối ca làm!", "Thông báo");

                            LoadDanhSachCa();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi SQL");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một đơn đăng ký trong bảng trước khi từ chối!", "Nhắc nhở");
            }
        }

        private void TanTrangBangChuan(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 0, 0);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.RowTemplate.Height = 35;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 228, 225);
            dgv.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(240, 240, 240);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                LoadDanhSachCa();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                LoadTheoDoiCa();
            }
        }
        private void LoadDanhSachCa()
        {
            string chuoiKetNoiCa = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                using (SqlConnection connCa = new SqlConnection(chuoiKetNoiCa))
                {
                    connCa.Open();
                    string queryCa = "SELECT MaDK, TenDangNhap AS [Nhân Viên], NgayDangKy AS [Ngày Làm], CaLam AS [Ca Đăng Ký], TrangThai AS [Trạng Thái] FROM DangKyCa ORDER BY NgayDangKy ASC";
                    using (SqlDataAdapter adapterCa = new SqlDataAdapter(queryCa, connCa))
                    {
                        DataTable dtCa = new DataTable();
                        adapterCa.Fill(dtCa);

                        dgvXepCa.AutoGenerateColumns = true;
                        dgvXepCa.DataSource = dtCa;
                    }
                }

                TanTrangBangChuan(dgvXepCa);

                foreach (DataGridViewRow row in dgvXepCa.Rows)
                {
                    if (row.IsNewRow) continue;
                    string trangThai = row.Cells["Trạng Thái"].Value.ToString();
                    if (trangThai == "Chờ xếp ca")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        row.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                        row.DefaultCellStyle.Font = new Font(dgvXepCa.Font, FontStyle.Bold);
                    }
                    else if (trangThai == "ĐÃ XẾP CA (DUYỆT)")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(230, 255, 230);
                        row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                    }
                    else if (trangThai == "TỪ CHỐI")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 228, 225);
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                        row.DefaultCellStyle.Font = new Font(dgvXepCa.Font, FontStyle.Strikeout);
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void LoadTheoDoiCa()
        {
            string chuoiKetNoi = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string query = "";

                    if (radHomNay.Checked)
                    {
                        query = "SELECT TenDangNhap AS [Nhân Viên], NgayDangKy AS [Ngày Làm], CaLam AS [Ca] FROM DangKyCa WHERE TrangThai = N'ĐÃ XẾP CA (DUYỆT)' AND NgayDangKy = CAST(GETDATE() AS DATE)";
                    }
                    else
                    {
                        query = "SELECT TenDangNhap AS [Nhân Viên], NgayDangKy AS [Ngày Làm], CaLam AS [Ca] FROM DangKyCa WHERE TrangThai = N'ĐÃ XẾP CA (DUYỆT)' AND DATEDIFF(week, 0, NgayDangKy) = DATEDIFF(week, 0, GETDATE()) ORDER BY NgayDangKy ASC";
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvTheoDoiCa.AutoGenerateColumns = true;
                        dgvTheoDoiCa.DataSource = dt;
                    }
                }

                TanTrangBangChuan(dgvTheoDoiCa);

                QuetNguoiDangTrongCa();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải lịch: " + ex.Message); }
        }
        private void QuetNguoiDangTrongCa()
        {
            int gioHienTai = DateTime.Now.Hour;

            string dangLam = "🔥 NHÂN VIÊN ĐANG TRỰC CA: ";
            bool coNguoi = false;

            foreach (DataGridViewRow row in dgvTheoDoiCa.Rows)
            {
                if (row.IsNewRow) continue;

                DateTime ngayLam = Convert.ToDateTime(row.Cells["Ngày Làm"].Value);
                if (ngayLam.Date != DateTime.Today) continue;

                string caLam = row.Cells["Ca"].Value.ToString();
                string tenNV = row.Cells["Nhân Viên"].Value.ToString();

                if (caLam.Contains("Sáng") && gioHienTai >= 6 && gioHienTai < 14)
                {
                    dangLam += tenNV + " (Ca Sáng), "; coNguoi = true;
                }
                else if (caLam.Contains("Chiều") && gioHienTai >= 14 && gioHienTai < 22)
                {
                    dangLam += tenNV + " (Ca Chiều), "; coNguoi = true;
                }
                else if (caLam.Contains("Tối") && gioHienTai >= 18 && gioHienTai < 22)
                {
                    dangLam += tenNV + " (Ca Tối), "; coNguoi = true;
                }
            }

            if (!coNguoi)
            {
                lblDangTrongCa.Text = "💤 Hiện tại không có nhân viên nào trong ca.";
                lblDangTrongCa.ForeColor = Color.Gray;
            }
            else
            {
                lblDangTrongCa.Text = dangLam.TrimEnd(',', ' ');
                lblDangTrongCa.ForeColor = Color.DarkGreen;
            }
        }

        private void radHomNay_CheckedChanged(object sender, EventArgs e)
        {
            if (radHomNay.Checked) LoadTheoDoiCa();
        }

        private void radTuanNay_CheckedChanged(object sender, EventArgs e)
        {
            if (radTuanNay.Checked) LoadTheoDoiCa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
