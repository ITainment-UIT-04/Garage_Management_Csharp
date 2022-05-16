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
    public partial class AccessoryList : Form
    {
        public AccessoryList()
        {
            InitializeComponent();
        }

        private void QUANLYVATTUPHUTUNG_Load(object sender, EventArgs e)
        {

        }

        private void PrintListVatTu_Button_Click(object sender, EventArgs e)
        {

        }

        private void EditVatTu_Button_Click(object sender, EventArgs e)
        {

        }

        private void AddVatTu_Button_Click(object sender, EventArgs e)
        {

        }

        private void VTPTVatTuPhuTung_Gr_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infocarbtn_Click(object sender, EventArgs e)
        {
            InfoAccessoryForm infoAccessoryForm = new InfoAccessoryForm();
            infoAccessoryForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InfoAccChangeForm infoAccChangeForm = new InfoAccChangeForm();
            infoAccChangeForm.ShowDialog();
        }
    }
}
