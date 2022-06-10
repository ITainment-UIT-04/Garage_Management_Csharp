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
    public partial class BAOCAODOANHSO : Form
    {
        public BAOCAODOANHSO()
        {
            InitializeComponent();
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
                            workbook.Worksheets.Add(bcdsdtgrid.DataSource as DataTable, "BAOCAODOANHSO");

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

        private void hienbcbtn_Click(object sender, EventArgs e)
        {
            int thang = Convert.ToInt32(thangnumeric.Value);
            int nam = Convert.ToInt32(namnumeric.Value);
            double ttt = 0;
          
        
            bcdsdtgrid.DataSource = BAOCAODOANHTHUDAO.Instance.BaoCao(thang, nam);
            if (bcdsdtgrid.Rows.Count > 0)
            {
                
                SqlDataReader dr = BAOCAODOANHTHUDAO.Instance.TongThanhTien(thang, nam);
                if (dr.Read())
                    ttt = Convert.ToDouble(dr["TONGTHANHTIEN"]);
                ttttxtbox.Text = ttt.ToString();
                for (int i = 0; i < bcdsdtgrid.Rows.Count; i++)
                {
                    bcdsdtgrid.Rows[i].Cells["TiLe"].Value = (Convert.ToDouble(bcdsdtgrid.Rows[i].Cells["THANHTIEN"].Value) / ttt);
                }
            }
        }

        private void bcdsdtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
