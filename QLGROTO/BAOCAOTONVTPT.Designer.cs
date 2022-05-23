namespace QLGROTO
{
    partial class BAOCAOTONVTPT
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
            this.ReportTonVTPT_Title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExportReport_TonVTPT = new System.Windows.Forms.Button();
            this.dateTimeTonVTPT = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.ReportTonVTPT_Title);
            this.panel1.Location = new System.Drawing.Point(18, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 109);
            this.panel1.TabIndex = 2;
            // 
            // ReportTonVTPT_Title
            // 
            this.ReportTonVTPT_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportTonVTPT_Title.AutoSize = true;
            this.ReportTonVTPT_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReportTonVTPT_Title.ForeColor = System.Drawing.Color.White;
            this.ReportTonVTPT_Title.Location = new System.Drawing.Point(189, 22);
            this.ReportTonVTPT_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ReportTonVTPT_Title.Name = "ReportTonVTPT_Title";
            this.ReportTonVTPT_Title.Size = new System.Drawing.Size(891, 71);
            this.ReportTonVTPT_Title.TabIndex = 2;
            this.ReportTonVTPT_Title.Text = "BÁO CÁO TỒN VẬT TƯ PHỤ TÙNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 685);
            this.dataGridView1.TabIndex = 3;
            // 
            // ExportReport_TonVTPT
            // 
            this.ExportReport_TonVTPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportReport_TonVTPT.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExportReport_TonVTPT.Location = new System.Drawing.Point(891, 157);
            this.ExportReport_TonVTPT.Name = "ExportReport_TonVTPT";
            this.ExportReport_TonVTPT.Size = new System.Drawing.Size(349, 97);
            this.ExportReport_TonVTPT.TabIndex = 4;
            this.ExportReport_TonVTPT.Text = "Xuất báo cáo";
            this.ExportReport_TonVTPT.UseVisualStyleBackColor = true;
            this.ExportReport_TonVTPT.Click += new System.EventHandler(this.ExportReport_TonVTPT_Click);
            // 
            // dateTimeTonVTPT
            // 
            this.dateTimeTonVTPT.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeTonVTPT.Location = new System.Drawing.Point(18, 171);
            this.dateTimeTonVTPT.Name = "dateTimeTonVTPT";
            this.dateTimeTonVTPT.Size = new System.Drawing.Size(837, 65);
            this.dateTimeTonVTPT.TabIndex = 35;
            // 
            // BAOCAOTONVTPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 1019);
            this.Controls.Add(this.dateTimeTonVTPT);
            this.Controls.Add(this.ExportReport_TonVTPT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "BAOCAOTONVTPT";
            this.ShowIcon = false;
            this.Text = "BAOCAOTONVTPT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label ReportTonVTPT_Title;
        private DataGridView dataGridView1;
        private Button ExportReport_TonVTPT;
        private DateTimePicker dateTimeTonVTPT;
    }
}