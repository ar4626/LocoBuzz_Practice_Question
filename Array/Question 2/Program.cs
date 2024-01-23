using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 4, 4, 5, 7 };
            int count = 0;

            for(int i = 0;i<arr.Length;i++)
            {
                count = 0;
                for(int j = 0;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if(count == 1)
                {

                Console.WriteLine($"{arr[i]} is {count} times.");
                }
            }
            Console.ReadLine();

        }
    }
}
