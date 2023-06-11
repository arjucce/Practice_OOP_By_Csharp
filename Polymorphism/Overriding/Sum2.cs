namespace PracticeConsoleApp.Polymorphism.Overriding
{
    internal class Sum2 : Calculate
    {
        public override void Sum()
        {
            Console.WriteLine(2 + 4);
        }
    }
}
