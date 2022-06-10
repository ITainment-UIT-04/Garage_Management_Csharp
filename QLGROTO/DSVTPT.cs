using ClosedXML.Excel;
using QLGROTO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGROTO
{
    public partial class DSVTPT : Form
    {
        int flag;
        public DSVTPT()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            ptdtgrid.DataSource = VTPTDAO.Instance.HienThi();
        }
        private void QUANLYVATTUPHUTUNG_Load(object sender, EventArgs e)
        {

        }

        private void PrintListVatTu_Button_Click(object sender, EventArgs e)
        {

        }

        private void EditVatTu_Button_Click(object sender, EventArgs e)
        {

        }

        private void AddVatTu_Button_Click(object sender, EventArgs e)
        {

        }

        private void VTPTVatTuPhuTung_Gr_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infocarbtn_Click(object sender, EventArgs e)
        {
            THONGTINVTPT infoAccessoryForm = new THONGTINVTPT();
            infoAccessoryForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SUAVTPT infoAccChangeForm = new SUAVTPT();
            infoAccChangeForm.mavtpt = mavtpttxtbox.Text;
            infoAccChangeForm.tenvtpt =tenvtpttxtbox.Text;
            infoAccChangeForm.soluong = sltxtbox.Text;
            infoAccChangeForm.dongia = dgtxtbox.Text;    
            infoAccChangeForm.ShowDialog();
            HienThi();
        }

        private void ptdtgrid_SelectionChanged(object sender, EventArgs e)
        {
            mavtpttxtbox.DataBindings.Clear();
            mavtpttxtbox.DataBindings.Add("Text", ptdtgrid.DataSource, "MaVTPT");
            tenvtpttxtbox.DataBindings.Clear();
            tenvtpttxtbox.DataBindings.Add("Text", ptdtgrid.DataSource, "TenVTPT");
            sltxtbox.DataBindings.Clear();
            sltxtbox.DataBindings.Add("Text", ptdtgrid.DataSource, "SoLuongTon");
            dgtxtbox.DataBindings.Clear();
            dgtxtbox.DataBindings.Add("Text", ptdtgrid.DataSource, "DonGia");
        }

        private void xoavtptbtn_Click(object sender, EventArgs e)
        {
            string ma = mavtpttxtbox.Text;
            if (!VTPTDAO.Instance.XoaVTPT(ma))
                MessageBox.Show("Không thể xóa vật tư phụ tùng!");
            HienThi();
        }

        private void timkiemtxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void theomaradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
          
        }

        private void theotenradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
          
        }

        private void xuatbtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(ptdtgrid.DataSource as DataTable, "VTPT");

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

        private void timkiembtn_Click(object sender, EventArgs e)
        {
            string s = timkiemtxtbox.Text;
            if (!string.IsNullOrEmpty(timkiemtxtbox.Text))
            {
                if (flag == 1)
                {
                    ptdtgrid.DataSource = VTPTDAO.Instance.TimKiemTheoMa(s);
                }
                else if (flag == 2)
                {
                    ptdtgrid.DataSource = VTPTDAO.Instance.TimKiemTheoTen(s);
                }
            }
            else
                HienThi();
        }

        private void themtcbtn_Click(object sender, EventArgs e)
        {
            THEMVTPT t = new THEMVTPT();
            t.ShowDialog();
        }
    }
}
