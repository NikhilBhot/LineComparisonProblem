using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Line :IComparable<Line>
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public bool Equals(Line other)
        {
            if (other == null)
                return false;

            return (X1 == other.X1 && Y1 == other.Y1 && X2 == other.X2 && Y2 == other.Y2)
                || (X1 == other.X2 && Y1 == other.Y2 && X2 == other.X1 && Y2 == other.Y1);
        }

        /*
         * As a fan of geometry, I want to
                compare two lines based on
                the end points, So that I know
                one line is equal, greater or
                less than the other line. - Using Java compareTo method to compare 2 Lengths is
         */
        public int CompareTo(Line other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            double length = CalculateLength();
            double otherLength = other.CalculateLength();

            return length.CompareTo(otherLength);
        }

        private double CalculateLength()
        {
            double deltaX = X2 - X1;
            double deltaY = Y2 - Y1;
            double length = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            return length;
        }
    }

}

