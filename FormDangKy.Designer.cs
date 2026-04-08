namespace BaiTap
{
    partial class FormDangKy
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
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDangKy = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = Color.AntiqueWhite;
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.ForeColor = Color.FromArgb(128, 64, 0);
            txtTaiKhoan.Location = new Point(177, 96);
            txtTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(114, 23);
            txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.AntiqueWhite;
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.FromArgb(128, 64, 0);
            txtMatKhau.Location = new Point(177, 145);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(114, 23);
            txtMatKhau.TabIndex = 1;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.BackColor = Color.AntiqueWhite;
            txtXacNhanMatKhau.BorderStyle = BorderStyle.None;
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtXacNhanMatKhau.ForeColor = Color.FromArgb(128, 64, 0);
            txtXacNhanMatKhau.Location = new Point(177, 194);
            txtXacNhanMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(114, 23);
            txtXacNhanMatKhau.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(3, 96);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 3;
            label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(3, 145);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(3, 194);
            label3.Name = "label3";
            label3.Size = new Size(168, 23);
            label3.TabIndex = 5;
            label3.Text = "Xác nhận mật khẩu:";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(128, 64, 0);
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.AntiqueWhite;
            btnDangKy.Location = new Point(163, 241);
            btnDangKy.Margin = new Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(140, 31);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng ký ngay";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnDangKy);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtXacNhanMatKhau);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 345);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 79);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 0);
            label4.Name = "label4";
            label4.Size = new Size(290, 38);
            label4.TabIndex = 7;
            label4.Text = "HỆ THỐNG QUẢN LÝ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 40);
            label5.Name = "label5";
            label5.Size = new Size(219, 38);
            label5.TabIndex = 8;
            label5.Text = "CÀ PHÊ DI SẢN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vecteezy_simple_coffee_cup_silhouette_on_transparent_background_52349389;
            pictureBox1.Location = new Point(13, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_wrt3wgwrt3wgwrt3;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1094, 600);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDangKy";
            Text = "Quản lý Cafe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDangKy;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}