using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class LineComparisionProblem
    {
        public static void LengthCalculation()
        {
            //UC1
            Console.WriteLine("Welcome to line comparision computation");
            Console.WriteLine("enter the value of co-ordinates");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double LengthOfLine1 = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine(LengthOfLine1);

            Console.WriteLine("Welcome to line comparision computation");
            Console.WriteLine("enter the value of co-ordinates");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            double LengthOfLine2 = (double)Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine(LengthOfLine2);

            //UC2

            if (Equals(LengthOfLine1, LengthOfLine2))
            {
                Console.WriteLine(" Both Lines are Equals ");
            }
            else
            {
                Console.WriteLine(" Both lines are not equal ");
            }

            //uc3

            if (LengthOfLine1.CompareTo(LengthOfLine2) < 0)
            {
                Console.WriteLine("LengthOfLine2 is greater than lengthOfLine1");
            }
            else
            {
                Console.WriteLine("LengthOfLine1 is greater than lengthOfLine2");
            }
            
                

        }
    }
}
