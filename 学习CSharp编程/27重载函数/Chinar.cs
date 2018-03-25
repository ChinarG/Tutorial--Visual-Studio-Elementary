using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _26重载函数
{
    /// <summary>
    /// 函数重载，方法名相同，传入参数、返回参数不同
    /// </summary>
    class Chinar
    {
        static int MaxNum(params int[] array)
        {
            int maxNum = array[0]; //默认第一个为最大
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxNum)
                {
                    maxNum = array[i];
                }
            }
            return maxNum; //返回最大值
        }


        static double MaxNum(params double[] array)
        {
            double maxNum = array[0]; //默认第一个为最大
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxNum)
                {
                    maxNum = array[i];
                }
            }
            return maxNum; //返回最大值
        }


        static void Main(string[] args)
        {
            int    temporary  = MaxNum(100, 399, 360);
            double temporary2 = MaxNum(3.33, 333.3444, 6.4);
            Console.WriteLine(temporary);
            Console.WriteLine(temporary2);
            Console.ReadLine();
        }
    }
}