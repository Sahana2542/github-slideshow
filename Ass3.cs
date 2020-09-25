
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Ass3
    { 
         static Boolean checkPrime(int number)
         {
             if(number==1)
             {
                 return false;
    }
             for(int i=2;i*i<=number;i++)
             {
                 if(number%i==0)
                 {
                     return false;
 } 
    } 
    return true; 
} 
 
static int primeSum(int n1, int n2) 
{ 
    int sum = 0; 
    for (int i = n2; i >= n1; i--) 
    { 
  
        bool isPrime = checkPrime(i); 
        if (isPrime) 
        { 
  
            sum = sum + i; 
        } 
    } 
    return sum; 
} 

  

 public static void Main(string[] args)
{
    int n1, n2;
    n1 = int.Parse(Console.ReadLine());
    n2 = int .Parse(Console.ReadLine()); 
  
  
    Console.Write(primeSum(n1, n2)); 
} 
} 
  
}




 
  
        