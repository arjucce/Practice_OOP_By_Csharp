using PracticeConsoleApp;
using PracticeConsoleApp.DoWhile;
using PracticeConsoleApp.Interface.Service;
using PracticeConsoleApp.Polymorphism;
using PracticeConsoleApp.StaticClass;

Palindrome palindrome= new Palindrome();
CalculationService calculationService= new CalculationService();
DW dW = new DW();
OutParameter outParameter = new OutParameter();
//Can not create object using static class
//Calculator calculator = new Calculator();

//Polymorphism
Calculate calculate= new Calculate();
Calculate sum1 = new Sum1();
Calculate sum2 = new Sum2();


//palindrome.Reverse();
//palindrome.CheckPalindrome();
//calculationService.Multiplication();
//calculationService.UsingDoWhileMultiplication();
//calculate.Sum();
//sum1.Sum();
//sum2.Sum();
//dW.SetDay();
//outParameter.CircleArea();

//Static class example
Calculator.Sum();
Console.WriteLine($"The Big Number is: {Calculator.BigNumber}");
Console.WriteLine($"The Big Number is: {Calculator.SmallNumber}");
