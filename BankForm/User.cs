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
    public partial class User : Form
    {
        public Account account;
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.label3.Text = account.Id;
            this.label4.Text = account.Money.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal money = Convert.ToDecimal(this.textBox1.Text);
            if (money < 0) return;
            account.SaveMoney(money);
            MessageBox.Show("存钱成功");
            this.label4.Text = account.Money.ToString();
            this.textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal money = Convert.ToDecimal(this.textBox2.Text);
            if (money < 0||money>account.Money) return;
            account.DrawMoney(money);
            MessageBox.Show("取钱成功");
            this.label4.Text = account.Money.ToString();
            this.textBox2.Text = string.Empty;
        }
    }
}
