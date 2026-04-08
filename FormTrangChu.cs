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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void btnToChamCong_Click(object sender, EventArgs e)
        {
            FormChamCong frm = new FormChamCong();
            frm.ShowDialog(); // Mở trang chấm công dưới dạng cửa sổ con
                              // Sau khi đóng trang chấm công, có thể cập nhật lại thông tin ở trang chủ nếu cần
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            lblUserHienTai.Text = "Nhân viên: " + LuuThongTin.TenDangNhap;
            lblUserHienTai.ForeColor = Color.FromArgb(128, 64, 0);
            if (LuuThongTin.Quyen == "Quản lý")
            {
                btnQuanLyAdmin.Visible = true;  // Sếp đăng nhập -> Hiện nút
            }
            else
            {
                btnQuanLyAdmin.Visible = false; // Nhân viên đăng nhập -> Giấu tịt đi
            }
            lblTenNhanVien.Text = "Nhân viên: " + LuuThongTin.TenDangNhap;
            string taiKhoan = LuuThongTin.TenDangNhap;
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Đếm số ngày đã chấm công trong THÁNG NÀY
                    string query = "SELECT COUNT(DISTINCT NgayLam) FROM ChamCong WHERE TenDangNhap = @tk AND MONTH(NgayLam) = MONTH(GETDATE()) AND YEAR(NgayLam) = YEAR(GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", taiKhoan);
                        int soNgay = (int)cmd.ExecuteScalar(); // Lấy trực tiếp con số

                        lblNgayCong.Text = soNgay.ToString() + " ngày";
                    }
                }
            }
            catch (Exception ex)
            {
                lblNgayCong.Text = "Lỗi tải";
            }
        }

        private void btnQuanLyAdmin_Click(object sender, EventArgs e)
        {
            FormQuanTri frm = new FormQuanTri();
            frm.ShowDialog();
        }

        private void btnMoBanHang_Click(object sender, EventArgs e)
        {
            FormBanHang frm = new FormBanHang();

            this.Hide();

            frm.ShowDialog();

            this.Show();
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

        private void btnDangKyCa_Click(object sender, EventArgs e)
        {
            FormDangKyCa frm = new FormDangKyCa();
            frm.ShowDialog();
        }
    }
}
