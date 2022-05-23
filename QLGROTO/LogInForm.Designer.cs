namespace QLGROTO
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EscapeButton = new System.Windows.Forms.Button();
            this.LogInButtion = new System.Windows.Forms.Button();
            this.PassTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(498, 38);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "PHẦN MỀM QUẢN LÝ GARA Ô TÔ";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EscapeButton);
            this.panel1.Controls.Add(this.LogInButtion);
            this.panel1.Controls.Add(this.PassTextbox);
            this.panel1.Controls.Add(this.UsernameTextbox);
            this.panel1.Controls.Add(this.PassLabel);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 180);
            this.panel1.TabIndex = 1;
            // 
            // EscapeButton
            // 
            this.EscapeButton.Location = new System.Drawing.Point(323, 92);
            this.EscapeButton.Name = "EscapeButton";
            this.EscapeButton.Size = new System.Drawing.Size(94, 29);
            this.EscapeButton.TabIndex = 4;
            this.EscapeButton.Text = "Thoát";
            this.EscapeButton.UseVisualStyleBackColor = true;
            this.EscapeButton.Click += new System.EventHandler(this.escbtn_Click);
            // 
            // LogInButtion
            // 
            this.LogInButtion.Location = new System.Drawing.Point(72, 92);
            this.LogInButtion.Name = "LogInButtion";
            this.LogInButtion.Size = new System.Drawing.Size(94, 29);
            this.LogInButtion.TabIndex = 3;
            this.LogInButtion.Text = "Đăng nhập";
            this.LogInButtion.UseVisualStyleBackColor = true;
            this.LogInButtion.Click += new System.EventHandler(this.lginbtn_Click);
            // 
            // PassTextbox
            // 
            this.PassTextbox.Location = new System.Drawing.Point(148, 50);
            this.PassTextbox.Name = "PassTextbox";
            this.PassTextbox.Size = new System.Drawing.Size(338, 27);
            this.PassTextbox.TabIndex = 2;
            this.PassTextbox.UseSystemPasswordChar = true;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(148, 15);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(338, 27);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassLabel.Location = new System.Drawing.Point(44, 49);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(98, 25);
            this.PassLabel.TabIndex = 0;
            this.PassLabel.Text = "Mật khẩu:";
            this.PassLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(3, 14);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(143, 25);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Tên đăng nhập:";
            this.UsernameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.LogInButtion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.EscapeButton;
            this.ClientSize = new System.Drawing.Size(498, 171);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label TitleLabel;
        private Panel panel1;
        private Label UsernameLabel;
        private Button EscapeButton;
        private Button LogInButtion;
        private TextBox PassTextbox;
        private TextBox UsernameTextbox;
        private Label PassLabel;
    }
}