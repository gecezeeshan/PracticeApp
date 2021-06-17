using System;
using System.Collections.Generic;
using System.Text;


namespace SOLID_PRINCIPLES.LSP
{
    
    public abstract class Fruit
    {
        public virtual string GetColor() { return "yellow"; }
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}