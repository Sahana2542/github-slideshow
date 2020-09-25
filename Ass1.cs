using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment
{
    public class Ass1
    {
      

        const int max_year = 9999;
        const int min_year = 1800;


        static bool isLeap(int year)
        {

            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }

        static bool isValidDate(int d, int m, int y)
        {

            if (y > max_year || y < min_year)

                return false;
            if (m < 1 || m > 12)
                return false;
            if (d < 1 || d > 31)
                return false;

            if (m == 2)
            {
                if (isLeap(y))
                    return (d <= 29);
                else
                    return (d <= 28);
            }


            if (m == 4 || m == 6 ||
                m == 9 || m == 11)
                return (d <= 30);

            return true;
        }


    static void Main(string[] args)
      {
          int d, m, y;
          d = int.Parse(Console.ReadLine());
          m = int.Parse(Console.ReadLine());
          y = int.Parse(Console.ReadLine());
            if (isValidDate(d, m, y))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }

}

