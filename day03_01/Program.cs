using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03_01
{
    class Program
    {
        enum Item
        {
            apple = 1,
            banana,
            candy,
            diamond,
            envi
        }

        [Flags] //각자의 고유한 값을 지닌다.
        enum bitem
        {
            Mon = 1,
            Tue = 2,
            Wed = 4,
            Thu = 8,
            Fri = 16,
            Sat = 32,
            Sun = 64,
        }

        static void Order(Item item, int num)
        {
            int money=0;
            switch (item)
            {
                case Item.apple: money = 1500; break;
                case Item.banana: money = 3900; break;
                case Item.candy: money = 200; break;
                case Item.diamond: money = 10000; break;
                case Item.envi: money = 20000; break;
            }
            money *= num;
            Console.WriteLine("Your Order: " + item + ", Item num: " + num + ", total price: " + money);
        }

        static void border(bitem B)
        {
            if ((B & bitem.Mon) != 0) Console.WriteLine("has Monday in collumns");
    
            if (B.HasFlag(bitem.Sat | bitem.Sun)) Console.WriteLine("has Weekend in collumns");
        }
        static void Main(string[] args)
        {
            Order(Item.banana, 5);

            bitem B = bitem.Mon | bitem.Wed | bitem.Fri;
            border(B);
        }
    }
}
