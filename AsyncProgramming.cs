using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//Invoking a function asynchronously is called async programming. function invocation would happen and the calling function will not wait for the function to return. 
//from .NET 4.0,we have 2 delegates which are of generic type: Func<> and Action<>. Action used for void functions and Func is used for non void functions.  
namespace SampleConApp.Day5
{
    class AsyncProgramming
    {

        static void strinFunc(string arg)
        {
            Console.WriteLine(arg);
        }
        static void bigFunc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Beep #{i}");
                Console.Beep(100, 1000);
            }
        }
        static void Main(string[] args)
        {
           
            Action act = new Action(bigFunc);//old syntax
            var temp = act.BeginInvoke(null, null);
            Console.WriteLine("back to main and continuing some more operations");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main doing some job");
                //Console.Beep(100, 1000);
            }
            act.EndInvoke(temp);//Makes the calling function to wait till the async function returns(Completes its operations)...
        }
    }
}
