﻿
using QLGROTO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGROTO
{
    public partial class SUATHONGTINXE : Form
    {
        public string bienso { get; set; }
        public string ten { get; set; }
        public string hieuxe { get; set; }
        public string diachi { get; set; }
        public string dth { get; set; }
        public string email { get; set; }
        public string no { get; set; }
        public DateTime ngay { get; set; }
           
        public SUATHONGTINXE()
        {
            InitializeComponent();
            LoadHieuXe();
        }
        public void LoadHieuXe()
        {
            SqlDataReader dr = HIEUXEDAO.Instance.HienThiCBBox();
            while (dr.Read())
            {
                hieuxecbbox.Items.Add(dr["HieuXe"]);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void suabtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tentxtbox.Text) || String.IsNullOrEmpty(hieuxecbbox.Text) || String.IsNullOrEmpty(diachitxtbox.Text) 
                || String.IsNullOrEmpty(dthtxtbox.Text) || String.IsNullOrEmpty(emailtxtbox.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            { 
                string bienso = biensotxtbox.Text;
                string ten = tentxtbox.Text;
                string hieu = hieuxecbbox.Text;
                string diachi = diachitxtbox.Text;
                string dth = dthtxtbox.Text;
                string email = emailtxtbox.Text;
                if (XEDAO.Instance.Sua(bienso, ten, hieu, diachi, dth, email))
                {
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin xe thất bại!");
                    this.Close();
                }
            }
        }
        
        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SUATHONGTINXE_Load(object sender, EventArgs e)
        {
            biensotxtbox.Text = bienso;
            tentxtbox.Text = ten;
            hieuxecbbox.Text = hieuxe;
            diachitxtbox.Text = diachi;
            emailtxtbox.Text = email;
            dthtxtbox.Text = dth;
            
          
        }
    }
}
