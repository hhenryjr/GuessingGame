using System;

namespace GuessingGame
{
    public class Program
    {
		public static void Main()
		{
			Console.WriteLine("Pick a number between 1 and 100");
			// get random # b/t 1 and 100
			int randomNum = CreateRandomNumber();
			// initialize counter
			int guesses = 10;
			while (guesses > 0)
			{
				// prompt user to pick # b/t 1 and 100
				int guess = int.Parse(Console.ReadLine());
				int comparison = guess.CompareTo(randomNum);
				if (comparison.Equals(0))
				{
					Console.WriteLine("Congrats! You guessed the right number!");
					break;
				}
				else
				{
					string direction = string.Empty;
					if (comparison > 0)
						direction = "Lower!";
					else if (comparison < 0)
						direction = "Higher!";
					guesses--;
					Console.WriteLine(string.Format("{0} You have {1} guesses left!", direction, guesses));
                }
            }

			Console.WriteLine("Game over! The right number is {0}!", randomNum);
		}

		public static int CreateRandomNumber()
		{
			Random rnd = new Random();
			int randomNum = rnd.Next(1, 101);
			return randomNum;
		}
	}
}
