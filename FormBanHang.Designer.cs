namespace BaiTap
{
    partial class FormBanHang
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            panel1 = new Panel();
            flpDanhSachBan = new FlowLayoutPanel();
            panel2 = new Panel();
            flpMenu = new FlowLayoutPanel();
            form2 = new Panel();
            btnQuayLai = new Button();
            radQR = new RadioButton();
            radTienMat = new RadioButton();
            btnQuanLyMenu = new Button();
            btnDangXuat = new Button();
            lblUserHienTai = new Label();
            btnHuyMon = new Button();
            btnLichSu = new Button();
            lblBanDangChon = new Label();
            btnThanhToan = new Button();
            lblTongTien = new Label();
            dgvHoaDon = new DataGridView();
            colTenMon = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            picQRCode = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            form2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(flpDanhSachBan);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 881);
            panel1.TabIndex = 0;
            // 
            // flpDanhSachBan
            // 
            flpDanhSachBan.BackColor = Color.RosyBrown;
            flpDanhSachBan.BackgroundImageLayout = ImageLayout.None;
            flpDanhSachBan.Dock = DockStyle.Fill;
            flpDanhSachBan.Location = new Point(0, 0);
            flpDanhSachBan.Margin = new Padding(3, 4, 3, 4);
            flpDanhSachBan.Name = "flpDanhSachBan";
            flpDanhSachBan.Size = new Size(287, 881);
            flpDanhSachBan.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(flpMenu);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(287, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 881);
            panel2.TabIndex = 1;
            // 
            // flpMenu
            // 
            flpMenu.BackColor = Color.MistyRose;
            flpMenu.BackgroundImageLayout = ImageLayout.Stretch;
            flpMenu.Dock = DockStyle.Fill;
            flpMenu.FlowDirection = FlowDirection.TopDown;
            flpMenu.Location = new Point(0, 0);
            flpMenu.Margin = new Padding(3, 4, 3, 4);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(1066, 881);
            flpMenu.TabIndex = 0;
            // 
            // form2
            // 
            form2.BackColor = Color.RosyBrown;
            form2.Controls.Add(btnQuayLai);
            form2.Controls.Add(radQR);
            form2.Controls.Add(radTienMat);
            form2.Controls.Add(btnQuanLyMenu);
            form2.Controls.Add(btnDangXuat);
            form2.Controls.Add(lblUserHienTai);
            form2.Controls.Add(btnHuyMon);
            form2.Controls.Add(btnLichSu);
            form2.Controls.Add(lblBanDangChon);
            form2.Controls.Add(btnThanhToan);
            form2.Controls.Add(lblTongTien);
            form2.Controls.Add(dgvHoaDon);
            form2.Dock = DockStyle.Right;
            form2.Location = new Point(1006, 0);
            form2.Margin = new Padding(3, 4, 3, 4);
            form2.Name = "form2";
            form2.Size = new Size(347, 881);
            form2.TabIndex = 2;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.FromArgb(128, 64, 0);
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.ForeColor = SystemColors.Control;
            btnQuayLai.Location = new Point(203, 793);
            btnQuayLai.Margin = new Padding(3, 4, 3, 4);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(125, 35);
            btnQuayLai.TabIndex = 10;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // radQR
            // 
            radQR.AutoSize = true;
            radQR.Location = new Point(81, 651);
            radQR.Name = "radQR";
            radQR.Size = new Size(111, 24);
            radQR.TabIndex = 9;
            radQR.Text = "Quét mã QR";
            radQR.UseVisualStyleBackColor = true;
            // 
            // radTienMat
            // 
            radTienMat.AutoSize = true;
            radTienMat.Checked = true;
            radTienMat.Location = new Point(203, 651);
            radTienMat.Name = "radTienMat";
            radTienMat.Size = new Size(88, 24);
            radTienMat.TabIndex = 8;
            radTienMat.TabStop = true;
            radTienMat.Text = "Tiền mặt";
            radTienMat.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyMenu
            // 
            btnQuanLyMenu.BackColor = Color.FromArgb(128, 64, 0);
            btnQuanLyMenu.FlatAppearance.BorderSize = 0;
            btnQuanLyMenu.FlatStyle = FlatStyle.Flat;
            btnQuanLyMenu.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanLyMenu.ForeColor = Color.White;
            btnQuanLyMenu.Location = new Point(3, 803);
            btnQuanLyMenu.Name = "btnQuanLyMenu";
            btnQuanLyMenu.Size = new Size(125, 29);
            btnQuanLyMenu.TabIndex = 7;
            btnQuanLyMenu.Text = "Quản Lý Menu";
            btnQuanLyMenu.UseVisualStyleBackColor = false;
            btnQuanLyMenu.Click += btnQuanLyMenu_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(197, 836);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(131, 29);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "ĐĂNG XUẤT";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // lblUserHienTai
            // 
            lblUserHienTai.Anchor = AnchorStyles.Top;
            lblUserHienTai.AutoSize = true;
            lblUserHienTai.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserHienTai.Location = new Point(3, 773);
            lblUserHienTai.Name = "lblUserHienTai";
            lblUserHienTai.Size = new Size(45, 25);
            lblUserHienTai.TabIndex = 4;
            lblUserHienTai.Text = "NV";
            // 
            // btnHuyMon
            // 
            btnHuyMon.BackColor = Color.FromArgb(128, 64, 0);
            btnHuyMon.FlatAppearance.BorderSize = 0;
            btnHuyMon.FlatStyle = FlatStyle.Flat;
            btnHuyMon.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyMon.ForeColor = Color.White;
            btnHuyMon.Location = new Point(81, 743);
            btnHuyMon.Margin = new Padding(3, 4, 3, 4);
            btnHuyMon.Name = "btnHuyMon";
            btnHuyMon.Size = new Size(86, 31);
            btnHuyMon.TabIndex = 5;
            btnHuyMon.Text = "HỦY MÓN";
            btnHuyMon.UseVisualStyleBackColor = false;
            btnHuyMon.Click += btnHuyMon_Click;
            // 
            // btnLichSu
            // 
            btnLichSu.BackColor = Color.FromArgb(128, 64, 0);
            btnLichSu.FlatAppearance.BorderSize = 0;
            btnLichSu.FlatStyle = FlatStyle.Flat;
            btnLichSu.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLichSu.ForeColor = Color.White;
            btnLichSu.Location = new Point(3, 833);
            btnLichSu.Margin = new Padding(3, 4, 3, 4);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Size = new Size(160, 32);
            btnLichSu.TabIndex = 4;
            btnLichSu.Text = "LỊCH SỬ BÁN HÀNG";
            btnLichSu.UseVisualStyleBackColor = false;
            btnLichSu.Click += btnLichSu_Click;
            // 
            // lblBanDangChon
            // 
            lblBanDangChon.AutoSize = true;
            lblBanDangChon.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBanDangChon.Location = new Point(81, 9);
            lblBanDangChon.Name = "lblBanDangChon";
            lblBanDangChon.Size = new Size(135, 23);
            lblBanDangChon.TabIndex = 3;
            lblBanDangChon.Text = "Chưa chọn bàn";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(128, 64, 0);
            btnThanhToan.FlatAppearance.BorderColor = Color.White;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(81, 683);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(194, 53);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "THANH TOÁN";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(0, 621);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(192, 26);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.RosyBrown;
            dgvHoaDon.BorderStyle = BorderStyle.None;
            dgvHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Brown;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colTenMon, colGia });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DarkRed;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Coral;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle4;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.GridColor = Color.IndianRed;
            dgvHoaDon.Location = new Point(0, 41);
            dgvHoaDon.Margin = new Padding(3, 4, 3, 4);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(347, 577);
            dgvHoaDon.TabIndex = 0;
            // 
            // colTenMon
            // 
            colTenMon.HeaderText = "Tên món";
            colTenMon.MinimumWidth = 6;
            colTenMon.Name = "colTenMon";
            // 
            // colGia
            // 
            colGia.HeaderText = "Giá tiền";
            colGia.MinimumWidth = 6;
            colGia.Name = "colGia";
            // 
            // picQRCode
            // 
            picQRCode.Dock = DockStyle.Fill;
            picQRCode.Location = new Point(287, 0);
            picQRCode.Name = "picQRCode";
            picQRCode.Size = new Size(719, 881);
            picQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            picQRCode.TabIndex = 11;
            picQRCode.TabStop = false;
            picQRCode.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 881);
            Controls.Add(picQRCode);
            Controls.Add(form2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBanHang";
            Text = "Quản lý Cafe";
            WindowState = FormWindowState.Maximized;
            Load += FormBanHang_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            form2.ResumeLayout(false);
            form2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flpDanhSachBan;
        private Panel panel2;
        private Panel form2;
        private FlowLayoutPanel flpMenu;
        private DataGridView dgvHoaDon;
        private Button btnThanhToan;
        private Label lblTongTien;
        private Label lblBanDangChon;
        private DataGridViewTextBoxColumn colTenMon;
        private DataGridViewTextBoxColumn colGia;
        private Button btnLichSu;
        private Button btnHuyMon;
        private Label lblUserHienTai;
        private Button btnDangXuat;
        private Button btnQuanLyMenu;
        private RadioButton radQR;
        private RadioButton radTienMat;
        private PictureBox picQRCode;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnQuayLai;
    }
}