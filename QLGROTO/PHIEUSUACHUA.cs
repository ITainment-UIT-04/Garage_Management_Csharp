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
        
        public PHIEUSUACHUA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
