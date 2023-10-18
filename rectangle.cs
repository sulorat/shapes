using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class rectangle
    {
        private double s_rectangle;
        private double p_rectangle;
        public double area_rectangle(double a, double b)
        {
            s_rectangle = a * b;
            return s_rectangle;
        }
        public double perimetr_rectangle(double a, double b)
        {
            p_rectangle = 2 * (a + b);
            return p_rectangle;
        }
    }
}
