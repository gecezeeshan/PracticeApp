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

            Codility b = new Codility();
            Console.WriteLine(string.Format("gaps are {0}", b.FindGap(1041)));
            Console.WriteLine(string.Format("gaps are {0}", b.FindGap(529)));
            Console.WriteLine(string.Format("gaps are {0}", b.FindGap(32)));

            Console.WriteLine(string.Format("gaps are {0}", b.FindGap(2342)));
            int[] A = { 4, 5 };
            int odd = b.FindOddByPower(A);
            Console.WriteLine("odd is " + odd);



           int jumpCount = b.FrogJump(10, 85, 30);
            Console.WriteLine(string.Format("Jump Count {0}", jumpCount));
            int []B = {2,3};
            Console.WriteLine(string.Format("Missing Param {0}", b.MissingParm(B)));

            Console.WriteLine(string.Format("Factorial {0}", b.Factorial(3)));


            Console.WriteLine(string.Format("Sequence {0}", b.Sequence(10)));

            Console.WriteLine(string.Format("Fabbonacci {0}", b.Fabonacci(4)));


Console.WriteLine(string.Format("Bracess {0}", b.checkBraces("{{6}+[5*(4)]}")));


        }





    }
}
