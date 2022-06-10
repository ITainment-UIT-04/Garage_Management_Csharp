
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
    public partial class TIEPNHANXE : Form
    {
        public TIEPNHANXE()
        {
            InitializeComponent();
            LoadHieuXe();
        }
        public void LoadHieuXe()
        {
            SqlDataReader dr = HIEUXEDAO.Instance.HienThiHieuXe1();
            while (dr.Read())
            {
                hieuxecbbox.Items.Add(dr["HieuXe"]);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HieuXe_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void BienSo_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void TenChuXe_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }

      
        public bool TiepNhan(string bs, string t, string h, string d, string dth, string email)
        {
       
            return XEDAO.Instance.TiepNhanXe(bs, t, h, d, dth, email);
        }
        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hieuxecbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void xacnhanbtn_Click(object sender, EventArgs e)
        {
            string bs = biensotxtbox.Text;  
            string t = tentxtbox.Text;
            string h = hieuxecbbox.Text;
            string d = diachitxtbox.Text;
            string dth = dthtxtbox.Text;
            string email = emailtxtbox.Text;    
            if (TiepNhan(bs, t, h, d, dth, email))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Trùng biển số/ Vượt quá số xe tiếp nhận trong ngày", "Tiếp nhận thất bại!");
                this.Close();
            }
        }
    }
}
