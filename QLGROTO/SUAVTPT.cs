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
    public partial class SUAVTPT : Form
    {
        public string mavtpt { get; set; }
        public string tenvtpt { get; set; }
        public string soluong { get; set; }
        public string dongia { get; set; }
        
        public SUAVTPT()
        {
            InitializeComponent();
        }

        private void suabtn_Click(object sender, EventArgs e)
        {
            string ma = mavtpttxtbox.Text;
            string ten = tenvtpttxtbox.Text;
            int sl = Convert.ToInt32(sltxtbox.Text);
            string dg = dgtxtbox.Text;
            if (VTPTDAO.Instance.SuaVTPT(ma, ten, sl, dg))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
                this.Close();
            }
        }

        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SUAVTPT_Load(object sender, EventArgs e)
        {
            mavtpttxtbox.Text = mavtpt;
            tenvtpttxtbox.Text = tenvtpt;
            sltxtbox.Text = soluong;
            dgtxtbox.Text = dongia;
        }
    }
}
