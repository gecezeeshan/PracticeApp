using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.NonSolid
{

  
    public class Square 
    {
       
        public Square(int w, int h) { this.Width = w;
            this.Height = h;
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public string color { get; set; }

        

        string Draw()
        {
            return "Square drawn";
        }

        public string GetName()
        {
            return "Square";
        }

        public string FillColor(string color) {
            this.color = color;
            return color + " has been filled in " + GetName();
        }
    }


}
