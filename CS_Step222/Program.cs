using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is " + DateTime.Now + "\n\nEnter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime addhours = DateTime.Now.AddHours(number);
            Console.WriteLine("\nIt will be {0} in {1} hours", addhours, number);
            Console.ReadLine();
        }
    }
}
