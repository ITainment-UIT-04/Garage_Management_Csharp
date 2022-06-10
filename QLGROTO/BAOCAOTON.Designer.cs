namespace QLGROTO
{
    partial class BAOCAOTON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAOCAOTON));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Group1 = new System.Windows.Forms.GroupBox();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.namnumeric = new System.Windows.Forms.NumericUpDown();
            this.thangnumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.themtiencong_btn = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.bctdtgrid = new System.Windows.Forms.DataGridView();
            this.MaVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportDoanhSo_Title = new System.Windows.Forms.Label();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.Group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangnumeric)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bctdtgrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Group1
            // 
            this.Group1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Group1.Controls.Add(this.xuatbtn);
            this.Group1.Controls.Add(this.namnumeric);
            this.Group1.Controls.Add(this.thangnumeric);
            this.Group1.Controls.Add(this.label2);
            this.Group1.Controls.Add(this.label1);
            this.Group1.Controls.Add(this.themtiencong_btn);
            this.Group1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Group1.Location = new System.Drawing.Point(13, 74);
            this.Group1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Group1.Name = "Group1";
            this.Group1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Group1.Size = new System.Drawing.Size(1081, 99);
            this.Group1.TabIndex = 4;
            this.Group1.TabStop = false;
            this.Group1.Text = "Báo cáo tháng, năm";
            // 
            // xuatbtn
            // 
            this.xuatbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xuatbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xuatbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xuatbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xuatbtn.Image = global::QLGROTO.Properties.Resources.certificate_g32c53cd83_640__1_;
            this.xuatbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatbtn.Location = new System.Drawing.Point(809, 26);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(265, 65);
            this.xuatbtn.TabIndex = 8;
            this.xuatbtn.Text = "Xuất báo cáo";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // namnumeric
            // 
            this.namnumeric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namnumeric.Location = new System.Drawing.Point(359, 47);
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
            this.namnumeric.TabIndex = 61;
            this.namnumeric.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // thangnumeric
            // 
            this.thangnumeric.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thangnumeric.Location = new System.Drawing.Point(117, 47);
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
            this.thangnumeric.TabIndex = 60;
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
            this.label2.Location = new System.Drawing.Point(295, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 59;
            this.label2.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 58;
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
            this.themtiencong_btn.Location = new System.Drawing.Point(538, 26);
            this.themtiencong_btn.Name = "themtiencong_btn";
            this.themtiencong_btn.Size = new System.Drawing.Size(265, 65);
            this.themtiencong_btn.TabIndex = 38;
            this.themtiencong_btn.Text = "Hiện báo cáo";
            this.themtiencong_btn.UseVisualStyleBackColor = false;
            this.themtiencong_btn.Click += new System.EventHandler(this.themtiencong_btn_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.bctdtgrid);
            this.GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBox2.Location = new System.Drawing.Point(13, 183);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(1081, 458);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Chi tiết báo cáo";
            // 
            // bctdtgrid
            // 
            this.bctdtgrid.AllowUserToAddRows = false;
            this.bctdtgrid.AllowUserToDeleteRows = false;
            this.bctdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bctdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bctdtgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bctdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bctdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVTPT,
            this.TenVTPT,
            this.TonDau,
            this.PhatSinh,
            this.SuDung,
            this.TonCuoi});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bctdtgrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.bctdtgrid.Location = new System.Drawing.Point(8, 28);
            this.bctdtgrid.Name = "bctdtgrid";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bctdtgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.bctdtgrid.RowHeadersWidth = 51;
            this.bctdtgrid.RowTemplate.Height = 29;
            this.bctdtgrid.Size = new System.Drawing.Size(1066, 421);
            this.bctdtgrid.TabIndex = 1;
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
            // TonDau
            // 
            this.TonDau.DataPropertyName = "TonDau";
            this.TonDau.HeaderText = "Tồn đầu";
            this.TonDau.MinimumWidth = 6;
            this.TonDau.Name = "TonDau";
            // 
            // PhatSinh
            // 
            this.PhatSinh.DataPropertyName = "PHATSINH";
            this.PhatSinh.HeaderText = "Phát sinh";
            this.PhatSinh.MinimumWidth = 6;
            this.PhatSinh.Name = "PhatSinh";
            // 
            // SuDung
            // 
            this.SuDung.DataPropertyName = "SUDUNG";
            this.SuDung.HeaderText = "Sử dụng";
            this.SuDung.MinimumWidth = 6;
            this.SuDung.Name = "SuDung";
            // 
            // TonCuoi
            // 
            this.TonCuoi.DataPropertyName = "TonCuoi";
            this.TonCuoi.HeaderText = "Tồn cuối";
            this.TonCuoi.MinimumWidth = 6;
            this.TonCuoi.Name = "TonCuoi";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.ReportDoanhSo_Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 66);
            this.panel1.TabIndex = 6;
            // 
            // ReportDoanhSo_Title
            // 
            this.ReportDoanhSo_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportDoanhSo_Title.AutoSize = true;
            this.ReportDoanhSo_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReportDoanhSo_Title.ForeColor = System.Drawing.Color.White;
            this.ReportDoanhSo_Title.Location = new System.Drawing.Point(378, 9);
            this.ReportDoanhSo_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportDoanhSo_Title.Name = "ReportDoanhSo_Title";
            this.ReportDoanhSo_Title.Size = new System.Drawing.Size(326, 45);
            this.ReportDoanhSo_Title.TabIndex = 3;
            this.ReportDoanhSo_Title.Text = "BÁO CÁO TỒN KHO";
            // 
            // thoatbtn
            // 
            this.thoatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatbtn.Location = new System.Drawing.Point(1000, 649);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 7;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // BAOCAOTON
            // 
            this.AcceptButton = this.thoatbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(1107, 690);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Group1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BAOCAOTON";
            this.Text = "Báo cáo tồn kho";
            this.Group1.ResumeLayout(false);
            this.Group1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangnumeric)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bctdtgrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Group1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private Panel panel1;
        private Label ReportDoanhSo_Title;
        private Button themtiencong_btn;
        private Button thoatbtn;
        private DataGridView bctdtgrid;
        private NumericUpDown namnumeric;
        private NumericUpDown thangnumeric;
        private Label label2;
        private Label label1;
        private Button xuatbtn;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn TonDau;
        private DataGridViewTextBoxColumn PhatSinh;
        private DataGridViewTextBoxColumn SuDung;
        private DataGridViewTextBoxColumn TonCuoi;
    }
}