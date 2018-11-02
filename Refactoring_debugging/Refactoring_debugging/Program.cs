using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(GetSum(array1));
        }

        public static int GetSum(int[] array1)
        {
            int i = 0;
            int getSum = 0;
            for (i = 0; i < array1.Length; i++)
            {
                getSum += array1[i];
            }
            return getSum;
        }
    }
}
    

