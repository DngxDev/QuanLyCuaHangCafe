using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FormDangKyCa : MaterialForm
    {
        public FormDangKyCa()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Brown700,     
                Primary.Brown900,    
                Primary.Brown500, 
                Accent.DeepOrange200, 
                TextShade.WHITE 
            );
        }

        private void btnXacNhanDK_Click(object sender, EventArgs e)
        {
            string chuoiKetNoi = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string query = "INSERT INTO DangKyCa (TenDangNhap, NgayDangKy, CaLam) VALUES (@ten, @ngay, @ca)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ten", LuuThongTin.TenDangNhap);
                    cmd.Parameters.AddWithValue("@ngay", ctrLichDangKy.SelectionStart.Date);
                    cmd.Parameters.AddWithValue("@ca", cmbCaLam.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gửi đăng ký ca thành công! Vui lòng chờ quản lý duyệt.", "Hoàn tất");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }


        private void ToMauLich()
        {
            string chuoiKetNoi = @"Data Source=DESKTOP-VB3S1MD\SQLEXPRESS;Initial Catalog=QL_NguoiDung;Integrated Security=True;TrustServerCertificate=True";
            List<DateTime> danhSachNgay = new List<DateTime>();

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string query = "SELECT NgayDangKy FROM DangKyCa WHERE TenDangNhap = @tk";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tk", LuuThongTin.TenDangNhap);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        danhSachNgay.Add(Convert.ToDateTime(reader["NgayDangKy"]));
                    }
                }
                ctrLichDangKy.BoldedDates = danhSachNgay.ToArray();
            }
            catch (Exception ex) { }
        }

        private void FormDangKyCa_Load(object sender, EventArgs e)
        {
            ToMauLich();
        }
    }
}
