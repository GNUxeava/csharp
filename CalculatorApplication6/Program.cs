using System;

namespace CalculatorApplication
{
	class NumberManipulator
	{
		public void getValue(out int x)
		{
			int temp = 5;
			x = temp;
		}

		static void Main(string[] args)
		{
			NumberManipulator n = new NumberManipulator();

			int a = 100;

			Console.WriteLine("Before method call, value of a: {0}", a);

			n.getValue(out a);

			Console.WriteLine("After Methid call, value of a: {0}", a);
		}
	}
}

