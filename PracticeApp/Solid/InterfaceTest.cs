using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Solid
{
    public interface InterfaceTest
    {
        void Test3();
    }

    public interface IInterace2 : InterfaceTest
    {
        void test2();
    }

    public abstract class AbstractTest
    {
        public abstract void Test1();
    }

    public abstract class AbstractTest1 : AbstractTest
    {
        public abstract void Test2();
    }

    public class Test : AbstractTest1, IInterace2
    {
        public override void Test1()
        {
            Console.WriteLine("I am from AbstractTest");
        }
        public override void Test2()
        {
            Console.WriteLine("I am from AbstractTest1");
        }

        void InterfaceTest.Test3()
        {
            Console.WriteLine("I am from InterfaceTest");
        }

        public void test2()
        {
            Console.WriteLine("I am from Interface2");
            // InterfaceTest.Test3();
        }
    }


    public abstract class Animal
    {
        public void move() { Console.WriteLine("Animal move"); }
        public virtual void Eat() { Console.WriteLine("Eat"); }
        public void Drink() { Console.WriteLine("Drink"); }
    }

    public class Bird : Animal
    {
        public new void move() { Console.WriteLine("Fly"); }
    }

    public class Fish : Animal
    {
        public new void move() { Console.WriteLine("Swim"); }

        public override void Eat()
        {
            Console.WriteLine("Swallow");
        }

        public new void Drink() { Console.WriteLine("Fish Drink"); }
    }

}
