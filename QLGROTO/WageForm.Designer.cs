namespace QLGROTO
{
    partial class WageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PhoneSearchRadiobtn = new System.Windows.Forms.RadioButton();
            this.NameSearchRadiobtn = new System.Windows.Forms.RadioButton();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TenChuXe = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TenChuXe_Box = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(347, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH LOẠI TIỀN CÔNG";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchButton.BackColor = System.Drawing.SystemColors.Info;
            this.SearchButton.Image = global::QLGROTO.Properties.Resources.search_6699087_640__1_;
            this.SearchButton.Location = new System.Drawing.Point(792, 80);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 27);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // PhoneSearchRadiobtn
            // 
            this.PhoneSearchRadiobtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhoneSearchRadiobtn.AutoSize = true;
            this.PhoneSearchRadiobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhoneSearchRadiobtn.Location = new System.Drawing.Point(596, 113);
            this.PhoneSearchRadiobtn.Name = "PhoneSearchRadiobtn";
            this.PhoneSearchRadiobtn.Size = new System.Drawing.Size(209, 24);
            this.PhoneSearchRadiobtn.TabIndex = 10;
            this.PhoneSearchRadiobtn.TabStop = true;
            this.PhoneSearchRadiobtn.Text = "Tìm theo tên loại tiền công";
            this.PhoneSearchRadiobtn.UseVisualStyleBackColor = true;
            // 
            // NameSearchRadiobtn
            // 
            this.NameSearchRadiobtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameSearchRadiobtn.AutoSize = true;
            this.NameSearchRadiobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameSearchRadiobtn.Location = new System.Drawing.Point(381, 113);
            this.NameSearchRadiobtn.Name = "NameSearchRadiobtn";
            this.NameSearchRadiobtn.Size = new System.Drawing.Size(209, 24);
            this.NameSearchRadiobtn.TabIndex = 11;
            this.NameSearchRadiobtn.TabStop = true;
            this.NameSearchRadiobtn.Text = "Tìm theo mã loại tiền công";
            this.NameSearchRadiobtn.UseVisualStyleBackColor = true;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTextbox.Location = new System.Drawing.Point(415, 80);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(371, 27);
            this.SearchTextbox.TabIndex = 8;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchLabel.Location = new System.Drawing.Point(305, 79);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 28);
            this.SearchLabel.TabIndex = 7;
            this.SearchLabel.Text = "Tìm kiếm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 466);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã tiền công";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên tiền công";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nội dung";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Image = global::QLGROTO.Properties.Resources.recycle_310938_640;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(894, 633);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(265, 65);
            this.button11.TabIndex = 17;
            this.button11.Text = "Xoá loại tiền công";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Image = global::QLGROTO.Properties.Resources.tool_145375_640;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(616, 633);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(265, 65);
            this.button10.TabIndex = 18;
            this.button10.Text = "Sửa loại tiền công";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1065, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 31);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tên loại tiền công:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(22, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 31);
            this.label8.TabIndex = 65;
            this.label8.Text = "Mã loại tiền công:";
            // 
            // TenChuXe
            // 
            this.TenChuXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TenChuXe.AutoSize = true;
            this.TenChuXe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenChuXe.Location = new System.Drawing.Point(104, 708);
            this.TenChuXe.Name = "TenChuXe";
            this.TenChuXe.Size = new System.Drawing.Size(115, 31);
            this.TenChuXe.TabIndex = 66;
            this.TenChuXe.Text = "Nội dung:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(225, 680);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(360, 25);
            this.textBox2.TabIndex = 61;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(225, 650);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox4.Size = new System.Drawing.Size(360, 25);
            this.textBox4.TabIndex = 62;
            // 
            // TenChuXe_Box
            // 
            this.TenChuXe_Box.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TenChuXe_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenChuXe_Box.Location = new System.Drawing.Point(225, 710);
            this.TenChuXe_Box.Multiline = true;
            this.TenChuXe_Box.Name = "TenChuXe_Box";
            this.TenChuXe_Box.ReadOnly = true;
            this.TenChuXe_Box.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TenChuXe_Box.Size = new System.Drawing.Size(360, 25);
            this.TenChuXe_Box.TabIndex = 63;
            // 
            // WageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 760);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TenChuXe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TenChuXe_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PhoneSearchRadiobtn);
            this.Controls.Add(this.NameSearchRadiobtn);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.panel1);
            this.Name = "WageForm";
            this.ShowIcon = false;
            this.Text = "Danh sách loại tiền công";
            this.Load += new System.EventHandler(this.WageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button SearchButton;
        private RadioButton PhoneSearchRadiobtn;
        private RadioButton NameSearchRadiobtn;
        private TextBox SearchTextbox;
        private Label SearchLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button11;
        private Button button10;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label TenChuXe;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox TenChuXe_Box;
    }
}