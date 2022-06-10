namespace QLGROTO
{
    partial class DSPHIEUTHUTIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSPHIEUTHUTIEN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VatTuPhuTung_Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dendtpicker = new System.Windows.Forms.DateTimePicker();
            this.tudtpicker = new System.Windows.Forms.DateTimePicker();
            this.timkiembtn = new System.Windows.Forms.Button();
            this.khoangngayradio = new System.Windows.Forms.RadioButton();
            this.mapttradio = new System.Windows.Forms.RadioButton();
            this.timkiemtxtbox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.pttdtgrid = new System.Windows.Forms.DataGridView();
            this.MaPTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pttdtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.VatTuPhuTung_Title);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 66);
            this.panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            this.VatTuPhuTung_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VatTuPhuTung_Title.AutoSize = true;
            this.VatTuPhuTung_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VatTuPhuTung_Title.ForeColor = System.Drawing.Color.White;
            this.VatTuPhuTung_Title.Location = new System.Drawing.Point(362, 11);
            this.VatTuPhuTung_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            this.VatTuPhuTung_Title.Size = new System.Drawing.Size(480, 45);
            this.VatTuPhuTung_Title.TabIndex = 5;
            this.VatTuPhuTung_Title.Text = "DANH SÁCH PHIẾU THU TIỀN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(597, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 33;
            this.label2.Text = "Đến:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Từ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dendtpicker
            // 
            this.dendtpicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dendtpicker.Location = new System.Drawing.Point(663, 131);
            this.dendtpicker.Name = "dendtpicker";
            this.dendtpicker.Size = new System.Drawing.Size(250, 27);
            this.dendtpicker.TabIndex = 4;
            this.dendtpicker.TabStop = false;
            this.dendtpicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tudtpicker
            // 
            this.tudtpicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tudtpicker.Location = new System.Drawing.Point(325, 131);
            this.tudtpicker.Name = "tudtpicker";
            this.tudtpicker.Size = new System.Drawing.Size(250, 27);
            this.tudtpicker.TabIndex = 3;
            this.tudtpicker.TabStop = false;
            this.tudtpicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timkiembtn
            // 
            this.timkiembtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiembtn.BackColor = System.Drawing.SystemColors.Info;
            this.timkiembtn.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.timkiembtn.Location = new System.Drawing.Point(795, 68);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(79, 27);
            this.timkiembtn.TabIndex = 1;
            this.timkiembtn.UseVisualStyleBackColor = false;
            this.timkiembtn.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // khoangngayradio
            // 
            this.khoangngayradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.khoangngayradio.AutoSize = true;
            this.khoangngayradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.khoangngayradio.Location = new System.Drawing.Point(611, 101);
            this.khoangngayradio.Name = "khoangngayradio";
            this.khoangngayradio.Size = new System.Drawing.Size(178, 24);
            this.khoangngayradio.TabIndex = 28;
            this.khoangngayradio.Text = "Tìm theo khoảng ngày";
            this.khoangngayradio.UseVisualStyleBackColor = true;
            this.khoangngayradio.CheckedChanged += new System.EventHandler(this.khoangngayradio_CheckedChanged);
            // 
            // mapttradio
            // 
            this.mapttradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mapttradio.AutoSize = true;
            this.mapttradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mapttradio.Location = new System.Drawing.Point(396, 101);
            this.mapttradio.Name = "mapttradio";
            this.mapttradio.Size = new System.Drawing.Size(209, 24);
            this.mapttradio.TabIndex = 2;
            this.mapttradio.Text = "Tìm theo mã phiếu thu tiền";
            this.mapttradio.UseVisualStyleBackColor = true;
            this.mapttradio.CheckedChanged += new System.EventHandler(this.mapnradio_CheckedChanged);
            // 
            // timkiemtxtbox
            // 
            this.timkiemtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiemtxtbox.Location = new System.Drawing.Point(418, 68);
            this.timkiemtxtbox.Name = "timkiemtxtbox";
            this.timkiemtxtbox.Size = new System.Drawing.Size(371, 27);
            this.timkiemtxtbox.TabIndex = 0;
            this.timkiemtxtbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchLabel.Location = new System.Drawing.Point(308, 67);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 28);
            this.SearchLabel.TabIndex = 26;
            this.SearchLabel.Text = "Tìm kiếm:";
            this.SearchLabel.Click += new System.EventHandler(this.SearchLabel_Click);
            // 
            // pttdtgrid
            // 
            this.pttdtgrid.AllowUserToAddRows = false;
            this.pttdtgrid.AllowUserToDeleteRows = false;
            this.pttdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pttdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pttdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pttdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPTT,
            this.NgayThuTien,
            this.BienSo,
            this.SoTienThu});
            this.pttdtgrid.Location = new System.Drawing.Point(12, 164);
            this.pttdtgrid.Name = "pttdtgrid";
            this.pttdtgrid.ReadOnly = true;
            this.pttdtgrid.RowHeadersWidth = 51;
            this.pttdtgrid.RowTemplate.Height = 29;
            this.pttdtgrid.Size = new System.Drawing.Size(1159, 423);
            this.pttdtgrid.TabIndex = 6;
            this.pttdtgrid.TabStop = false;
            this.pttdtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pttdtgrid_CellContentClick);
            // 
            // MaPTT
            // 
            this.MaPTT.DataPropertyName = "MaPTT";
            this.MaPTT.HeaderText = "Mã phiếu thu tiền";
            this.MaPTT.MinimumWidth = 6;
            this.MaPTT.Name = "MaPTT";
            this.MaPTT.ReadOnly = true;
            // 
            // NgayThuTien
            // 
            this.NgayThuTien.DataPropertyName = "NgayThuTien";
            this.NgayThuTien.HeaderText = "Ngày thu tiền";
            this.NgayThuTien.MinimumWidth = 6;
            this.NgayThuTien.Name = "NgayThuTien";
            this.NgayThuTien.ReadOnly = true;
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSo";
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.MinimumWidth = 6;
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // SoTienThu
            // 
            this.SoTienThu.DataPropertyName = "SoTienThu";
            this.SoTienThu.HeaderText = "Tiền thu";
            this.SoTienThu.MinimumWidth = 6;
            this.SoTienThu.Name = "SoTienThu";
            this.SoTienThu.ReadOnly = true;
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
            this.xuatbtn.Location = new System.Drawing.Point(437, 593);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(265, 65);
            this.xuatbtn.TabIndex = 3;
            this.xuatbtn.Text = "Xuất file danh sách";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // DSPHIEUTHUTIEN
            // 
            this.AcceptButton = this.timkiembtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(1183, 670);
            this.Controls.Add(this.xuatbtn);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.pttdtgrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dendtpicker);
            this.Controls.Add(this.tudtpicker);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.khoangngayradio);
            this.Controls.Add(this.mapttradio);
            this.Controls.Add(this.timkiemtxtbox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DSPHIEUTHUTIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu thu tiền";
            this.Load += new System.EventHandler(this.DSPHIEUTHUTIEN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pttdtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private Label label2;
        private Label label1;
        private DateTimePicker dendtpicker;
        private DateTimePicker tudtpicker;
        private Button timkiembtn;
        private RadioButton khoangngayradio;
        private RadioButton mapttradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private DataGridView pttdtgrid;
        private Button thoatbtn;
        private DataGridViewTextBoxColumn MaPTT;
        private DataGridViewTextBoxColumn NgayThuTien;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn SoTienThu;
        private Button xuatbtn;
    }
}