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
    public partial class PHIEUSUACHUA : Form
    {
        double s = 0;

        public PHIEUSUACHUA()
        {
            InitializeComponent();
            HienThi();

        }
        public void HienThi()
        {
           

        }

        

        private void pt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PHIEUSUACHUA_Load(object sender, EventArgs e)
        {
            mapsctxtbox.Text = PHIEUSUACHUADAO.Instance.LoadMPSC();
            SqlDataReader dr = XEDAO.Instance.LoadBienSo();
            while (dr.Read())
            {
                biensocbbox.Items.Add(dr["BienSo"]);
            }
            SqlDataReader dr1 = TIENCONGDAO.Instance.LoadTienCong();
            while (dr1.Read())
            {
                ndcbbox.Items.Add(dr1["NoiDung"]);
            }
            SqlDataReader dr2 = VTPTDAO.Instance.LoadVTPT();
            while (dr2.Read())
            {
                ptcbbox.Items.Add(dr2["TenVTPT"]);
            }


        }

        private void ptcbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = VTPTDAO.Instance.LoadDonGia(ptcbbox.Text);
            if (dr.Read())
                dgtxtbox.Text = dr["DonGia"].ToString();
            int sl = Convert.ToInt32(slnumeric.Value);
            if (!String.IsNullOrEmpty(tctxtbox.Text) && !String.IsNullOrEmpty(dgtxtbox.Text) && sl > 0)
            {
                double dg = Double.Parse(dgtxtbox.Text);

                double tc = Double.Parse(tctxtbox.Text);
                thanhtientxtbox.Text = (dg * sl + tc).ToString();
            }

        }

        private void ndcbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = TIENCONGDAO.Instance.LoadTienCongTheoNoiDung(ndcbbox.Text);
            if (dr.Read())
                tctxtbox.Text = dr["TienCong"].ToString();
            int sl = Convert.ToInt32(slnumeric.Value);
            if (!String.IsNullOrEmpty(tctxtbox.Text) && !String.IsNullOrEmpty(dgtxtbox.Text) && sl > 0)
            {
                double dg = Double.Parse(dgtxtbox.Text);

                double tc = Double.Parse(tctxtbox.Text);
                thanhtientxtbox.Text = (dg * sl + tc).ToString();
            }

        }

        private void slnumeric_ValueChanged(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(slnumeric.Value);
            if (!String.IsNullOrEmpty(tctxtbox.Text) && !String.IsNullOrEmpty(dgtxtbox.Text) && sl > 0)
            {
                double dg = Double.Parse(dgtxtbox.Text);

                double tc = Double.Parse(tctxtbox.Text);
                thanhtientxtbox.Text = (dg * sl + tc).ToString();
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string nd = ndcbbox.Text;
            string tenvt = ptcbbox.Text;
            string dg = dgtxtbox.Text;
            double tt = Convert.ToDouble(thanhtientxtbox.Text);
            string tc = tctxtbox.Text;
            int sl = Convert.ToInt32(slnumeric.Value);
            string mavt = "";
            SqlDataReader dr = VTPTDAO.Instance.LoadMaVTPT(tenvt);
            if (dr.Read())
                mavt = dr["MaVTPT"].ToString();
            
            pscdtgrid.Rows.Add(nd, mavt, tenvt, sl, dg, tc, tt);
            s += tt;
            ttttxtbox.Text = s.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pscdtgrid.Rows.Count == 0)
                MessageBox.Show("Không có dữ liệu để xóa!");
            else
            {
                double tt = Convert.ToDouble(pscdtgrid.CurrentRow.Cells["ThanhTien"].Value.ToString());
                pscdtgrid.Rows.RemoveAt(pscdtgrid.CurrentCell.RowIndex);
                s -= tt;
                ttttxtbox.Text = s.ToString();
            }
        }

        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lapphieubtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(biensocbbox.Text))
                MessageBox.Show("Vui lòng chọn biển số xe!");




            if (pscdtgrid.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
            }
            else
            {
                string masc = mapsctxtbox.Text;
                string bienso = biensocbbox.Text;
                double tongtien = Convert.ToDouble(ttttxtbox.Text);
                PHIEUSUACHUADAO.Instance.Them(masc, bienso, tongtien);

                foreach (DataGridViewRow dataRow in pscdtgrid.Rows)
                {
                    string mavt = pscdtgrid.CurrentRow.Cells["MaVTPT"].Value.ToString();
                    string tenvt = pscdtgrid.CurrentRow.Cells["TenVTPT"].Value.ToString();
                    string noidung = pscdtgrid.CurrentRow.Cells["NoiDung"].Value.ToString();
                    int sl = Convert.ToInt32(pscdtgrid.CurrentRow.Cells["SoLuong"].Value);
                    string dg = pscdtgrid.CurrentRow.Cells["DonGia"].Value.ToString();
                    string tc = pscdtgrid.CurrentRow.Cells["TienCong"].Value.ToString();
                    string tt = pscdtgrid.CurrentRow.Cells["ThanhTien"].Value.ToString();
                    string matc = "";
                    SqlDataReader dr = TIENCONGDAO.Instance.LoadTienCongTheoNoiDung(noidung);
                    if (dr.Read())
                        matc = dr["MaTienCong"].ToString();

                    if (!CT_PSCDAO.Instance.Them(masc, noidung, mavt, tenvt, sl, dg, matc, tc, tt))
                    {

                        MessageBox.Show("Lập phiếu thất bại!");
                        break;
                    }

                }
                this.Close();

            }
        }
    }
}    