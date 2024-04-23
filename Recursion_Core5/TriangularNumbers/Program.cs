//Using the Visual Studio Solution provided in the starting files as a starting point, write a recursive method to calculate the nth triangular number
//and use it to write an application that displays the first 10 triangular numbers.  The method should take an integer n as its parameter and return an integer. 

//The triangular number T_1 is a figurate number that can be represented in the form of a triangular grid of points where the first row
//contains a single element and each subsequent row contains one more element than the previous one. This is illustrated above for T_1=1, T_2=3, ....
//The triangular numbers are therefore 1, 1+2, 1+2+3, 1+2+3+4, ..., so for n=1, 2, ..., the first few are 1, 3, 6, 10, 15, 21,


//Input 
//taking the defined integer(n) to pass and calcualte the nth trangular number

//Processing
//Check if n = 1, (n == 1 is the base case)
// if n is equal to 1 then return 1
// else call the recursive function at traingularNumber method with n -1 as parameter
// add n to the recurive call
//

//output
//int: n'th triangular number



using System;

namespace TriangularNumbers
 

{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the first 10 triangular numbers with a loop, defined within the main, within the loop, write a string (T) at the iteration(i) to equal triangularNumber method.
            for (int i = 1; i <= 10; i++)
            {
                int triangularNumber = TriangularNumber(i);
                Console.WriteLine($"(T){i} = {triangularNumber}");
            }
        }

        static int TriangularNumber(int n)
        {
            // Base case: if n is 1, return 1
            if (n == 1)
                return 1;

            // Recursive case: call triangularNumber(n-1) and add n
            return TriangularNumber(n - 1) + n;
        }
    }
}



