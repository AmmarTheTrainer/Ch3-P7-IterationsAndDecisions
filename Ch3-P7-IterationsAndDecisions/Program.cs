using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_P7_IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {

            // chapter 3 - project 7 - Loops and decisions

            #region - 1 - C# Iteration Constructs




            //ForLoopExample();
            //ForEachLoopExample();
            //LinqQueryOverInts();
            //WhileLoopExample();
            //DoWhileLoopExample();

            #endregion

            #region - 2 - Decision Constructs and the Relational/Equality Operators



            #endregion

            Console.ReadLine();
        }

        private static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
            while (userIsDone.ToLower() != "yes"); // Note the semicolon!
        }

        private static void WhileLoopExample()
        {
            string userIsDone = "";
            // Test on a lower-class copy of the string.
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("\nNo , you are a great Patwari....!");
                Console.Write("Are you Patwari ? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        private static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
        }

        private static void ForEachLoopExample()
        {
            string[] carTypes = { "Mehran", "Civic", "YBR", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);
            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
                Console.WriteLine(i);
        }

        private static void ForLoopExample()
        {
            // Note! "i" is only visible within the scope of the for loop.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // "i" is not visible here.
        }
    }
}
