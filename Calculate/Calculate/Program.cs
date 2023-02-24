using System;
namespace Calculate
{
	public class Program
	{
		public Action<string> WriteLine { get; init; } = Console.WriteLine;
		public Func<string> ReadLine { get; init; } = Console.ReadLine;

		public Program(Action<string> writeLine, Func<string> readLine)
		{
			WriteLine = writeLine;
			ReadLine = readLine;
		}

		public Program() { } //empty constr

		static void Main(string[] args)
		{
			var program = new Program();
			{
				program.WriteLine("WriteLine test");
				string readInput = program.ReadLine();

				program.WriteLine($"Test ReadLine {readInput}");
			}

			Calculator calculator = new();
			//calculator.TryCalculate(program.WriteLine, program.ReadLine);

			while(true)
			{
				program.WriteLine("Please input function: (format) x [opertor] y, or 'q' to quit program");

				string userInput = Console.ReadLine().Trim();

				if (string.IsNullOrWhiteSpace(userInput) || string.IsNullOrEmpty(userInput))
				{
					program.WriteLine("Invalid Input, please try again");
					continue;
				}

                if (userInput.Equals("q"))
                {
					break;
                }

                else if (Calculator.TryCalculate(userInput, out int x))
				{
					program.WriteLine(x.ToString());
				}

				else
				{
					program.WriteLine("Invalid input, please try again");
					continue;
				}
			}

		}
	}
}

