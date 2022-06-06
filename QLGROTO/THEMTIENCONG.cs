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
    public partial class ThemTienCong : Form
    {
        public ThemTienCong()
        {
            InitializeComponent();
        }

        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
            string matc = matctxtbox.Text;
            string tc = tctxtbox.Text;
            string nd = ndtxtbox.Text;
            if (TIENCONGDAO.Instance.ThemTienCong(matc, tc, nd))
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
