using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp2MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(1 + "*" + j + "=" + i * j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
