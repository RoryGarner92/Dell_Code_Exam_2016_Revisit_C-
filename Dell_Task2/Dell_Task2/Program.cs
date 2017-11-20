/*
 Name :         Rory Garner
 College :      IT Carlow
 Course :       Software Development
 Description :  I am looking for a number that is the porduct of two three digit numbers (e.g 999*999),
                the number must also be a palindrome and the largest 
                
 Solution :     I use a nested for loop starting at 999 and working back to 0 (looking for the largest)
                I pass the product of the index position of the two loops i&j to the function
                The function uses mod10 to reverse the number and check to see if its a palindrome 
                I also use a shared variable to initialize the size of the loop which is reduced by one each pass of the inner loop */
using System;
using System.Diagnostics;

namespace Dell_Task2
{
    class Program
    {   //using mod 10 to reverse the number rather than converting to a string
        public static bool CheckNumberIsPalindrome(ref int num)
        {
            var palindromeValue = false;
            var checkNumber = num;
            var reverseNumber = 0;

            while (num > 0)
            {
                var remainder = num % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                num = num / 10;
            }

            if (checkNumber == reverseNumber)
            {
                palindromeValue = true;
            }

            return palindromeValue;
        }

        public static void Main()
        {
            var count = 999;
            var sum = 0;
            //var sw = Stopwatch.StartNew();

            for (var i = count; i >= 100; --i) //993
            {
                for (var j = count; j >= 100; --j) //913 
                {
                    var answer = i * j;
                    var var1 = answer;

                    if (CheckNumberIsPalindrome(ref var1) && answer > sum)
                    {
                        sum = answer;
                    }
                }
                count--;
            }
            //sw.Stop();
            //Console.WriteLine($"Time to calculate in milliseconds : {sw.ElapsedMilliseconds}");
            Console.WriteLine("The largest palindrome, that is also the product of 3 numbers : " + sum);
            Console.ReadKey();
        }
    }
}

