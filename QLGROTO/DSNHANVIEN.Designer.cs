namespace QLGROTO
{
    partial class DSNHANVIEN
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DS_NhanVien_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NV_BoxSearch = new System.Windows.Forms.TextBox();
            this.Bt_DeleteNV = new System.Windows.Forms.Button();
            this.Group_EditNV = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhieuSuaChua_Title = new System.Windows.Forms.Label();
            this.Bt_EditNV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_AddNV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TenChuXe = new System.Windows.Forms.Label();
            this.DiaChi_Text = new System.Windows.Forms.TextBox();
            this.HoTen_Text = new System.Windows.Forms.TextBox();
            this.DienThoai_Text = new System.Windows.Forms.TextBox();
            this.ChucVu_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Group_EditNV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // DS_NhanVien_Label
            // 
            this.DS_NhanVien_Label.AutoSize = true;
            this.DS_NhanVien_Label.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DS_NhanVien_Label.Location = new System.Drawing.Point(14, 156);
            this.DS_NhanVien_Label.Name = "DS_NhanVien_Label";
            this.DS_NhanVien_Label.Size = new System.Drawing.Size(316, 59);
            this.DS_NhanVien_Label.TabIndex = 1;
            this.DS_NhanVien_Label.Text = "Bảng nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 745);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm:";
            // 
            // NV_BoxSearch
            // 
            this.NV_BoxSearch.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NV_BoxSearch.Location = new System.Drawing.Point(227, 745);
            this.NV_BoxSearch.Name = "NV_BoxSearch";
            this.NV_BoxSearch.Size = new System.Drawing.Size(734, 65);
            this.NV_BoxSearch.TabIndex = 3;
            // 
            // Bt_DeleteNV
            // 
            this.Bt_DeleteNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Bt_DeleteNV.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bt_DeleteNV.Location = new System.Drawing.Point(726, 424);
            this.Bt_DeleteNV.Name = "Bt_DeleteNV";
            this.Bt_DeleteNV.Size = new System.Drawing.Size(203, 67);
            this.Bt_DeleteNV.TabIndex = 4;
            this.Bt_DeleteNV.Text = "Xóa";
            this.Bt_DeleteNV.UseVisualStyleBackColor = false;
            // 
            // Group_EditNV
            // 
            this.Group_EditNV.Controls.Add(this.Bt_EditNV);
            this.Group_EditNV.Controls.Add(this.Bt_DeleteNV);
            this.Group_EditNV.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Group_EditNV.Location = new System.Drawing.Point(14, 816);
            this.Group_EditNV.Name = "Group_EditNV";
            this.Group_EditNV.Size = new System.Drawing.Size(947, 510);
            this.Group_EditNV.TabIndex = 5;
            this.Group_EditNV.TabStop = false;
            this.Group_EditNV.Text = "Thông tin nhân viên";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.PhieuSuaChua_Title);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 137);
            this.panel1.TabIndex = 6;
            // 
            // PhieuSuaChua_Title
            // 
            this.PhieuSuaChua_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhieuSuaChua_Title.AutoSize = true;
            this.PhieuSuaChua_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhieuSuaChua_Title.ForeColor = System.Drawing.Color.White;
            this.PhieuSuaChua_Title.Location = new System.Drawing.Point(659, 33);
            this.PhieuSuaChua_Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PhieuSuaChua_Title.Name = "PhieuSuaChua_Title";
            this.PhieuSuaChua_Title.Size = new System.Drawing.Size(658, 71);
            this.PhieuSuaChua_Title.TabIndex = 0;
            this.PhieuSuaChua_Title.Text = "DANH SÁCH NHÂN VIÊN";
            this.PhieuSuaChua_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_EditNV
            // 
            this.Bt_EditNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Bt_EditNV.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bt_EditNV.Location = new System.Drawing.Point(500, 424);
            this.Bt_EditNV.Name = "Bt_EditNV";
            this.Bt_EditNV.Size = new System.Drawing.Size(203, 67);
            this.Bt_EditNV.TabIndex = 5;
            this.Bt_EditNV.Text = "Sửa";
            this.Bt_EditNV.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChucVu_Text);
            this.groupBox1.Controls.Add(this.DienThoai_Text);
            this.groupBox1.Controls.Add(this.HoTen_Text);
            this.groupBox1.Controls.Add(this.DiaChi_Text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TenChuXe);
            this.groupBox1.Controls.Add(this.Bt_AddNV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(991, 745);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 581);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // Bt_AddNV
            // 
            this.Bt_AddNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Bt_AddNV.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bt_AddNV.Location = new System.Drawing.Point(738, 495);
            this.Bt_AddNV.Name = "Bt_AddNV";
            this.Bt_AddNV.Size = new System.Drawing.Size(203, 67);
            this.Bt_AddNV.TabIndex = 4;
            this.Bt_AddNV.Text = "Thêm ";
            this.Bt_AddNV.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 50);
            this.label3.TabIndex = 23;
            this.label3.Text = "Chức vụ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 50);
            this.label2.TabIndex = 24;
            this.label2.Text = "Điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 50);
            this.label4.TabIndex = 25;
            this.label4.Text = "Địa chỉ:";
            // 
            // TenChuXe
            // 
            this.TenChuXe.AutoSize = true;
            this.TenChuXe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenChuXe.Location = new System.Drawing.Point(69, 100);
            this.TenChuXe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TenChuXe.Name = "TenChuXe";
            this.TenChuXe.Size = new System.Drawing.Size(188, 50);
            this.TenChuXe.TabIndex = 26;
            this.TenChuXe.Text = "Họ và tên:";
            // 
            // DiaChi_Text
            // 
            this.DiaChi_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiaChi_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DiaChi_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiaChi_Text.Location = new System.Drawing.Point(293, 197);
            this.DiaChi_Text.Margin = new System.Windows.Forms.Padding(5);
            this.DiaChi_Text.Multiline = true;
            this.DiaChi_Text.Name = "DiaChi_Text";
            this.DiaChi_Text.ReadOnly = true;
            this.DiaChi_Text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DiaChi_Text.Size = new System.Drawing.Size(619, 68);
            this.DiaChi_Text.TabIndex = 27;
            // 
            // HoTen_Text
            // 
            this.HoTen_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HoTen_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HoTen_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoTen_Text.Location = new System.Drawing.Point(293, 96);
            this.HoTen_Text.Margin = new System.Windows.Forms.Padding(5);
            this.HoTen_Text.Multiline = true;
            this.HoTen_Text.Name = "HoTen_Text";
            this.HoTen_Text.ReadOnly = true;
            this.HoTen_Text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.HoTen_Text.Size = new System.Drawing.Size(619, 68);
            this.HoTen_Text.TabIndex = 28;
            // 
            // DienThoai_Text
            // 
            this.DienThoai_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DienThoai_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DienThoai_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DienThoai_Text.Location = new System.Drawing.Point(293, 292);
            this.DienThoai_Text.Margin = new System.Windows.Forms.Padding(5);
            this.DienThoai_Text.Multiline = true;
            this.DienThoai_Text.Name = "DienThoai_Text";
            this.DienThoai_Text.ReadOnly = true;
            this.DienThoai_Text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DienThoai_Text.Size = new System.Drawing.Size(619, 68);
            this.DienThoai_Text.TabIndex = 29;
            // 
            // ChucVu_Text
            // 
            this.ChucVu_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChucVu_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChucVu_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChucVu_Text.Location = new System.Drawing.Point(293, 392);
            this.ChucVu_Text.Margin = new System.Windows.Forms.Padding(5);
            this.ChucVu_Text.Multiline = true;
            this.ChucVu_Text.Name = "ChucVu_Text";
            this.ChucVu_Text.ReadOnly = true;
            this.ChucVu_Text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ChucVu_Text.Size = new System.Drawing.Size(619, 68);
            this.ChucVu_Text.TabIndex = 30;
            // 
            // DSNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1952, 1338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Group_EditNV);
            this.Controls.Add(this.NV_BoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DS_NhanVien_Label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DSNHANVIEN";
            this.ShowIcon = false;
            this.Text = "Danh sách nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Group_EditNV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label DS_NhanVien_Label;
        private Label label1;
        private TextBox NV_BoxSearch;
        private Button Bt_DeleteNV;
        private GroupBox Group_EditNV;
        private Panel panel1;
        private Label PhieuSuaChua_Title;
        private Button Bt_EditNV;
        private GroupBox groupBox1;
        private Button Bt_AddNV;
        private TextBox ChucVu_Text;
        private TextBox DienThoai_Text;
        private TextBox HoTen_Text;
        private TextBox DiaChi_Text;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label TenChuXe;
    }
}