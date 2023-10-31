using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            int i;
            int number;
            Console.WriteLine("enter number:");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + "" + n2 + "");
            for (i = 2; i < number; i++)
              
            {
                n3 = n1 + n2;
                Console.Write(n3 + "");
                n1 = n2;
                n2 = n3;
                
            }
            Console.WriteLine("=is");
            Console.ReadKey();
            Console.Clear();
            Console.ReadLine();
        }
    }
}
//سورنا کریمی مقدم
//تمرین 4