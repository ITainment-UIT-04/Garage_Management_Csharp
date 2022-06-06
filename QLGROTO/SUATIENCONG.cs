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
    public partial class SUATIENCONG : Form
    {
        public string matiencong { get; set; }
        public string tiencong { get; set; }
        public string noidung { get; set; }
        public SUATIENCONG()
        {
            InitializeComponent();
        }

     

        private void ChangeWageForm_Load(object sender, EventArgs e)
        {
            matctxtbox.Text = matiencong;
            tctxtbox.Text = tiencong;
            ndtxtbox.Text = noidung;
        }

        private void suabtn_Click(object sender, EventArgs e)
        {
            string mtc = matctxtbox.Text;
            string tc = tctxtbox.Text;
            string nd = ndtxtbox.Text;
            if (TIENCONGDAO.Instance.SuaTienCong(mtc, tc, nd))
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
    }
}
