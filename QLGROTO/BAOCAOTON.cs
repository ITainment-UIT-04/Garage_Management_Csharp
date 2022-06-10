using ClosedXML.Excel;
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

        private void xuatbtn_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(bctdtgrid.DataSource as DataTable, "BAOCAOTON");

                            workbook.SaveAs(saveFileDialog.FileName);


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xuất file không thành công!");
                    }
                }
            }
        }

        private void themtiencong_btn_Click(object sender, EventArgs e)
        {
            int thang = Convert.ToInt32(thangnumeric.Value);
            int nam = Convert.ToInt32(namnumeric.Value);


            bctdtgrid.DataSource = BAOCAOTONDAO.Instance.PhatSinhVaSuDung(thang, nam);
            if (bctdtgrid.Rows.Count > 0)
            {
                for (int i = 0; i < bctdtgrid.Rows.Count; i++)
                {
                    SqlDataReader dr = VTPTDAO.Instance.LoadVTPTTheoTen(bctdtgrid.Rows[i].Cells["TenVTPT"].Value.ToString());
                    if (dr.Read())
                    {
                        int tc = Convert.ToInt32(dr["SoLuongTon"]);
                        int ps = Convert.ToInt32(bctdtgrid.Rows[i].Cells["PhatSinh"].Value);
                        int sd = Convert.ToInt32(bctdtgrid.Rows[i].Cells["SuDung"].Value);
                        int td = tc - ps + sd;
                        bctdtgrid.Rows[i].Cells["TonCuoi"].Value = tc.ToString();
                        bctdtgrid.Rows[i].Cells["TonDau"].Value = td.ToString();
                    }
                }
                
            }
        }
    }
}
