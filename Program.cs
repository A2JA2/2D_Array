using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[,] { { "Ubisoft", "Valve Corporation" }, { "Nintendo", "Sega" }, };
            // ... Print out values.
            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[1, 0]);
            Console.WriteLine(array[1, 1]);
            Console.ReadKey();
        }
    }
}
