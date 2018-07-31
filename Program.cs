using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace 猜數字
{
    class Program
    {
        static void Main(string[] args)
        {
            int 神秘的整數;

            // fix #1 觀察下一行
            // 產生一個從1到100共100個整數範圍的任意一個整數
            神秘的整數 = (int)(new Random().NextDouble() * 100 + 1);

            Console.WriteLine("從1到100共100個整數範圍的任意一個整數   為");
            Debug.WriteLine(神秘的整數);

            Console.WriteLine("#################################################");
            String 使用者猜的輸入;
            int 使用者猜的整數;
            bool 使用者輸入的是int;

            bool 猜對了 = false;

            while (!猜對了)// teacher to do #1 猜對了, 才離開此 while 
            {
                Console.WriteLine();
                Console.WriteLine("請輸入一個從1到100的整數");
                使用者猜的輸入 = Console.ReadLine();
                // fix #4 觀察下面 TryParse 
                //   , 它可把使用者輸入的字串, 轉成整數存到 "使用者猜的整數" 變數中.
                //   若轉成功, 會算出 true
                //   若轉不成功, 會算出 false
                使用者輸入的是int = int.TryParse(使用者猜的輸入, out 使用者猜的整數);
                if (使用者輸入的是int)
                {
                    Console.Write("使用者猜的整數     為 ");
                    Console.WriteLine(使用者猜的整數);

                    if (使用者猜的整數 > 神秘的整數)
                    {
                        Console.WriteLine("往小一點的方向猜");
                    }
                    if (使用者猜的整數 < 神秘的整數)
                    {
                        Console.WriteLine("往大一點的方向猜");
                    }
                    if (使用者猜的整數 == 神秘的整數)
                    {
                        猜對了 = true;
                        Console.WriteLine("猜對了");
                    }
                }
            } // end of 迴圈 while

            Console.WriteLine();
            Console.WriteLine("遊戲結束");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    }

