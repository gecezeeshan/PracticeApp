using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.NonSolid
{
    class AreaCalculator
    {

        public double CalculateArea(object obj)
        {
            double area = 0;
            if (obj is Circle)
            {
                Circle c = (Circle)obj;
                area = (3.14 * c.Radius);
            }
            else if (obj is Square)
            {
                Square c = (Square)obj;
                area = (c.Width * c.Height);
            }
            return area;
        }
      
    }
}
