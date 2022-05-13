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
            this.escbtn = new System.Windows.Forms.Button();
            this.pschgbtn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.escbtn);
            this.panel2.Controls.Add(this.pschgbtn);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // escbtn
            // 
            resources.ApplyResources(this.escbtn, "escbtn");
            this.escbtn.Name = "escbtn";
            this.escbtn.UseVisualStyleBackColor = true;
            // 
            // pschgbtn
            // 
            resources.ApplyResources(this.pschgbtn, "pschgbtn");
            this.pschgbtn.Name = "pschgbtn";
            this.pschgbtn.UseVisualStyleBackColor = true;
            this.pschgbtn.Click += new System.EventHandler(this.pschgbtn_Click);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.UseSystemPasswordChar = true;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.UseSystemPasswordChar = true;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.UseSystemPasswordChar = true;
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
            this.AcceptButton = this.escbtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.pschgbtn;
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "PassChangeForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Button escbtn;
        private Button pschgbtn;
    }
}