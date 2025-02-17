using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UserInput
    {
        public static double[] UserData()
        {
            
            double[] num = new double[2];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Enter number {i} :");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }

            return num;
        }
    }
}
