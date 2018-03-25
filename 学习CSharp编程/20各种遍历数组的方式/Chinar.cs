using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20各种遍历数组的方式
{
    class Chinar
    {
        static void Main(string[] args)
        {
            int[] scores = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //取值最为简单的循环结构，但是无法获取索引、下标
            foreach (var score in scores)
            {
                Console.WriteLine(score);
            }


            //for 循环遍历
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}
            Console.ReadKey();
        }
    }
}
