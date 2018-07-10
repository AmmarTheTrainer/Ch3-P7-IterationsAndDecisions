using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_P7_IterationsAndDecisions
{
    enum RizviStyle
    {
        OyeSoora,
        Dalle ,
        DangarDoctorDiyaPutra
    }
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

            //IfElseExample();
            //ExecuteIfElseUsingConditionalOperator();
            //LogicalOperators_ShortCircuting();
            //SwitchExample();
            //SwitchOnStringExample();
            //SwitchOnEnumExample();
            SwitchWithGoto();
            
            // for next lecture 
            //ExecutePatternMatchingSwitch();

            #endregion

            Console.ReadLine();
        }

        private static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice;
            //This is a standard constant pattern switch statement to set up the example
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            //This is new the pattern matching switch statement
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer.");
                    break;
                case string s:
                    Console.WriteLine("Your choice is a string.");
                    break;
                case decimal d:
                    Console.WriteLine("Your choice is a decimal.");
                    break;
                default:
                    Console.WriteLine("Your choice is something else");
                    break;
            }
            Console.WriteLine();


        }

        private static void SwitchWithGoto()
        {
            Console.WriteLine(" Who are you ? [ 1 - lota ] ---  [ any other number ] ");
            int choice = int.Parse( Console.ReadLine());
            //var foo = 5;
            switch (choice)
            {
                case 1:
                    Console.WriteLine(" welcome Mr Lota its time to move on .. ");
                    goto case 2;
                case 2:
                    Console.WriteLine(" this is PTI ");
                    break;


                case 3:
                case 4:
                    //yet another action
                    goto default;


                default:
                    Console.WriteLine(" default ");
                    //default action
                    break;
            }


           

        }

        private static void SwitchOnEnumExample()
        {
            Console.WriteLine(" Enter your favourite Rizwi speaks...! ");
            RizviStyle rizwiTalks;

            //try
            {
                rizwiTalks = (RizviStyle)Enum.Parse(typeof(RizviStyle), Console.ReadLine());
            }
            //catch (Exception )
            {
                //Console.WriteLine(" Gali not found ...");
            }

            switch (rizwiTalks)
            {
                case RizviStyle.OyeSoora:
                    Console.WriteLine(" oye soura .................... found here ");
                    break;
                case RizviStyle.Dalle:
                    Console.WriteLine(" dalle.................... found here ");
                    break;
                case RizviStyle.DangarDoctorDiyaPutra:
                    Console.WriteLine(" dangar doctor diya putra.................... found here ");
                    break;
                default:
                    Console.WriteLine(" no option ");
                    break;
            }

        }

        private static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        private static void SwitchExample()
        {
            Console.WriteLine("1 [ Mehran ], 2 [ FX ]");
            Console.Write("Please pick your Car preference: ");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, Mehran is a noticable car.");
                    break;
                case 2:
                    Console.WriteLine("FX : !");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        private static void LogicalOperators_ShortCircuting()
        {

            //bool b = true | functionA();

            //Console.WriteLine(b);

            //if ( functionA() | functionB() | functionC() )
            //{
            //    Console.WriteLine(" If condition got true ");
            //}
            //else
            //{
            //    Console.WriteLine(" If condition got false < else part executed > ");
            //}
        }

        private static bool functionC()
        {
            Console.WriteLine("function < condition > C executed");
            return false;
        }

        private static bool functionB()
        {
            Console.WriteLine("function < condition > B executed");
            return true;
        }

        private static bool functionA()
        {
            Console.WriteLine("function A executed");
            return true;
        }

        private static void ExecuteIfElseUsingConditionalOperator()
        {
            //int number = 0;
            ////int result = 0 ? 1 : 8;
            //int result = 0==0 ? 1 : 8;
            //Console.WriteLine( result);

            string stringData = "My textual data";
            
            //Console.WriteLine(stringData.Length > 0 ? " > than 0 characters" : " ! > 0 characters");
            Console.WriteLine();

            //bool result = stringData.Length > 0 ? true : false;
            //bool result = stringData.Length > 0 ? "true" : "false";
            //int result = stringData.Length > 0 ? 2 : 1;
            //Console.WriteLine(result);

            // Restrictions ( you can't use this operator without assignment operator )
            // stringData.Length > 0 ? 2 : 1;
        }

        private static void IfElseExample()
        {
            string YourParty = "PML-N or PTI";

            //if (1)
            //{

            //}

            if (YourParty.Length == 1)
            {
                Console.WriteLine(" Your party is greater than zero ");
            }
            else
            {
                Console.WriteLine(" your party is piece of crap ");
            }

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
            bool check = false;
            string userIsDone = "";
            // Test on a lower-class copy of the string.
            while (check )
            {
                Console.WriteLine("\nNo , you are a great Patwari....!");
                Console.Write("Are you Patwari ? [yes] [no]: ");
                userIsDone = Console.ReadLine();
                if (userIsDone == "yes")
                {
                    check = true;
                }
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

            foreach (var vehicle in carTypes)
            {
                Console.WriteLine(vehicle);
            }

            //int[] myInts = { 10, 20, 30, 40 };
            //foreach (int i in myInts)
            //    Console.WriteLine(i);
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
