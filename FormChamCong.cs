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
    public partial class FormChamCong : Form
    {
        public FormChamCong()
        {
            InitializeComponent();
        }

        private void CapNhatLich()
        {
            string taiKhoan = LuuThongTin.TenDangNhap;
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            List<DateTime> danhSachNgay = new List<DateTime>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT NgayLam FROM ChamCong WHERE TenDangNhap = @tk";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tk", taiKhoan);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        danhSachNgay.Add(Convert.ToDateTime(reader["NgayLam"]));
                    }
                    reader.Close();
                }

                ctrLichLamViec.BoldedDates = danhSachNgay.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch: " + ex.Message);
            }
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            lblTenNhanVien.Text = "Nhân viên: " + LuuThongTin.TenDangNhap;
            CapNhatLich();

            string taiKhoan = LuuThongTin.TenDangNhap;
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT GioRa FROM ChamCong WHERE TenDangNhap = @tk AND NgayLam = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", taiKhoan);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["GioRa"] == DBNull.Value)
                                {
                                    btnChamCong.Text = "CHẤM CÔNG TAN CA";
                                    btnChamCong.BackColor = Color.FromArgb(40, 167, 69);
                                }
                                else
                                {
                                    btnChamCong.Text = "ĐÃ HOÀN THÀNH CA LÀM";
                                    btnChamCong.BackColor = Color.Gray;
                                    btnChamCong.Enabled = false;
                                }
                            }
                            else
                            {
                                btnChamCong.Text = "CHẤM CÔNG VÀO CA";
                                btnChamCong.BackColor = Color.FromArgb(139, 0, 0);
                                btnChamCong.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            string taiKhoan = LuuThongTin.TenDangNhap;
            string connectionString = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT MaCC, GioRa FROM ChamCong WHERE TenDangNhap = @tk AND NgayLam = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@tk", taiKhoan);
                        using (SqlDataReader reader = cmdCheck.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["GioRa"] == DBNull.Value)
                                {
                                    int maCC = Convert.ToInt32(reader["MaCC"]);
                                    reader.Close();

                                    string updateQuery = "UPDATE ChamCong SET GioRa = GETDATE() WHERE MaCC = @ma";
                                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                                    {
                                        cmdUpdate.Parameters.AddWithValue("@ma", maCC);
                                        cmdUpdate.ExecuteNonQuery();

                                        MessageBox.Show("Chấm công TAN CA thành công! Chúc bạn nghỉ ngơi vui vẻ.", "Hoàn thành ca làm");

                                        btnChamCong.Text = "ĐÃ HOÀN THÀNH CA LÀM";
                                        btnChamCong.BackColor = Color.Gray;
                                        btnChamCong.Enabled = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hôm nay bạn đã hoàn thành ca làm việc rồi, không cần bấm nữa nhé!", "Thông báo");
                                }
                            }
                            else
                            {
                                reader.Close();

                                string insertQuery = "INSERT INTO ChamCong (TenDangNhap, NgayLam, GioVao) VALUES (@tk, CAST(GETDATE() AS DATE), GETDATE())";
                                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                                {
                                    cmdInsert.Parameters.AddWithValue("@tk", taiKhoan);
                                    cmdInsert.ExecuteNonQuery();

                                    MessageBox.Show("Chấm công VÀO CA thành công! Chúc bạn ngày mới làm việc năng suất.", "Chào buổi sáng");

                                    btnChamCong.Text = "CHẤM CÔNG TAN CA";
                                    btnChamCong.BackColor = Color.FromArgb(40, 167, 69);

                                    CapNhatLich();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống chấm công: " + ex.Message, "Lỗi SQL");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
