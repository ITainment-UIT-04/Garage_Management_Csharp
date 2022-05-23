namespace QLGROTO
{
    partial class BAOCAODOANHSOTHANG
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportDoanhSo_Title = new System.Windows.Forms.Label();
            this.dateTimeDoanhSo = new System.Windows.Forms.DateTimePicker();
            this.ExportReport_DoanhSo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 816);
            this.dataGridView1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.ReportDoanhSo_Title);
            this.panel1.Location = new System.Drawing.Point(-8, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 132);
            this.panel1.TabIndex = 36;
            // 
            // ReportDoanhSo_Title
            // 
            this.ReportDoanhSo_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportDoanhSo_Title.AutoSize = true;
            this.ReportDoanhSo_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReportDoanhSo_Title.ForeColor = System.Drawing.Color.White;
            this.ReportDoanhSo_Title.Location = new System.Drawing.Point(238, 37);
            this.ReportDoanhSo_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ReportDoanhSo_Title.Name = "ReportDoanhSo_Title";
            this.ReportDoanhSo_Title.Size = new System.Drawing.Size(768, 71);
            this.ReportDoanhSo_Title.TabIndex = 2;
            this.ReportDoanhSo_Title.Text = "BÁO CÁO DOANH SỐ THÁNG";
            // 
            // dateTimeDoanhSo
            // 
            this.dateTimeDoanhSo.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeDoanhSo.Location = new System.Drawing.Point(12, 177);
            this.dateTimeDoanhSo.Name = "dateTimeDoanhSo";
            this.dateTimeDoanhSo.Size = new System.Drawing.Size(816, 65);
            this.dateTimeDoanhSo.TabIndex = 39;
            // 
            // ExportReport_DoanhSo
            // 
            this.ExportReport_DoanhSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportReport_DoanhSo.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExportReport_DoanhSo.Location = new System.Drawing.Point(852, 163);
            this.ExportReport_DoanhSo.Name = "ExportReport_DoanhSo";
            this.ExportReport_DoanhSo.Size = new System.Drawing.Size(349, 97);
            this.ExportReport_DoanhSo.TabIndex = 38;
            this.ExportReport_DoanhSo.Text = "Xuất báo cáo";
            this.ExportReport_DoanhSo.UseVisualStyleBackColor = true;
            // 
            // BAOCAODOANHSOTHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 1119);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimeDoanhSo);
            this.Controls.Add(this.ExportReport_DoanhSo);
            this.Name = "BAOCAODOANHSOTHANG";
            this.ShowIcon = false;
            this.Text = "Báo cáo doanh số tháng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label ReportDoanhSo_Title;
        private DateTimePicker dateTimeDoanhSo;
        private Button ExportReport_DoanhSo;
    }
}