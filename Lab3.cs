using System;

namespace Lab_Exercise_3
{

   class Hidden
   {
      private int number;

      public int Number
      {
         get
         {
            return number;
         }
         set
         {
            number = value;
         }
      }
      //public int GetValue()
      //{
      //   return number;
      //}

      //public void SetValue(int initiate)
      //{
      //   number = initiate;
      //}
   }


   class Program
   {
      static void Main(string[] args)
      {

         int number1 = 0;
         int number2 = 0;

         Random rnd = new Random();
         int randomNumber = rnd.Next(100);

         Hidden unknown = new Hidden();
         unknown.Number = (randomNumber);

         Console.WriteLine("!!! Guess my number !!!\n");

         Console.WriteLine("You have two chances to guess my number from the range 0 .. 99\n");
         Console.Write("Guess my number in the first attempt: ");
         number1 = int.Parse(Console.ReadLine());

         if (number1 > unknown.Number )
         {
            Console.WriteLine($"Your number {number1} is greater than mine by {number1 - unknown.Number}");
         }

         if (number1 < unknown.Number )
         {
            Console.WriteLine($"Your number {number1} is smaller than mine by {unknown.Number  - number1}");
         }

         if (number1 == unknown.Number )
         {
            Console.WriteLine($"You guessed my number {number1} in the first attempt!!");
         }
         else
         {
            Console.Write("\nGuess my number knowing the answer above: ");
            number2 = int.Parse(Console.ReadLine());

            if (number2 == unknown.Number )
            {
               Console.WriteLine($"\nYou guessed my number {number2} in the second attempt!!\n");
            }
            else
            {
               Console.WriteLine($"\nYou failed to guess my number {unknown.Number } in the second attempt!!\nBetter luck next time.\n");
            }
         }

      }
   }
}
