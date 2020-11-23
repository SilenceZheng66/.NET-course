using System;
using System.Collections.Generic;
using System.Text;

namespace TheRightPriceGame
{
    public class Game
    {
        public void PlayTheGame()
        {
            var mysteryNumber = GetAMysteryNumberBetween0To10();
            var isGameFinished = false;

            while (!isGameFinished)
            {
                isGameFinished = LetTheUserPlayTheGame(mysteryNumber, isGameFinished);
            }
        }

        private int GetAMysteryNumberBetween0To10()
        {
            var random = new Random();
            var mysteryNumber = random.Next(0, 10);
            return mysteryNumber;
        }

        private bool LetTheUserPlayTheGame(int mysteryNumber, bool isGameFinished)
        {
            try
            {
                var input = GetUserInput();
                isGameFinished = ManageUserInput(mysteryNumber, input);
            }
            catch (Exception e)
            {
                Console.WriteLine("This is not a number.");
            }

            return isGameFinished;
        }

        private int GetUserInput()
        {
            Console.WriteLine("\nFind my mystery number");
            var input = Int32.Parse(Console.ReadLine());
            return input;
        }

        private  bool ManageUserInput(int mysteryNumber, int input)
        {
            bool isGameFinished = false;
            if (input == mysteryNumber)
            {
                isGameFinished = true;
                Console.Write("Congratulation, you won!!!!");
            }
            else if (input > mysteryNumber)
            {
                Console.Write("Too big, try a lower number");
            }
            else
            {
                Console.Write("Too low, try a bigger number");
            }

            return isGameFinished;
        }
    }
}
