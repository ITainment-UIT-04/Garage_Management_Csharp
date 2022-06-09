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
    public partial class DSPHIEUSUACHUA : Form
    {
        public DSPHIEUSUACHUA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void DSPHIEUSUACHUA_Load(object sender, EventArgs e)
        {
            pscdtgrid.DataSource = PHIEUSUACHUADAO.Instance.HienThi();
        }

        private void xembtn_Click(object sender, EventArgs e)
        {
            CHITIETPSC t = new CHITIETPSC();
            t.tongtien = pscdtgrid.CurrentRow.Cells["TongTien"].Value.ToString();
            t.ngaysua = pscdtgrid.CurrentRow.Cells["NgaySuaChua"].Value.ToString();
            t.bienso = pscdtgrid.CurrentRow.Cells["BienSo"].Value.ToString();
            t.mapsc = pscdtgrid.CurrentRow.Cells["MaPSC"].Value.ToString();
            t.ShowDialog();
        }
    }
}
