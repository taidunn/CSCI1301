//****************************************************************************
//****************************************************************************
//
// Tai Dunn
// CSCI 1301CD
// Lab Exercise 2
// 02/03/2020
//
// Fundamentals.cs
//
//***************************************************************************
//***************************************************************************

using System;

namespace Lab_Exercise_2
{
   class Fundamentals2
   {
      static void Main(string[] args)
      {
         //Initializing 'i' you will see more how this is used below.'
         int i = 0;

         int number1 = 0;
         int number2 = 0;
         int abs = 0;
         int absdiff = 0;



         //Asking for the user to input their name and storing it in hold1 string.
         Console.WriteLine("What is your name? ");
         string name = Console.ReadLine();

         //Welcoming the user to my program.
         Console.WriteLine($"Welcome to my number sorter {name} \n");

         //Asking for user to input their first number.
         //Storing their number in an integer value (number1).
         Console.Write("Please enter your first number: ");
         number1 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their second number.
         //Storing their number in an integer value (number2).
         Console.Write("\nPlease enter your second number: ");
         number2 = Convert.ToInt32(Console.ReadLine());

         //*********************************************************************
         /* Dealing with the first number */
         //*********************************************************************
         Console.Write($"\nGetting your first number ({number1}) modulus of 5.");
         System.Threading.Thread.Sleep(1000);
         Console.Write(".");
         System.Threading.Thread.Sleep(1000);
         Console.Write(".");

         //Placing the modulus in an integer value.
         int nummod1 = (number1 % 5);
         Console.WriteLine($"\nThe remainder of {number1} modulus 5 is {nummod1}.");

         //*********************************************************************
         /* Dealing with the second number */
         //*********************************************************************
         Console.Write($"\nGetting your second number ({number2}) modulus of 5.");
         System.Threading.Thread.Sleep(1000);
         Console.Write(".");
         System.Threading.Thread.Sleep(1000);
         Console.Write(".");

         int nummod2 = (number2 % 5);
         Console.WriteLine($"\nThe remainder of {number2} modulus 5 is {nummod2}.");
         //*********************************************************************


         //*********************************************************************
         /* Dealing with the second number */
         //*********************************************************************
         Console.Write($"\nGetting the absolute value.");
         System.Threading.Thread.Sleep(1000);
         Console.Write(".");
         System.Threading.Thread.Sleep(1000);
         Console.Write(".");

         if (number1 > number2)
         {
            abs = number1 - number2; 
         }
         else
         {
            abs = number2 - number1;     
         }

         Console.WriteLine($"\n The absolute value of {number1} and {number2}" +
              $" is {abs}.");

         absdiff = (abs % 5);
         Console.WriteLine($"\nThe remainder of the absolute difference " +
            $"({abs}) modulus 5 is {absdiff}.");


         Console.WriteLine("\n( •_•)O*¯`·.¸.·´¯`°Q(•_• )");
         //*********************************************************************

      }
   }
}
