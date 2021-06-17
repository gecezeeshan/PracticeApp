using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Solid
{
    class ColorHandler
    {
        public IShape FillColor(string color, IShape sh)
        {
            sh.color = color;
            return sh;
        }
    }
}
