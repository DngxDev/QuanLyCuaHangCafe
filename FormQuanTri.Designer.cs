namespace BaiTap
{
    partial class FormQuanTri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabPage3 = new TabPage();
            button1 = new Button();
            btnTuChoi = new Button();
            btnDuyetCa = new Button();
            dgvXepCa = new DataGridView();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            btnSuaGia = new Button();
            btnXoa = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDonVi = new TextBox();
            btnNhapHang = new Button();
            txtGiaNhap = new TextBox();
            txtSoLuong = new TextBox();
            txtTenNL = new TextBox();
            dgvNguyenLieu = new DataGridView();
            btnQuayLai1 = new Button();
            tabPage1 = new TabPage();
            btnQuayLai = new Button();
            dgvDanhSachChamCong = new DataGridView();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            dgvTheoDoiCa = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            radHomNay = new RadioButton();
            lblDangTrongCa = new Label();
            radTuanNay = new RadioButton();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXepCa).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChamCong).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheoDoiCa).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(btnTuChoi);
            tabPage3.Controls.Add(btnDuyetCa);
            tabPage3.Controls.Add(dgvXepCa);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1920, 1017);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Xếp Ca";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 64, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1321, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 43);
            button1.TabIndex = 4;
            button1.Text = "QUAY LẠI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTuChoi
            // 
            btnTuChoi.Location = new Point(1321, 203);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(120, 29);
            btnTuChoi.TabIndex = 2;
            btnTuChoi.Text = "TỪ CHỐI";
            btnTuChoi.UseVisualStyleBackColor = true;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // btnDuyetCa
            // 
            btnDuyetCa.Location = new Point(1321, 143);
            btnDuyetCa.Name = "btnDuyetCa";
            btnDuyetCa.Size = new Size(120, 35);
            btnDuyetCa.TabIndex = 1;
            btnDuyetCa.Text = "DUYỆT CA";
            btnDuyetCa.UseVisualStyleBackColor = true;
            btnDuyetCa.Click += btnDuyetCa_Click;
            // 
            // dgvXepCa
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvXepCa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvXepCa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXepCa.Location = new Point(0, 0);
            dgvXepCa.Name = "dgvXepCa";
            dgvXepCa.RowHeadersWidth = 51;
            dgvXepCa.Size = new Size(1222, 956);
            dgvXepCa.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(dgvNguyenLieu);
            tabPage2.Controls.Add(btnQuayLai1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1920, 1017);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kiểm Soát Hàng Hóa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnSuaGia);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDonVi);
            panel1.Controls.Add(btnNhapHang);
            panel1.Controls.Add(txtGiaNhap);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(txtTenNL);
            panel1.Location = new Point(1472, 73);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 423);
            panel1.TabIndex = 12;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.vecteezy_simple_coffee_cup_silhouette_on_transparent_background_52349389;
            pictureBox5.Location = new Point(16, 44);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(168, 133);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(245, 272);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 15;
            label5.Text = "ĐƠN VỊ";
            // 
            // btnSuaGia
            // 
            btnSuaGia.BackColor = Color.FromArgb(128, 64, 0);
            btnSuaGia.FlatAppearance.BorderSize = 0;
            btnSuaGia.FlatStyle = FlatStyle.Flat;
            btnSuaGia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaGia.ForeColor = Color.White;
            btnSuaGia.Location = new Point(16, 345);
            btnSuaGia.Margin = new Padding(3, 4, 3, 4);
            btnSuaGia.Name = "btnSuaGia";
            btnSuaGia.Size = new Size(107, 37);
            btnSuaGia.TabIndex = 6;
            btnSuaGia.Text = "SỬA GIÁ";
            btnSuaGia.UseVisualStyleBackColor = false;
            btnSuaGia.Click += btnSuaGia_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(128, 64, 0);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(16, 272);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 37);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "XÓA BỎ";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(245, 199);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 14;
            label4.Text = "GIÁ NHẬP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 121);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 13;
            label3.Text = "SỐ LƯỢNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 49);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 12;
            label2.Text = "TÊN NGUYÊN LIỆU";
            // 
            // txtDonVi
            // 
            txtDonVi.Location = new Point(223, 296);
            txtDonVi.Margin = new Padding(3, 4, 3, 4);
            txtDonVi.Name = "txtDonVi";
            txtDonVi.Size = new Size(114, 32);
            txtDonVi.TabIndex = 11;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.FromArgb(128, 64, 0);
            btnNhapHang.FlatAppearance.BorderSize = 0;
            btnNhapHang.FlatStyle = FlatStyle.Flat;
            btnNhapHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhapHang.ForeColor = Color.White;
            btnNhapHang.Location = new Point(16, 188);
            btnNhapHang.Margin = new Padding(3, 4, 3, 4);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(147, 45);
            btnNhapHang.TabIndex = 5;
            btnNhapHang.Text = "NHẬP HÀNG";
            btnNhapHang.UseVisualStyleBackColor = false;
            btnNhapHang.Click += btnNhapHang_Click;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(223, 223);
            txtGiaNhap.Margin = new Padding(3, 4, 3, 4);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(114, 32);
            txtGiaNhap.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(223, 145);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(114, 32);
            txtSoLuong.TabIndex = 9;
            // 
            // txtTenNL
            // 
            txtTenNL.Location = new Point(223, 73);
            txtTenNL.Margin = new Padding(3, 4, 3, 4);
            txtTenNL.Name = "txtTenNL";
            txtTenNL.Size = new Size(114, 32);
            txtTenNL.TabIndex = 8;
            // 
            // dgvNguyenLieu
            // 
            dgvNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguyenLieu.BackgroundColor = Color.AntiqueWhite;
            dgvNguyenLieu.BorderStyle = BorderStyle.None;
            dgvNguyenLieu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkRed;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNguyenLieu.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNguyenLieu.Dock = DockStyle.Left;
            dgvNguyenLieu.EnableHeadersVisualStyles = false;
            dgvNguyenLieu.GridColor = SystemColors.ButtonFace;
            dgvNguyenLieu.Location = new Point(3, 4);
            dgvNguyenLieu.Margin = new Padding(3, 4, 3, 4);
            dgvNguyenLieu.Name = "dgvNguyenLieu";
            dgvNguyenLieu.RowHeadersVisible = false;
            dgvNguyenLieu.RowHeadersWidth = 51;
            dgvNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNguyenLieu.Size = new Size(1440, 1009);
            dgvNguyenLieu.TabIndex = 4;
            dgvNguyenLieu.CellClick += dgvNguyenLieu_CellClick;
            // 
            // btnQuayLai1
            // 
            btnQuayLai1.BackColor = Color.FromArgb(128, 64, 0);
            btnQuayLai1.FlatAppearance.BorderSize = 0;
            btnQuayLai1.FlatStyle = FlatStyle.Flat;
            btnQuayLai1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai1.ForeColor = Color.White;
            btnQuayLai1.Location = new Point(1786, 4);
            btnQuayLai1.Margin = new Padding(3, 4, 3, 4);
            btnQuayLai1.Name = "btnQuayLai1";
            btnQuayLai1.Size = new Size(112, 43);
            btnQuayLai1.TabIndex = 3;
            btnQuayLai1.Text = "QUAY LẠI";
            btnQuayLai1.UseVisualStyleBackColor = false;
            btnQuayLai1.Click += btnQuayLai1_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnQuayLai);
            tabPage1.Controls.Add(dgvDanhSachChamCong);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1920, 1017);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Ngày Công";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.FromArgb(128, 64, 0);
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.ForeColor = SystemColors.Control;
            btnQuayLai.Location = new Point(1756, 8);
            btnQuayLai.Margin = new Padding(3, 4, 3, 4);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(125, 43);
            btnQuayLai.TabIndex = 3;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // dgvDanhSachChamCong
            // 
            dgvDanhSachChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachChamCong.BackgroundColor = Color.AntiqueWhite;
            dgvDanhSachChamCong.BorderStyle = BorderStyle.None;
            dgvDanhSachChamCong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSachChamCong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DarkRed;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDanhSachChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDanhSachChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.MistyRose;
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDanhSachChamCong.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDanhSachChamCong.EnableHeadersVisualStyles = false;
            dgvDanhSachChamCong.GridColor = SystemColors.ButtonFace;
            dgvDanhSachChamCong.Location = new Point(-5, 0);
            dgvDanhSachChamCong.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachChamCong.Name = "dgvDanhSachChamCong";
            dgvDanhSachChamCong.RowHeadersVisible = false;
            dgvDanhSachChamCong.RowHeadersWidth = 51;
            dgvDanhSachChamCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachChamCong.Size = new Size(1702, 1375);
            dgvDanhSachChamCong.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1928, 1055);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvTheoDoiCa);
            tabPage4.Controls.Add(panel2);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1920, 1017);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Ca Làm";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvTheoDoiCa
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvTheoDoiCa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvTheoDoiCa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheoDoiCa.Location = new Point(504, 0);
            dgvTheoDoiCa.Name = "dgvTheoDoiCa";
            dgvTheoDoiCa.RowHeadersWidth = 51;
            dgvTheoDoiCa.Size = new Size(1425, 1017);
            dgvTheoDoiCa.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(radHomNay);
            panel2.Controls.Add(lblDangTrongCa);
            panel2.Controls.Add(radTuanNay);
            panel2.Location = new Point(8, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 335);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 64, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(112, 43);
            button2.TabIndex = 5;
            button2.Text = "QUAY LẠI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // radHomNay
            // 
            radHomNay.AutoSize = true;
            radHomNay.BackColor = Color.FromArgb(128, 64, 0);
            radHomNay.Checked = true;
            radHomNay.FlatAppearance.BorderSize = 0;
            radHomNay.FlatStyle = FlatStyle.Flat;
            radHomNay.ForeColor = Color.White;
            radHomNay.Location = new Point(3, 66);
            radHomNay.Name = "radHomNay";
            radHomNay.Size = new Size(192, 29);
            radHomNay.TabIndex = 0;
            radHomNay.TabStop = true;
            radHomNay.Text = "Chỉ xem Hôm Nay";
            radHomNay.UseVisualStyleBackColor = false;
            radHomNay.CheckedChanged += radHomNay_CheckedChanged;
            // 
            // lblDangTrongCa
            // 
            lblDangTrongCa.AutoSize = true;
            lblDangTrongCa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangTrongCa.Location = new Point(3, 133);
            lblDangTrongCa.Name = "lblDangTrongCa";
            lblDangTrongCa.Size = new Size(395, 28);
            lblDangTrongCa.TabIndex = 2;
            lblDangTrongCa.Text = "[Nhân viên đang trong ca sẽ hiện ở đây]";
            // 
            // radTuanNay
            // 
            radTuanNay.AutoSize = true;
            radTuanNay.BackColor = Color.FromArgb(128, 64, 0);
            radTuanNay.FlatAppearance.BorderSize = 0;
            radTuanNay.FlatStyle = FlatStyle.Flat;
            radTuanNay.ForeColor = Color.White;
            radTuanNay.Location = new Point(3, 101);
            radTuanNay.Name = "radTuanNay";
            radTuanNay.Size = new Size(147, 29);
            radTuanNay.TabIndex = 1;
            radTuanNay.Text = "Xem Cả Tuần";
            radTuanNay.UseVisualStyleBackColor = false;
            radTuanNay.CheckedChanged += radTuanNay_CheckedChanged;
            // 
            // FormQuanTri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1928, 1055);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormQuanTri";
            Text = "FormQuanTri";
            WindowState = FormWindowState.Maximized;
            Load += FormQuanTri_Load;
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXepCa).EndInit();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChamCong).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTheoDoiCa).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage3;
        private Button btnTuChoi;
        private Button btnDuyetCa;
        private DataGridView dgvXepCa;
        private TabPage tabPage2;
        private Panel panel1;
        private PictureBox pictureBox5;
        private Label label5;
        private Button btnSuaGia;
        private Button btnXoa;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDonVi;
        private Button btnNhapHang;
        private TextBox txtGiaNhap;
        private TextBox txtSoLuong;
        private TextBox txtTenNL;
        private DataGridView dgvNguyenLieu;
        private Button btnQuayLai1;
        private TabPage tabPage1;
        private Button btnQuayLai;
        private DataGridView dgvDanhSachChamCong;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private Label lblDangTrongCa;
        private RadioButton radTuanNay;
        private RadioButton radHomNay;
        private DataGridView dgvTheoDoiCa;
        private Panel panel2;
        private Button button1;
        private Button button2;
    }
}