using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QlTheCao;
namespace GuiQuanLyTheCao
{
    public partial class Form1 : Form
    {
        BUS_Login buslogin = new BUS_Login();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txbUserName!= null && txtPassWord!= null)
            {
                string UserName = txbUserName.Text;
                string PassWord = txtPassWord.Text;
                if(buslogin.CheckLogin(UserName,PassWord))
                {
                    
                    MessageBox.Show("Dang nhap thanh cong");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("tai khoan hoac mat khau sai");
                    txbUserName.Text = "";
                    txtPassWord.Text = "";
                    txbUserName.Focus();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
