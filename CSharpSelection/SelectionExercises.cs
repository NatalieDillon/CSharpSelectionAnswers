

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

	}
}
