//Using the Visual Studio Solution provided in the starting files as a starting point,
//write a recursive method to determine if a string is a palindrome.  The method should take a
//string s as its parameter and return a bool. Use your method to write an application that asks
//the user to enter a word or phrase from the keyboard and then tells the user whether or not the
//text that they entered is a palindrome.  Capitalization whitespace and punctuation should be
//removed before calling your function.


//Input 
    //user enters a word or phrase, string 

//Proccessing
    //takes string s as its parameter 
    //Capitalization and punctuation should be removed from the string s from input
    //calcualate the string to a reverse and compare the first instance to the second, this equals a palindrome. 
    //checks whether the word is a palindrome or not 
        //if word is palindrome then return a bool - (Whether the string is the same backwards and forwards)


//Output
    //outputs whether the string entered is a palindrome or not. 



using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word or phrase:");
            string input = Console.ReadLine();

            // Check if the input string is a palindrome
            bool isPalindrome = Palindrome(input);

            // Output the result
            if (isPalindrome)
                Console.WriteLine("The entered text is a palindrome.");
            else
                Console.WriteLine("The entered text is not a palindrome.");




            static bool Palindrome(string str)
            {
                // Remove capitalization, whitespace, and punctuation
                string polishedInput = str.ToLower();
                polishedInput = new string(Array.FindAll(polishedInput.ToCharArray(), char.IsLetterOrDigit));

                // Base case: if the string is empty or has only one character, it's a palindrome
                if (polishedInput.Length <= 1)
                    return true;

                // Compare the first and last characters
                if (polishedInput[0] != polishedInput[polishedInput.Length - 1])
                    return false;

                // check the substring without the first and last characters by calling the recursion
                return Palindrome(polishedInput.Substring(1, polishedInput.Length - 2));
            }




        }
    }
}
