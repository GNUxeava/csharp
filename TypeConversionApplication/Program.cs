using System;

namespace TypeConversionApplication
{
	class ExplicitConversion
	{
		public void run()
		{
			double d = 5673.74;
			int i;

			// cast double to int
			i = (int)d;
			Console.WriteLine(i);
		}
	}

	class StringConversion
	{
		public void run()
		{
			int i = 75;
			float f = 53.005f;
			double d = 2345.7652;
			bool b = true;

			Console.WriteLine(i.ToString());
			Console.WriteLine(f.ToString());
			Console.WriteLine(d.ToString());
			Console.WriteLine(b.ToString());
		}
	}

	class Conversion
	{
		static void Main(string[] args)
		{
			ExplicitConversion e = new ExplicitConversion();
			e.run();

			StringConversion s = new StringConversion();
			s.run();
		}
	}
}

