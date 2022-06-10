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
            if (String.IsNullOrEmpty(tdntxtbox.Text) || String.IsNullOrEmpty(mktxtbox.Text) || String.IsNullOrEmpty(tentxtbox.Text)
                || String.IsNullOrEmpty(dctxtbox.Text) || String.IsNullOrEmpty(dthtxtbox.Text) || String.IsNullOrEmpty(emailtxtbox.Text) || String.IsNullOrEmpty(chucvutxtbox.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
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
}
