namespace QLGROTO
{
    partial class DOIMATKHAU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOIMATKHAU));
            this.panel2 = new System.Windows.Forms.Panel();
            this.doibtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.nhaplaitxtbox = new System.Windows.Forms.TextBox();
            this.mkmtxtbox = new System.Windows.Forms.TextBox();
            this.mkctxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.doibtn);
            this.panel2.Controls.Add(this.thoatbtn);
            this.panel2.Controls.Add(this.nhaplaitxtbox);
            this.panel2.Controls.Add(this.mkmtxtbox);
            this.panel2.Controls.Add(this.mkctxtbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // doibtn
            // 
            resources.ApplyResources(this.doibtn, "doibtn");
            this.doibtn.Name = "doibtn";
            this.doibtn.UseVisualStyleBackColor = true;
            this.doibtn.Click += new System.EventHandler(this.chgbtn_Click);
            // 
            // thoatbtn
            // 
            resources.ApplyResources(this.thoatbtn, "thoatbtn");
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.escbtn_Click);
            // 
            // nhaplaitxtbox
            // 
            resources.ApplyResources(this.nhaplaitxtbox, "nhaplaitxtbox");
            this.nhaplaitxtbox.Name = "nhaplaitxtbox";
            this.nhaplaitxtbox.UseSystemPasswordChar = true;
            // 
            // mkmtxtbox
            // 
            resources.ApplyResources(this.mkmtxtbox, "mkmtxtbox");
            this.mkmtxtbox.Name = "mkmtxtbox";
            this.mkmtxtbox.UseSystemPasswordChar = true;
            // 
            // mkctxtbox
            // 
            resources.ApplyResources(this.mkctxtbox, "mkctxtbox");
            this.mkctxtbox.Name = "mkctxtbox";
            this.mkctxtbox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // DOIMATKHAU
            // 
            this.AcceptButton = this.doibtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.thoatbtn;
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "DOIMATKHAU";
            this.Load += new System.EventHandler(this.DOIMATKHAU_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private TextBox mkmtxtbox;
        private TextBox mkctxtbox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nhaplaitxtbox;
        private Button doibtn;
        private Button thoatbtn;
    }
}