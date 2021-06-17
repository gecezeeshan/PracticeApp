using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Solid
{
    interface IShape : IArea
    {
        string color { get; set; }
        string GetName();
        string Draw();
    }
}
