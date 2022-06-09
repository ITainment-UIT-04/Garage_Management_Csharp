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
    public partial class THUTIEN : Form
    {
        public THUTIEN()
        {
            InitializeComponent();
        }

      
        private void THUTIEN_Load(object sender, EventArgs e)
        {
            matttxtbox.Text = PHIEUTHUTIENDAO.Instance.LoadMaPTT();
            SqlDataReader dr = XEDAO.Instance.LoadBienSo();
            while (dr.Read())
            {
                biensocbbox.Items.Add(dr["BienSo"]);
            }
        }

        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void biensocbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = XEDAO.Instance.LoadThongTinTheoBienSo(biensocbbox.Text);
            if (dr.Read())
            {
                tentxtbox.Text = dr["TenChuXe"].ToString();
                hieuxetxtbox.Text = dr["HieuXe"].ToString();
                diachitxtbox.Text = dr["DiaChi"].ToString();
                dthtxtbox.Text = dr["DienThoai"].ToString();
                emailtxtbox.Text = dr["Email"].ToString();
                tiennotxtbox.Text = dr["TienNo"].ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void diachitxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tienthutxtbox_TextChanged(object sender, EventArgs e)
        {
            double tienconno;
            if (!String.IsNullOrEmpty(biensocbbox.Text))
            {
                if (String.IsNullOrEmpty(tienthutxtbox.Text))
                {
                    tienconnotxtbox.Text = "0"
;                }
                else
                {
                    double tienno = Convert.ToDouble(tiennotxtbox.Text);
                    double tienthu = Convert.ToDouble(tienthutxtbox.Text);
                    if (tienthu > tienno)
                    {
                        MessageBox.Show("Tiền thu không được lớn hơn tiền nợ!");

                    }

                    else
                    {
                        tienconno = tienno - tienthu;
                        tienconnotxtbox.Text = tienconno.ToString();
                    }
                }
            }
        }

        private void lapphieubtn_Click(object sender, EventArgs e)
        {
            string maptt = matttxtbox.Text;
            string bienso = biensocbbox.Text;
            string tienthu = tienthutxtbox.Text;
            if (PHIEUTHUTIENDAO.Instance.Them(maptt, bienso, tienthu))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
                this.Close();
            }
        }
    }
}
