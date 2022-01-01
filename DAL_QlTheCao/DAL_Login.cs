using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QlTheCao
{
    public class DAL_Login:DBConnection
    {
        public bool CheckLogin(String username, String password)
        {
            String sql = string.Format("select * from DangNhap where tendangnhap='{0}' and matkhau='{1}'", username, password);
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dtb = new DataTable();
            cmd.Fill(dtb);
            return dtb.Rows.Count > 0;
        }
    }
}
