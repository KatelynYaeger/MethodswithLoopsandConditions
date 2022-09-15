using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace MethodsWithLoopsandConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTable();

        }



        //Write a method that will print to the console all numbers 1000 through -1000.

        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static void PrintByThrees(int floor, int ceiling)
        {
            for (int i = floor; i <= ceiling; i += 3)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method to accept two integers as parameters and check whether they are equal or not.


        public static bool IsEqual(int a, int b)
        {
            if (a==b)
            {
                return true;
            }

            return false;

            //return (a == b);
            
        }

        //Write a method to check whether a given number is even or odd.

        public static bool EvenCheck(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }

            return false;
            
            //return (a % 2 == 0);
        }


        //Write a method to check whether a given number is positive or negative.

        public static bool IsPositive(int a)
        {
            if (a >= 0)
            {
                return true;
            }

                return false;
        }



        //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!


        
        public static bool VotingAge(int a)

        {
            Console.WriteLine("How old are you?");
            int userAnswer = int.Parse(Console.ReadLine());
            bool result = userAnswer > 17;

            if (result)
            {
                Console.WriteLine("You're old enough to vote");
            }

            else
            {
                Console.WriteLine("You're too young to vote");
            }
            return result;

        }

        //Write a method to check if an integer (from the user) is in the range -10 to 10.

        public static bool WithinRange(int a)
        {
            Console.WriteLine("Give me a number please");
            int userInteger = int.Parse(Console.ReadLine());
            bool result = userInteger >= -10 && userInteger <= 10;
            if (result)
            {
                Console.WriteLine($"{userInteger} is in range");
            }

            else
            {
                Console.WriteLine($"{userInteger} is not in range");
            }

            return result;
        }


        //Write a method to display a given integer's multiplication table(from 1 to 12).

        public static void MultiplicationTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write(i * j  + "\t");
                }

                Console.WriteLine("new row");
            }
            Console.ReadLine();
        }



    }




}
