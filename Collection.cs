/*
 Arrays are fixed in size,they are nor dynamic.Once u create an array,it cannot be modified.
Collections are classes created to solve these problems and create dynamic arrays.There asre different ways of collections depending on how U use the data structure.FIFO,key-value pairs,unique values and so forth...
We are using the latest version of collections callled Generics,similar to Templates in C++
Interanlly all generics are collection classes which implement a set of interfaces to achieve functionality of dynamic sizing.
Collection means a group of objects that meet a common criteria and will be itearble thro it.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Collection
    {
      
        public int EmpID { get; set; }
  
        //private static void hashsetExample()
        // {
        //similar to list,but stores only unique values.Lists can have duplicates as list does not check for uniqueness.
        //}

        private static void ListExample()
        {
            //RemoveAt, Insert, InsertAt, ToArray functions, Count
            List<string> fruits = new List<string>();
            //list is similar to array but with extra methods to add, remove, insert, removeat and perform some common operations.
            fruits.Add("Apple"); //adds the new item to the bottom of the list.
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("PineApple");
            fruits.Remove("Orange");//Removes the specific element from the list. 
            foreach (var item in fruits) Console.WriteLine(item);

            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}