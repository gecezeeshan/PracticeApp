using PracticeApp.Solid;
using SOLID_PRINCIPLES.LSP;
using System;
using Codility;
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

            


            //DuplicateFileRemover duplicateFileRemover = new DuplicateFileRemover();
            //duplicateFileRemover.DuplicateRemover();

            Miscellaneous b = new Miscellaneous();
            int[] A = { 5, 4,  2, 3 };
            //Console.WriteLine( b.MissingSmallParm(A));

            //CyclicRotation cyclic = new CyclicRotation();
            //cyclic.Test();
            //PermCheck perm = new PermCheck();
            //perm.solution(A);

            b.FormatString();
        }





    }
}
