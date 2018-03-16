using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem;

namespace BankForm
{
    
    public partial class UserLogin : Form
    {
        private Account account;
        public Bank bank;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          account=  bank.FindAccount(this.textBox1.Text, this.textBox2.Text);
            if (account != null)
            {
                User user = new User();
                user.account = this.account;
                user.Show();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
