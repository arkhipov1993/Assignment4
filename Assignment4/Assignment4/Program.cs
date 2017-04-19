using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit ");
            TriangleSolver.Validation(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
