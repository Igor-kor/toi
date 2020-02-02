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
            f4_1(2);
            Console.WriteLine();
            Console.ReadKey();

        }

        static void f4_1(byte x)
        {
            var list = new Boolean[8];
            for (int i = 0; i < 8; i++)
            {             
                list[i] = ((x & (1 << i))!=0 );
            }
            Array.Reverse(list);
            for (int i = 0; i < 8; i++)
            {
                Console.Write(list[i]==false?0:1);
            }      
        }

    }
}
