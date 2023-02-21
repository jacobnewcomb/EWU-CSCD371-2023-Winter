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
		}

	}
}

