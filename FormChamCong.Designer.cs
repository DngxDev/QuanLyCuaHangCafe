namespace BaiTap
{
    partial class FormChamCong
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
            ctrLichLamViec = new MonthCalendar();
            btnChamCong = new Button();
            btnQuayLai = new Button();
            lblTenNhanVien = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrLichLamViec
            // 
            ctrLichLamViec.CalendarDimensions = new Size(4, 3);
            ctrLichLamViec.Location = new Point(273, 1);
            ctrLichLamViec.MaxSelectionCount = 1;
            ctrLichLamViec.Name = "ctrLichLamViec";
            ctrLichLamViec.TabIndex = 0;
            // 
            // btnChamCong
            // 
            btnChamCong.BackColor = Color.DarkRed;
            btnChamCong.FlatAppearance.BorderSize = 0;
            btnChamCong.FlatStyle = FlatStyle.Flat;
            btnChamCong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamCong.ForeColor = Color.White;
            btnChamCong.Location = new Point(12, 216);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(186, 43);
            btnChamCong.TabIndex = 1;
            btnChamCong.Text = "CHẤM CÔNG";
            btnChamCong.UseVisualStyleBackColor = false;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.FromArgb(128, 64, 0);
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.ForeColor = Color.White;
            btnQuayLai.Location = new Point(12, 3);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(91, 31);
            btnQuayLai.TabIndex = 2;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenNhanVien.ForeColor = Color.FromArgb(64, 0, 0);
            lblTenNhanVien.Location = new Point(12, 170);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(48, 25);
            lblTenNhanVien.TabIndex = 3;
            lblTenNhanVien.Text = "TÊN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(btnQuayLai);
            panel1.Controls.Add(lblTenNhanVien);
            panel1.Controls.Add(btnChamCong);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 296);
            panel1.TabIndex = 4;
            // 
            // FormChamCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1197, 699);
            Controls.Add(panel1);
            Controls.Add(ctrLichLamViec);
            Name = "FormChamCong";
            Text = "FormChamCong";
            Load += FormChamCong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar ctrLichLamViec;
        private Button btnChamCong;
        private Button btnQuayLai;
        private Label lblTenNhanVien;
        private Panel panel1;
    }
}