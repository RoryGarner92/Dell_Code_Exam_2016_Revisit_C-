/*
 Name :         Rory Garner
 College :      IT Carlow
 Course :       Software Development
 Description :  Looking for the largest factor of a set number
                
 Solution :    For this one I had to do a bit of reading to refresh.
               Worth noting about this number (not devisable by 2 so I can eliminate all the evens )
               I set my inital factor to 3 for this reason (smallest odd number)
               I check to see if the number divided into is a factor then increment by 2 hitting all the odd numbers 

               */
using System;
using System.Diagnostics;

namespace Dell_Task1
{
    class Program
    {
        static void Main()
        {
            var longNumber = 600851475143L; 
            var factor = 3;
            //var sw = Stopwatch.StartNew();
        
            while (longNumber > 1)
            {
                if (longNumber % factor != 0)
                {
                    factor += 2; 
                }
                else
                {
                    longNumber = longNumber / factor;
                }       
            }
            //sw.Stop();
           // Console.WriteLine($"Time to calculate in milliseconds : {sw.ElapsedMilliseconds}");
            Console.WriteLine("The answer is : " + factor);
            Console.ReadKey();
        }
    }
}
