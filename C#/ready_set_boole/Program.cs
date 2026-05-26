using System;
using ReadySetBoole;

class Program
{
	private static void	exit(string message)
	{
		Console.WriteLine(message);
		Environment.Exit(1);
	}

	public static void Main(string[] args)
	{
		if (args.Length == 0)
			exit("Usage: dotnet run <number of the exercise> <arguments>");

		uint exerciseNumber = uint.Parse(args[0]);
		switch (exerciseNumber)
		{
			case 0:
				if (args.Length != 3)
					exit("Usage for Adder: dotnet run 0 <uint> <uint>");
				Console.WriteLine($"The sum of {args[1]} and {args[2]} is: {Adder.Add(uint.Parse(args[1]), uint.Parse(args[2]))}");
				break;
			case 1:
				if (args.Length != 3)
					exit("Usage for Multiplier: dotnet run 1 <uint> <uint>");
				Console.WriteLine($"The product of {args[1]} and {args[2]} is: {Multiplier.Multiply(uint.Parse(args[1]), uint.Parse(args[2]))}");
				break;
			case 2:
				if (args.Length != 2)
					exit("Usage for GrayCode: dotnet run 2 <uint>");
				Console.WriteLine($"The Gray code of {args[1]} is: {GrayCode.ToGray(uint.Parse(args[1]))}");
				break;
			default:
				exit("Invalid exercise number. Please provide a valid exercise number as the first argument.");
				break;
		}
	}
}