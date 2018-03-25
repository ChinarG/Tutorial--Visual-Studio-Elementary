using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _14求素数
{
    class Chinar
    {
        /// <summary>
        /// 求一个范围内的素数/质数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 2; i < 1000; i++)
            {
                bool isSu = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isSu = false;
                    }
                }
                if (isSu)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}