using System;

namespace mindbox_FiguresLibrary
{
	public class Figure
	{
		protected double Area { get; set; }
		protected double Perimeter { get; set; }

		public virtual double GetArea()
		{
			return Area;
		}
		public virtual double GetPerimeter()
		{
			return Perimeter;
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Area: {Math.Round(GetArea(), 2)}");
			Console.WriteLine($"Perimeter: {Math.Round(GetPerimeter(), 2)}");
			Console.WriteLine();
		}

		public virtual void RectangularTriangle()
		{
		}
	}
}