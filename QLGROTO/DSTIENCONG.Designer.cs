namespace QLGROTO
{
    partial class DSTIENCONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSTIENCONG));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ndtcbtn = new System.Windows.Forms.RadioButton();
            this.matcradio = new System.Windows.Forms.RadioButton();
            this.timkiemtxtbox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.tcdtgrid = new System.Windows.Forms.DataGridView();
            this.MaTienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoatcbtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TenChuXe = new System.Windows.Forms.Label();
            this.tctxtbox = new System.Windows.Forms.TextBox();
            this.matctxtbox = new System.Windows.Forms.TextBox();
            this.ndtxtbox = new System.Windows.Forms.TextBox();
            this.themtcbtn = new System.Windows.Forms.Button();
            this.suatcbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timkiembtn = new System.Windows.Forms.Button();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcdtgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(327, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH LOẠI TIỀN CÔNG";
            // 
            // ndtcbtn
            // 
            this.ndtcbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ndtcbtn.AutoSize = true;
            this.ndtcbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ndtcbtn.Location = new System.Drawing.Point(623, 114);
            this.ndtcbtn.Name = "ndtcbtn";
            this.ndtcbtn.Size = new System.Drawing.Size(152, 24);
            this.ndtcbtn.TabIndex = 2;
            this.ndtcbtn.TabStop = true;
            this.ndtcbtn.Text = "Tìm theo nội dung";
            this.ndtcbtn.UseVisualStyleBackColor = true;
            this.ndtcbtn.CheckedChanged += new System.EventHandler(this.ndtcbtn_CheckedChanged);
            // 
            // matcradio
            // 
            this.matcradio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matcradio.AutoSize = true;
            this.matcradio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.matcradio.Location = new System.Drawing.Point(408, 114);
            this.matcradio.Name = "matcradio";
            this.matcradio.Size = new System.Drawing.Size(209, 24);
            this.matcradio.TabIndex = 2;
            this.matcradio.TabStop = true;
            this.matcradio.Text = "Tìm theo mã loại tiền công";
            this.matcradio.UseVisualStyleBackColor = true;
            this.matcradio.CheckedChanged += new System.EventHandler(this.matcradio_CheckedChanged);
            // 
            // timkiemtxtbox
            // 
            this.timkiemtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiemtxtbox.Location = new System.Drawing.Point(420, 84);
            this.timkiemtxtbox.Name = "timkiemtxtbox";
            this.timkiemtxtbox.Size = new System.Drawing.Size(371, 27);
            this.timkiemtxtbox.TabIndex = 1;
            this.timkiemtxtbox.TextChanged += new System.EventHandler(this.timkiemtxtbox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchLabel.Location = new System.Drawing.Point(310, 83);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 28);
            this.SearchLabel.TabIndex = 7;
            this.SearchLabel.Text = "Tìm kiếm:";
            // 
            // tcdtgrid
            // 
            this.tcdtgrid.AllowUserToAddRows = false;
            this.tcdtgrid.AllowUserToDeleteRows = false;
            this.tcdtgrid.AllowUserToOrderColumns = true;
            this.tcdtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcdtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tcdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTienCong,
            this.TienCong,
            this.NoiDung});
            this.tcdtgrid.Location = new System.Drawing.Point(12, 157);
            this.tcdtgrid.Name = "tcdtgrid";
            this.tcdtgrid.RowHeadersWidth = 51;
            this.tcdtgrid.RowTemplate.Height = 29;
            this.tcdtgrid.Size = new System.Drawing.Size(1147, 448);
            this.tcdtgrid.TabIndex = 4;
            this.tcdtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tcdtgrid.SelectionChanged += new System.EventHandler(this.tcdtgrid_SelectionChanged);
            // 
            // MaTienCong
            // 
            this.MaTienCong.DataPropertyName = "MaTienCong";
            this.MaTienCong.HeaderText = "Mã tiền công";
            this.MaTienCong.MinimumWidth = 6;
            this.MaTienCong.Name = "MaTienCong";
            // 
            // TienCong
            // 
            this.TienCong.DataPropertyName = "TienCong";
            this.TienCong.HeaderText = "Tiền công";
            this.TienCong.MinimumWidth = 6;
            this.TienCong.Name = "TienCong";
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // xoatcbtn
            // 
            this.xoatcbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xoatcbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xoatcbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoatcbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xoatcbtn.Image = global::QLGROTO.Properties.Resources.recycle_310938_640;
            this.xoatcbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoatcbtn.Location = new System.Drawing.Point(623, 682);
            this.xoatcbtn.Name = "xoatcbtn";
            this.xoatcbtn.Size = new System.Drawing.Size(265, 65);
            this.xoatcbtn.TabIndex = 7;
            this.xoatcbtn.Text = "Xoá loại tiền công";
            this.xoatcbtn.UseVisualStyleBackColor = false;
            this.xoatcbtn.Click += new System.EventHandler(this.xoatcbtn_Click);
            // 
            // thoatbtn
            // 
            this.thoatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatbtn.Location = new System.Drawing.Point(1065, 753);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 9;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(106, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tiền công:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(28, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 31);
            this.label8.TabIndex = 65;
            this.label8.Text = "Mã loại tiền công:";
            // 
            // TenChuXe
            // 
            this.TenChuXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TenChuXe.AutoSize = true;
            this.TenChuXe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenChuXe.Location = new System.Drawing.Point(28, 86);
            this.TenChuXe.Name = "TenChuXe";
            this.TenChuXe.Size = new System.Drawing.Size(115, 31);
            this.TenChuXe.TabIndex = 66;
            this.TenChuXe.Text = "Nội dung:";
            // 
            // tctxtbox
            // 
            this.tctxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tctxtbox.Enabled = false;
            this.tctxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tctxtbox.Location = new System.Drawing.Point(231, 57);
            this.tctxtbox.Multiline = true;
            this.tctxtbox.Name = "tctxtbox";
            this.tctxtbox.ReadOnly = true;
            this.tctxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tctxtbox.Size = new System.Drawing.Size(360, 25);
            this.tctxtbox.TabIndex = 61;
            // 
            // matctxtbox
            // 
            this.matctxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.matctxtbox.Enabled = false;
            this.matctxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matctxtbox.Location = new System.Drawing.Point(231, 27);
            this.matctxtbox.Multiline = true;
            this.matctxtbox.Name = "matctxtbox";
            this.matctxtbox.ReadOnly = true;
            this.matctxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.matctxtbox.Size = new System.Drawing.Size(360, 25);
            this.matctxtbox.TabIndex = 62;
            // 
            // ndtxtbox
            // 
            this.ndtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ndtxtbox.Enabled = false;
            this.ndtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ndtxtbox.Location = new System.Drawing.Point(149, 89);
            this.ndtxtbox.Multiline = true;
            this.ndtxtbox.Name = "ndtxtbox";
            this.ndtxtbox.ReadOnly = true;
            this.ndtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ndtxtbox.Size = new System.Drawing.Size(442, 76);
            this.ndtxtbox.TabIndex = 63;
            // 
            // themtcbtn
            // 
            this.themtcbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.themtcbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.themtcbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.themtcbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.themtcbtn.Image = ((System.Drawing.Image)(resources.GetObject("themtcbtn.Image")));
            this.themtcbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themtcbtn.Location = new System.Drawing.Point(626, 611);
            this.themtcbtn.Name = "themtcbtn";
            this.themtcbtn.Size = new System.Drawing.Size(265, 65);
            this.themtcbtn.TabIndex = 5;
            this.themtcbtn.Text = "Thêm loại tiền công";
            this.themtcbtn.UseVisualStyleBackColor = false;
            this.themtcbtn.Click += new System.EventHandler(this.themtiencong_btn_Click);
            // 
            // suatcbtn
            // 
            this.suatcbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.suatcbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.suatcbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suatcbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suatcbtn.Image = ((System.Drawing.Image)(resources.GetObject("suatcbtn.Image")));
            this.suatcbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suatcbtn.Location = new System.Drawing.Point(894, 611);
            this.suatcbtn.Name = "suatcbtn";
            this.suatcbtn.Size = new System.Drawing.Size(265, 65);
            this.suatcbtn.TabIndex = 6;
            this.suatcbtn.Text = "Cập nhật loại tiền công";
            this.suatcbtn.UseVisualStyleBackColor = false;
            this.suatcbtn.Click += new System.EventHandler(this.suatiencong_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ndtxtbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.matctxtbox);
            this.groupBox1.Controls.Add(this.tctxtbox);
            this.groupBox1.Controls.Add(this.TenChuXe);
            this.groupBox1.Location = new System.Drawing.Point(12, 611);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 171);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // timkiembtn
            // 
            this.timkiembtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiembtn.BackColor = System.Drawing.SystemColors.Info;
            this.timkiembtn.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.timkiembtn.Location = new System.Drawing.Point(797, 84);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(79, 27);
            this.timkiembtn.TabIndex = 3;
            this.timkiembtn.UseVisualStyleBackColor = false;
            this.timkiembtn.Click += new System.EventHandler(this.timkiembtn_Click);
            // 
            // xuatbtn
            // 
            this.xuatbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xuatbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xuatbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xuatbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xuatbtn.Image = global::QLGROTO.Properties.Resources.certificate_g32c53cd83_640__1_;
            this.xuatbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatbtn.Location = new System.Drawing.Point(894, 682);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(265, 65);
            this.xuatbtn.TabIndex = 8;
            this.xuatbtn.Text = "Xuất file danh sách";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // DSTIENCONG
            // 
            this.AcceptButton = this.timkiembtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(1171, 794);
            this.Controls.Add(this.xuatbtn);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.suatcbtn);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.xoatcbtn);
            this.Controls.Add(this.themtcbtn);
            this.Controls.Add(this.tcdtgrid);
            this.Controls.Add(this.ndtcbtn);
            this.Controls.Add(this.matcradio);
            this.Controls.Add(this.timkiemtxtbox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DSTIENCONG";
            this.Text = "Danh sách loại tiền công";
            this.Load += new System.EventHandler(this.WageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcdtgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RadioButton ndtcbtn;
        private RadioButton matcradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private DataGridView tcdtgrid;
        private Button xoatcbtn;
        private Button thoatbtn;
        private Label label7;
        private Label label8;
        private Label TenChuXe;
        private TextBox tctxtbox;
        private TextBox matctxtbox;
        private TextBox ndtxtbox;
        private Button themtcbtn;
        private Button suatcbtn;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn MaTienCong;
        private DataGridViewTextBoxColumn TienCong;
        private DataGridViewTextBoxColumn NoiDung;
        private Button timkiembtn;
        private Button xuatbtn;
    }
}