using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {

        public static void PrintThousand()
        {
            for (int i = 1000; i > -1001; i--) ;
        }

        public static void CountByThree()
        {
            for (int i = 3; i <= 999; i += 3) ;
        }

        public static void EqualOrNot(int num1, int num2)
        {
            if (num1 == num2)
                Console.WriteLine($"{num1} and {num2} are equal.");
            else 
                    Console.WriteLine($" {num1} is not equal to {num2}");
        }
        public static void EvenOrOdd(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine($"{a} is even");
            else
                Console.WriteLine($"{a} is odd");
        }
        
        public static void VotingAge(int age)
        
            { 
                if (age < 18)
            
                Console.WriteLine("Sorry maybe next year!");

                else
                    Console.WriteLine("Vote your little heart out!");
            }
        // Still working on Heating Up Exercises
        

    }
}
