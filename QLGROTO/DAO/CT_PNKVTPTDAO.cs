using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class CT_PNKVTPTDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static CT_PNKVTPTDAO instance;
        private CT_PNKVTPTDAO()
        {
            dc = new DataConnection();
        }
        public static CT_PNKVTPTDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CT_PNKVTPTDAO();
                return instance;

            }
            set { instance = value; }
        }
        public DataTable HienThi(string mank)
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT TenVTPT, MaVTPT, SoLuong, GiaNhap FROM CT_PNKVTPT WHERE MaNKVTPT = @ma";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ma", mank);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}
