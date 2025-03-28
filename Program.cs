

using System;
using DotNetLab01;

internal class Program
{
    private static void Main(string[] args)
    {
        //Assignment 1: Printing Hello and Name in separate line
        Console.WriteLine("Hi");
        Console.WriteLine("Saragam Adhikari");


        //Assignment 2: Swapping Two numbers
        Console.Clear();
        Console.WriteLine("Enter the first number for swapping: \n");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number for swapping: \n");
        int input2 = Convert.ToInt32(Console.ReadLine());
        Swapping swap = new Swapping();
        swap.swapping(input1, input2);


        //Assignment 3: Finding largest among 3 numbers 
        Console.Clear();
        Console.WriteLine("Enter the first number : \n ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number : \n ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number : \n ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Largest largest = new Largest();
        largest.largest(num1, num2, num3);


        //Assignment 4: Check Even or Odd
        Console.Clear();
        Console.WriteLine("Enter the value : \n");
        int val1 = Convert.ToInt32(Console.ReadLine());
        EvenOdd evenOdd = new EvenOdd();
        evenOdd.evenodd(val1);


        //Assignment 5: Sum of n natural numbers
        Console.Clear();
        Console.WriteLine("Enter the number: \n");
        int n = Convert.ToInt32(Console.ReadLine());
        Sumofnaturalno sum = new Sumofnaturalno();
        sum.sum(n);

        //Assignment 6: To check the year is leap year or not
        Console.Clear();
        LeapYear leapYear = new LeapYear();
        leapYear.leap();

        //Assignment 7: Sum of its elements in Array
        Console.Clear();
        arraySum arraySum = new arraySum();
        arraySum.ArraySum();

        //Assignment 8 : To find the factorial of the number
        Console.Clear();
        Console.WriteLine(" -To find the Factorial- ");
        Factorial fact = new Factorial();
        fact.calculateFactorial();
        Console.ReadKey();

        //Assignment 9 : To Check whether the number is prime or not.
        Console.Clear();
        PrimeNum primeNum = new PrimeNum();
        primeNum.checkPrimeNumber();
        Console.ReadKey();


    }
} 

