﻿using System;
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
            //f3_8();
            //f4_1(2);
            //f4_2(2);
            //f4_4(256);
            //f4_6();
            //Console.Write(f4_3(240,3));
            //f5_4();
            //f5_5();
            //f5_3();
            f7_3();
            Console.WriteLine("finish");
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
            for (int i = 0, k = 7; i < 4; i++, k--)
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

        static void f4_6()
        {
            Console.WriteLine("Введите 8 битное двоичное число");
            string str = Console.ReadLine();
            for (int i = 0, k = 7; i < 4; i++, k--)
            {
                if (str[i] != str[k])
                {
                    Console.WriteLine(" Не является полиндромом");
                    return;
                }
            }
            Console.WriteLine(" Является полиндромом");

        }
        static void f5_3()
        {
            byte a = 0b1100;
            sbyte b = 0b11;
            Console.WriteLine("byte ={0:D}, sbyte={1:D}",a,b);
        }

        static void f7_3()
        {
            sbyte x = 0b0110;
            sbyte y = 0b1010;
            int[] xms = new int[5];
            int[] yms = new int[5];

            int next, s, p, g, c = 0, c1 = 0;
            for( byte i = 0; i < 4; i++)
            {
                next = x & 0x1;
                xms[i] = next;
                x = Convert.ToSByte(x >> 1);
            }
            next = 0;
            for (byte i = 0; i < 4; i++)
            {
                next = y & 0x1;
                yms[i] = next;
                y = Convert.ToSByte(y >> 1);
            }
            for (byte i = 0; i < 4; i++)
            {
                Console.Write(xms[i]);
            }
            Console.WriteLine(" ");
            for (byte i = 0; i < 4; i++)
            {
                Console.Write(yms[i]);
            }
            Console.WriteLine(" ");

            for (byte i = 0; i < 4; i++)
            {
              if(xms[i] == 1 & yms[i] == 1)
                {
                    s = 0;
                    p = 0;
                    g = xms[i] * yms[i];
                    c1 = c;
                    c = g + p * c1;
                    Console.WriteLine("C + {0} = {1} ", i, c);
                    Console.WriteLine("X + {0} = {1} ", i, xms[i]);
                    Console.WriteLine("Y + {0} = {1} ", i, yms[i]);
                    Console.WriteLine("S + {0} = {1} ", i, s);
                    Console.WriteLine("P + {0} = {1} ", i, p);
                    Console.WriteLine("G + {0} = {1} ", i, g);
                }
                else if(xms[i] == 1 || yms[i] == 1)
                {
                    s = 1;
                    p = 1;
                    g = xms[i] * yms[i];
                    c1 = c;
                    c = g + p * c1;
                    Console.WriteLine("C + {0} = {1} ", i, c);
                    Console.WriteLine("X + {0} = {1} ", i, xms[i]);
                    Console.WriteLine("Y + {0} = {1} ", i, yms[i]);
                    Console.WriteLine("S + {0} = {1} ", i, s);
                    Console.WriteLine("P + {0} = {1} ", i, p);
                    Console.WriteLine("G + {0} = {1} ", i, g);
                }
                else if (xms[i] == 0 & yms[i] == 0)
                {
                    s = 0;
                    p = 0;
                    g = xms[i] * yms[i];
                    c1 = c;
                    c = g + p * c1;
                    Console.WriteLine("C + {0} = {1} ", i, c);
                    Console.WriteLine("X + {0} = {1} ", i, xms[i]);
                    Console.WriteLine("Y + {0} = {1} ", i, yms[i]);
                    Console.WriteLine("S + {0} = {1} ", i, s);
                    Console.WriteLine("P + {0} = {1} ", i, p);
                    Console.WriteLine("G + {0} = {1} ", i, g);
                }
      
            }
            Console.WriteLine("Флаги:");
            Console.WriteLine("CF - {0}, ZF - {1}, SF - {2}, PF - {3}",c,0,1,1);
        }
    }
}
