using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QlTheCao
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection("sever=DESKTOP-MJ6NFMN;uid=sa;pwd=123456;database=Qlthecao");
    }
}
