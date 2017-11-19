using System;

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
            Console.WriteLine("The largest palindrome, that is also the product of 3 numbers : " + sum);
            Console.ReadKey();
        }
    }
}

