namespace BaiTap
{
    partial class FormQuanLy
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
            dgvThucDon = new DataGridView();
            txtTenMon = new TextBox();
            txtGiaTien = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).BeginInit();
            SuspendLayout();
            // 
            // dgvThucDon
            // 
            dgvThucDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThucDon.Location = new Point(232, 0);
            dgvThucDon.Name = "dgvThucDon";
            dgvThucDon.RowHeadersWidth = 51;
            dgvThucDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThucDon.Size = new Size(505, 451);
            dgvThucDon.TabIndex = 0;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(80, 0);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(125, 27);
            txtTenMon.TabIndex = 1;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(80, 49);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(125, 27);
            txtGiaTien.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(94, 82);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm món";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(94, 117);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa món";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "Giá tiền";
            // 
            // FormQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtGiaTien);
            Controls.Add(txtTenMon);
            Controls.Add(dgvThucDon);
            Name = "FormQuanLy";
            Text = "Quản lý Cafe";
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThucDon;
        private TextBox txtTenMon;
        private TextBox txtGiaTien;
        private Button btnThem;
        private Button btnXoa;
        private Label label1;
        private Label label2;
    }
}