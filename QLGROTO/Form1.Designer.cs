namespace QLGROTO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.escbtn = new System.Windows.Forms.Button();
            this.lginbtn = new System.Windows.Forms.Button();
            this.MatKhau_TextBox = new System.Windows.Forms.TextBox();
            this.Ten_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ GARA Ô TÔ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.escbtn);
            this.panel1.Controls.Add(this.lginbtn);
            this.panel1.Controls.Add(this.MatKhau_TextBox);
            this.panel1.Controls.Add(this.Ten_TextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 180);
            this.panel1.TabIndex = 1;
            // 
            // escbtn
            // 
            this.escbtn.Location = new System.Drawing.Point(323, 92);
            this.escbtn.Name = "escbtn";
            this.escbtn.Size = new System.Drawing.Size(94, 29);
            this.escbtn.TabIndex = 4;
            this.escbtn.Text = "Thoát";
            this.escbtn.UseVisualStyleBackColor = true;
            this.escbtn.Click += new System.EventHandler(this.escbtn_Click);
            // 
            // lginbtn
            // 
            this.lginbtn.Location = new System.Drawing.Point(72, 92);
            this.lginbtn.Name = "lginbtn";
            this.lginbtn.Size = new System.Drawing.Size(94, 29);
            this.lginbtn.TabIndex = 3;
            this.lginbtn.Text = "Đăng nhập";
            this.lginbtn.UseVisualStyleBackColor = true;
            this.lginbtn.Click += new System.EventHandler(this.lginbtn_Click);
            // 
            // MatKhau_TextBox
            // 
            this.MatKhau_TextBox.Location = new System.Drawing.Point(148, 50);
            this.MatKhau_TextBox.Name = "MatKhau_TextBox";
            this.MatKhau_TextBox.Size = new System.Drawing.Size(338, 27);
            this.MatKhau_TextBox.TabIndex = 2;
            this.MatKhau_TextBox.UseSystemPasswordChar = true;
            // 
            // Ten_TextBox
            // 
            this.Ten_TextBox.Location = new System.Drawing.Point(148, 15);
            this.Ten_TextBox.Name = "Ten_TextBox";
            this.Ten_TextBox.Size = new System.Drawing.Size(338, 27);
            this.Ten_TextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.lginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.escbtn;
            this.ClientSize = new System.Drawing.Size(498, 171);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button escbtn;
        private Button lginbtn;
        private TextBox MatKhau_TextBox;
        private TextBox Ten_TextBox;
        private Label label3;
    }
}