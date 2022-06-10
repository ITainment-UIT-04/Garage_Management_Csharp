namespace QLGROTO
{
    partial class BAOCAODOANHSO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAOCAODOANHSO));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportDoanhSo_Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.namnumeric = new System.Windows.Forms.NumericUpDown();
            this.thangnumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.themtiencong_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bcdsdtgrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.ttttxtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangnumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcdsdtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.ReportDoanhSo_Title);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 66);
            this.panel1.TabIndex = 0;
            // 
            // ReportDoanhSo_Title
            // 
            this.ReportDoanhSo_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportDoanhSo_Title.AutoSize = true;
            this.ReportDoanhSo_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReportDoanhSo_Title.ForeColor = System.Drawing.Color.White;
            this.ReportDoanhSo_Title.Location = new System.Drawing.Point(339, 10);
            this.ReportDoanhSo_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportDoanhSo_Title.Name = "ReportDoanhSo_Title";
            this.ReportDoanhSo_Title.Size = new System.Drawing.Size(477, 45);
            this.ReportDoanhSo_Title.TabIndex = 4;
            this.ReportDoanhSo_Title.Text = "BÁO CÁO DOANH SỐ THÁNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.xuatbtn);
            this.groupBox1.Controls.Add(this.namnumeric);
            this.groupBox1.Controls.Add(this.thangnumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.themtiencong_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo tháng, năm";
            // 
            // xuatbtn
            // 
            this.xuatbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xuatbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xuatbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xuatbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xuatbtn.Image = global::QLGROTO.Properties.Resources.certificate_g32c53cd83_640__1_;
            this.xuatbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatbtn.Location = new System.Drawing.Point(810, 26);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(265, 65);
            this.xuatbtn.TabIndex = 58;
            this.xuatbtn.Text = "Xuất báo cáo";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // namnumeric
            // 
            this.namnumeric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namnumeric.Location = new System.Drawing.Point(362, 47);
            this.namnumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namnumeric.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.namnumeric.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.namnumeric.Name = "namnumeric";
            this.namnumeric.Size = new System.Drawing.Size(137, 29);
            this.namnumeric.TabIndex = 57;
            this.namnumeric.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // thangnumeric
            // 
            this.thangnumeric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thangnumeric.Location = new System.Drawing.Point(120, 47);
            this.thangnumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thangnumeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.thangnumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thangnumeric.Name = "thangnumeric";
            this.thangnumeric.Size = new System.Drawing.Size(137, 29);
            this.thangnumeric.TabIndex = 56;
            this.thangnumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(298, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tháng:";
            // 
            // themtiencong_btn
            // 
            this.themtiencong_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.themtiencong_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.themtiencong_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.themtiencong_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.themtiencong_btn.Image = ((System.Drawing.Image)(resources.GetObject("themtiencong_btn.Image")));
            this.themtiencong_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themtiencong_btn.Location = new System.Drawing.Point(539, 26);
            this.themtiencong_btn.Name = "themtiencong_btn";
            this.themtiencong_btn.Size = new System.Drawing.Size(265, 65);
            this.themtiencong_btn.TabIndex = 41;
            this.themtiencong_btn.Text = "Hiện báo cáo";
            this.themtiencong_btn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bcdsdtgrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1081, 467);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết báo cáo";
            // 
            // bcdsdtgrid
            // 
            this.bcdsdtgrid.AllowUserToAddRows = false;
            this.bcdsdtgrid.AllowUserToDeleteRows = false;
            this.bcdsdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bcdsdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bcdsdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcdsdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HieuXe,
            this.Column1,
            this.ThanhTien,
            this.TiLe});
            this.bcdsdtgrid.Location = new System.Drawing.Point(8, 26);
            this.bcdsdtgrid.Name = "bcdsdtgrid";
            this.bcdsdtgrid.ReadOnly = true;
            this.bcdsdtgrid.RowHeadersWidth = 51;
            this.bcdsdtgrid.RowTemplate.Height = 29;
            this.bcdsdtgrid.Size = new System.Drawing.Size(1067, 435);
            this.bcdsdtgrid.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1001, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ttttxtbox
            // 
            this.ttttxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ttttxtbox.Enabled = false;
            this.ttttxtbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ttttxtbox.Location = new System.Drawing.Point(432, 650);
            this.ttttxtbox.Name = "ttttxtbox";
            this.ttttxtbox.Size = new System.Drawing.Size(397, 27);
            this.ttttxtbox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(272, 646);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 28);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tổng thành tiền:";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(755, 650);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(9, 8);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // HieuXe
            // 
            this.HieuXe.DataPropertyName = "HieuXe";
            this.HieuXe.HeaderText = "Hiệu xe";
            this.HieuXe.MinimumWidth = 6;
            this.HieuXe.Name = "HieuXe";
            this.HieuXe.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số lượt sửa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // TiLe
            // 
            this.TiLe.DataPropertyName = "TiLe";
            this.TiLe.HeaderText = "Tỉ lệ";
            this.TiLe.MinimumWidth = 6;
            this.TiLe.Name = "TiLe";
            this.TiLe.ReadOnly = true;
            // 
            // BAOCAODOANHSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 690);
            this.Controls.Add(this.ttttxtbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BAOCAODOANHSO";
            this.Text = "Báo cáo doanh số tháng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangnumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bcdsdtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label ReportDoanhSo_Title;
        private GroupBox groupBox1;
        private Button themtiencong_btn;
        private GroupBox groupBox2;
        private Button button2;
        private NumericUpDown namnumeric;
        private NumericUpDown thangnumeric;
        private Label label2;
        private Label label1;
        private DataGridView bcdsdtgrid;
        private Button xuatbtn;
        private TextBox ttttxtbox;
        private Label label11;
        private Button button4;
        private DataGridViewTextBoxColumn HieuXe;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn TiLe;
    }
}