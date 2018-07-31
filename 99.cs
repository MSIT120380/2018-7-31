using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            
            int c;
            while (a<=9)
              {
               int b=1;
                
                while (b <=9)
                {
                c = a * b;
                Console.Write(a);
                Console.Write("X");
                Console.Write(b);
                Console.Write("=");
                if (c < 10) { Console.Write(" "); }
                Console.Write(c);
                Console.Write(" ");
                 b++;  }
                Console.WriteLine("");
                a++;}
           


        }
    }
}
