/*
Using the Visual Studio Solution provided in the starting files as a starting point, write a recursive method to calculate the nth fibonacci number and use it to write an application that displays the first 10 fibonacci numbers.  The method should take an integer n as its parameter and return an integer.

In mathematics, the Fibonacci numbers, commonly denoted Fn, form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,{\displaystyle F_{0}= 0,\quad F_ {1} = 1,} and {\displaystyle F_{n}= F_{ n - 1}
+F_{ n - 2},} for n > 1.The beginning of the sequence is thus:

    {\displaystyle 0,\; 1,\; 1,\; 2,\; 3,\; 5,\; 8,\; 13,\; 21,\; 34,\; 55,\; 89,\; 144,\;\ldots }

*/


//Input 
//the nth number, int type(Fibonacci number to calculate)

//Processing
//base number
    //Check if n is 0 or 1
    //if n is 0, return 0
    //if n is 1, return 1
    //calculate (n -1) and (n-2), for n > 1
//call to recursive function(condition)
    //Fibonacci(n-1)
    //Fibonaci(n-2)
    //Add the results of the recursive calls 
//output
//fibbanacci 1 through 10

using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the first 10 Fibonacci numbers with a loop, defined within the main, within the loop, write a string (F) at the iteration(i)
            // to equal fibonacci method.
            for (int i = 0; i <= 10; i++)
            {
                int fibonacci = Fibonacci(i);
                Console.WriteLine($"(F){i} = {fibonacci}");
            }
        }


        static int Fibonacci(int n ) {
           
            // Base case: if n is 0, return 0
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            // Recursive case: return Fibonacci(n-1) + Fibonacci(n -2)
            return Fibonacci(n - 1) + Fibonacci(n -2);

        }


    }
}
