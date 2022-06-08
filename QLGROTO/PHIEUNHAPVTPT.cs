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
    public partial class PHIEUNHAPVTPT : Form
    {

        

        public PHIEUNHAPVTPT()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi() { 

            string mpn = mapntxtbox.Text;
        
            ctnkgrid.DataSource = CT_PNKVTPTDAO.Instance.HienThi(mpn);
        }
        private void AccessoryForm_Load(object sender, EventArgs e)
        {
            PNKVTPTDAO.Instance.InsertPNK();
            DataTable dt = PNKVTPTDAO.Instance.HienThiMaPhieuNhap();
            foreach (DataRow dataRow in dt.Rows)
            {
                mapntxtbox.Text = dataRow["MaNKVTPT"].ToString();
            }
            SqlDataReader dr = PNKVTPTDAO.Instance.LoadVTPT();
            while (dr.Read())
            {
                tenvtcbbox.Items.Add(dr["TenVTPT"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
            string mpn = mapntxtbox.Text;
            string ten = tenvtcbbox.Text;
            string dgn = dgtxtbox.Text;
            int sl = Convert.ToInt32(slnum.Value);
            string l = "1";
            DataTable dt = PNKVTPTDAO.Instance.LoadMaVTPT(ten);
            foreach(DataRow dataRow in dt.Rows)
            {
                l = dataRow["MaVTPT"].ToString();
            }
            if (PNKVTPTDAO.Instance.ThemCTPNK(mpn, l, ten, sl, dgn))
            {

            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
                
            }
            HienThi();
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            string mpn = mapntxtbox.Text;
            string mapt = ctnkgrid.CurrentRow.Cells[1].Value.ToString();
            if (mapt == null)
            {
                MessageBox.Show("Không có dòng nào để xóa!");
            }
            else
            {
                CT_PNKVTPTDAO.Instance.Xoa(mpn, mapt);
                HienThi();
            }
        }
    }
}
