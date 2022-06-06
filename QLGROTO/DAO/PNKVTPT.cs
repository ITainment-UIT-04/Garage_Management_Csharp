using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class PNKVTPT
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static PNKVTPT instance;
        private PNKVTPT()
        {
            dc = new DataConnection();
        }
        public static PNKVTPT Instance
        {
            get
            {
                if (instance == null)
                    instance = new PNKVTPT();
                return instance;
            }
            set { instance = value; }
        }
        public DataTable HienThi()
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHIEUNHAPKHOVTPT";
            SqlCommand cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable HienThiChiTiet(string s)
        {


            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT C.MaVTPT, TenVTPT, SoLuong, GiaNhap FROM PHIEUNHAPKHOVTPT P, CT_PNKVTPT C WHERE P.MaNKVTPT = C.MaNKVTPT AND P.MaNKVTPT = @mank";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mank", s);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;


        }
    }
}
