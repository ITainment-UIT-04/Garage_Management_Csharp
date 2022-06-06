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
    public partial class PassChangeForm : Form
    {
        public PassChangeForm()
        {
            InitializeComponent();
        }

       

        private void chgbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đổi mật khẩu thành công!", "Đổi mật khẩu", MessageBoxButtons.OK);
            this.Close(); 
        }

        private void escbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
