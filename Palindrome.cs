namespace PracticeConsoleApp
{
    internal class Palindrome
    {
        public void Reverse()
        {
            Console.WriteLine("Plesase enter a number");
            int a = int.Parse(Console.ReadLine());
            int reverse = 0;
            char[] ch = a.ToString().ToCharArray();
            Array.Reverse(ch);            
            reverse = int.Parse(ch);
            Console.WriteLine("Reverse Number: {0}", reverse);
        }

        public void CheckPalindrome()
        {
            Console.WriteLine("Plesase enter a number");
            int a = int.Parse(Console.ReadLine());
            int reverse = 0;
            char[] ch = a.ToString().ToCharArray();
            Array.Reverse(ch);
            reverse = int.Parse(ch);

            if(a == reverse)
            {
                Console.WriteLine("This number is palindrome and checked");
            }
            else
            {
                Console.WriteLine("This number is not palindromed and checked");
            }            
        }
    }
}
