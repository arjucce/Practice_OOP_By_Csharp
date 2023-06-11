namespace PracticeConsoleApp.Interface.Service
{
    internal class CalculationService:ICalculation
    {
        public void Sum()
        {
            Console.WriteLine("Enter first number:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int y = int.Parse(Console.ReadLine());

            int result = x + y;
            Console.WriteLine("Summation result : {0}", result);
            Console.ReadKey();
        }

        public void Multiplication()
        {
            try
            {
                Console.WriteLine("Which number you want to table multiplier ?");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(a * i);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }            
        }

        public void UsingDoWhileMultiplication()
        {
            try
            {
                Console.WriteLine("Which number you want to table multiplier ?");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int i = 0;
                
                do
                {
                    Console.WriteLine(i * a);
                    i++;
                }
                while (i <= 10);
                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

    }
}
