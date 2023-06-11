using PracticeConsoleApp;
using PracticeConsoleApp.DoWhile;
using PracticeConsoleApp.Interface;
using PracticeConsoleApp.Interface.Service;
using PracticeConsoleApp.Polymorphism;
using PracticeConsoleApp.Polymorphism.Overloading;
using PracticeConsoleApp.Polymorphism.Overriding;
using PracticeConsoleApp.StaticClass;

Palindrome palindrome= new Palindrome();
CalculationService calculationService= new CalculationService();
DW dW = new DW();
OutParameter outParameter = new OutParameter();
//Can not create object using static class
//Calculator calculator = new Calculator();
 
//Polymorphism-Overriding
PracticeConsoleApp.Polymorphism.Overriding.Calculate calculate= new PracticeConsoleApp.Polymorphism.Overriding.Calculate();
PracticeConsoleApp.Polymorphism.Overriding.Calculate sum1 = new Sum1();
PracticeConsoleApp.Polymorphism.Overriding.Calculate sum2 = new Sum2();

//Polymorphism-Overloading
PracticeConsoleApp.Polymorphism.Overloading.Calculate calculate1 = new PracticeConsoleApp.Polymorphism.Overloading.Calculate();


//palindrome.Reverse();
//palindrome.CheckPalindrome();
calculationService.Multiplication();
calculationService.UsingDoWhileMultiplication();
//calculate.Sum();
//sum1.Sum();
//sum2.Sum();
//dW.SetDay();
//outParameter.Sum();

//Static class example
//Calculator.Sum();
//Console.WriteLine($"The Big Number is: {Calculator.BigNumber}");
//Console.WriteLine($"The Big Number is: {Calculator.SmallNumber}");

//int a = calculate1.Sum(1,2);
//double b = calculate1.Sum(2.32, 1.34);
//Console.WriteLine($"{a} {b}");
