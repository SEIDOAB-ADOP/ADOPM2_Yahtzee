using System;
using Seido.Utilities.ConsoleInput;

namespace M3_Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sprint 3
            Console.WriteLine("\n\nSprint 3");

            ICupOfDice cup = null;
            Console.WriteLine($"Newly created cup\n{cup}");

            try
            {
                int _nrDice;
                //ConsoleInput.TryReadInt32("How many dice?", 1, 10, out _nrDice);

                Console.WriteLine("How many dice?");
                string input = Console.ReadLine();
                _nrDice = int.Parse(input);

                ICupOfDice cup2 = null;//new CupOfDice(_nrDice);
                Console.WriteLine($"Newly created cup\n{cup2}");
                Console.WriteLine($"NrOfDice: {cup2.Count}");
                Console.WriteLine($"Dice[0]: {cup2[0]}");
                Console.WriteLine($"Dice[{cup2.Count - 1}]: {cup2[cup2.Count - 1]}");

                Console.WriteLine($"\nSorted cup\n{cup2.Sort()}");
                Console.WriteLine($"Dice[0]: {cup2[0]}");
                Console.WriteLine($"Dice[{cup2.Count - 1}]: {cup2[cup2.Count - 1]}");

                Console.WriteLine($"\nShaken cup\n{cup2.Shake()}");
                Console.WriteLine($"Dice[0]: {cup2[0]}");
                Console.WriteLine($"Dice[{cup2.Count - 1}]: {cup2[cup2.Count - 1]}");

                Console.WriteLine($"\nHighest: {cup2.Highest}");
                Console.WriteLine($"Lowest: {cup2.Lowest}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error running the program, pls try again");
                Console.WriteLine($"Error: {ex.Message}");
            }
            #endregion

            #region sprint 4
            Console.WriteLine("\n\nSprint 4");

            ICupDoubleDice doubleDice = null;
            Console.WriteLine($"Cup of double dices\n{doubleDice}");

            //Continue with your code
            #endregion

            #region sprint 5
            Console.WriteLine("\n\nSprint 5");

            //Test the YahtzeeDices
            ICupYahtzeeDice yahtzeeDice = null;
            Console.WriteLine($"Cup of Yahtzee dices\n{yahtzeeDice}");

            #endregion

            //Continue with your code
            Console.WriteLine("\n\nThank you for playing");
        }
    }
}
