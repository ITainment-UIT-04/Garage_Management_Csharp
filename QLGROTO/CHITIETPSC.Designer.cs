namespace QLGROTO
{
    partial class CHITIETPSC
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
            this.ngaydtpicker = new System.Windows.Forms.DateTimePicker();
            this.biensotxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ttttxtbox = new System.Windows.Forms.TextBox();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.pscdtgrid = new System.Windows.Forms.DataGridView();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.masctxtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pscdtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ngaydtpicker
            // 
            this.ngaydtpicker.Enabled = false;
            this.ngaydtpicker.Location = new System.Drawing.Point(991, 80);
            this.ngaydtpicker.Name = "ngaydtpicker";
            this.ngaydtpicker.Size = new System.Drawing.Size(250, 27);
            this.ngaydtpicker.TabIndex = 9;
            // 
            // biensotxtbox
            // 
            this.biensotxtbox.Enabled = false;
            this.biensotxtbox.Location = new System.Drawing.Point(599, 82);
            this.biensotxtbox.Name = "biensotxtbox";
            this.biensotxtbox.Size = new System.Drawing.Size(220, 27);
            this.biensotxtbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(840, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sửa chữa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(491, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Biển số xe:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(526, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "PHIẾU SỬA CHỮA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 63);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(491, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng thành tiền:";
            // 
            // ttttxtbox
            // 
            this.ttttxtbox.Enabled = false;
            this.ttttxtbox.Location = new System.Drawing.Point(651, 550);
            this.ttttxtbox.Name = "ttttxtbox";
            this.ttttxtbox.ReadOnly = true;
            this.ttttxtbox.ShortcutsEnabled = false;
            this.ttttxtbox.Size = new System.Drawing.Size(220, 27);
            this.ttttxtbox.TabIndex = 8;
            // 
            // thoatbtn
            // 
            this.thoatbtn.Location = new System.Drawing.Point(1241, 553);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 13;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.thoatbtn_Click);
            // 
            // pscdtgrid
            // 
            this.pscdtgrid.AllowUserToAddRows = false;
            this.pscdtgrid.AllowUserToDeleteRows = false;
            this.pscdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pscdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pscdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pscdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoiDung,
            this.MaVTPT,
            this.TenVTPT,
            this.SoLuong,
            this.DonGia,
            this.TienCong,
            this.ThanhTien});
            this.pscdtgrid.Location = new System.Drawing.Point(12, 135);
            this.pscdtgrid.Name = "pscdtgrid";
            this.pscdtgrid.RowHeadersWidth = 51;
            this.pscdtgrid.RowTemplate.Height = 29;
            this.pscdtgrid.Size = new System.Drawing.Size(1323, 409);
            this.pscdtgrid.TabIndex = 18;
            this.pscdtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pscdtgrid_CellContentClick);
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
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
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // TienCong
            // 
            this.TienCong.DataPropertyName = "TienCong";
            this.TienCong.HeaderText = "Tiền công";
            this.TienCong.MinimumWidth = 6;
            this.TienCong.Name = "TienCong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(55, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã phiếu sửa chữa:";
            // 
            // masctxtbox
            // 
            this.masctxtbox.Enabled = false;
            this.masctxtbox.Location = new System.Drawing.Point(241, 82);
            this.masctxtbox.Name = "masctxtbox";
            this.masctxtbox.Size = new System.Drawing.Size(220, 27);
            this.masctxtbox.TabIndex = 8;
            // 
            // CHITIETPSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1347, 594);
            this.Controls.Add(this.pscdtgrid);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ngaydtpicker);
            this.Controls.Add(this.ttttxtbox);
            this.Controls.Add(this.masctxtbox);
            this.Controls.Add(this.biensotxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "CHITIETPSC";
            this.ShowIcon = false;
            this.Text = "Chi tiết phiếu sửa chữa";
            this.Load += new System.EventHandler(this.CHITIETPSC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pscdtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker ngaydtpicker;
        private TextBox biensotxtbox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox ttttxtbox;
        private Button thoatbtn;
        private DataGridView pscdtgrid;
        private Label label5;
        private TextBox masctxtbox;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TienCong;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}