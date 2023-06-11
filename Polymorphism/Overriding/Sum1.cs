namespace PracticeConsoleApp.Polymorphism.Overriding
{
    internal class Sum1 : Calculate
    {
        //Method overriding
        public override void Sum()
        {
            Console.WriteLine(2 + 3);
        }
    }
}
