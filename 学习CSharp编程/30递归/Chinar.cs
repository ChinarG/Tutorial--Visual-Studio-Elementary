using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _30递归
{
    class Chinar
    {
        static void Main(string[] args)
        {
            Console.WriteLine(F(40));
            Console.WriteLine(F(2));
            Console.WriteLine(Factorial(5));
            Console.ReadLine();
        }


        /// <summary>
        /// 递归函数 —— 函数调用自身，就叫做递归调用！
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int F(int n)
        {
            if (n == 0) return 2; //递归会一直向下分解，形成死循环！
            if (n == 1) return 3; //所以，需要有一个终止条件
            return F(n - 1) + F(n - 2);
        }


        static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}