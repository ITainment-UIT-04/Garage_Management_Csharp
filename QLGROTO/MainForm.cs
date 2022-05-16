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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(); 
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();  
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReceiveForm t = new ReceiveForm();
            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           AccessoryForm accessoryForm = new AccessoryForm();
           accessoryForm.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RepairForm repairForm = new RepairForm();   
            repairForm.ShowDialog();   
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm();    
            receiptForm.ShowDialog();
        }

        private void infocarbtn_Click(object sender, EventArgs e)
        {
            InfoCarForm infoCarForm = new InfoCarForm();    
            infoCarForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChangeForm changeForm = new ChangeForm();
            changeForm.ShowDialog();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchVậtTưPhụTùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchPhiếuNhậtKhoVTPTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchVậtTưPhụTùngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccessoryList a = new AccessoryList();
            a.ShowDialog();
        }
    }
}
