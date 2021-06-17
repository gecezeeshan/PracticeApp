using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Solid
{
    class ShapeFactory
    {
        IShape shape1;
        public IShape CreateShape(string shape) {
            if (shape.ToLower() == "circle")
            {
                shape1 =  new Circle(0);
            }
            else if (shape.ToLower() == "square")
            {
                shape1 = new Square(0, 0);
            }
            return shape1;
            
        }

      
    }
}
