//write a recursive method to solve the Tower of Hanoi puzzle with n discs.
//The method should take an integer n representing the number of discs and a
//string representing the name of the tower on which the discs start,
//a string representing the name of the tower to which the discs must be
//moved and a string representing the name of the extra tower as its parameters.
//The method does not return a value but displays a message describing each move.
//Use your method to write an application that asks the user to enter how many discs
//they would like and then displays the moves necessary to solve the puzzle.


//Input 
//integer n that represents the number of disks

//Processing
//Check if n equals 1, the base case. 
 //if n does equal 1, then move the disk from the starting tower to the ending tower
   //else call the recursion at (n -1), moving the discs to the goal tower by use of
   //the holding tower at first.
   //then you want to continue the iteration, moving the n'th disk from the start tower to goal tower
   //then finally move the disks from the holding tower to the goal tower, you need to use the starting tower as a holding tower as well
//Output
//console message that will describe each move. 

using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of discs:");
            int discNumber = Convert.ToInt32(Console.ReadLine());

            // Solve the Tower of Hanoi puzzle
            TowerOfHanoi(discNumber, "Start", "Goal", "Holding");
        }

        static void TowerOfHanoi(int n, string start, string goal, string holding)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from {start} to {goal}");
                return;
            }

            TowerOfHanoi(n - 1, start, holding, goal);
            Console.WriteLine($"Move disk {n} from {start} to {goal}");
            TowerOfHanoi(n - 1, holding, goal, start);
        }
    }
}