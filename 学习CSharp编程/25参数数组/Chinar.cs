using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _24参数数组
{
    class Chinar
    {
        static void Main(string[] args)
        {
            int userNum  = He(new int[] {3, 35, 6, 6, 34, 2, 4, 23, 42, 4});
            int userNum2 = Plus(3, 4, 5, 6);
            Console.WriteLine(userNum);
            Console.WriteLine(userNum2);
        }


        /// <summary>
        /// 求和 —— 参数数组
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        /// 定义一个int类型的参数数组
        /// 参数数组 与 数组参数 的不同：
        /// 1.调用参数数组的函数，可以传递多个参数。我们传递多个参数后，系统会自动帮我们构建一个数组，并传入
        /// 2.调用数组参数的函数，需要我们自己定义一个数组，来当做传入参数
        static int Plus(params int[] array)
        {
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                num += array[i];
            }
            return num;
        }


        /// <summary>
        /// 求和 —— 数组参数
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int He(int[] array)
        {
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                num += array[i];
            }
            return num;
        }
    }
}