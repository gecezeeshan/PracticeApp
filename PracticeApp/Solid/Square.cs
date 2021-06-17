using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Solid
{
    public class Square : IShape, IRotate
    {
        ColorHandler ch;
        int Width { get; set; }
        int Height { get; set; }
        public string color { get; set; }

        public Square(int width, int height) { this.Height = height; this.Width = width; ch = new ColorHandler(); }
        
        string IShape.Draw()
        {
            return "Square drawn";
        }

        double IArea.AreaCalculator()
        {
            return (Width * Height);
        }

      
        string IShape.GetName()
        {
            return "Square";
        }

        public string Move()
        {
            return  "Slide";
        }
    }
}
