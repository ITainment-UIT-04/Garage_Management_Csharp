using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class VTPTDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static VTPTDAO instance;
        private VTPTDAO()
        {
            dc = new DataConnection();
        }
        public static VTPTDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new VTPTDAO();
                return instance;
            }
            set { instance = value; }
        }
        public DataTable HienThi()
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG";
            SqlCommand cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void XoaVTPT(string mavtpt)
        {
            SqlConnection con = dc.getConnect();
            con.Open();

            string sql = "DELETE FROM PHUTUNG WHERE MaVTPT = @mavtpt";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mavtpt", mavtpt);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
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
        public SqlDataReader LoadMaVTPT(string ten)
        {
           
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG WHERE TenVTPT = @ten";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", ten);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;

        }
        public SqlDataReader LoadDonGia(string ten)
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG WHERE TenVTPT = @ten" ;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;


        }
        public bool SuaVTPT(string ma, string ten, int slt, string dg)
        {
            string sql = "UPDATE PHUTUNG SET TenVTPT = @ten, SoLuongTon = @slt, DonGia = @dg WHERE MaVTPT = @ma";
            SqlConnection con = dc.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@slt", slt);
                cmd.Parameters.AddWithValue("@dg", dg);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiemTheoMa(string s)
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG WHERE MaVTPT LIKE CONCAT('%', @ten, '%')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", s);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;


        }
        public DataTable TimKiemTheoTen(string s)
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG WHERE dbo.fuConvertToUnsign1(TenVTPT) LIKE N'%' + dbo.fuConvertToUnsign1(@ten) + '%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", s);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;


        }
    }
  
}
