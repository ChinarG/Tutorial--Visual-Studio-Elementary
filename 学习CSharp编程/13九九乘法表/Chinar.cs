using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _13九九乘法表
{
    class Chinar
    {
        /// <summary>
        /// 九九乘法表
        /// </summary>
        static void Main()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    Console.Write(i + "*" + j + "=" + i * j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}