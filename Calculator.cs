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
                if(i % divisor1 == 0 || i % divisor2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }


    }
}