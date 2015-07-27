using NUnit.Framework;
using System;

namespace Task1
{
    class Solution
    {
        public void solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)         
            for (int integer = 1; integer <= N; integer++)
            {
                string currentLine = string.Empty;
                if ((integer % 3) == 0)
                    currentLine += "Fizz";
                if ((integer % 5) == 0)
                    currentLine += "Buzz";
                if ((integer % 7) == 0)
                    currentLine += "Woof";
                if (currentLine == string.Empty)
                    currentLine += integer;                
                System.Console.WriteLine(currentLine);
            }            
        }
    }

    [TestFixture()]
    public class Task1Tests
    {
       
        [Test()]
        public void Test1()
        {
            Solution instance = new Solution();
            string result = 
                    @"1
                    2
                    Fizz
                    4
                    Buzz
                    Fizz
                    Woof
                    8
                    Fizz
                    Buzz
                    11
                    Fizz
                    13
                    Woof
                    FizzBuzz
                    16
                    17
                    Fizz
                    19
                    Buzz
                    FizzWoof
                    22
                    23
                    Fizz";            
            instance.solution(24);
            
        }
       
    }


}
