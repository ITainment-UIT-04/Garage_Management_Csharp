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
    public partial class BAOCAOTON : Form
    {
        public BAOCAOTON()
        {
            InitializeComponent();
        }

        private void PhieuSuaChua_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

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
                BCTgrid.DataSource = BAOCAOTONDAO.Instance.HienThi(thang, nam);
                
            }
        }

        private void InBCTon_btn_Click(object sender, EventArgs e) // Chỉnh cái xuất phiếu ở đây nha bro
        {
            if (String.IsNullOrEmpty(ThangText.Text) && String.IsNullOrEmpty(NamText.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                int thang = Convert.ToInt32(ThangText.Text);
                int nam = Convert.ToInt32(NamText.Text);
                if (thang < 1 || thang > 12)
                {
                    MessageBox.Show("Đầu vào không hợp lệ!");
                }
                /*else
                {
                    
                }*/
            }
        }
    }
}
