using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QlTheCao;
namespace BUS_QlTheCao
{
    public class BUS_Login
    {
        DAL_Login dallogin = new DAL_Login();
        public bool CheckLogin(String username, String password)
        {
            return dallogin.CheckLogin(username, password);
        }
    }
}
