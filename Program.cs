using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toi
{
    class Program
    {
        static void Main(string[] args)
        {
            f3_8();
            //f4_1(2);
            //f4_2(2);
            //f4_4(256);
            //Console.Write(f4_3(240,3));
            //f5_4();
            //f5_5();
            Console.WriteLine();
            Console.ReadKey();

        }

        static void f3_8()
        {
            Console.WriteLine("минимальное значение ulong = {0}, максимальное значение ulong = {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("минимальное значение uint = {0}, максимальное значение uint = {1}", uint.MinValue, uint.MaxValue);
        }
    

        static void f4_1(byte x)
        {
            var list = new Boolean[8];
            for (int i = 0; i < 8; i++)
            {
                list[i] = ((x & (1 << i)) != 0);
            }
            Array.Reverse(list);
            for (int i = 0; i < 8; i++)
            {
                Console.Write(list[i] == false ? 0 : 1);
            }
        }
        static void f4_2(byte x)
        {
            Console.Write((x & (1 << 3)) == (x & (1 << 4)) ? "Биты одинаковы" : "Биты не одинаковы");
        }

        static void f4_4(int x)
        {
            for (int i = 0, k = 7; i < 8; i++, k--)
            {
                if (Convert.ToBoolean(x & (1 << i)) != Convert.ToBoolean(x & (1 << k)))
                {
                    Console.Write("старшая и младшая тетрада не равны");
                    return;
                }
            }
            Console.Write("старшая и младшая тетрада равны");
        }

        // todo 
        static byte f4_3(byte x, int setTetr)
        {
            return (byte)((x & 0b00001111) & (setTetr));
        }


        static void f5_4()
        {
            //sbyte x = -128,y = 8;
            //sbyte x = -1, y = 64;
            //short x = -129, y = 16; 
            int x = 0x7fffffff, y = 16;  
            //int x = 0x7fffffff, y = 32; 
            //int x = 0x7fff0000, y = 8;  

            var list = new Boolean[y];
            for (int i = 0; i < y; i++)
            {
                list[i] = ((x & (1 << i)) != 0);
            }
            Array.Reverse(list);
            for (int i = 0; i < y; i++)
            {
                Console.Write(list[i] == false ? 0 : 1);
            }
            Console.WriteLine();
        }

        static void f5_5()
        {
            Console.WriteLine("минимальное значение long = {0}, максимальное значение long = {1}", long.MinValue, long.MaxValue);
        }

    }
}
