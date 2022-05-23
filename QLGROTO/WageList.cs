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
    public partial class WageList : Form
    {
        public WageList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WageForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themtiencong_btn_Click(object sender, EventArgs e)
        {
            ThemTienCong themTienCong = new ThemTienCong();
            themTienCong.ShowDialog();
        }

        private void suatiencong_btn_Click(object sender, EventArgs e)
        {
            ChangeWageForm wageForm = new ChangeWageForm();
            wageForm.ShowDialog();  
        }
    }
}
