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
    public partial class THONGTINADMIN : Form
    {
        public string tendangnhap { get; set; }
        public string matkhau { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string dth { get; set; }
        public string email { get; set; }
        public string chucvu { get; set; }
    
       
        public THONGTINADMIN()
        {
            InitializeComponent();
        }

      

        private void SUANV_Load(object sender, EventArgs e)
        {
            tdntxtbox.Text = tendangnhap;
            mktxtbox.Text = matkhau;
            tentxtbox.Text = ten;
            dthtxtbox.Text = dth;
            dctxtbox.Text = diachi;
            chucvutxtbox.Text = chucvu;
            emailtxtbox.Text = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tdn = tdntxtbox.Text;
            string mk = mktxtbox.Text;
            string ten = tentxtbox.Text;
            string diachi = dctxtbox.Text;
            string dth = dthtxtbox.Text;
            string email = emailtxtbox.Text;
            string cv = chucvutxtbox.Text;
            if (NHANVIENDAO.Instance.SuaNhanVien(tdn, mk, ten, diachi, dth, email, cv)) 
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!");
                this.Close();
            }

        }
    }
}
