﻿using QLGROTO.DAO;

namespace QLGROTO
{
    public partial class THEMHIEUXE : Form
    {
        public THEMHIEUXE()
        {
            InitializeComponent();
        }

        private void ThemHieuXe_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public bool ThemHieuXe(string s)
        {
            return HIEUXEDAO.Instance.ThemHieuXe(s);
        }

        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
            string s =themtxtbox.Text;
            if (ThemHieuXe(s))
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
