namespace QLGROTO
{
    partial class PHIEUNHAPVTPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHIEUNHAPVTPT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ctnkgrid = new System.Windows.Forms.DataGridView();
            this.MaVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lpbtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mapntxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xoabtn = new System.Windows.Forms.Button();
            this.tenvtcbbox = new System.Windows.Forms.ComboBox();
            this.slnum = new System.Windows.Forms.NumericUpDown();
            this.thembtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgtxtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctnkgrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slnum)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            // 
            // ctnkgrid
            // 
            this.ctnkgrid.AllowUserToAddRows = false;
            this.ctnkgrid.AllowUserToDeleteRows = false;
            this.ctnkgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctnkgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctnkgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctnkgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVTPT,
            this.TenVTPT,
            this.SoLuong,
            this.GiaNhap});
            this.ctnkgrid.Location = new System.Drawing.Point(14, 215);
            this.ctnkgrid.Name = "ctnkgrid";
            this.ctnkgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ctnkgrid.RowHeadersWidth = 51;
            this.ctnkgrid.RowTemplate.Height = 29;
            this.ctnkgrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctnkgrid.Size = new System.Drawing.Size(1152, 394);
            this.ctnkgrid.TabIndex = 5;
            this.ctnkgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctnkgrid_CellContentClick);
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
            // lpbtn
            // 
            this.lpbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lpbtn.Location = new System.Drawing.Point(972, 615);
            this.lpbtn.Name = "lpbtn";
            this.lpbtn.Size = new System.Drawing.Size(94, 29);
            this.lpbtn.TabIndex = 5;
            this.lpbtn.Text = "Lập phiếu";
            this.lpbtn.UseVisualStyleBackColor = true;
            this.lpbtn.Click += new System.EventHandler(this.lpbtn_Click);
            // 
            // thoatbtn
            // 
            this.thoatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatbtn.Location = new System.Drawing.Point(1072, 615);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 87;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.huybtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(173, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // mapntxtbox
            // 
            this.mapntxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mapntxtbox.Enabled = false;
            this.mapntxtbox.Location = new System.Drawing.Point(326, 80);
            this.mapntxtbox.Name = "mapntxtbox";
            this.mapntxtbox.ReadOnly = true;
            this.mapntxtbox.Size = new System.Drawing.Size(220, 27);
            this.mapntxtbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(593, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày nhập:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(711, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.xoabtn);
            this.panel2.Controls.Add(this.tenvtcbbox);
            this.panel2.Controls.Add(this.slnum);
            this.panel2.Controls.Add(this.thembtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgtxtbox);
            this.panel2.Location = new System.Drawing.Point(14, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 94);
            this.panel2.TabIndex = 6;
            // 
            // xoabtn
            // 
            this.xoabtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xoabtn.Location = new System.Drawing.Point(1043, 51);
            this.xoabtn.Name = "xoabtn";
            this.xoabtn.Size = new System.Drawing.Size(94, 29);
            this.xoabtn.TabIndex = 4;
            this.xoabtn.Text = "Xóa";
            this.xoabtn.UseVisualStyleBackColor = true;
            this.xoabtn.Click += new System.EventHandler(this.xoabtn_Click);
            // 
            // tenvtcbbox
            // 
            this.tenvtcbbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tenvtcbbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tenvtcbbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tenvtcbbox.FormattingEnabled = true;
            this.tenvtcbbox.Location = new System.Drawing.Point(174, 12);
            this.tenvtcbbox.Name = "tenvtcbbox";
            this.tenvtcbbox.Size = new System.Drawing.Size(360, 28);
            this.tenvtcbbox.TabIndex = 0;
            // 
            // slnum
            // 
            this.slnum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.slnum.Location = new System.Drawing.Point(847, 30);
            this.slnum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.slnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slnum.Name = "slnum";
            this.slnum.Size = new System.Drawing.Size(150, 27);
            this.slnum.TabIndex = 2;
            this.slnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // thembtn
            // 
            this.thembtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thembtn.Location = new System.Drawing.Point(1043, 13);
            this.thembtn.Name = "thembtn";
            this.thembtn.Size = new System.Drawing.Size(94, 29);
            this.thembtn.TabIndex = 3;
            this.thembtn.Text = "Thêm";
            this.thembtn.UseVisualStyleBackColor = true;
            this.thembtn.Click += new System.EventHandler(this.thembtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 31);
            this.label5.TabIndex = 65;
            this.label5.Text = "Đơn giá nhập:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(730, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 66;
            this.label4.Text = "Số lượng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(57, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 31);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tên VTPT:";
            // 
            // dgtxtbox
            // 
            this.dgtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgtxtbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgtxtbox.Location = new System.Drawing.Point(174, 46);
            this.dgtxtbox.Multiline = true;
            this.dgtxtbox.Name = "dgtxtbox";
            this.dgtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgtxtbox.Size = new System.Drawing.Size(360, 25);
            this.dgtxtbox.TabIndex = 1;
            this.dgtxtbox.TextChanged += new System.EventHandler(this.dgtxtbox_TextChanged);
            // 
            // PHIEUNHAPVTPT
            // 
            this.AcceptButton = this.lpbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(1178, 656);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mapntxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.lpbtn);
            this.Controls.Add(this.ctnkgrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PHIEUNHAPVTPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập vật tư phụ tùng";
            this.Load += new System.EventHandler(this.AccessoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctnkgrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView ctnkgrid;
        private Button lpbtn;
        private Button thoatbtn;
        private Label label2;
        private TextBox mapntxtbox;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox dgtxtbox;
        private NumericUpDown slnum;
        private Button thembtn;
        private ComboBox tenvtcbbox;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaNhap;
        private Button xoabtn;
    }
}