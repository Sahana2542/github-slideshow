using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract classes are classes that ahve atleast one abstract method...
//abstract methods are methods which do not have implementation/body. 
namespace ConsoleApp2
{
    abstract class AbstractClass
    {
        public void NormalMethod() => Console.WriteLine("Normal Method");
        public virtual void VirtualMethod() => Console.WriteLine("Virtual Method");
        public abstract void AbstractMethod();
    }

    //The Subclass must implement all the abstract methods...
    class ExtendedClass : AbstractClass
    {
        public override void AbstractMethod() => Console.WriteLine("Abstract method implemented in derived class");
    }
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            AbstractClass cls = new ExtendedClass();
            cls.NormalMethod();
            cls.VirtualMethod();
            cls.AbstractMethod();//overriden, so will call the derived version...
        }
    }
}
   