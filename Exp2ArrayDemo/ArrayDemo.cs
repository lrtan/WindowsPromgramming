using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp2ArrayDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            float[] elements = new float[6];
            int index;
            float temp;
            Console.WriteLine("请输入要排序的6个数值");
            for (index = 0; index < elements.Length; index++)
            {
                elements[index] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("已经排列好的数组的");
            for(index = 0; index < elements.Length; index++)
            {
                for(int j = index + 1; j < elements.Length; j++)
                {
                    if (elements[index] > elements[j])
                    {
                        temp = elements[j];
                        elements[j] = elements[index];
                        elements[index] = temp;

                    }
                }
                Console.WriteLine(elements[index]);
            }

        }
    }
}
