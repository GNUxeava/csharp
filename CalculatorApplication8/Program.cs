using System;

namespace CalculatorApplication8
{
	class NullablesAtShow
	{
		static void Main(string[] args)
		{
			int? num1 = null;
			int? num2 = 45;

			double? num3 = new double?();
			double? num4 = 3.14157;

			bool? boolVal = new bool?();

			Console.WriteLine("Nullables ar Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
			Console.WriteLine("A Nullable boolean value: {0}", boolVal);
		}
	}
}

