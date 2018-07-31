using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 聖誕樹
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor ori = Console.ForegroundColor;

            int x = 5;//x為聖誕樹階層
            int y = 5;//y為空白格數量
            string z = "*";
            while (x > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                while (y > 0)
                {
                    Console.Write(" ");
                    y--;
                }
                Console.Write(z);
                Console.WriteLine("");
                z += "**";
                x--;
                y = x;
            }
            Console.ForegroundColor = ori ;
            Console.WriteLine("結束");
        }
    }
}
