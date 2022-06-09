using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLGROTO.DAO
{
    internal class BAOCAODOANHSODAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static BAOCAODOANHSODAO instance;
        private BAOCAODOANHSODAO()
        {
            dc = new DataConnection();
        }

        public static BAOCAODOANHSODAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BAOCAODOANHSODAO();
                return instance;
            }
            set { instance = value; }
        }

        public DataTable Hienthi(int thang, int nam)
        {
            string sql = "SELECT CT_BAOCAODOANHTHU.MaBCDT, HieuXe, ThanhTien, TiLe FROM BAOCAODOANHTHU FULL JOIN CT_BAOCAODOANHTHU ON BAOCAODOANHTHU.MaBCDT = CT_BAOCAODOANHTHU.MaBCDT WHERE Thang = @Thang AND Nam = @Nam";
            SqlConnection con = dc.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }
    }
}
