

using System.Linq;

namespace CSharpSelection
{
	public static class SelectionExercises
	{
		// Q1
		public static string FizzBuzz(int number)
		{
			string result = Convert.ToString(number);
			if ((number % 5 == 0) && (number % 3 == 0))
			{
				result = "FizzBuzz";
			}
			else if (number % 5 == 0)
			{
				result = "Buzz";
			}
			else if (number % 3 == 0)
			{
				result = "Fizz";
			}
			return result;
		}

		public static string FizzBuzzAlt(int number)
		{
			string result = string.Empty;
			if (number % 3 == 0)
			{
				result = "Fizz";
			}
			if (number % 5 == 0)
			{
				result += "Buzz";
			}
			return result == string.Empty ? Convert.ToString(number) : result;
		}

		// Q2
		public static bool IsVowel(char letter)
		{
			bool result = false;
			letter = Char.ToLower(letter);
			switch (letter)
			{
				case ('a'):
				case ('e'):
				case ('i'):
				case ('o'):
				case ('u'):
					result = true;
					break;
			}
			return result;
		}

		// Q3
		public static void DiceRoll()
		{
			Random random = new();
			int dice1 = random.Next(0, 7);
			int dice2 = random.Next(0, 7);
			int dice3 = random.Next(0, 7);
			Console.WriteLine($"You rolled a {dice1}, a {dice2} and a {dice3}");
			if ((dice1 == dice2) && (dice2 == dice3))
			{
				Console.WriteLine("Three of a kind");
			}
			else if ((dice1 == dice2) || (dice2 == dice3) || (dice1 == dice3))
			{
				Console.WriteLine("You have a pair");
			}
			else
			{
				Console.WriteLine("Sorry you lose");
			}
		}

	}
}
