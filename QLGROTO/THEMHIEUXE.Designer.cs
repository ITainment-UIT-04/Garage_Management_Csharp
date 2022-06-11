namespace QLGROTO
{
    partial class THEMHIEUXE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THEMHIEUXE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.thembtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.themtxtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(135, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÊM HIỆU XE";
            // 
            // thembtn
            // 
            this.thembtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thembtn.Location = new System.Drawing.Point(335, 105);
            this.thembtn.Name = "thembtn";
            this.thembtn.Size = new System.Drawing.Size(94, 29);
            this.thembtn.TabIndex = 62;
            this.thembtn.Text = "Thêm";
            this.thembtn.UseVisualStyleBackColor = true;
            this.thembtn.Click += new System.EventHandler(this.thembtn_Click);
            // 
            // thoatbtn
            // 
            this.thoatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatbtn.Location = new System.Drawing.Point(435, 105);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 63;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.thoatbtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 31);
            this.label8.TabIndex = 68;
            this.label8.Text = "Hiệu xe:";
            // 
            // themtxtbox
            // 
            this.themtxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.themtxtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.themtxtbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themtxtbox.Location = new System.Drawing.Point(136, 70);
            this.themtxtbox.Multiline = true;
            this.themtxtbox.Name = "themtxtbox";
            this.themtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.themtxtbox.Size = new System.Drawing.Size(360, 25);
            this.themtxtbox.TabIndex = 67;
            // 
            // THEMHIEUXE
            // 
            this.AcceptButton = this.thembtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(541, 146);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.themtxtbox);
            this.Controls.Add(this.thembtn);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "THEMHIEUXE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hiệu xe";
            this.Load += new System.EventHandler(this.ThemHieuXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button thembtn;
        private Button thoatbtn;
        private Label label8;
        private TextBox themtxtbox;
    }
}