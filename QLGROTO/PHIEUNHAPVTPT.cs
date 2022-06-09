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

           
        }
        private void AccessoryForm_Load(object sender, EventArgs e)
        {
            mapntxtbox.Text = PNKVTPTDAO.Instance.LoadMPN();
            SqlDataReader dr = VTPTDAO.Instance.LoadVTPT();
            while (dr.Read())
            {
                tenvtcbbox.Items.Add(dr["TenVTPT"]);
            }
        }

        

        private void thembtn_Click(object sender, EventArgs e)
        {
            string mpn = mapntxtbox.Text;
            string ten = tenvtcbbox.Text;
            string dgn = dgtxtbox.Text;
            int sl = Convert.ToInt32(slnum.Value);
            string mavt = "";
            SqlDataReader dr = VTPTDAO.Instance.LoadMaVTPT(ten);
            if (dr.Read())
                mavt = dr["MaVTPT"].ToString();
            ctnkgrid.Rows.Add(mavt, ten, dgn, sl);
           
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            ctnkgrid.Rows.RemoveAt(ctnkgrid.CurrentCell.RowIndex);
        }
        
        private void lpbtn_Click(object sender, EventArgs e)
        {
            string mpn = mapntxtbox.Text;
            PNKVTPTDAO.Instance.Them(mpn);

            foreach (DataGridViewRow dataRow in ctnkgrid.Rows)
            {
                string mavt = ctnkgrid.CurrentRow.Cells["MaVTPT"].Value.ToString();
                string dgn = ctnkgrid.CurrentRow.Cells["GiaNhap"].Value.ToString();
                string ten = ctnkgrid.CurrentRow.Cells["TenVTPT"].Value.ToString();
                int sl = Convert.ToInt32(ctnkgrid.CurrentRow.Cells["SoLuong"].Value);
                if (CT_PNKVTPTDAO.Instance.Them(mpn, mavt, ten, sl, dgn))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lập phiếu thất bại!");
                    this.Close();
                }
            }
        }

        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
