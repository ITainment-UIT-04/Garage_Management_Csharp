namespace UI
{
    partial class BAOCAOTON
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BaoCaoTon_Title = new System.Windows.Forms.Label();
            this.Review_Report = new System.Windows.Forms.Button();
            this.Print_Report = new System.Windows.Forms.Button();
            this.Group1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(356, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.BaoCaoTon_Title);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 71);
            this.panel1.TabIndex = 1;
            // 
            // BaoCaoTon_Title
            // 
            this.BaoCaoTon_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaoCaoTon_Title.AutoSize = true;
            this.BaoCaoTon_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoTon_Title.ForeColor = System.Drawing.Color.White;
            this.BaoCaoTon_Title.Location = new System.Drawing.Point(295, 22);
            this.BaoCaoTon_Title.Name = "BaoCaoTon_Title";
            this.BaoCaoTon_Title.Size = new System.Drawing.Size(213, 31);
            this.BaoCaoTon_Title.TabIndex = 0;
            this.BaoCaoTon_Title.Text = "BÁO CÁO TỒN";
            // 
            // Review_Report
            // 
            this.Review_Report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Review_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Review_Report.Location = new System.Drawing.Point(463, 112);
            this.Review_Report.Name = "Review_Report";
            this.Review_Report.Size = new System.Drawing.Size(156, 47);
            this.Review_Report.TabIndex = 2;
            this.Review_Report.Text = "Hiện báo cáo";
            this.Review_Report.UseVisualStyleBackColor = true;
            // 
            // Print_Report
            // 
            this.Print_Report.AllowDrop = true;
            this.Print_Report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Report.Location = new System.Drawing.Point(640, 112);
            this.Print_Report.Name = "Print_Report";
            this.Print_Report.Size = new System.Drawing.Size(156, 47);
            this.Print_Report.TabIndex = 3;
            this.Print_Report.Text = "In Báo Cáo";
            this.Print_Report.UseVisualStyleBackColor = true;
            // 
            // Group1
            // 
            this.Group1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group1.Location = new System.Drawing.Point(26, 89);
            this.Group1.Name = "Group1";
            this.Group1.Size = new System.Drawing.Size(783, 92);
            this.Group1.TabIndex = 4;
            this.Group1.TabStop = false;
            this.Group1.Text = "Báo cáo tháng, năm";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(26, 206);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(783, 344);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Chi tiết báo cáo";
            // 
            // BAOCAOTON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 574);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Print_Report);
            this.Controls.Add(this.Review_Report);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Group1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BAOCAOTON";
            this.Text = "BAOCAOTON";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BaoCaoTon_Title;
        private System.Windows.Forms.Button Review_Report;
        private System.Windows.Forms.Button Print_Report;
        private System.Windows.Forms.GroupBox Group1;
        private System.Windows.Forms.GroupBox GroupBox2;
    }
}