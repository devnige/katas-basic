﻿using System.Linq.Expressions;
using System.Net.WebSockets;
using System;

namespace basic_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine("Which calculation would you like to do today?");
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine("Enter A if you want to take a number n and print the sum of numbers 1 to n");
            System.Console.WriteLine("Enter B if you want to take a number n and print the sum of numbers 1 to n if it is a multiple of three or five.");
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine("Choose A or B: ");
            var userCalcChoice = Console.ReadLine().ToUpper();
            System.Console.WriteLine(Environment.NewLine+Environment.NewLine);
            Console.WriteLine("Enter a number: ");
            var inputLastNum = Console.ReadLine();
            
            int lastNum;
            const int divisor1 = 0;
            const int divisor2 = 5;



            var IsValidNum = Int32.TryParse(inputLastNum, out lastNum);
            
            Calculator calc = new Calculator ();
            
            
            if(userCalcChoice == "A")
            {
                var result = calc.CalculateSum(lastNum);
                System.Console.WriteLine("The sum of all numbers from 1 to {0} is {1} ", lastNum, result);
            }
            else if(userCalcChoice == "B")
            {
                try
                {
                var result = calc.CalculateSumOfRemainder(lastNum, divisor1, divisor2);
                System.Console.WriteLine("The sum of all numbers from 1 to {0} that are divisible by 3 or 5 is {1} ", lastNum, result);
                }
                catch(ValidationException)
                {
                    System.Console.WriteLine("You have tried to divide by zero. Reassign divisor.");
                }
            }
            else
            {
                System.Console.WriteLine("Invalid choice, sorry bye bye"); 
            }    
        }
    }
}
