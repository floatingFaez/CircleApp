using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radious;
        public double GetDiameter()
        {
            return 2*radious;
        }

        public double GetPerimeter()
        {
            return 2*Math.PI*radious;
        }

        public double GetArea()
        {
            return Math.PI*radious*radious;
        }



    }
}
