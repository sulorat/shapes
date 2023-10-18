using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{ internal class circle
    {
        private double s_circle;
        private double p_circle;
        public double area_circle(double r)
        {
            s_circle = Math.PI * (Math.Pow(r, 2));
            return s_circle;
        }
        public double perimetr_circle(double r)
        {
            p_circle = 2 * (Math.PI * r);
            return p_circle;
        }
    }
}
