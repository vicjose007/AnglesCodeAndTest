using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles
{
    public class Angle
    {
        private double x;
        private double y;

        public Angle(double eX, double eY)
        {
            this.x = eX;
            this.y = eY;

        }
        public double Magnitud()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double DotProduct(Angle obj, Angle obj2)
        {
            return (obj.x * obj2.x) + (obj.y * obj2.y);
        }

    }
}
