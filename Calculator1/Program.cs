
using System;
using Moq;

public class Program
{
    public static void Main(string[] args)
    {
        int num1;
        int num2;
        string Symbol;
        double result;
        Console.WriteLine("Welcome to My Calculator!");
        Console.WriteLine("");
        Console.WriteLine("Enter the first number: ");
         num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        num2= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Operation needed");
        Symbol = Console.ReadLine();

        Calcolo calcolo = new Calcolo();

        Calculator5 Calculator5 = new Calculator5(calcolo);

        switch (Symbol)
        {
            case "+":
                result = Calculator5.Sum(num1 , num2);
                Console.WriteLine(result);
                break;
            case "-":
                result = Calculator5.Diffrence(num1, num2);
                Console.WriteLine(result);
                break;
            case "*":
                result = Calculator5.Multiplication(num1, num2);
                Console.WriteLine(result);
                break;
            case "/":
                result = Calculator5.Division(num1, num2);
                Console.WriteLine(result);
                break;
            default:
                Console.WriteLine("Your input was not correct.");
                break;
        }

    }
}