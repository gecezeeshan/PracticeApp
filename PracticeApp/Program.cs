using PracticeApp.Solid;
using SOLID_PRINCIPLES.LSP;
using System;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShapeFactory sh = new ShapeFactory();
            //IShape s1 = sh.CreateShape("square");
            //s1.Draw().Print();
            //s1 = sh.CreateShape("circle");
            ////s1.BorderColor("red").Print();
            ////s1.FillColor("green").Print();
            //s1.AreaCalculator().ToString().Print();

            //Fruit fruit = new Orange();
            //fruit.GetColor().Print();
            //fruit = new Apple();
            //fruit.GetColor().Print();

            //Test t = new Test();
            //t.Test1();
            //t.Test2();
            //t.test2();

            //Animal a = new Bird();
            //a.move();
            //a.Eat();
            //a.Drink();
            //Animal a1 = new Fish();
            //a1.move();
            //a1.Eat();
            //a1.Drink();


            //DuplicateFileRemover duplicateFileRemover = new DuplicateFileRemover();
            //duplicateFileRemover.DuplicateRemover();

            BinaryGap b = new BinaryGap();

            Console.WriteLine(string.Format("gaps are {0}", b.FindGap(1041)));
            Console.WriteLine(string.Format("gaps are {0}", b.FindGap(529)));
            Console.WriteLine(string.Format("gaps are {0}", b.FindGap(32)));

            Console.WriteLine(string.Format("gaps are {0}", b.FindGap(2342)));



        }


    }
}
