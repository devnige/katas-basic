using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System;

namespace basic_coding
{
    public class Calculator
    {    
        public int CalculateSum (int lastNum)
        {
            int sum = 0;
            for (var i=1; i<=lastNum; i++)
            {
                sum += i;
            }
            return sum;
        }
             
        public int CalculateSumOfRemainder (int lastNum, int divisor1, int divisor2)
        {  
            var validator = new Validations ();
            if(validator.isNumberZeroOrLess(divisor1) || validator.isNumberZeroOrLess(divisor2))
            {
                throw new ValidationException ();
            }
            int sum = 0;
            for (var i=1; i<=lastNum; i++)
            {
                if(i % divisor1 == 0 || i % divisor2 == 0) // conditional if i is divisible by divisor 1 or divisor 2
                {
                    sum += i;
                }
            }
            return sum;
        }

        public int CalculateProd (int lastNum)
        {
            int prod = 1; // can't be zero because it will always give a product of zero!
            for (var i=1; i<=lastNum; i++)
            {
                prod *= i;
            }
            return prod;
        }

        public void MultiplyTable (int lastNum)
        {
            for(var i=1; i<=lastNum; i++)
            {
                for (var j=1; j<=10; j++)
                {
                    System.Console.WriteLine("{0}*{1}={2}", i, j, i*j);
                }
                System.Console.WriteLine();
            }
            // Keep the console open in debug mode
            System.Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}