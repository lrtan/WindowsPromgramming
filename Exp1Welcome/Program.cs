using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp1Welcome
{
    class Welcome
    {
        static void Main(string[] args)
        {
            Console.Write("请输入你的姓名:");
            string strName = Console.ReadLine();
            Console.WriteLine("{0}，你好！\n欢迎使用C#语言!", strName);
        }
    }
}
