﻿using System;

namespace CalculatorApplication4
{
	class NumberManipulator
	{
		public void swap(int x, int y)
		{
			int temp;

			temp = x;
			x = y;
			y = temp;
		}

		static void Main(string[] args)
		{
			NumberManipulator n = new NumberManipulator();

			int a = 100;
			int b = 200;

			Console.WriteLine("Before swap, value of a: {0}", a);
			Console.WriteLine("Before swap, value of b: {0}", b);

			n.swap(a, b);

			Console.WriteLine("After swap, value of a: {0}", a);
			Console.WriteLine("After swap, value of b: {0}", b);
		}
	}
}

