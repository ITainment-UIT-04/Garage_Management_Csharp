namespace QLGROTO
{
    partial class DSVTPT
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
            this.VatTuPhuTung_Title = new System.Windows.Forms.Label();
            this.theotenradio = new System.Windows.Forms.RadioButton();
            this.theomaradio = new System.Windows.Forms.RadioButton();
            this.timkiemtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptdtgrid = new System.Windows.Forms.DataGridView();
            this.MaVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoavtptbtn = new System.Windows.Forms.Button();
            this.suavtptbtn = new System.Windows.Forms.Button();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sltxtbox = new System.Windows.Forms.TextBox();
            this.tenvtpttxtbox = new System.Windows.Forms.TextBox();
            this.mavtpttxtbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgtxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timkiembtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptdtgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.VatTuPhuTung_Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 51);
            this.panel1.TabIndex = 1;
            // 
            // VatTuPhuTung_Title
            // 
            this.VatTuPhuTung_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VatTuPhuTung_Title.AutoSize = true;
            this.VatTuPhuTung_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VatTuPhuTung_Title.ForeColor = System.Drawing.Color.White;
            this.VatTuPhuTung_Title.Location = new System.Drawing.Point(274, 7);
            this.VatTuPhuTung_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            this.VatTuPhuTung_Title.Size = new System.Drawing.Size(429, 37);
            this.VatTuPhuTung_Title.TabIndex = 2;
            this.VatTuPhuTung_Title.Text = "DANH SÁCH VẬT TƯ PHỤ TÙNG";
            // 
            // theotenradio
            // 
            this.theotenradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.theotenradio.AutoSize = true;
            this.theotenradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.theotenradio.Location = new System.Drawing.Point(509, 93);
            this.theotenradio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.theotenradio.Name = "theotenradio";
            this.theotenradio.Size = new System.Drawing.Size(121, 19);
            this.theotenradio.TabIndex = 10;
            this.theotenradio.TabStop = true;
            this.theotenradio.Text = "Tìm theo tên VTPT";
            this.theotenradio.UseVisualStyleBackColor = true;
            this.theotenradio.CheckedChanged += new System.EventHandler(this.theotenradio_CheckedChanged);
            // 
            // theomaradio
            // 
            this.theomaradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.theomaradio.AutoSize = true;
            this.theomaradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.theomaradio.Location = new System.Drawing.Point(355, 93);
            this.theomaradio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.theomaradio.Name = "theomaradio";
            this.theomaradio.Size = new System.Drawing.Size(121, 19);
            this.theomaradio.TabIndex = 11;
            this.theomaradio.TabStop = true;
            this.theomaradio.Text = "Tìm theo mã VTPT";
            this.theomaradio.UseVisualStyleBackColor = true;
            this.theomaradio.CheckedChanged += new System.EventHandler(this.theomaradio_CheckedChanged);
            // 
            // timkiemtxtbox
            // 
            this.timkiemtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiemtxtbox.Location = new System.Drawing.Point(349, 68);
            this.timkiemtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timkiemtxtbox.Name = "timkiemtxtbox";
            this.timkiemtxtbox.Size = new System.Drawing.Size(325, 23);
            this.timkiemtxtbox.TabIndex = 8;
            this.timkiemtxtbox.TextChanged += new System.EventHandler(this.timkiemtxtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(253, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm:";
            // 
            // ptdtgrid
            // 
            this.ptdtgrid.AllowUserToAddRows = false;
            this.ptdtgrid.AllowUserToDeleteRows = false;
            this.ptdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ptdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ptdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVTPT,
            this.TenVTPT,
            this.SoLuongTon,
            this.DonGia});
            this.ptdtgrid.Location = new System.Drawing.Point(10, 128);
            this.ptdtgrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptdtgrid.Name = "ptdtgrid";
            this.ptdtgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ptdtgrid.RowHeadersWidth = 51;
            this.ptdtgrid.RowTemplate.Height = 29;
            this.ptdtgrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ptdtgrid.Size = new System.Drawing.Size(972, 359);
            this.ptdtgrid.TabIndex = 13;
            this.ptdtgrid.SelectionChanged += new System.EventHandler(this.ptdtgrid_SelectionChanged);
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
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // xoavtptbtn
            // 
            this.xoavtptbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xoavtptbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xoavtptbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoavtptbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xoavtptbtn.Image = global::QLGROTO.Properties.Resources.recycle_310938_640;
            this.xoavtptbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoavtptbtn.Location = new System.Drawing.Point(377, 559);
            this.xoavtptbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoavtptbtn.Name = "xoavtptbtn";
            this.xoavtptbtn.Size = new System.Drawing.Size(232, 49);
            this.xoavtptbtn.TabIndex = 14;
            this.xoavtptbtn.Text = "Xoá VTPT";
            this.xoavtptbtn.UseVisualStyleBackColor = false;
            this.xoavtptbtn.Click += new System.EventHandler(this.xoavtptbtn_Click);
            // 
            // suavtptbtn
            // 
            this.suavtptbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.suavtptbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.suavtptbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suavtptbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suavtptbtn.Image = global::QLGROTO.Properties.Resources.tool_145375_640;
            this.suavtptbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suavtptbtn.Location = new System.Drawing.Point(10, 559);
            this.suavtptbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suavtptbtn.Name = "suavtptbtn";
            this.suavtptbtn.Size = new System.Drawing.Size(232, 49);
            this.suavtptbtn.TabIndex = 16;
            this.suavtptbtn.Text = "Sửa thông tin VTPT";
            this.suavtptbtn.UseVisualStyleBackColor = false;
            this.suavtptbtn.Click += new System.EventHandler(this.button10_Click);
            // 
            // xuatbtn
            // 
            this.xuatbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xuatbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xuatbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xuatbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xuatbtn.Image = global::QLGROTO.Properties.Resources.certificate_g32c53cd83_640__1_;
            this.xuatbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatbtn.Location = new System.Drawing.Point(751, 559);
            this.xuatbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(232, 49);
            this.xuatbtn.TabIndex = 14;
            this.xuatbtn.Text = "Xuất file danh sách";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(900, 612);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(473, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Số lượng tồn:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(36, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Tên VTPT:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(38, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Mã VTPT:";
            // 
            // sltxtbox
            // 
            this.sltxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sltxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sltxtbox.Location = new System.Drawing.Point(611, 18);
            this.sltxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sltxtbox.Multiline = true;
            this.sltxtbox.Name = "sltxtbox";
            this.sltxtbox.ReadOnly = true;
            this.sltxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.sltxtbox.Size = new System.Drawing.Size(316, 20);
            this.sltxtbox.TabIndex = 45;
            // 
            // tenvtpttxtbox
            // 
            this.tenvtpttxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tenvtpttxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenvtpttxtbox.Location = new System.Drawing.Point(138, 40);
            this.tenvtpttxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenvtpttxtbox.Multiline = true;
            this.tenvtpttxtbox.Name = "tenvtpttxtbox";
            this.tenvtpttxtbox.ReadOnly = true;
            this.tenvtpttxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tenvtpttxtbox.Size = new System.Drawing.Size(316, 20);
            this.tenvtpttxtbox.TabIndex = 46;
            // 
            // mavtpttxtbox
            // 
            this.mavtpttxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mavtpttxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mavtpttxtbox.Location = new System.Drawing.Point(138, 18);
            this.mavtpttxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mavtpttxtbox.Multiline = true;
            this.mavtpttxtbox.Name = "mavtpttxtbox";
            this.mavtpttxtbox.ReadOnly = true;
            this.mavtpttxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mavtpttxtbox.Size = new System.Drawing.Size(316, 20);
            this.mavtpttxtbox.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.tenvtpttxtbox);
            this.groupBox1.Controls.Add(this.mavtpttxtbox);
            this.groupBox1.Controls.Add(this.dgtxtbox);
            this.groupBox1.Controls.Add(this.sltxtbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 487);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(972, 68);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // dgtxtbox
            // 
            this.dgtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgtxtbox.Location = new System.Drawing.Point(611, 39);
            this.dgtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgtxtbox.Multiline = true;
            this.dgtxtbox.Name = "dgtxtbox";
            this.dgtxtbox.ReadOnly = true;
            this.dgtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgtxtbox.Size = new System.Drawing.Size(316, 20);
            this.dgtxtbox.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(518, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Đơn giá:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timkiembtn
            // 
            this.timkiembtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiembtn.BackColor = System.Drawing.SystemColors.Info;
            this.timkiembtn.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.timkiembtn.Location = new System.Drawing.Point(679, 68);
            this.timkiembtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(69, 20);
            this.timkiembtn.TabIndex = 70;
            this.timkiembtn.UseVisualStyleBackColor = false;
            this.timkiembtn.Click += new System.EventHandler(this.timkiembtn_Click);
            // 
            // DSVTPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 643);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.xuatbtn);
            this.Controls.Add(this.xoavtptbtn);
            this.Controls.Add(this.suavtptbtn);
            this.Controls.Add(this.ptdtgrid);
            this.Controls.Add(this.theotenradio);
            this.Controls.Add(this.theomaradio);
            this.Controls.Add(this.timkiemtxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DSVTPT";
            this.ShowIcon = false;
            this.Text = "Danh sách vật tư phụ tùng";
            this.Load += new System.EventHandler(this.QUANLYVATTUPHUTUNG_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptdtgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VatTuPhuTung_Title;
        private RadioButton theotenradio;
        private RadioButton theomaradio;
        private TextBox timkiemtxtbox;
        private Label label1;
        private DataGridView ptdtgrid;
        private Button xoavtptbtn;
        private Button suavtptbtn;
        private Button xuatbtn;
        private Button button2;
        private Label label3;
        private Label label7;
        private Label label8;
        private TextBox sltxtbox;
        private TextBox tenvtpttxtbox;
        private TextBox mavtpttxtbox;
        private GroupBox groupBox1;
        private TextBox dgtxtbox;
        private Label label2;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn DonGia;
        private Button timkiembtn;
    }
}