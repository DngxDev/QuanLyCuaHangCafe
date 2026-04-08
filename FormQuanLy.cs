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
    public partial class FormQuanLy : Form
    {
        string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

        public FormQuanLy()
        {
            InitializeComponent();
            TaiDanhSachMon();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            TaiDanhSachMon();
        }

        private void TaiDanhSachMon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ThucDon";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvThucDon.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Sếp ơi, nhập đủ tên món và giá tiền nhé!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO ThucDon (TenMon, GiaTien) VALUES (@Ten, @Gia)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ten", txtTenMon.Text);
                        cmd.Parameters.AddWithValue("@Gia", Convert.ToInt32(txtGiaTien.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm món mới thành công rực rỡ!");
                        TaiDanhSachMon(); 

                        txtTenMon.Clear();
                        txtGiaTien.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rùi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThucDon.SelectedRows.Count > 0)
            {
                DialogResult hoiLai = MessageBox.Show("Sếp chắc chắn muốn xóa món này khỏi Menu?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (hoiLai == DialogResult.Yes)
                {
                    int maMon = Convert.ToInt32(dgvThucDon.SelectedRows[0].Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM ThucDon WHERE MaMon = @Ma"; 
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Ma", maMon);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Đã xóa món thành công!");
                            TaiDanhSachMon(); 
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click bôi đen nguyên dòng món muốn xóa nhé!");
            }
        }
    }
}
