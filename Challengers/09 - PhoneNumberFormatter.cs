using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public class PhoneNumberFormatter
    {
        /*
            Title: Phone Number Formatter

            Difficulty: Easy

            Description: Write a C# function that takes a string phone number as input and formats it to a standard format (XXX) XXX-XXXX. 
            The phone number can have any combination of digits and any number of digits in it. 
            If the phone number is not valid, the function should return null.

            Example:

                Input: "123-456-7890"
                Output: (123) 456-7890

                Input: "123 456 7890"
                Output: (123) 456-7890

                Input: "1234567890"
                Output: (123) 456-7890

                Input: "12-345-67-890"
                Output: null
         */
        public static string GetPhoneNumberFormatter(string phoneNumber ) {
            
            // Remove any non-digit characters from the input
            string digitsOnly = new string(phoneNumber.Where(char.IsDigit).ToArray());

            // Check if the input is a valid 10-digit phone number
            if (digitsOnly.Length != 10)
            {
                throw new ArgumentException("Input is not a valid 10-digit phone number");
            }

            var firstPartNumerCounter = 0;
            var secondPartNumerCounter = 0;
            var thirdPartNumerCounter = 0; 
             

            for (int i = 0; i < phoneNumber.Length; i++)
            {

                if(firstPartNumerCounter < 3)
                {
                    var isNumber = char.IsDigit(phoneNumber[i]);

                    if (isNumber)
                    {
                        firstPartNumerCounter++; 
                        continue;
                    }
                    else
                    {
                        if(firstPartNumerCounter > 0)
                        {
                            return "Format to first part of phoneNumber is Invalid. Needs 3 digits together, ex: -123-";
                        } 
                    }
                }
                else
                {
                    if (secondPartNumerCounter < 3)
                    {
                        var isNumber = char.IsDigit(phoneNumber[i]);

                        if (isNumber)
                        {
                            secondPartNumerCounter++; 
                            continue;
                        }
                        else
                        {
                            if (secondPartNumerCounter > 0)
                            {
                                return "Format to secound part of phoneNumber is Invalid. Needs 3 digits together, ex: -123-";
                            }
                        }
                    }
                    else if(thirdPartNumerCounter < 4)
                    {
                        var isNumber = char.IsDigit(phoneNumber[i]);

                        if (isNumber)
                        {
                            thirdPartNumerCounter++;
                            continue;
                        }
                        else
                        {
                            if (thirdPartNumerCounter > 0)
                            {
                                return "Format to third part of phoneNumber is Invalid. Needs 4 digits together, ex: -1234-";
                            }
                        }
                    } 
                } 
                
                if(firstPartNumerCounter != 3 && secondPartNumerCounter != 3 && thirdPartNumerCounter != 4)
                {
                    return $"Format of {phoneNumber} is Invalid needs together: part1: 3 nums, part2: 3 muns and part3 4 nums";
                }
            } 

            // Format the phone number as "(xxx) xxx-xxxx"
            return String.Format("({0}) {1}-{2}",
                digitsOnly.Substring(0, 3),
                digitsOnly.Substring(3, 3),
                digitsOnly.Substring(6, 4));

        }
    
     
    }
}
