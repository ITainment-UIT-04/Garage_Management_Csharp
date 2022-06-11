namespace QLGROTO
{
    partial class DSPNKVTPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSPNKVTPT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VatTuPhuTung_Title = new System.Windows.Forms.Label();
            this.phieunhapvtptdtgrid = new System.Windows.Forms.DataGridView();
            this.MaNKVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timkiembtn = new System.Windows.Forms.Button();
            this.timtheomaradio = new System.Windows.Forms.RadioButton();
            this.timkiemtxtbox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.xemctbtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.ngaydtpicker = new System.Windows.Forms.DateTimePicker();
            this.timngayradio = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapvtptdtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.VatTuPhuTung_Title);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 69);
            this.panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            this.VatTuPhuTung_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VatTuPhuTung_Title.AutoSize = true;
            this.VatTuPhuTung_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VatTuPhuTung_Title.ForeColor = System.Drawing.Color.White;
            this.VatTuPhuTung_Title.Location = new System.Drawing.Point(196, 11);
            this.VatTuPhuTung_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            this.VatTuPhuTung_Title.Size = new System.Drawing.Size(810, 45);
            this.VatTuPhuTung_Title.TabIndex = 4;
            this.VatTuPhuTung_Title.Text = "DANH SÁCH PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            // 
            // phieunhapvtptdtgrid
            // 
            this.phieunhapvtptdtgrid.AllowUserToAddRows = false;
            this.phieunhapvtptdtgrid.AllowUserToDeleteRows = false;
            this.phieunhapvtptdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phieunhapvtptdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phieunhapvtptdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieunhapvtptdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNKVTPT,
            this.NgayNhap});
            this.phieunhapvtptdtgrid.Location = new System.Drawing.Point(12, 164);
            this.phieunhapvtptdtgrid.Name = "phieunhapvtptdtgrid";
            this.phieunhapvtptdtgrid.ReadOnly = true;
            this.phieunhapvtptdtgrid.RowHeadersWidth = 51;
            this.phieunhapvtptdtgrid.RowTemplate.Height = 29;
            this.phieunhapvtptdtgrid.Size = new System.Drawing.Size(1159, 423);
            this.phieunhapvtptdtgrid.TabIndex = 6;
            this.phieunhapvtptdtgrid.TabStop = false;
            this.phieunhapvtptdtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaNKVTPT
            // 
            this.MaNKVTPT.DataPropertyName = "MaNKVTPT";
            this.MaNKVTPT.HeaderText = "Số phiếu nhập";
            this.MaNKVTPT.MinimumWidth = 6;
            this.MaNKVTPT.Name = "MaNKVTPT";
            this.MaNKVTPT.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // timkiembtn
            // 
            this.timkiembtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiembtn.BackColor = System.Drawing.SystemColors.Info;
            this.timkiembtn.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.timkiembtn.Location = new System.Drawing.Point(803, 71);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(79, 27);
            this.timkiembtn.TabIndex = 1;
            this.timkiembtn.UseVisualStyleBackColor = false;
            this.timkiembtn.Click += new System.EventHandler(this.timkiembtn_Click);
            // 
            // timtheomaradio
            // 
            this.timtheomaradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timtheomaradio.AutoSize = true;
            this.timtheomaradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timtheomaradio.Location = new System.Drawing.Point(406, 101);
            this.timtheomaradio.Name = "timtheomaradio";
            this.timtheomaradio.Size = new System.Drawing.Size(192, 24);
            this.timtheomaradio.TabIndex = 2;
            this.timtheomaradio.Text = "Tìm theo mã phiếu nhập";
            this.timtheomaradio.UseVisualStyleBackColor = true;
            this.timtheomaradio.CheckedChanged += new System.EventHandler(this.timtheomaradio_CheckedChanged_1);
            // 
            // timkiemtxtbox
            // 
            this.timkiemtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiemtxtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.timkiemtxtbox.Location = new System.Drawing.Point(426, 71);
            this.timkiemtxtbox.Name = "timkiemtxtbox";
            this.timkiemtxtbox.Size = new System.Drawing.Size(371, 27);
            this.timkiemtxtbox.TabIndex = 0;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchLabel.Location = new System.Drawing.Point(316, 70);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 28);
            this.SearchLabel.TabIndex = 19;
            this.SearchLabel.Text = "Tìm kiếm:";
            // 
            // xemctbtn
            // 
            this.xemctbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xemctbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xemctbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xemctbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xemctbtn.Image = global::QLGROTO.Properties.Resources.lens_1723832_640;
            this.xemctbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xemctbtn.Location = new System.Drawing.Point(333, 593);
            this.xemctbtn.Name = "xemctbtn";
            this.xemctbtn.Size = new System.Drawing.Size(265, 65);
            this.xemctbtn.TabIndex = 2;
            this.xemctbtn.Text = "Xem chi tiết";
            this.xemctbtn.UseVisualStyleBackColor = false;
            this.xemctbtn.Click += new System.EventHandler(this.xemctbtn_Click);
            // 
            // thoatbtn
            // 
            this.thoatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatbtn.Location = new System.Drawing.Point(1077, 629);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 4;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // xuatbtn
            // 
            this.xuatbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xuatbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xuatbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xuatbtn.Image = global::QLGROTO.Properties.Resources.certificate_g32c53cd83_640__1_;
            this.xuatbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatbtn.Location = new System.Drawing.Point(636, 593);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(265, 65);
            this.xuatbtn.TabIndex = 3;
            this.xuatbtn.Text = "Xuất file danh sách";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // ngaydtpicker
            // 
            this.ngaydtpicker.Location = new System.Drawing.Point(477, 131);
            this.ngaydtpicker.Name = "ngaydtpicker";
            this.ngaydtpicker.Size = new System.Drawing.Size(250, 27);
            this.ngaydtpicker.TabIndex = 29;
            // 
            // timngayradio
            // 
            this.timngayradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timngayradio.AutoSize = true;
            this.timngayradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timngayradio.Location = new System.Drawing.Point(604, 101);
            this.timngayradio.Name = "timngayradio";
            this.timngayradio.Size = new System.Drawing.Size(191, 24);
            this.timngayradio.TabIndex = 30;
            this.timngayradio.Text = "Tìm theo ngày lập phiếu";
            this.timngayradio.UseVisualStyleBackColor = true;
            this.timngayradio.CheckedChanged += new System.EventHandler(this.timngayradio_CheckedChanged);
            // 
            // DSPNKVTPT
            // 
            this.AcceptButton = this.timkiembtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(1183, 670);
            this.Controls.Add(this.timngayradio);
            this.Controls.Add(this.ngaydtpicker);
            this.Controls.Add(this.xuatbtn);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.xemctbtn);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.timtheomaradio);
            this.Controls.Add(this.timkiemtxtbox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.phieunhapvtptdtgrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DSPNKVTPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu nhập kho vật tư phụ tùng";
            this.Load += new System.EventHandler(this.DSPNKVTPT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapvtptdtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private DataGridView phieunhapvtptdtgrid;
        private Button timkiembtn;
        private RadioButton timtheomaradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private Button xemctbtn;
        private Button thoatbtn;
        private DataGridViewTextBoxColumn MaNKVTPT;
        private DataGridViewTextBoxColumn NgayNhap;
        private Button xuatbtn;
        private DateTimePicker ngaydtpicker;
        private RadioButton timngayradio;
    }
}