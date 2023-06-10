using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.DoWhile
{
    internal class DW
    {
        public void SetDay()
        {
            Console.WriteLine("Which day you want for ?");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            int[] b = { a };
            ArrayList array = new ArrayList();
            for (int i = 0;i < 4; i++) 
            {
                array.Add(b[0]);
            }
            
            for(int j=0;j< array.Count;j++)
            {
                Console.WriteLine(array[j]);
            }
            

            switch(a)
            {
                case 1: 
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;                
            }

        }
    }
}
