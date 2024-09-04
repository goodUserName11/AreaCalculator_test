using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : AbstractFigure
    {
        private double _radius;

        public Circle() { }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => _radius;

            set
            {
                ValidateLength(value);

                _radius = value;
            }
        }

        public override double CalculateArea() => 
            Math.PI * Math.Pow(Radius, 2);
    }
}
