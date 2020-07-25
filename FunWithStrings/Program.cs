using System;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("Lets have some fun with strings! \nWhat would you like to do?\n 1) Just print a word you boring boring person:\n 2) Put in alphebetical order\n 3) Reverse the word\n 4) Find out length");
            string manipulationType = Console.ReadLine();
            if (manipulationType == "1")
            {
                PrintResult(StringEnter());
                Continue();
            }

            else if (manipulationType == "2")
            {
                PrintResult(AlphabeticOrder(StringEnter()));
                Continue();
            }

            else if (manipulationType == "3")
            {
                PrintResult(ReverseString(StringEnter()));
                Continue();
            }

            else if (manipulationType == "4")
            {
                PrintResult(Length(StringEnter()));
                Continue();
            }

            else
            {
                Console.Clear();
                MainMenu();
            }
        }

        private static string StringEnter()
        {
            Console.Clear();
            Console.Write("Enter a word you want to manipulate: ");
            string enteredWord = Console.ReadLine();
            return enteredWord;
        }

        private static void PrintResult(string eW)
        {
            Console.WriteLine(eW);
            Console.Read();
        }

        private static string ReverseString(string eW)
        {
            char[] eWArray = eW.ToCharArray();
            Array.Reverse(eWArray);
            string revString = String.Concat(eWArray);
            return revString;
        }

        private static string AlphabeticOrder(string eW)
        {
            char[] eWArray = eW.ToCharArray();
            Array.Sort(eWArray);
            string alphabeticOrder = String.Concat(eWArray).ToLower();
            return alphabeticOrder;
        }

        private static string Length(string eW)
        {
            string stringLength = eW.Length.ToString();
            return stringLength;
        }

        private static void Continue()
        {
            Console.Clear();
            Console.Write("Do you want to play again? y/n: ");
            Console.Read();
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain == "y")
            {
                MainMenu();
            }

            else if (playAgain == "n")
            {
                Environment.Exit(0);
            }

            else
            {
                for (int i = 0; i < 1000000; i++)
                {
                    Console.Write("Not an Option Mike is King ");
                }
                Console.Write("GoodBye");
                Console.Read();
            }
        }
    }
}
