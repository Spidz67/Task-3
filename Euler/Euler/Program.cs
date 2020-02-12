using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {

        static int SumArry(int[] arry_Values)
        {
            return arry_Values.Sum();
        }
        static void Main(string[] args)
        {
            int[] Arry = new int[] { 1, 2, 5, 9, 8, 5, 5, 6, 58, 55, 5, 54, 58, 5, 58, 5, 5, };
            Console.Write(SumArry(Arry));
            Console.Read();
        }
    }
}
