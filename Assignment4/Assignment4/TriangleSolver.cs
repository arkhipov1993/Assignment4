using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class TriangleSolver
    {
        public static string Validation(int userInput, float a=0, float b=0, float c=0)
        {
            string triangleType="";
            
            if (userInput == 1)
            {
                if (a == 0 && b == 0 && c == 0)
                {
                    Console.WriteLine("Type the side A:");
                    a = float.Parse(Console.ReadLine());


                    Console.WriteLine("Type the side B:");
                    b = float.Parse(Console.ReadLine());

                    Console.WriteLine("Type the side C:");
                    c = float.Parse(Console.ReadLine());
                }
                if (a + b > c && b + c > a && a + c > b)
                {
                    Console.WriteLine("\nYou typed:\nA:{0}\nB:{1}\nC:{2}\n", a, b, c);
                    Console.WriteLine("The triangle exists");
                    triangleType = TriangleSolver.Analyze(a, b, c);

                    Program p = new Program();
                    Program.Main(null);
                }
                else
                {
                    Console.WriteLine("Triangle doesn't exist, try again\n");
                    triangleType = "Triangle doesn't exist, try again\n";
                }
                Console.ReadLine();
            }
            else if (userInput == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You wrote the wrong number, please try again.");
                Program p = new Program();
                Program.Main(null);

            }

            return triangleType;
        }
        public static string Analyze(float a,float b,float c)
        {
            string triangleType=""; // line 61
            if (a==b && b==c)   // line 62
            {
                Console.WriteLine("The triangle is EQUILATERAL\n");
                triangleType = "The triangle is EQUILATERAL\n";
            }
            else if (a==b || b==c || c==a) //line 67
            {
                Console.WriteLine("The triangle is ISOSCELES\n");
                triangleType = "The triangle is ISOSCELES\n";
            }
            else if (a!=b && b!=c) //line 72
            {
                Console.WriteLine("The triangle is SCALENE\n");
                triangleType = "The triangle is SCALENE\n";
            }
            return triangleType; //line 77
        }
    }
}
