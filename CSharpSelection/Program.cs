using System.Diagnostics;

namespace CSharpSelection
{
	internal class Program
	{
		static void Main()
		{
			Console.WriteLine("Q1:");
			Console.WriteLine($"FizzBuzz(4) returns {SelectionExercises.FizzBuzz(4)}");
			Console.WriteLine($"FizzBuzz(3) returns {SelectionExercises.FizzBuzz(3)}");
			Console.WriteLine($"FizzBuzz(5) returns {SelectionExercises.FizzBuzz(5)}");
			Console.WriteLine($"FizzBuzz(15) returns {SelectionExercises.FizzBuzz(15)}");
			Console.WriteLine($"FizzBuzzAlt(4) returns {SelectionExercises.FizzBuzzAlt(4)}");
			Console.WriteLine($"FizzBuzzAlt(3) returns {SelectionExercises.FizzBuzzAlt(3)}");
			Console.WriteLine($"FizzBuzzAlt(5) returns {SelectionExercises.FizzBuzzAlt(5)}");
			Console.WriteLine($"FizzBuzzAlt(15) returns {SelectionExercises.FizzBuzzAlt(15)}");
			Console.WriteLine();

			Console.WriteLine("Q2:");
			Console.WriteLine($"a is a vowel: {SelectionExercises.IsVowel('A')}");
			Console.WriteLine($"z is a vowel: {SelectionExercises.IsVowel('z')}");
			Console.WriteLine($"i is a vowel: {SelectionExercises.IsVowel('i')}");
			Console.WriteLine($"? is a vowel: {SelectionExercises.IsVowel('?')}");
			Console.WriteLine();

			Console.WriteLine("Q3:");
			SelectionExercises.DiceRoll();
			Console.WriteLine();
		}
	}
}