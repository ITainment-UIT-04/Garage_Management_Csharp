using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class BAOCAODOANHTHUDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static BAOCAODOANHTHUDAO instance;  
        private BAOCAODOANHTHUDAO()
        {
            dc = new DataConnection();
        }
        public static BAOCAODOANHTHUDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BAOCAODOANHTHUDAO();
                return instance;
            }
            set { instance = value; }
        }
    }
}
