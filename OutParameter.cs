using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class OutParameter
    {
        public void CircleArea()
        {
            Console.WriteLine("Enter the radious for a circle:");
            double  a = double.Parse(Console.ReadLine());
            double b = CalculateCircle(a, out double area);

            Console.WriteLine($"Circle's circumference is {b}");
            Console.WriteLine($"Circle's area is {area}");
            Console.ReadKey();
        }

        private double CalculateCircle(double a, out double area)
        {
            area = Math.PI * Math.Pow(a, 2);
            double circumference = 2 * Math.PI * a;
            return circumference;
        }
    
    
        public void Sum()
        {
            Console.WriteLine("Enter number :");
            int a = int.Parse(Console.ReadLine());
            int result = GetSum(a, out int b);
            Console.WriteLine($"a : {result} and b : {b} ");
        }

        private int GetSum(int a, out int b)
        {
            b = a + 100;//105
            a = b + 10;
            return a;
        }
    }
}
