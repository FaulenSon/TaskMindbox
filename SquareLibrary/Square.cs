using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public class Square : IShape
    {
        private double Radius { get; }
        public Square(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше нуля.", nameof(radius));

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
