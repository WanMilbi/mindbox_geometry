using Microsoft.VisualStudio.TestTools.UnitTesting;
using mindbox_FiguresLibrary;

namespace UnitTest
{
	[TestClass]
	public class CircumferenceTest
	{
		[TestMethod]
		public void CircumferenceAreaTestMethod()
		{
			//Arrange
			double radius = 5;
			double expected = 78.53981633974483;
			Circumference circle = new Circumference(radius);

			//Act
			double actual = circle.GetArea();

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CircumferencePerimeterTestMethod()
		{
			//Arrange
			double radius = 5;
			double expected = 31.41592653589793;
			Circumference circle = new Circumference(radius);

			//Act
			double actual = circle.GetPerimeter();

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}