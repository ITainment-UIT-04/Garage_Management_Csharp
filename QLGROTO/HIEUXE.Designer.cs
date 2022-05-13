namespace UI
{
    partial class HIEUXE
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
            this.QuanLyHieuXe_Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HieuXe_Label = new System.Windows.Forms.Label();
            this.HieuXe_SettingGr = new System.Windows.Forms.GroupBox();
            this.DeleteHieuXe_Button = new System.Windows.Forms.Button();
            this.AddHieuXe_button = new System.Windows.Forms.Button();
            this.HieuXe_DanhSachGr = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HieuXe_SettingGr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.QuanLyHieuXe_Title);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 85);
            this.panel1.TabIndex = 0;
            // 
            // QuanLyHieuXe_Title
            // 
            this.QuanLyHieuXe_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuanLyHieuXe_Title.AutoSize = true;
            this.QuanLyHieuXe_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuanLyHieuXe_Title.Location = new System.Drawing.Point(200, 18);
            this.QuanLyHieuXe_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuanLyHieuXe_Title.Name = "QuanLyHieuXe_Title";
            this.QuanLyHieuXe_Title.Size = new System.Drawing.Size(268, 39);
            this.QuanLyHieuXe_Title.TabIndex = 0;
            this.QuanLyHieuXe_Title.Text = "Quản lý hiệu xe";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.HieuXe_Label);
            this.panel2.Location = new System.Drawing.Point(16, 131);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 154);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(141, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(234, 30);
            this.textBox1.TabIndex = 1;
            // 
            // HieuXe_Label
            // 
            this.HieuXe_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HieuXe_Label.AutoSize = true;
            this.HieuXe_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HieuXe_Label.Location = new System.Drawing.Point(25, 62);
            this.HieuXe_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HieuXe_Label.Name = "HieuXe_Label";
            this.HieuXe_Label.Size = new System.Drawing.Size(100, 29);
            this.HieuXe_Label.TabIndex = 0;
            this.HieuXe_Label.Text = "Hiệu xe:";
            // 
            // HieuXe_SettingGr
            // 
            this.HieuXe_SettingGr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HieuXe_SettingGr.Controls.Add(this.DeleteHieuXe_Button);
            this.HieuXe_SettingGr.Controls.Add(this.AddHieuXe_button);
            this.HieuXe_SettingGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HieuXe_SettingGr.Location = new System.Drawing.Point(431, 120);
            this.HieuXe_SettingGr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HieuXe_SettingGr.Name = "HieuXe_SettingGr";
            this.HieuXe_SettingGr.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HieuXe_SettingGr.Size = new System.Drawing.Size(267, 166);
            this.HieuXe_SettingGr.TabIndex = 2;
            this.HieuXe_SettingGr.TabStop = false;
            this.HieuXe_SettingGr.Text = "Tùy chỉnh";
            // 
            // DeleteHieuXe_Button
            // 
            this.DeleteHieuXe_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteHieuXe_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteHieuXe_Button.Location = new System.Drawing.Point(8, 103);
            this.DeleteHieuXe_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteHieuXe_Button.Name = "DeleteHieuXe_Button";
            this.DeleteHieuXe_Button.Size = new System.Drawing.Size(251, 48);
            this.DeleteHieuXe_Button.TabIndex = 1;
            this.DeleteHieuXe_Button.Text = "Xóa hiệu xe";
            this.DeleteHieuXe_Button.UseVisualStyleBackColor = false;
            // 
            // AddHieuXe_button
            // 
            this.AddHieuXe_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHieuXe_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddHieuXe_button.Location = new System.Drawing.Point(8, 45);
            this.AddHieuXe_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddHieuXe_button.Name = "AddHieuXe_button";
            this.AddHieuXe_button.Size = new System.Drawing.Size(251, 48);
            this.AddHieuXe_button.TabIndex = 0;
            this.AddHieuXe_button.Text = "Thêm hiệu xe";
            this.AddHieuXe_button.UseVisualStyleBackColor = false;
            // 
            // HieuXe_DanhSachGr
            // 
            this.HieuXe_DanhSachGr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HieuXe_DanhSachGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HieuXe_DanhSachGr.Location = new System.Drawing.Point(16, 295);
            this.HieuXe_DanhSachGr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HieuXe_DanhSachGr.Name = "HieuXe_DanhSachGr";
            this.HieuXe_DanhSachGr.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HieuXe_DanhSachGr.Size = new System.Drawing.Size(681, 465);
            this.HieuXe_DanhSachGr.TabIndex = 3;
            this.HieuXe_DanhSachGr.TabStop = false;
            this.HieuXe_DanhSachGr.Text = "Danh sách";
            // 
            // HIEUXE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 778);
            this.Controls.Add(this.HieuXe_DanhSachGr);
            this.Controls.Add(this.HieuXe_SettingGr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HIEUXE";
            this.ShowIcon = false;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HieuXe_SettingGr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QuanLyHieuXe_Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label HieuXe_Label;
        private System.Windows.Forms.GroupBox HieuXe_SettingGr;
        private System.Windows.Forms.GroupBox HieuXe_DanhSachGr;
        private System.Windows.Forms.Button DeleteHieuXe_Button;
        private System.Windows.Forms.Button AddHieuXe_button;
    }
}