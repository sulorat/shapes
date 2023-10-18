using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{ internal class triangle
    {
        private double s_triangle;
        private double p_triangle;
        public double area_triangle_common(double a, double h)
        {
            s_triangle = 0.5 * (a * h);
            return s_triangle;
        }
        public double periment_triangle_common(double a, double b, double c)
        {
            p_triangle = a + b + c;
            return p_triangle;
        }
        public double area_triangle_rectangular(double a, double b)
        {
            s_triangle += 0.5 * (a * b);
            return s_triangle;
        }
        public double area_triangle_correct(double a)
        {
            s_triangle = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
            return s_triangle;
        }
    }
}
