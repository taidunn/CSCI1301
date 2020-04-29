//****************************************************************************
//****************************************************************************
//
// Your Name Here
// CSCI 1301A/B
// Programming Assignment 7
// Deadline: Friday, April 24th, 2020.
// Date of Submission
//
// SourceCodeFileNameHere.cs
//
//***************************************************************************
//***************************************************************************

using System;

namespace AllPermutations
{
   class Program
   {
      static int LIMIT = 5;
      static void Main(string[] args)
      {
         int[] Permutation = new int[LIMIT];

         // Initalisation of the permutation vector
         for (int i = 0; i < LIMIT; ++i)
         {
            Permutation[i] = i + 1;
         }

         Permutations(LIMIT, ref Permutation); // You are asked to implement this method

      }
      static void Permutations(int n, ref int[] Array)
      {
         // DO NOT change any code above this line
         // write your code below this line, make sure you report all permutations here
         if (n != 1)
         {
            //Random random = new Random();
            //int r = random.Next(0, n - 2);
            int r = 0;
            for (r = 0; r < LIMIT; r++)
            {
               Swap(n - 1, r, ref Array);
               Permutations(n - 1, ref Array);
               PrintArray(Array);
            }
         }
      }

      static void PrintArray(int[] Array)
      {
         int h = 0;
         for (h = 0; h < Array.Length; h++)
         {
            Console.Write($"{Array[h]}, ");
         }
         Console.WriteLine();
      }

      // write yuor code above this line
      // DO NOT change any code below this line

      static void Swap(int i, int j, ref int[] Array)
      {
         int temp = Array[i];
         Array[i] = Array[j];
         Array[j] = temp;
      }
   }
}
