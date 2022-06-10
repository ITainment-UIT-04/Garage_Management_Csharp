using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
