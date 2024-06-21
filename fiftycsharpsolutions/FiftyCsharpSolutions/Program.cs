namespace FiftyCsharpSolutions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// -----------------------------------------------------------------
			// Program 1 ---> print Hello and your name in separate line
			// -----------------------------------------------------------------
			Console.WriteLine("Hello");
			Console.WriteLine("Dhaval Parikh");

			// -----------------------------------------------------------------
			// Program 2 --> print the sum of two numbers user entered
			// -----------------------------------------------------------------
			Console.WriteLine("Enter a number");
			var s = Console.ReadLine();
			int x = 0, y = 0;
			if (s != null)
			{
				_ = int.TryParse(s, out x);
			}

			Console.WriteLine("Enter second number");
			var s2 = Console.ReadLine();
			if (s2 != null)
			{
				y = int.Parse(s2);
			}

			Console.WriteLine("Sum of x and y is {0}", x + y);

			// -----------------------------------------------------------------
			// Program 3 --> print the result of dividing two numbers user entered
			// -----------------------------------------------------------------

			Console.WriteLine("Enter a number");
			var s3 = Console.ReadLine();
			Console.WriteLine("Enter second number");
			var s4 = Console.ReadLine();

			Console.WriteLine("divingd s3 and s4 is {0}", Int32.Parse(s3) / Int32.Parse(s4));

			// -----------------------------------------------------------------
			// Program 4 --> print the results of the specified operations.
			// Test data:
			// 
			// -1 + 4 * 6
			// ( 35+ 5 ) % 7
			// 14 + -4 * 6 / 11
			// 2 + 15 / 6 * 1 - 7 % 2
			// -----------------------------------------------------------------

			Console.WriteLine("first one is {0}", -1 + 4 * 6);
			Console.WriteLine("second one is{0}", (35 + 5) % 7);
			Console.WriteLine("third one is {0}", 14 + -4 * 6 / 11);
			Console.WriteLine("fourth one is {0}", 2 + 15 / 6 * 1 - 7 % 2);

			// -----------------------------------------------------------------
			// Program 5 --> swap two numbers
			// -----------------------------------------------------------------
			Console.WriteLine("Enter a number");
			var s5 = Console.ReadLine();
			Console.WriteLine("Enter second number");
			var s6 = Console.ReadLine();


			// -----------------------------------------------------------------
			// Program 6 --> print the output of the multiplication of three numbers entered by the user.
			// -----------------------------------------------------------------

			// -----------------------------------------------------------------
			// Program 7 --> print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user
			// -----------------------------------------------------------------

			// -----------------------------------------------------------------
			// Program 8 --> prints the multiplication table of a number as input
			// -----------------------------------------------------------------

			// -----------------------------------------------------------------
			// Program 9 --> program that takes four numbers as input to calculate and print the average
			// -----------------------------------------------------------------

			// -----------------------------------------------------------------
			// Program 10 --> program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
			// -----------------------------------------------------------------
		}
	}
}