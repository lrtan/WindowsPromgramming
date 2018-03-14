using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp1WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long oper1, oper2, result;
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                //如果操作数为空，显示警告信息
                MessageBox.Show(this, "操作数不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                oper1 = Convert.ToInt64(textBox1.Text);
                oper2 = Convert.ToInt64(textBox2.Text);
                result = oper1 + oper2;
                textBox3.Text = Convert.ToString(result);
            }catch(Exception e1)
            {
                MessageBox.Show(this, e1.Message, "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
