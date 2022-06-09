using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLGROTO.DAO
{
    internal class BAOCAOTONDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static BAOCAOTONDAO instance;
        private BAOCAOTONDAO()
        {
            dc = new DataConnection();
        }
        public static BAOCAOTONDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BAOCAOTONDAO();
                return instance;
            }
            set { instance = value; }
        }

        public DataTable HienThi(int thang, int nam)
        {
            string sql = "SELECT A.MaVTPT, TenVTPT, TonDau, PhatSinh, TonCuoi FROM (CT_BAOCAOTONVTPT A FULL JOIN BAOCAOTONVTPT B ON A.MaBCTVTPT = B.MaBCTVTPT) FULL JOIN PHUTUNG C ON A.MaVTPT = C.MaVTPT WHERE Thang = @Thang AND Nam = @Nam";
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
