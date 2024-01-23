using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        class Inventry
        {
            private int weight;
            private string name;
            private int price;

            public Inventry(int weight, string name, int price)
            {
                this.weight = weight;
                this.name = name;
                this.price = price;
            }

            public int calcPrice()
            {
                return weight * price;
            }
            static void Main(string[] args)
            {
                Inventry rice = new Inventry(10, "Rice", 2);
                Inventry pulses = new Inventry(12, "Pulses", 8);
                Inventry wheat = new Inventry(22, "Wheat", 3);

                Console.WriteLine(rice.calcPrice());
                Console.WriteLine(pulses.calcPrice());
                Console.WriteLine(wheat.calcPrice());
                Console.ReadLine();
            }
        }
    }
}
