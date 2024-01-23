using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 234534;
            int sum = 0;
            for(int i = n;n>0; i++)
            {
                sum = sum + n%10;
                n = n / 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
