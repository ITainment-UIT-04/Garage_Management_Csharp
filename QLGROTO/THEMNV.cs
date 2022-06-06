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
    public partial class THEMNV : Form
    {
       
    
       
        public THEMNV()
        {
            InitializeComponent();
        }

        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
            string tdn = tdntxtbox.Text;
            string mk = mktxtbox.Text;
            string ten = tentxtbox.Text;
            string diachi = dctxtbox.Text;
            string dth = dthtxtbox.Text;
            string email = emailtxtbox.Text;
            string cv = chucvutxtbox.Text;
            if (NHANVIENDAO.Instance.ThemNhanVien(tdn, mk, ten, diachi, dth, email, cv))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!");
                this.Close();
            }


        }
    }
}
