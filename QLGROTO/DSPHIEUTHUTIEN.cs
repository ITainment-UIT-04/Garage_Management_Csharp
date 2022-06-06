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
    public partial class DSPHIEUTHUTIEN : Form
    {
        public DSPHIEUTHUTIEN()
        {
            InitializeComponent();
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void PhoneSearchRadiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NameSearchRadiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void themtiencong_btn_Click(object sender, EventArgs e)
        {
            CHITIETPTT cHITIETPTT = new CHITIETPTT();
            cHITIETPTT.ShowDialog();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
