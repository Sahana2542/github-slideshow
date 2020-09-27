using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BookManager
    {

        int[] id;
        string[] title;
        string[] author;
        float[] price;
    }
    interface IBookManager
    {
        void AddNewBook(int id, string title);
        void DeleteBook(int id);
        void FindBook(string title);
        void UpdateBook(int id);
    }

    class Book : IBookManager
    {
        int id;
        string title;
        string author;
        float price;

        public void AddNewBook(int BookId, string Booktitle)
        {
            id = BookId;
            title = Booktitle;
            
        }
        public void DeleteBook(int BookId)
        {
            id = BookId;

        }
        public void FindBook(string Booktitle)
        {

            title = Booktitle;
        }
        public void UpdateBook(int BookId)
        {
            id = BookId;

        }
    }

        
            }
    

