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
    public partial class DSPNKVTPT : Form
    {
        public DSPNKVTPT()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            phieunhapvtptdtgrid.DataSource = PNKVTPT.Instance.HienThi();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xemctbtn_Click(object sender, EventArgs e)
        {
            CHITIETPNK c = new CHITIETPNK();
            c.maphieunhap = phieunhapvtptdtgrid.CurrentRow.Cells[0].Value.ToString();
            c.ngaynhap = phieunhapvtptdtgrid.CurrentRow.Cells[1].Value.ToString();
            c.ShowDialog();
        }
    }
}
