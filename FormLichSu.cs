using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BaiTap
{
    public partial class FormLichSu : Form
    {
        public FormLichSu()
        {
            InitializeComponent();
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaHD AS [Mã Hóa Đơn], MaBan AS [Bàn Số], ThoiGian AS [Thời Gian], TongTien AS [Tổng Tiền], NguoiBan AS [Người Bán], PhuongThuc AS [Phương Thức] FROM HoaDon ORDER BY ThoiGian DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    dgvLichSu.DataSource = dt;
                }
            }
        }

        private void dgvLichSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

