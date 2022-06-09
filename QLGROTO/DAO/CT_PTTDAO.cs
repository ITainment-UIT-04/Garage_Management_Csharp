using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class CT_PTTDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static CT_PTTDAO instance;
        private CT_PTTDAO()
        {
            dc = new DataConnection();
        }
        public static CT_PTTDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CT_PTTDAO();
                return instance;
            }
            set { instance = value; }
        }
        
    }
}
