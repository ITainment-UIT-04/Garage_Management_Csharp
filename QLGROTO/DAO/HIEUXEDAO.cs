﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class HIEUXEDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static HIEUXEDAO instance;
        private HIEUXEDAO()
        {
            dc = new DataConnection();
        }
        public static HIEUXEDAO Instance
        {
            get { if (instance == null)
                    instance = new HIEUXEDAO();
            return instance;
                    }
            set { instance = value; }
        }
        public SqlDataReader HienThiHieuXe1()
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM HIEUXE";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection = con;
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;
        }
        public DataTable HienThiHieuXe2()
        {
          
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM HIEUXE";
            SqlCommand cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
         
            return dt;
        }
        public DataTable TimHieuXe(string s)
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM HIEUXE WHERE dbo.fuConvertToUnsign1(HieuXe) LIKE N'%' +dbo.fuConvertToUnsign1(@ten) + '%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@hieuxe", s);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;


        }
        public bool ThemHieuXe(string h)
        {
            string sql = "INSERT INTO HIEUXE VALUES(@h)";
            SqlConnection con = dc.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@h", h);
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                
                return false;
            }
            return true;
        }
        public void XoaHieuXe(string s)
        {
            SqlConnection con = dc.getConnect();
            con.Open();

            string sql = "DELETE FROM HIEUXE WHERE HieuXe = @h";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@h", s);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
