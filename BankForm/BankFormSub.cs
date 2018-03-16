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
    public partial class BankFormSub : Form
    {

        public Bank bank;
        private Account account;
        public BankFormSub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string password = this.textBox2.Text;
            string name = this.textBox3.Text;
            decimal money=0m;
            if (this.textBox4.Text != "") {
                money = Convert.ToDecimal(this.textBox4.Text);
            }
           

           if( bank.OpenAccount(id, password, money, name))
            {
                MessageBox.Show("开户成功");
            }
            else
            {
                MessageBox.Show("开户失败");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.textBox8.Text;
            string password = this.textBox7.Text;
            account = bank.FindAccount(id, password);
            if (account != null)
            {
                this.textBox6.Text = account.Name;
                this.textBox5.Text = account.Money.ToString();
            }
            else
            {
                MessageBox.Show("找不到用户");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(bank.CloseAccount(this.textBox8.Text, this.textBox7.Text))
            {
                MessageBox.Show("已经销户");
            }
            else
            {
                MessageBox.Show("销户失败!");
            }
        }
    }
}
