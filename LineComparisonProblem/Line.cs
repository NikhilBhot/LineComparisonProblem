using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Line
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
    }
}
