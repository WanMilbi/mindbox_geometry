using Microsoft.VisualStudio.TestTools.UnitTesting;
using mindbox_FiguresLibrary;

namespace UnitTest
{
	[TestClass]
	public class TriangleTest
	{
		[TestMethod]
		public void TriangleAreaTestMethod()
		{
			//Arrange
			double a = 3;
			double b = 4;
			double c = 5;
			double expected = 6;
			Triangle triangle = new Triangle(a, b, c);

			//Act
			double actual = triangle.GetArea();

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TrianglePerimeterTestMethod()
		{
			//Arrange
			double a = 3;
			double b = 4;
			double c = 5;
			double expected = 12;
			Triangle triangle = new Triangle(a, b, c);

			//Act
			double actual = triangle.GetPerimeter();

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}