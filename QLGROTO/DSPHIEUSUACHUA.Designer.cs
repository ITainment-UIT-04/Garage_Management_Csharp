namespace QLGROTO
{
    partial class DSPHIEUSUACHUA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSPHIEUSUACHUA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VatTuPhuTung_Title = new System.Windows.Forms.Label();
            this.timkiembtn = new System.Windows.Forms.Button();
            this.mapscradio = new System.Windows.Forms.RadioButton();
            this.timkiemtxtbox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.xembtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.pscdtgrid = new System.Windows.Forms.DataGridView();
            this.MaPSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.timtheongayradio = new System.Windows.Forms.RadioButton();
            this.ngaydtpicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pscdtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.VatTuPhuTung_Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 67);
            this.panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            this.VatTuPhuTung_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VatTuPhuTung_Title.AutoSize = true;
            this.VatTuPhuTung_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VatTuPhuTung_Title.ForeColor = System.Drawing.Color.White;
            this.VatTuPhuTung_Title.Location = new System.Drawing.Point(349, 9);
            this.VatTuPhuTung_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            this.VatTuPhuTung_Title.Size = new System.Drawing.Size(502, 45);
            this.VatTuPhuTung_Title.TabIndex = 4;
            this.VatTuPhuTung_Title.Text = "DANH SÁCH PHIẾU SỬA CHỮA";
            // 
            // timkiembtn
            // 
            this.timkiembtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiembtn.BackColor = System.Drawing.SystemColors.Info;
            this.timkiembtn.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.timkiembtn.Location = new System.Drawing.Point(809, 71);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(79, 27);
            this.timkiembtn.TabIndex = 1;
            this.timkiembtn.UseVisualStyleBackColor = false;
            this.timkiembtn.Click += new System.EventHandler(this.timkiembtn_Click);
            // 
            // mapscradio
            // 
            this.mapscradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mapscradio.AutoSize = true;
            this.mapscradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mapscradio.Location = new System.Drawing.Point(408, 104);
            this.mapscradio.Name = "mapscradio";
            this.mapscradio.Size = new System.Drawing.Size(218, 24);
            this.mapscradio.TabIndex = 2;
            this.mapscradio.Text = "Tìm theo mã phiếu sửa chữa";
            this.mapscradio.UseVisualStyleBackColor = true;
            this.mapscradio.CheckedChanged += new System.EventHandler(this.mapscradio_CheckedChanged);
            // 
            // timkiemtxtbox
            // 
            this.timkiemtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiemtxtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.timkiemtxtbox.Location = new System.Drawing.Point(432, 71);
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
            this.SearchLabel.Location = new System.Drawing.Point(322, 70);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 28);
            this.SearchLabel.TabIndex = 26;
            this.SearchLabel.Text = "Tìm kiếm:";
            // 
            // xembtn
            // 
            this.xembtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xembtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xembtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xembtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xembtn.Image = global::QLGROTO.Properties.Resources.lens_1723832_640;
            this.xembtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xembtn.Location = new System.Drawing.Point(322, 593);
            this.xembtn.Name = "xembtn";
            this.xembtn.Size = new System.Drawing.Size(265, 65);
            this.xembtn.TabIndex = 2;
            this.xembtn.Text = "Xem chi tiết";
            this.xembtn.UseVisualStyleBackColor = false;
            this.xembtn.Click += new System.EventHandler(this.xembtn_Click);
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
            this.MaPSC,
            this.BienSo,
            this.NgaySuaChua,
            this.TongTien});
            this.pscdtgrid.Location = new System.Drawing.Point(12, 171);
            this.pscdtgrid.Name = "pscdtgrid";
            this.pscdtgrid.ReadOnly = true;
            this.pscdtgrid.RowHeadersWidth = 51;
            this.pscdtgrid.RowTemplate.Height = 29;
            this.pscdtgrid.Size = new System.Drawing.Size(1159, 416);
            this.pscdtgrid.TabIndex = 8;
            this.pscdtgrid.TabStop = false;
            // 
            // MaPSC
            // 
            this.MaPSC.DataPropertyName = "MaPSC";
            this.MaPSC.HeaderText = "Mã phiếu sửa chữa";
            this.MaPSC.MinimumWidth = 6;
            this.MaPSC.Name = "MaPSC";
            this.MaPSC.ReadOnly = true;
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSo";
            this.BienSo.HeaderText = "Biển số xe";
            this.BienSo.MinimumWidth = 6;
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // NgaySuaChua
            // 
            this.NgaySuaChua.DataPropertyName = "NgaySuaChua";
            this.NgaySuaChua.HeaderText = "Ngày sửa chữa";
            this.NgaySuaChua.MinimumWidth = 6;
            this.NgaySuaChua.Name = "NgaySuaChua";
            this.NgaySuaChua.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng thành tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // xuatbtn
            // 
            this.xuatbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xuatbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xuatbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xuatbtn.Image = global::QLGROTO.Properties.Resources.certificate_g32c53cd83_640__1_;
            this.xuatbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatbtn.Location = new System.Drawing.Point(623, 593);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(265, 65);
            this.xuatbtn.TabIndex = 3;
            this.xuatbtn.Text = "Xuất file danh sách";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // timtheongayradio
            // 
            this.timtheongayradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timtheongayradio.AutoSize = true;
            this.timtheongayradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timtheongayradio.Location = new System.Drawing.Point(632, 104);
            this.timtheongayradio.Name = "timtheongayradio";
            this.timtheongayradio.Size = new System.Drawing.Size(191, 24);
            this.timtheongayradio.TabIndex = 27;
            this.timtheongayradio.Text = "Tìm theo ngày lập phiếu";
            this.timtheongayradio.UseVisualStyleBackColor = true;
            this.timtheongayradio.CheckedChanged += new System.EventHandler(this.timtheongayradio_CheckedChanged);
            // 
            // ngaydtpicker
            // 
            this.ngaydtpicker.Location = new System.Drawing.Point(486, 134);
            this.ngaydtpicker.Name = "ngaydtpicker";
            this.ngaydtpicker.Size = new System.Drawing.Size(250, 27);
            this.ngaydtpicker.TabIndex = 28;
            // 
            // DSPHIEUSUACHUA
            // 
            this.AcceptButton = this.timkiembtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(1183, 670);
            this.Controls.Add(this.ngaydtpicker);
            this.Controls.Add(this.timtheongayradio);
            this.Controls.Add(this.xuatbtn);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.xembtn);
            this.Controls.Add(this.pscdtgrid);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.mapscradio);
            this.Controls.Add(this.timkiemtxtbox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DSPHIEUSUACHUA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu sửa chữa";
            this.Load += new System.EventHandler(this.DSPHIEUSUACHUA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pscdtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private Button timkiembtn;
        private RadioButton mapscradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private Button xembtn;
        private Button thoatbtn;
        private DataGridView pscdtgrid;
        private DataGridViewTextBoxColumn MaPSC;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn NgaySuaChua;
        private DataGridViewTextBoxColumn TongTien;
        private Button xuatbtn;
        private RadioButton timtheongayradio;
        private DateTimePicker ngaydtpicker;
    }
}