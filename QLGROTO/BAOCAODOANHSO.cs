using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGROTO.DAO;


namespace QLGROTO
{
    public partial class BAOCAODOANHSO : Form
    {
        public BAOCAODOANHSO()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themtiencong_btn_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(ThangText.Text) && String.IsNullOrEmpty(NamText.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                int thang = Convert.ToInt32(ThangText.Text);
                int nam = Convert.ToInt32(NamText.Text);
                BCDSgrid.DataSource = BAOCAODOANHSODAO.Instance.Hienthi(thang, nam);
                
            }
        }

        private void InBCDS_btn_Click(object sender, EventArgs e)
        {
            // Cái này là của btn in
        }
    }
}
