using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace consoleapplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int n;
            int i;
            Console.Write("enter number:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial = : {0}", fact);
            Console.ReadKey();
        }
    }
}
//رامین کریمی
//تمرین5