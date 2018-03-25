using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Unity.Kim
{
    class Chinar
    {
        static void Main(string[] args)
        {
            int num      = 364; //可乐总数
            int emptyNum = 364; //空瓶子也是364个
            while (emptyNum >= 3)
            {
                num                 += emptyNum / 3;             //总共会有多少空瓶子
                int newKeLe         = emptyNum  / 3;             //空瓶子一共可以兑换多少瓶可乐
                int surplusEmptyNum = emptyNum  % 3;             //剩余的空瓶子数量
                emptyNum            = newKeLe + surplusEmptyNum; //兑换后，还有多少空瓶子
            }
            Console.WriteLine(num + ":" + emptyNum);
            Console.ReadKey();
        }

        

    }
}