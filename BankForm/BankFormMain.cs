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
    public partial class BankFormMain : Form
    {
        /// <summary>
        /// 一个银行
        /// </summary>
        public Bank bank;
        public BankFormMain()
        {
            InitializeComponent();
            bank = new Bank("中国人民银行");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankFormSub b = new BankFormSub();
            b.bank = this.bank;
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserLogin u =new UserLogin();
            u.bank = this.bank;
            u.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //创建 一个银行
            this.label1.Text = bank.Name;
        }
    }
}
