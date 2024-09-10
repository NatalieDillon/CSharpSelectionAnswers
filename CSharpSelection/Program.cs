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

			Console.WriteLine("Q4:");
			Console.WriteLine($"4 is {SelectionExercises.ClassifyAngle(4)}");
			Console.WriteLine($"90 is {SelectionExercises.ClassifyAngle(90)}");
			Console.WriteLine($"94 is {SelectionExercises.ClassifyAngle(94)}");
			Console.WriteLine($"180 is {SelectionExercises.ClassifyAngle(180)}");
			Console.WriteLine($"355 is {SelectionExercises.ClassifyAngle(355)}");
			Console.WriteLine($"370 is {SelectionExercises.ClassifyAngle(370)}");
			Console.WriteLine();
			
			Console.WriteLine("Q5:");
			Console.Write("Please enter 0 for Rock. 1 for Paper. 2 for scissors: ");
			int userInput = Convert.ToInt32(Console.ReadLine());
			if (userInput < 0 || userInput > 2)
			{
				Console.WriteLine("Value entered is invalid");
			}
			else
			{
				SelectionExercises.RockPaperScissors((SelectionExercises.Choice)userInput);
			}
			Console.WriteLine();

			Console.WriteLine("Q6:");
			Console.WriteLine($"3, 4, 5 is {SelectionExercises.ClassifyTriangle(3, 4, 5)}");
			Console.WriteLine($"1.3, 1, 1.3 is {SelectionExercises.ClassifyTriangle(1.3, 1, 1.3)}");
			Console.WriteLine($"6, 6, 6 is {SelectionExercises.ClassifyTriangle(6, 6, 6)}");
			Console.WriteLine();

			Console.WriteLine("Q7:");
			SelectionExercises.ConcertSale();
			Console.WriteLine();

			Console.WriteLine("Q8:");
			DateTime birthDate1 = new(1993, 07, 20);
			DateTime birthDate2 = new(1993, 12, 01);
			DateTime birthDate3 = new(2024, 12, 22);
			Console.WriteLine($"{birthDate1:D} Eligible for 18to30 :{SelectionExercises.EligibleFor18To30(birthDate1)}");
			Console.WriteLine($"{birthDate2:D} Eligible for 18to30 :{SelectionExercises.EligibleFor18To30(birthDate2)}");
		    Console.WriteLine($"{birthDate3:D} Eligible for 18to30 :{SelectionExercises.EligibleFor18To30(birthDate3)}");
		}
	}
}