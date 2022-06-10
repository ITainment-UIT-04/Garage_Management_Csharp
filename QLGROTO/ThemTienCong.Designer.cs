namespace QLGROTO
{
    partial class ThemTienCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTienCong));
            this.thembtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TenChuXe = new System.Windows.Forms.Label();
            this.tctxtbox = new System.Windows.Forms.TextBox();
            this.matctxtbox = new System.Windows.Forms.TextBox();
            this.ndtxtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VatTuPhuTung_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // thembtn
            // 
            this.thembtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thembtn.Location = new System.Drawing.Point(427, 160);
            this.thembtn.Name = "thembtn";
            this.thembtn.Size = new System.Drawing.Size(94, 29);
            this.thembtn.TabIndex = 68;
            this.thembtn.Text = "Thêm";
            this.thembtn.UseVisualStyleBackColor = true;
            this.thembtn.Click += new System.EventHandler(this.thembtn_Click);
            // 
            // thoatbtn
            // 
            this.thoatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatbtn.Location = new System.Drawing.Point(527, 160);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 69;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.thoatbtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(111, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tiền công:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(33, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 31);
            this.label8.TabIndex = 66;
            this.label8.Text = "Mã loại tiền công:";
            // 
            // TenChuXe
            // 
            this.TenChuXe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TenChuXe.AutoSize = true;
            this.TenChuXe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenChuXe.Location = new System.Drawing.Point(115, 123);
            this.TenChuXe.Name = "TenChuXe";
            this.TenChuXe.Size = new System.Drawing.Size(115, 31);
            this.TenChuXe.TabIndex = 67;
            this.TenChuXe.Text = "Nội dung:";
            // 
            // tctxtbox
            // 
            this.tctxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tctxtbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tctxtbox.Location = new System.Drawing.Point(236, 95);
            this.tctxtbox.Multiline = true;
            this.tctxtbox.Name = "tctxtbox";
            this.tctxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tctxtbox.Size = new System.Drawing.Size(360, 25);
            this.tctxtbox.TabIndex = 62;
            this.tctxtbox.TextChanged += new System.EventHandler(this.tctxtbox_TextChanged);
            // 
            // matctxtbox
            // 
            this.matctxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matctxtbox.Enabled = false;
            this.matctxtbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matctxtbox.Location = new System.Drawing.Point(236, 65);
            this.matctxtbox.Multiline = true;
            this.matctxtbox.Name = "matctxtbox";
            this.matctxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.matctxtbox.Size = new System.Drawing.Size(360, 25);
            this.matctxtbox.TabIndex = 63;
            // 
            // ndtxtbox
            // 
            this.ndtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ndtxtbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ndtxtbox.Location = new System.Drawing.Point(236, 125);
            this.ndtxtbox.Multiline = true;
            this.ndtxtbox.Name = "ndtxtbox";
            this.ndtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ndtxtbox.Size = new System.Drawing.Size(360, 25);
            this.ndtxtbox.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.VatTuPhuTung_Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 60);
            this.panel1.TabIndex = 70;
            // 
            // VatTuPhuTung_Title
            // 
            this.VatTuPhuTung_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VatTuPhuTung_Title.AutoSize = true;
            this.VatTuPhuTung_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VatTuPhuTung_Title.ForeColor = System.Drawing.Color.White;
            this.VatTuPhuTung_Title.Location = new System.Drawing.Point(115, 9);
            this.VatTuPhuTung_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            this.VatTuPhuTung_Title.Size = new System.Drawing.Size(382, 45);
            this.VatTuPhuTung_Title.TabIndex = 71;
            this.VatTuPhuTung_Title.Text = "THÊM LOẠI TIỀN CÔNG";
            // 
            // ThemTienCong
            // 
            this.AcceptButton = this.thembtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(633, 201);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thembtn);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TenChuXe);
            this.Controls.Add(this.tctxtbox);
            this.Controls.Add(this.matctxtbox);
            this.Controls.Add(this.ndtxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemTienCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại tiền công";
            this.Load += new System.EventHandler(this.ThemTienCong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button thembtn;
        private Button thoatbtn;
        private Label label7;
        private Label label8;
        private Label TenChuXe;
        private TextBox tctxtbox;
        private TextBox matctxtbox;
        private TextBox ndtxtbox;
        private Panel panel1;
        private Label VatTuPhuTung_Title;
    }
}