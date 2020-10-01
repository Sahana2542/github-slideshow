using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BaseClass
    {
        public virtual void SomeFunc()
        {
            Console.WriteLine("Base class Function");
        }
    }
class DerivedClass : BaseClass
    {
      public override void SomeFunc()
        {
            base.SomeFunc();
            //base is the keyword in C# to represent the current class's immediate base class. 
            Console.WriteLine("adding few more features");
        }
    }
    class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            //Substitution principle...
            BaseClass instance = new DerivedClass();//Runtime polymorphism
            instance.SomeFunc();//It will invoke the derive version...
        }
    }
}