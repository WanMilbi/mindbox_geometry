using System;

namespace mindbox_FiguresLibrary
{
	public class Triangle : Figure
	{
		private double a_Side { get; set; }
		private double b_Side { get; set; }
		private double c_Side { get; set; }
		public Triangle(double a, double b, double c)
		{
			if (a <= 0 || b <= 0 || c <= 0)
			{
				throw new ArgumentException("The sides should be positive");
			}
			if (a + b < c || b + c < a || a + c < b)
			{
				throw new ArgumentException("A side cannot be greater than the sum of the two sides");
			}
			a_Side = a;
			b_Side = b;
			c_Side = c;
		}
		public override double GetArea()
		{
			double p = GetPerimeter() / 2;
			Area = Math.Sqrt(p*(p - a_Side) * (p - b_Side) * (p - c_Side));
			return Area;
		}
		public override double GetPerimeter()
		{
			Perimeter = a_Side + b_Side + c_Side;
			return Perimeter;
		}

		public override void RectangularTriangle()
		{
			if ((Math.Pow(a_Side, 2) + Math.Pow(b_Side, 2) == Math.Pow(c_Side, 2))
			    || (Math.Pow(a_Side, 2) + Math.Pow(c_Side, 2) == Math.Pow(b_Side, 2))
			    || (Math.Pow(b_Side, 2) + Math.Pow(c_Side, 2) == Math.Pow(a_Side, 2)))
			{
				Console.WriteLine();
				Console.WriteLine("Triangle is rectangular");
			}
			else
			{
				Console.WriteLine();
				Console.WriteLine("Triangle is not rectangular");
			}
			
		}

	}
}