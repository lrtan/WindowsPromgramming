using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1SampleStruct
{
    class Program
    {
        struct IP
        {
            public Byte p1, p2, p3, p4;
        }
        static void Main(string[] args)
        {
            IP SampleStruct;
            SampleStruct.p1 = 192;
            SampleStruct.p2 = 168;
            SampleStruct.p3 = 1;
            SampleStruct.p4 = 2;
            Console.WriteLine("{0}.{1}.{2}.{3}", SampleStruct.p1, SampleStruct.p2, SampleStruct.p3, SampleStruct.p4);
        }
    }
}
