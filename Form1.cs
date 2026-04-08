using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";
            string user = txtUsername.Text;
            string pass = txtPassword.Text;


            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Thay vì COUNT(*), ta SELECT Quyen để lấy chức vụ
                    string query = "SELECT Quyen FROM [User] WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Code cũ của bạn truyền tham số rất chuẩn rồi, mình giữ nguyên
                        cmd.Parameters.AddWithValue("@Username", user);
                        cmd.Parameters.AddWithValue("@Password", pass);

                        // ExecuteScalar giờ sẽ bắt chữ "Quản lý" hoặc "Nhân viên" từ SQL mang về
                        object ketQua = cmd.ExecuteScalar();

                        if (ketQua != null) // Nếu ketQua có dữ liệu = Đăng nhập đúng!
                        {
                            // 1. Lưu Tên và Quyền vào bộ nhớ ở Program.cs
                            LuuThongTin.TenDangNhap = txtUsername.Text;
                            LuuThongTin.Quyen = ketQua.ToString();

                            // 2. Chào mừng thật ngầu
                            MessageBox.Show("Đăng nhập thành công! Chào mừng " + LuuThongTin.Quyen + " " + LuuThongTin.TenDangNhap);

                            // 3. Mở Form Bán Hàng (Giữ nguyên logic cũ của bạn)
                            this.Hide();
                            FormTrangChu frm = new FormTrangChu();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDangKy frmDK = new FormDangKy();
frmDK.ShowDialog(); // Mở form đăng ký lên
        }
    }
}