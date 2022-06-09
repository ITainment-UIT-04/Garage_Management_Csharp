using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class PHIEUSUACHUADAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static PHIEUSUACHUADAO instance;
        private PHIEUSUACHUADAO()
        {
            dc = new DataConnection();
        }
        public static PHIEUSUACHUADAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PHIEUSUACHUADAO();
                return instance;
            }
            set { instance = value; }
        }
        public string LoadMPSC()
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT COUNT(*) + 1 AS SO FROM PHIEUSUACHUA";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            string l = "1";
            foreach (DataRow dr in dt.Rows)
            {
                l = dr["SO"].ToString();
            }
            return "SC" + l;
        }
    }
}
