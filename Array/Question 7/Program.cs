using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "Ankit";
            Console.WriteLine(s);
            char[] chars = s.ToCharArray();
            for(int i = 0, j=s.Length-1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = s[j];
                chars[j] = c;
            }
            Console.WriteLine(chars);
            Console.ReadLine();
        }
    }
}
