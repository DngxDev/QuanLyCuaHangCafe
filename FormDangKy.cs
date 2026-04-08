using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace BaiTap
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text;
            string pass = txtMatKhau.Text;
            string confirmPass = txtXacNhanMatKhau.Text;

            if (user == "" || pass == "" || confirmPass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [User] WHERE Username = @User";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@User", user);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Tên tài khoản này đã có người sử dụng. Vui lòng chọn tên khác!");
                            return; 
                        }
                    }

                    string insertQuery = "INSERT INTO [User] (Username, Password) VALUES (@User, @Pass)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@User", user);
                        insertCmd.Parameters.AddWithValue("@Pass", pass);

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký tài khoản thành công!");
                        this.Close(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
                }
            }
        }
    }
}