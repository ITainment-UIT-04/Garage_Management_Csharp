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
    public partial class BrandList : Form
    {
        public BrandList()
        {
            InitializeComponent();
        }

        private void BrandList_Load(object sender, EventArgs e)
        {

        }

        private void themtiencong_btn_Click(object sender, EventArgs e)
        {
            ThemHieuXe themHieuXe = new ThemHieuXe();
            themHieuXe.ShowDialog();
        }
    }
}
