using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Solid
{

    /// <summary>
    /// * Single responsibility principle - Each class should have single responsibility.
    /// It has been handled over here. Like Circle class do have it's on properties, however color filling could be 
    /// performed by other class. As color could be filled on any shape, therefore we have seperate Color handler.
    ///</summary>

    /// <summary>
    /// * Open closed principle - open for extension and closed for modification.
    /// It is applied for area calculation, each class is self responsible of creating it's own area by their 
    /// respective method. So, it could be easily extended in case of new shape, rather than having seperate Area calculator class
    /// where object being passed and calculate it via multiple if clauses.
    /// Explaination: 
    /// Through polymorphism, we can extend our parent entity to suit the needs of the child entity while leaving the parent intact.
    /// Our parent entity will serve as an abstract base class that can be reused with added specializations through inheritance.
    /// However, the original entity is locked to allow the program to be both open and closed.
    /// The advantage of OCP is that it minimizes program risk when you add new uses for an entity.
    /// Instead of reworking the base class to fit a work-in-progress feature,
    /// you create a derived class separate from the classes currently present throughout the program.
    ///We can then work on this unique derived class, confident that any changes we make to it will not affect the parent or any other derived class.
    /// </summary>

    ///<summary>
    /// * Liskov Principle - Child class should be able to substitute it's parent class
    /// Here, Ishape object could be replaced by any shape(circle,square). 
    /// It would have been wrong if Circle would be inherited from Square. in that case, square object would be behaving like circle. 
    ///</summary>

    ///<summary> 
    /// * Interface segregation - Many client specific interface is better than one general interface.
    /// Instead of craeting one general IMove(ISlide,IRotate) interface and implementing in IShape. Seperate interface would be 
    /// implemented in different class based on the need.
    /// advantages
    /// The advantage of ISP is that it splits large methods into smaller, more specific methods. 
    /// This makes the program easier to debug for three reasons:
    ///There is less code carried between classes.Less code means fewer bugs.
    ///A single method is responsible for a smaller variety of behaviors. 
    ///If there is a problem with a behavior, you only need to look over the smaller methods.
    ///If a general method with multiple behaviors is passed to a class 
    ///that doesn’t support all behaviors(such as calling for a property that the class doesn’t have), 
    ///there will be a bug if the class tries to use the unsupported behavior.
    ///</summary>

    ///<summary>
    /// * Dependency inversion principle - High level object should not be dependant on low level implementation.
    /// By implementing factory pattern, By calling create method of shape factory any object could be created at runtime. We may take 
    /// the input from user which type of object do we want and shape factory will create it for us.
    /// 
    /// 
    /// </summary>
    public class Circle : IShape
    {
        
        public Circle(int r) { this.Radius = r; 
           
        }
        private int Radius { get; set; }
        public string color { get; set; }

        double IArea.AreaCalculator()
        {
            return (3.14 * Radius);
        }

        string IShape.Draw()
        {
            return "Circle drawn";
        }

        public string GetName()
        {
            return "Circle";
        }


      
    }


}
