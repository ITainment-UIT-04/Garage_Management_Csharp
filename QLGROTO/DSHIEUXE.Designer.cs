namespace QLGROTO
{
    partial class DSHIEUXE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSHIEUXE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VatTuPhuTung_Title = new System.Windows.Forms.Label();
            this.timhieuxetxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hieuxedtgrid = new System.Windows.Forms.DataGridView();
            this.HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoahieuxebtn = new System.Windows.Forms.Button();
            this.themhieuxebtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.timkiembtn = new System.Windows.Forms.Button();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hieuxedtgrid)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(801, 64);
            this.panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            this.VatTuPhuTung_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VatTuPhuTung_Title.AutoSize = true;
            this.VatTuPhuTung_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VatTuPhuTung_Title.ForeColor = System.Drawing.Color.White;
            this.VatTuPhuTung_Title.Location = new System.Drawing.Point(225, 9);
            this.VatTuPhuTung_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            this.VatTuPhuTung_Title.Size = new System.Drawing.Size(350, 45);
            this.VatTuPhuTung_Title.TabIndex = 4;
            this.VatTuPhuTung_Title.Text = "DANH SÁCH HIỆU XE";
            // 
            // timhieuxetxtbox
            // 
            this.timhieuxetxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timhieuxetxtbox.Location = new System.Drawing.Point(231, 84);
            this.timhieuxetxtbox.Name = "timhieuxetxtbox";
            this.timhieuxetxtbox.Size = new System.Drawing.Size(371, 27);
            this.timhieuxetxtbox.TabIndex = 1;
            this.timhieuxetxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(121, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tìm kiếm:";
            // 
            // hieuxedtgrid
            // 
            this.hieuxedtgrid.AllowUserToAddRows = false;
            this.hieuxedtgrid.AllowUserToDeleteRows = false;
            this.hieuxedtgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hieuxedtgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hieuxedtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hieuxedtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HieuXe});
            this.hieuxedtgrid.Location = new System.Drawing.Point(12, 133);
            this.hieuxedtgrid.Name = "hieuxedtgrid";
            this.hieuxedtgrid.ReadOnly = true;
            this.hieuxedtgrid.RowHeadersWidth = 51;
            this.hieuxedtgrid.RowTemplate.Height = 29;
            this.hieuxedtgrid.Size = new System.Drawing.Size(776, 257);
            this.hieuxedtgrid.TabIndex = 2;
            this.hieuxedtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HieuXe
            // 
            this.HieuXe.DataPropertyName = "HieuXe";
            this.HieuXe.HeaderText = "Hiệu xe";
            this.HieuXe.MinimumWidth = 6;
            this.HieuXe.Name = "HieuXe";
            this.HieuXe.ReadOnly = true;
            // 
            // xoahieuxebtn
            // 
            this.xoahieuxebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xoahieuxebtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xoahieuxebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoahieuxebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xoahieuxebtn.Image = global::QLGROTO.Properties.Resources.recycle_310938_640;
            this.xoahieuxebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoahieuxebtn.Location = new System.Drawing.Point(263, 396);
            this.xoahieuxebtn.Name = "xoahieuxebtn";
            this.xoahieuxebtn.Size = new System.Drawing.Size(265, 65);
            this.xoahieuxebtn.TabIndex = 4;
            this.xoahieuxebtn.Text = "Xóa hiệu xe";
            this.xoahieuxebtn.UseVisualStyleBackColor = false;
            this.xoahieuxebtn.Click += new System.EventHandler(this.xoahieuxebtn_Click);
            // 
            // themhieuxebtn
            // 
            this.themhieuxebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.themhieuxebtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.themhieuxebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.themhieuxebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.themhieuxebtn.Image = ((System.Drawing.Image)(resources.GetObject("themhieuxebtn.Image")));
            this.themhieuxebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themhieuxebtn.Location = new System.Drawing.Point(12, 396);
            this.themhieuxebtn.Name = "themhieuxebtn";
            this.themhieuxebtn.Size = new System.Drawing.Size(265, 65);
            this.themhieuxebtn.TabIndex = 3;
            this.themhieuxebtn.Text = "Thêm hiệu xe";
            this.themhieuxebtn.UseVisualStyleBackColor = false;
            this.themhieuxebtn.Click += new System.EventHandler(this.themhieuxebtn_Click);
            // 
            // thoatbtn
            // 
            this.thoatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatbtn.Location = new System.Drawing.Point(694, 464);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 6;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // timkiembtn
            // 
            this.timkiembtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timkiembtn.BackColor = System.Drawing.SystemColors.Info;
            this.timkiembtn.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.timkiembtn.Location = new System.Drawing.Point(608, 84);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(79, 27);
            this.timkiembtn.TabIndex = 2;
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
            this.xuatbtn.Location = new System.Drawing.Point(523, 396);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(265, 65);
            this.xuatbtn.TabIndex = 5;
            this.xuatbtn.Text = "Xuất file danh sách";
            this.xuatbtn.UseVisualStyleBackColor = false;
            this.xuatbtn.Click += new System.EventHandler(this.xuatbtn_Click);
            // 
            // DSHIEUXE
            // 
            this.AcceptButton = this.timkiembtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.xuatbtn);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.xoahieuxebtn);
            this.Controls.Add(this.themhieuxebtn);
            this.Controls.Add(this.hieuxedtgrid);
            this.Controls.Add(this.timhieuxetxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DSHIEUXE";
            this.Text = "Danh sách hiệu xe";
            this.Load += new System.EventHandler(this.BrandList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hieuxedtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private TextBox timhieuxetxtbox;
        private Label label1;
        private DataGridView hieuxedtgrid;
        private Button xoahieuxebtn;
        private Button themhieuxebtn;
        private Button thoatbtn;
        private DataGridViewTextBoxColumn HieuXe;
        private Button timkiembtn;
        private Button xuatbtn;
    }
}