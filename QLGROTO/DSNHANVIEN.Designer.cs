namespace QLGROTO
{
    partial class DSNHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSNHANVIEN));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VatTuPhuTung_Title = new System.Windows.Forms.Label();
            this.timkiembtn = new System.Windows.Forms.Button();
            this.tennvradiobtn = new System.Windows.Forms.RadioButton();
            this.tendnradio = new System.Windows.Forms.RadioButton();
            this.timkiemtxtbox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.nvdtgrid = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suanvbtn = new System.Windows.Forms.Button();
            this.xoanvbtn = new System.Windows.Forms.Button();
            this.themnvbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TenChuXe = new System.Windows.Forms.Label();
            this.chucvutxtbox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dthtxtbox = new System.Windows.Forms.TextBox();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.tentxtbox = new System.Windows.Forms.TextBox();
            this.dctxtbox = new System.Windows.Forms.TextBox();
            this.mktxtbox = new System.Windows.Forms.TextBox();
            this.tdntxtbox = new System.Windows.Forms.TextBox();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.sdtradio = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvdtgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.VatTuPhuTung_Title);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 66);
            this.panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            this.VatTuPhuTung_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VatTuPhuTung_Title.AutoSize = true;
            this.VatTuPhuTung_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VatTuPhuTung_Title.ForeColor = System.Drawing.Color.White;
            this.VatTuPhuTung_Title.Location = new System.Drawing.Point(480, 9);
            this.VatTuPhuTung_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            this.VatTuPhuTung_Title.Size = new System.Drawing.Size(409, 45);
            this.VatTuPhuTung_Title.TabIndex = 6;
            this.VatTuPhuTung_Title.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // timkiembtn
            // 
            this.timkiembtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiembtn.BackColor = System.Drawing.SystemColors.Info;
            this.timkiembtn.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.timkiembtn.Location = new System.Drawing.Point(911, 81);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(79, 27);
            this.timkiembtn.TabIndex = 35;
            this.timkiembtn.UseVisualStyleBackColor = false;
            this.timkiembtn.Click += new System.EventHandler(this.timkiembtn_Click);
            // 
            // tennvradiobtn
            // 
            this.tennvradiobtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tennvradiobtn.AutoSize = true;
            this.tennvradiobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tennvradiobtn.Location = new System.Drawing.Point(592, 111);
            this.tennvradiobtn.Name = "tennvradiobtn";
            this.tennvradiobtn.Size = new System.Drawing.Size(181, 24);
            this.tennvradiobtn.TabIndex = 33;
            this.tennvradiobtn.TabStop = true;
            this.tennvradiobtn.Text = "Tìm theo tên nhân viên";
            this.tennvradiobtn.UseVisualStyleBackColor = true;
            this.tennvradiobtn.CheckedChanged += new System.EventHandler(this.tennvradiobtn_CheckedChanged);
            // 
            // tendnradio
            // 
            this.tendnradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tendnradio.AutoSize = true;
            this.tendnradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tendnradio.Location = new System.Drawing.Point(397, 111);
            this.tendnradio.Name = "tendnradio";
            this.tendnradio.Size = new System.Drawing.Size(189, 24);
            this.tendnradio.TabIndex = 34;
            this.tendnradio.TabStop = true;
            this.tendnradio.Text = "Tìm theo tên đăng nhập";
            this.tendnradio.UseVisualStyleBackColor = true;
            this.tendnradio.CheckedChanged += new System.EventHandler(this.manvradio_CheckedChanged);
            // 
            // timkiemtxtbox
            // 
            this.timkiemtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiemtxtbox.Location = new System.Drawing.Point(534, 81);
            this.timkiemtxtbox.Name = "timkiemtxtbox";
            this.timkiemtxtbox.Size = new System.Drawing.Size(371, 27);
            this.timkiemtxtbox.TabIndex = 32;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchLabel.Location = new System.Drawing.Point(424, 80);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 28);
            this.SearchLabel.TabIndex = 31;
            this.SearchLabel.Text = "Tìm kiếm:";
            // 
            // nvdtgrid
            // 
            this.nvdtgrid.AllowUserToAddRows = false;
            this.nvdtgrid.AllowUserToDeleteRows = false;
            this.nvdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nvdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nvdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nvdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.MatKhau,
            this.TenNV,
            this.DiaChi,
            this.DienThoai,
            this.Email,
            this.ChucVu});
            this.nvdtgrid.Location = new System.Drawing.Point(12, 156);
            this.nvdtgrid.Name = "nvdtgrid";
            this.nvdtgrid.ReadOnly = true;
            this.nvdtgrid.RowHeadersWidth = 51;
            this.nvdtgrid.RowTemplate.Height = 29;
            this.nvdtgrid.Size = new System.Drawing.Size(1380, 293);
            this.nvdtgrid.TabIndex = 36;
            this.nvdtgrid.SelectionChanged += new System.EventHandler(this.nvdtgrid_SelectionChanged);
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Họ và tên ";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // suanvbtn
            // 
            this.suanvbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.suanvbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.suanvbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suanvbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suanvbtn.Image = global::QLGROTO.Properties.Resources.tool_145375_640;
            this.suanvbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suanvbtn.Location = new System.Drawing.Point(387, 666);
            this.suanvbtn.Name = "suanvbtn";
            this.suanvbtn.Size = new System.Drawing.Size(265, 65);
            this.suanvbtn.TabIndex = 70;
            this.suanvbtn.Text = "Sửa thông tin nhân viên";
            this.suanvbtn.UseVisualStyleBackColor = false;
            this.suanvbtn.Click += new System.EventHandler(this.suanvbtn_Click);
            // 
            // xoanvbtn
            // 
            this.xoanvbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xoanvbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xoanvbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoanvbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xoanvbtn.Image = global::QLGROTO.Properties.Resources.recycle_310938_640;
            this.xoanvbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoanvbtn.Location = new System.Drawing.Point(764, 666);
            this.xoanvbtn.Name = "xoanvbtn";
            this.xoanvbtn.Size = new System.Drawing.Size(265, 65);
            this.xoanvbtn.TabIndex = 68;
            this.xoanvbtn.Text = "Xóa nhân viên";
            this.xoanvbtn.UseVisualStyleBackColor = false;
            this.xoanvbtn.Click += new System.EventHandler(this.xoanvbtn_Click);
            // 
            // themnvbtn
            // 
            this.themnvbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.themnvbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.themnvbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.themnvbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.themnvbtn.Image = ((System.Drawing.Image)(resources.GetObject("themnvbtn.Image")));
            this.themnvbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themnvbtn.Location = new System.Drawing.Point(12, 666);
            this.themnvbtn.Name = "themnvbtn";
            this.themnvbtn.Size = new System.Drawing.Size(265, 65);
            this.themnvbtn.TabIndex = 69;
            this.themnvbtn.Text = "Thêm nhân viên";
            this.themnvbtn.UseVisualStyleBackColor = false;
            this.themnvbtn.Click += new System.EventHandler(this.themtiencong_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1300, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 71;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TenChuXe);
            this.groupBox1.Controls.Add(this.chucvutxtbox);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.dthtxtbox);
            this.groupBox1.Controls.Add(this.emailtxtbox);
            this.groupBox1.Controls.Add(this.tentxtbox);
            this.groupBox1.Controls.Add(this.dctxtbox);
            this.groupBox1.Controls.Add(this.mktxtbox);
            this.groupBox1.Controls.Add(this.tdntxtbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1380, 205);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(522, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 33;
            this.label3.Text = "Chức vụ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(227, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(765, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(751, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(235, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 36;
            this.label4.Text = "Họ và tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(725, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mật khẩu:";
            // 
            // TenChuXe
            // 
            this.TenChuXe.AutoSize = true;
            this.TenChuXe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenChuXe.Location = new System.Drawing.Point(180, 37);
            this.TenChuXe.Name = "TenChuXe";
            this.TenChuXe.Size = new System.Drawing.Size(171, 31);
            this.TenChuXe.TabIndex = 36;
            this.TenChuXe.Text = "Tên đăng nhập:";
            // 
            // chucvutxtbox
            // 
            this.chucvutxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chucvutxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chucvutxtbox.Location = new System.Drawing.Point(629, 160);
            this.chucvutxtbox.Multiline = true;
            this.chucvutxtbox.Name = "chucvutxtbox";
            this.chucvutxtbox.ReadOnly = true;
            this.chucvutxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.chucvutxtbox.Size = new System.Drawing.Size(300, 29);
            this.chucvutxtbox.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(629, 160);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox3.Size = new System.Drawing.Size(300, 29);
            this.textBox3.TabIndex = 29;
            // 
            // dthtxtbox
            // 
            this.dthtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dthtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dthtxtbox.Location = new System.Drawing.Point(357, 114);
            this.dthtxtbox.Multiline = true;
            this.dthtxtbox.Name = "dthtxtbox";
            this.dthtxtbox.ReadOnly = true;
            this.dthtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dthtxtbox.Size = new System.Drawing.Size(300, 29);
            this.dthtxtbox.TabIndex = 31;
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailtxtbox.Location = new System.Drawing.Point(846, 114);
            this.emailtxtbox.Multiline = true;
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.ReadOnly = true;
            this.emailtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.emailtxtbox.Size = new System.Drawing.Size(300, 29);
            this.emailtxtbox.TabIndex = 30;
            // 
            // tentxtbox
            // 
            this.tentxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tentxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tentxtbox.Location = new System.Drawing.Point(357, 79);
            this.tentxtbox.Multiline = true;
            this.tentxtbox.Name = "tentxtbox";
            this.tentxtbox.ReadOnly = true;
            this.tentxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tentxtbox.Size = new System.Drawing.Size(300, 29);
            this.tentxtbox.TabIndex = 32;
            // 
            // dctxtbox
            // 
            this.dctxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dctxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dctxtbox.Location = new System.Drawing.Point(846, 79);
            this.dctxtbox.Multiline = true;
            this.dctxtbox.Name = "dctxtbox";
            this.dctxtbox.ReadOnly = true;
            this.dctxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dctxtbox.Size = new System.Drawing.Size(300, 29);
            this.dctxtbox.TabIndex = 31;
            // 
            // mktxtbox
            // 
            this.mktxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mktxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mktxtbox.Location = new System.Drawing.Point(846, 44);
            this.mktxtbox.Multiline = true;
            this.mktxtbox.Name = "mktxtbox";
            this.mktxtbox.ReadOnly = true;
            this.mktxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mktxtbox.Size = new System.Drawing.Size(300, 29);
            this.mktxtbox.TabIndex = 32;
            // 
            // tdntxtbox
            // 
            this.tdntxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tdntxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tdntxtbox.Location = new System.Drawing.Point(357, 39);
            this.tdntxtbox.Multiline = true;
            this.tdntxtbox.Name = "tdntxtbox";
            this.tdntxtbox.ReadOnly = true;
            this.tdntxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tdntxtbox.Size = new System.Drawing.Size(300, 29);
            this.tdntxtbox.TabIndex = 32;
            // 
            // xuatbtn
            // 
            this.xuatbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xuatbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xuatbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xuatbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xuatbtn.Image = global::QLGROTO.Properties.Resources.certificate_g32c53cd83_640__1_;
            this.xuatbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatbtn.Location = new System.Drawing.Point(1127, 666);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(265, 65);
            this.xuatbtn.TabIndex = 73;
            this.xuatbtn.Text = "Xuất file danh sách";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // sdtradio
            // 
            this.sdtradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sdtradio.AutoSize = true;
            this.sdtradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sdtradio.Location = new System.Drawing.Point(779, 111);
            this.sdtradio.Name = "sdtradio";
            this.sdtradio.Size = new System.Drawing.Size(246, 24);
            this.sdtradio.TabIndex = 74;
            this.sdtradio.TabStop = true;
            this.sdtradio.Text = "Tìm theo số điện thoại nhân viên";
            this.sdtradio.UseVisualStyleBackColor = true;
            this.sdtradio.CheckedChanged += new System.EventHandler(this.sdtradio_CheckedChanged);
            // 
            // DSNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1404, 778);
            this.Controls.Add(this.sdtradio);
            this.Controls.Add(this.xuatbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.suanvbtn);
            this.Controls.Add(this.xoanvbtn);
            this.Controls.Add(this.themnvbtn);
            this.Controls.Add(this.nvdtgrid);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.tennvradiobtn);
            this.Controls.Add(this.tendnradio);
            this.Controls.Add(this.timkiemtxtbox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DSNHANVIEN";
            this.ShowIcon = false;
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.DSNHANVIEN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvdtgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private Button timkiembtn;
        private RadioButton tennvradiobtn;
        private RadioButton tendnradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private DataGridView nvdtgrid;
        private Button suanvbtn;
        private Button xoanvbtn;
        private Button themnvbtn;
        private Button button1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label TenChuXe;
        private TextBox chucvutxtbox;
        private TextBox textBox3;
        private TextBox emailtxtbox;
        private TextBox dctxtbox;
        private TextBox tdntxtbox;
        private Label label5;
        private Label label4;
        private TextBox dthtxtbox;
        private TextBox tentxtbox;
        private Button xuatbtn;
        private RadioButton sdtradio;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn ChucVu;
        private Label label6;
        private TextBox mktxtbox;
    }
}