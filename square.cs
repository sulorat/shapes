using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class square
    {
        private double s_square;
        private double p_square;
        public double area_square(double x)
        {
            s_square = Math.Pow(x, 2);
            return s_square;
        }
        public double perimetr_square(double x)
        {
            p_square = 4 * x;
            return p_square;
        }
    }
}
