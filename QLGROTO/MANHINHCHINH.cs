using ClosedXML.Excel;
using QLGROTO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGROTO
{
    public partial class MANHINHCHINH : Form
    {
        int flag;
        public string tendangnhap { get; set; }

        public MANHINHCHINH()
        {
           
            InitializeComponent();
            xedtgrid.Columns["BienSo"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["TenChuXe"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["HieuXe"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["DiaChi"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["DienThoai"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["Email"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["TienNo"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["NgayTiepNhan"].DefaultCellStyle.ForeColor = Color.Black;
            HienThi();
            
        }
        public void HienThi()
        {
            DataTable dt = XEDAO.Instance.HienThi();
            xedtgrid.DataSource = dt;
        }
        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THONGTINPM aboutForm = new THONGTINPM();
            aboutForm.ShowDialog(); 
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LIENHE contactForm = new LIENHE();
            contactForm.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THONGTINADMIN t = new THONGTINADMIN();

            t.tendangnhap = tendangnhap;      

            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = NHANVIENDAO.Instance.HienThiThongTin(tendangnhap);
            if (dr.Read())
                dangsudungtxtbox.Text = dr["TenNV"].ToString();

            
            
            

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TIEPNHANXE t = new TIEPNHANXE();
            t.ShowDialog();
            HienThi();
           
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            PHIEUSUACHUA repairForm = new PHIEUSUACHUA();   
            repairForm.ShowDialog();
            HienThi();
        }


       

        

        private void button10_Click(object sender, EventArgs e)
        {
            if (xedtgrid.Rows.Count == 0)
                MessageBox.Show("Không có xe để cập nhật!");
            else
            {
                SUATHONGTINXE changeForm = new SUATHONGTINXE();
                changeForm.bienso = biensotxtbox.Text;
                changeForm.ten = tentxtbox.Text;
                changeForm.hieuxe = hieuxetxtbox.Text;
                changeForm.diachi = diachitxtbox.Text;
                changeForm.dth = dthtxtbox.Text;
                changeForm.email = emailtxtbox.Text;
                changeForm.no = notxtbox.Text;
                changeForm.ngay = ngaydtpicker.Value;
                changeForm.ShowDialog();
                HienThi();
            }
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchVậtTưPhụTùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchPhiếuNhậtKhoVTPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSPNKVTPT dSPHIEUNHAPKHO = new DSPNKVTPT();
            dSPHIEUNHAPKHO.ShowDialog();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchVậtTưPhụTùngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DSVTPT a = new DSVTPT();
            a.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string bienso = biensotxtbox.Text;
            if (xedtgrid.Rows.Count == 0)
                MessageBox.Show("Không có xe để xóa");
            else
            {
                if (XEDAO.Instance.XoaXe(bienso))
                {

                    HienThi();
                    biensotxtbox.Clear();
                    tentxtbox.Clear();
                    dthtxtbox.Clear();
                    diachitxtbox.Clear();
                    emailtxtbox.Clear();
                    hieuxetxtbox.Clear();
                    notxtbox.Clear();
                }
                else
                    MessageBox.Show("Không thể xóa xe!");
            }
        }

        private void cậpNhậtTỉLệLãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAPNHATTILELAI interestRateForm = new CAPNHATTILELAI();
            interestRateForm.ShowDialog();
        }

        private void thayĐổiSốXeSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAPNHATSOXE maxCarForm = new CAPNHATSOXE();
            maxCarForm.ShowDialog();
        }

        private void danhSáchLoạiTiềnCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSTIENCONG wageForm = new DSTIENCONG();
            wageForm.ShowDialog();
        }

        private void danhSáchHiệuXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSHIEUXE brandForm = new DSHIEUXE();
            brandForm.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSNHANVIEN dSNHANVIEN = new DSNHANVIEN();
            dSNHANVIEN.ShowDialog();
        }

        private void báoCáoTồnVậtTưPhụTùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAOCAOTON bAOCAOTON = new BAOCAOTON();
            bAOCAOTON.ShowDialog();
        }

        private void báoCáoDoanhSốThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAOCAODOANHSO b = new BAOCAODOANHSO();
            b.ShowDialog();
        }

        private void danhSáchLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSPHIEUSUACHUA dSPHIEUSUACHUA = new DSPHIEUSUACHUA();
            dSPHIEUSUACHUA.ShowDialog();
        }

        private void danhSáchPhiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSPHIEUTHUTIEN dSPHIEUTHUTIEN = new DSPHIEUTHUTIEN();
            dSPHIEUTHUTIEN.ShowDialog();
        }

       

        private void xedtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameSearchRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
           
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void sdttimradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
          
        }

        private void biensotimradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 3;
            
        }

        private void xedtgrid_SelectionChanged_1(object sender, EventArgs e)
        {
            biensotxtbox.DataBindings.Clear();
            biensotxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "BienSo");
            tentxtbox.DataBindings.Clear();
            tentxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "TenChuXe");
            hieuxetxtbox.DataBindings.Clear();
            hieuxetxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "HieuXe");
            diachitxtbox.DataBindings.Clear();
            diachitxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "DiaChi");
            dthtxtbox.DataBindings.Clear();
            dthtxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "DienThoai");
            emailtxtbox.DataBindings.Clear();
            emailtxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "Email");
            notxtbox.DataBindings.Clear();
            notxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "TienNo");
            ngaydtpicker.DataBindings.Clear();
            ngaydtpicker.DataBindings.Add("Value", xedtgrid.DataSource, "NgayTiepNhan");
        }

        private void lapphieuvtptbtn_Click(object sender, EventArgs e)
        {
            PHIEUNHAPVTPT p = new PHIEUNHAPVTPT();
            p.ShowDialog();
        }

        private void timkiembtn_Click(object sender, EventArgs e)
        {
            string s = timtxtbox.Text;
            if (!string.IsNullOrEmpty(s))
            {
                if (flag == 1)
                    xedtgrid.DataSource = XEDAO.Instance.TimKiemTheoTen(s);
                else if (flag == 2)
                    xedtgrid.DataSource = XEDAO.Instance.TimKiemTheoSDT(s);
                else if (flag == 3)
                    xedtgrid.DataSource = XEDAO.Instance.TimKiemTheoBienSo(s);
            }
            else
                HienThi();
        }

        private void xuatbtn_Click(object sender, EventArgs e)
        {
            if (xedtgrid.Rows.Count == 0)
                MessageBox.Show("Không có thông tin để xuất");
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(xedtgrid.DataSource as DataTable, "Xe");

                                workbook.SaveAs(saveFileDialog.FileName);


                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xuất file không thành công!");
                        }
                    }
                }
            }
        }

        private void thutienbtn_Click(object sender, EventArgs e)
        {
            PHIEUTHUTIEN t = new PHIEUTHUTIEN();
            t.ShowDialog();
            HienThi();
        }

        private void dangxuatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (NHANVIENDAO.Instance.flag != 1)
                MessageBox.Show("Phải là quản lý mới có quyền truy cập!");
            else
            {
                THONGTINADMIN t = new THONGTINADMIN();
                t.tendangnhap = tendangnhap;
                t.ShowDialog();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (NHANVIENDAO.Instance.flag != 1)
                MessageBox.Show("Phải là quản lý mới có quyền truy cập!");
            else
            {
                DSNHANVIEN t = new DSNHANVIEN();
                t.ShowDialog();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dangsudungtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void xedtgrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void biensotxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hieuxetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dthtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void notxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void diachitxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
