using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp2EnumDemo
{
    enum Degree:int
    {
        Bachelor, //学士
        Master,//硕士
        Doctor//博士
    }
    class EnumDemo
    {
        static void Main(string[] args)
        {
            for(int i = (int)Degree.Bachelor; i <= (int)Degree.Doctor+1; i++)
            {
                switch( (Degree)i)
                {
                    case Degree.Bachelor:
                        Console.WriteLine("你的学位是学士");
                        break;
                    case Degree.Master:
                        Console.WriteLine("你的学位是硕士");
                        break;
                    case Degree.Doctor:
                        Console.WriteLine("你的学位是博士");
                        break;
                    default:
                        Console.WriteLine("没有这样的学位");
                        break;

                }

            }
            
            Console.ReadLine();

        }
    }
}
