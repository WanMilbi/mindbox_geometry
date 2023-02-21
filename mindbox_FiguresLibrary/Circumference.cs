using System;

namespace mindbox_FiguresLibrary
{
    public class Circumference :Figure
    {
	    private double radius { get; set; }
        public Circumference(double r)
        {
            radius = r;
        }
        public override double GetArea()
        {
            Area = Math.PI*Math.Pow(radius,2);
            return Area;
        }
        public override double GetPerimeter()
        {
            Perimeter = 2*Math.PI*radius;
            return Perimeter;
        }
    }
}
