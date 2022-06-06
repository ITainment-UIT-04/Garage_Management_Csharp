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
            this.panel1 = new System.Windows.Forms.Panel();
            this.VatTuPhuTung_Title = new System.Windows.Forms.Label();
            this.phieunhapvtptdtgrid = new System.Windows.Forms.DataGridView();
            this.MaNKVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PhoneSearchRadiobtn = new System.Windows.Forms.RadioButton();
            this.NameSearchRadiobtn = new System.Windows.Forms.RadioButton();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.xemctbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.VatTuPhuTung_Title.Location = new System.Drawing.Point(357, 11);
            this.VatTuPhuTung_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            this.VatTuPhuTung_Title.Size = new System.Drawing.Size(504, 45);
            this.VatTuPhuTung_Title.TabIndex = 4;
            this.VatTuPhuTung_Title.Text = "DANH SÁCH PHIẾU NHẬP KHO";
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
            this.phieunhapvtptdtgrid.Location = new System.Drawing.Point(12, 194);
            this.phieunhapvtptdtgrid.Name = "phieunhapvtptdtgrid";
            this.phieunhapvtptdtgrid.ReadOnly = true;
            this.phieunhapvtptdtgrid.RowHeadersWidth = 51;
            this.phieunhapvtptdtgrid.RowTemplate.Height = 29;
            this.phieunhapvtptdtgrid.Size = new System.Drawing.Size(1159, 393);
            this.phieunhapvtptdtgrid.TabIndex = 18;
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
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchButton.BackColor = System.Drawing.SystemColors.Info;
            this.SearchButton.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.SearchButton.Location = new System.Drawing.Point(820, 85);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 27);
            this.SearchButton.TabIndex = 23;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // PhoneSearchRadiobtn
            // 
            this.PhoneSearchRadiobtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhoneSearchRadiobtn.AutoSize = true;
            this.PhoneSearchRadiobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhoneSearchRadiobtn.Location = new System.Drawing.Point(636, 118);
            this.PhoneSearchRadiobtn.Name = "PhoneSearchRadiobtn";
            this.PhoneSearchRadiobtn.Size = new System.Drawing.Size(178, 24);
            this.PhoneSearchRadiobtn.TabIndex = 21;
            this.PhoneSearchRadiobtn.TabStop = true;
            this.PhoneSearchRadiobtn.Text = "Tìm theo khoảng ngày";
            this.PhoneSearchRadiobtn.UseVisualStyleBackColor = true;
            // 
            // NameSearchRadiobtn
            // 
            this.NameSearchRadiobtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameSearchRadiobtn.AutoSize = true;
            this.NameSearchRadiobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameSearchRadiobtn.Location = new System.Drawing.Point(443, 118);
            this.NameSearchRadiobtn.Name = "NameSearchRadiobtn";
            this.NameSearchRadiobtn.Size = new System.Drawing.Size(186, 24);
            this.NameSearchRadiobtn.TabIndex = 22;
            this.NameSearchRadiobtn.TabStop = true;
            this.NameSearchRadiobtn.Text = "Tìm theo số phiếu nhập";
            this.NameSearchRadiobtn.UseVisualStyleBackColor = true;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTextbox.Location = new System.Drawing.Point(443, 85);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(371, 27);
            this.SearchTextbox.TabIndex = 20;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchLabel.Location = new System.Drawing.Point(333, 84);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 28);
            this.SearchLabel.TabIndex = 19;
            this.SearchLabel.Text = "Tìm kiếm:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Từ:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Location = new System.Drawing.Point(688, 148);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(622, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Đến:";
            // 
            // xemctbtn
            // 
            this.xemctbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xemctbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xemctbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xemctbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xemctbtn.Image = global::QLGROTO.Properties.Resources.lens_1723832_640;
            this.xemctbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xemctbtn.Location = new System.Drawing.Point(462, 593);
            this.xemctbtn.Name = "xemctbtn";
            this.xemctbtn.Size = new System.Drawing.Size(265, 65);
            this.xemctbtn.TabIndex = 26;
            this.xemctbtn.Text = "Xem chi tiết";
            this.xemctbtn.UseVisualStyleBackColor = false;
            this.xemctbtn.Click += new System.EventHandler(this.xemctbtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1077, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DSPHIEUNHAPKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xemctbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PhoneSearchRadiobtn);
            this.Controls.Add(this.NameSearchRadiobtn);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.phieunhapvtptdtgrid);
            this.Controls.Add(this.panel1);
            this.Name = "DSPHIEUNHAPKHO";
            this.ShowIcon = false;
            this.Text = "Danh sách phiếu nhập kho";
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
        private Button SearchButton;
        private RadioButton PhoneSearchRadiobtn;
        private RadioButton NameSearchRadiobtn;
        private TextBox SearchTextbox;
        private Label SearchLabel;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Button xemctbtn;
        private Button button1;
        private DataGridViewTextBoxColumn MaNKVTPT;
        private DataGridViewTextBoxColumn NgayNhap;
    }
}