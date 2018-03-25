using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _15求范围内的完数
{
    class Chinar
    {
        /// <summary>
        /// 求出因子
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++) //数 防伪
            {
                string str = "1";
                int num = 1;

                for (int j = 2; j < i; j++) //因子范围
                {
                    if (i % j == 0) //求出因子
                    {
                        str += "+" + j;
                        num += j; //因子之和
                    }
                }
                if (num == i)//这个数  等于 它因子的和
                {
                    Console.WriteLine(num+":"+str);//输入这个数
                }
            }
            Console.ReadKey();
        }
    }
}