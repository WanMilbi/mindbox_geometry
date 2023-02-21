using System;
using mindbox_FiguresLibrary;

namespace mindbox_Geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			Figure figure = new Figure();
			figure.DisplayInfo();

			Console.Write("Enter side A: ");
			double a = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter side B: ");
			double b = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter side C: ");
			double c = Convert.ToDouble(Console.ReadLine());


			Figure triangle = new Triangle(a, b, c);
			triangle.RectangularTriangle();

			triangle.DisplayInfo();
			Console.WriteLine();

			Console.WriteLine("Enter radius:");
			double r = Convert.ToDouble(Console.ReadLine());
			Figure circumference = new Circumference(r);
			circumference.DisplayInfo();



		}
	}
}