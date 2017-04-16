using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAndConvertExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            double y = 12.6;
            x = (int)y; // Casts double type value into int.
            Console.WriteLine("Double casted to int: " + x);

            int xx = 7;
            double yy = 12.6;
            xx = Convert.ToInt32(yy);
            Console.WriteLine("Double casted to int: " + xx);

            string str = "123";
            int r;
            r = Convert.ToInt32(str); // Converts string str into an int
            Console.WriteLine("Using Convert to convert string to int: " + r);

        }
    }
}
