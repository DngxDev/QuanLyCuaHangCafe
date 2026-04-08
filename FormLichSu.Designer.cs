namespace BaiTap
{
    partial class FormLichSu
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
            dgvLichSu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // dgvLichSu
            // 
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Location = new Point(2, 1);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.RowHeadersWidth = 51;
            dgvLichSu.Size = new Size(788, 448);
            dgvLichSu.TabIndex = 0;
            dgvLichSu.CellContentClick += dgvLichSu_CellContentClick;
            // 
            // FormLichSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 451);
            Controls.Add(dgvLichSu);
            Name = "FormLichSu";
            Text = "Quản lý Cafe";
            WindowState = FormWindowState.Maximized;
            Load += FormLichSu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLichSu;
    }
}