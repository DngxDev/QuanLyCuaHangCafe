namespace BaiTap
{
    partial class FormDangKyCa
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ctrLichDangKy = new MonthCalendar();
            cmbCaLam = new MaterialSkin.Controls.MaterialComboBox();
            btnXacNhanDK = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(ctrLichDangKy);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(418, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(569, 439);
            materialCard1.TabIndex = 0;
            // 
            // ctrLichDangKy
            // 
            ctrLichDangKy.CalendarDimensions = new Size(2, 2);
            ctrLichDangKy.Dock = DockStyle.Fill;
            ctrLichDangKy.Location = new Point(14, 14);
            ctrLichDangKy.MaxSelectionCount = 1;
            ctrLichDangKy.Name = "ctrLichDangKy";
            ctrLichDangKy.TabIndex = 1;
            // 
            // cmbCaLam
            // 
            cmbCaLam.AutoResize = false;
            cmbCaLam.BackColor = Color.FromArgb(255, 255, 255);
            cmbCaLam.Depth = 0;
            cmbCaLam.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCaLam.DropDownHeight = 174;
            cmbCaLam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaLam.DropDownWidth = 121;
            cmbCaLam.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCaLam.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCaLam.FormattingEnabled = true;
            cmbCaLam.IntegralHeight = false;
            cmbCaLam.ItemHeight = 43;
            cmbCaLam.Items.AddRange(new object[] { "Ca Sáng (6h-14h)", "Ca Chiều (14h-22h)", "Ca Tối (18h-22h)" });
            cmbCaLam.Location = new Point(169, 179);
            cmbCaLam.MaxDropDownItems = 4;
            cmbCaLam.MouseState = MaterialSkin.MouseState.OUT;
            cmbCaLam.Name = "cmbCaLam";
            cmbCaLam.Size = new Size(151, 49);
            cmbCaLam.StartIndex = 0;
            cmbCaLam.TabIndex = 1;
            // 
            // btnXacNhanDK
            // 
            btnXacNhanDK.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXacNhanDK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnXacNhanDK.Depth = 0;
            btnXacNhanDK.HighEmphasis = true;
            btnXacNhanDK.Icon = null;
            btnXacNhanDK.Location = new Point(169, 262);
            btnXacNhanDK.Margin = new Padding(4, 6, 4, 6);
            btnXacNhanDK.MouseState = MaterialSkin.MouseState.HOVER;
            btnXacNhanDK.Name = "btnXacNhanDK";
            btnXacNhanDK.NoAccentTextColor = Color.Empty;
            btnXacNhanDK.Size = new Size(95, 36);
            btnXacNhanDK.TabIndex = 2;
            btnXacNhanDK.Text = "XÁC NHẬN";
            btnXacNhanDK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnXacNhanDK.UseAccentColor = false;
            btnXacNhanDK.UseVisualStyleBackColor = true;
            btnXacNhanDK.Click += btnXacNhanDK_Click;
            // 
            // FormDangKyCa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 657);
            Controls.Add(btnXacNhanDK);
            Controls.Add(cmbCaLam);
            Controls.Add(materialCard1);
            Name = "FormDangKyCa";
            Text = "Đăng ký ca";
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MonthCalendar ctrLichDangKy;
        private MaterialSkin.Controls.MaterialComboBox cmbCaLam;
        private MaterialSkin.Controls.MaterialButton btnXacNhanDK;
    }
}