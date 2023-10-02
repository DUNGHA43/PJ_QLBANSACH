using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect_Close_DB
    {
        private string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_BANSACH;User ID=sa;Password=DUng0403";
        protected SqlConnection sqlcon = null;

        public void connect_DB()
        {
            sqlcon = new SqlConnection(strCon);
            if (sqlcon == null)
            {
                sqlcon.Open();
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }

        public void Close_DB()
        {
            if (sqlcon != null || sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
    }
}
