namespace QLGROTO
{
    partial class CAPNHATTILELAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAPNHATTILELAI));
            this.tilenumeric = new System.Windows.Forms.NumericUpDown();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.capnhatbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tilenumeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tilenumeric
            // 
            this.tilenumeric.DecimalPlaces = 2;
            this.tilenumeric.Location = new System.Drawing.Point(97, 60);
            this.tilenumeric.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tilenumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tilenumeric.Name = "tilenumeric";
            this.tilenumeric.Size = new System.Drawing.Size(150, 27);
            this.tilenumeric.TabIndex = 0;
            this.tilenumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // thoatbtn
            // 
            this.thoatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thoatbtn.Location = new System.Drawing.Point(234, 97);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(94, 29);
            this.thoatbtn.TabIndex = 2;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.thoatbtn_Click);
            // 
            // capnhatbtn
            // 
            this.capnhatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.capnhatbtn.Location = new System.Drawing.Point(134, 97);
            this.capnhatbtn.Name = "capnhatbtn";
            this.capnhatbtn.Size = new System.Drawing.Size(94, 29);
            this.capnhatbtn.TabIndex = 1;
            this.capnhatbtn.Text = "Cập nhật";
            this.capnhatbtn.UseVisualStyleBackColor = true;
            this.capnhatbtn.Click += new System.EventHandler(this.capnhatbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(96, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "TỈ LỆ LÃI";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 54);
            this.panel1.TabIndex = 3;
            // 
            // CAPNHATTILELAI
            // 
            this.AcceptButton = this.capnhatbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton = this.thoatbtn;
            this.ClientSize = new System.Drawing.Size(340, 138);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.capnhatbtn);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.tilenumeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CAPNHATTILELAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cập nhật tỉ lệ lãi";
            ((System.ComponentModel.ISupportInitialize)(this.tilenumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown tilenumeric;
        private Button thoatbtn;
        private Button capnhatbtn;
        private Label label1;
        private Panel panel1;
    }
}