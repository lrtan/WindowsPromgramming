using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank b = new Bank();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User u=new User();
            u.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //创建 一个银行

        }
    }
}
