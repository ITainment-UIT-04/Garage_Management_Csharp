namespace QLGROTO
{
    partial class CHITIETPNK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnkvtptdtgrid = new System.Windows.Forms.DataGridView();
            this.MaVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ngaynhapdtpicker = new System.Windows.Forms.DateTimePicker();
            this.mpntxtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnkvtptdtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            // 
            // pnkvtptdtgrid
            // 
            this.pnkvtptdtgrid.AllowUserToAddRows = false;
            this.pnkvtptdtgrid.AllowUserToDeleteRows = false;
            this.pnkvtptdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnkvtptdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pnkvtptdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pnkvtptdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVTPT,
            this.TenVTPT,
            this.SoLuong,
            this.GiaNhap});
            this.pnkvtptdtgrid.Location = new System.Drawing.Point(14, 132);
            this.pnkvtptdtgrid.Name = "pnkvtptdtgrid";
            this.pnkvtptdtgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.pnkvtptdtgrid.RowHeadersWidth = 51;
            this.pnkvtptdtgrid.RowTemplate.Height = 29;
            this.pnkvtptdtgrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pnkvtptdtgrid.Size = new System.Drawing.Size(1152, 468);
            this.pnkvtptdtgrid.TabIndex = 1;
            this.pnkvtptdtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pnkvtptdtgrid_CellContentClick);
            // 
            // MaVTPT
            // 
            this.MaVTPT.DataPropertyName = "MaVTPT";
            this.MaVTPT.HeaderText = "Mã VTPT";
            this.MaVTPT.MinimumWidth = 6;
            this.MaVTPT.Name = "MaVTPT";
            // 
            // TenVTPT
            // 
            this.TenVTPT.DataPropertyName = "TenVTPT";
            this.TenVTPT.HeaderText = "Tên VTPT";
            this.TenVTPT.MinimumWidth = 6;
            this.TenVTPT.Name = "TenVTPT";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Đơn giá nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1072, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(179, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày nhập:";
            // 
            // ngaynhapdtpicker
            // 
            this.ngaynhapdtpicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ngaynhapdtpicker.Enabled = false;
            this.ngaynhapdtpicker.Location = new System.Drawing.Point(726, 85);
            this.ngaynhapdtpicker.Name = "ngaynhapdtpicker";
            this.ngaynhapdtpicker.Size = new System.Drawing.Size(250, 27);
            this.ngaynhapdtpicker.TabIndex = 5;
            // 
            // mpntxtbox
            // 
            this.mpntxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mpntxtbox.Location = new System.Drawing.Point(332, 87);
            this.mpntxtbox.Name = "mpntxtbox";
            this.mpntxtbox.ReadOnly = true;
            this.mpntxtbox.Size = new System.Drawing.Size(220, 27);
            this.mpntxtbox.TabIndex = 6;
            // 
            // CHITIETPNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 656);
            this.Controls.Add(this.mpntxtbox);
            this.Controls.Add(this.ngaynhapdtpicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnkvtptdtgrid);
            this.Controls.Add(this.panel1);
            this.Name = "CHITIETPNK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phiếu nhập vật tư phụ tùng";
            this.Load += new System.EventHandler(this.CHITIETPNK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnkvtptdtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView pnkvtptdtgrid;
        private Button button2;
        private Label label2;
        private Label label3;
        private DateTimePicker ngaynhapdtpicker;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaNhap;
        private TextBox mpntxtbox;
    }
}