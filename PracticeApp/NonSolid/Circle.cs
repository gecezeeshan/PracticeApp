using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.NonSolid
{

  
    public class Circle 
    {
       
        public Circle(int r) { this.Radius = r; 
           
        }
        public int Radius { get; set; }
        public string color { get; set; }


        string Draw()
        {
            return "Circle drawn";
        }

        public string GetName()
        {
            return "Circle";
        }

        public string FillColor(string color) {
            this.color = color;
            return color + " has been filled in " + GetName();
        }
    }


}
