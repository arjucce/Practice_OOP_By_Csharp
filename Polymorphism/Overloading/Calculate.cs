using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Polymorphism.Overloading
{
    internal class Calculate
    {
        public int Sum(int a,int b)
        {            
            return a + b;
        }

        public float Sum(float a, float b)
        {
            return a + b;
        }

        public double Sum(double a, double b)
        {           
            return a + b;
        }
    }
}
