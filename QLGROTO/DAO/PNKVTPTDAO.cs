using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class PNKVTPTDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static PNKVTPTDAO instance;
        private PNKVTPTDAO()
        {
            dc = new DataConnection();
        }
        public static PNKVTPTDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PNKVTPTDAO();
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
        public bool InsertPNK()
        {
            string sql = "INSERT INTO PHIEUNHAPKHOVTPT VALUES (GETDATE())";
            SqlConnection con = dc.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
              
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool ThemCTPNK(string mank, string mavt, string tenvt, int sl, string gn)
        {
            string sql = "INSERT INTO CT_PNKVTPT (MaNKVTPT, MaVTPT, TenVTPT, SoLuong, GiaNhap)" +
                "VALUES (@mank, @mavt, @tenvt, @sl, @gn)";
            SqlConnection con = dc.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                cmd.Parameters.AddWithValue("@mank", mank);
                cmd.Parameters.AddWithValue("@mavt", mavt);
                cmd.Parameters.AddWithValue("@tenvt", tenvt);
                cmd.Parameters.AddWithValue("@sl", sl);
                cmd.Parameters.AddWithValue("@gn", gn);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public SqlDataReader LoadVTPT()
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;
        }
      
        public DataTable LoadMaVTPT(string ten)
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG WHERE TenVTPT = @ten";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", ten);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            con.Close();

            return dt;


        }
        public DataTable HienThiMaPhieuNhap()
        {

            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT TOP 1 * FROM PHIEUNHAPKHOVTPT ORDER BY IntMaNKVTPT DESC";
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
