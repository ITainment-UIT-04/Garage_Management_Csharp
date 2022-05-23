namespace QLGROTO
{
    partial class PassChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassChangeForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Thoat_Button = new System.Windows.Forms.Button();
            this.DoiMatKhau_Button = new System.Windows.Forms.Button();
            this.NhapLaiMatKhauMoi_Textbox = new System.Windows.Forms.TextBox();
            this.MatKhauMoi_Textbox = new System.Windows.Forms.TextBox();
            this.MatKhauCu_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Thoat_Button);
            this.panel2.Controls.Add(this.DoiMatKhau_Button);
            this.panel2.Controls.Add(this.NhapLaiMatKhauMoi_Textbox);
            this.panel2.Controls.Add(this.MatKhauMoi_Textbox);
            this.panel2.Controls.Add(this.MatKhauCu_Textbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Thoat_Button
            // 
            resources.ApplyResources(this.Thoat_Button, "Thoat_Button");
            this.Thoat_Button.Name = "Thoat_Button";
            this.Thoat_Button.UseVisualStyleBackColor = true;
            // 
            // DoiMatKhau_Button
            // 
            resources.ApplyResources(this.DoiMatKhau_Button, "DoiMatKhau_Button");
            this.DoiMatKhau_Button.Name = "DoiMatKhau_Button";
            this.DoiMatKhau_Button.UseVisualStyleBackColor = true;
            this.DoiMatKhau_Button.Click += new System.EventHandler(this.pschgbtn_Click);
            // 
            // NhapLaiMatKhauMoi_Textbox
            // 
            resources.ApplyResources(this.NhapLaiMatKhauMoi_Textbox, "NhapLaiMatKhauMoi_Textbox");
            this.NhapLaiMatKhauMoi_Textbox.Name = "NhapLaiMatKhauMoi_Textbox";
            this.NhapLaiMatKhauMoi_Textbox.UseSystemPasswordChar = true;
            this.NhapLaiMatKhauMoi_Textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // MatKhauMoi_Textbox
            // 
            resources.ApplyResources(this.MatKhauMoi_Textbox, "MatKhauMoi_Textbox");
            this.MatKhauMoi_Textbox.Name = "MatKhauMoi_Textbox";
            this.MatKhauMoi_Textbox.UseSystemPasswordChar = true;
            this.MatKhauMoi_Textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // MatKhauCu_Textbox
            // 
            resources.ApplyResources(this.MatKhauCu_Textbox, "MatKhauCu_Textbox");
            this.MatKhauCu_Textbox.Name = "MatKhauCu_Textbox";
            this.MatKhauCu_Textbox.UseSystemPasswordChar = true;
            this.MatKhauCu_Textbox.TextChanged += new System.EventHandler(this.tbMatKhauCu_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassChangeForm
            // 
            this.AcceptButton = this.Thoat_Button;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.DoiMatKhau_Button;
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "PassChangeForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private TextBox MatKhauMoi_Textbox;
        private TextBox MatKhauCu_Textbox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NhapLaiMatKhauMoi_Textbox;
        private Button Thoat_Button;
        private Button DoiMatKhau_Button;
    }
}