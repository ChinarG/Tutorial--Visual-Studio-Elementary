using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _31求反弹高度_长度
{
    class Chinar
    {
        static void Main(string[] args)
        {
            float height   = 100;
            float distance = 0;
            for (int i = 1; i < 4; i++)
            {
                distance += height;
                height   /= 2;
            }
            Console.WriteLine(distance);


            Console.WriteLine(height / 2);


            int num = 0;
            for (int i = 1; i < 20; i++)
            {
                num += Multiply(i);
            }
            Console.WriteLine(num);
            Console.ReadLine();

    }


    static int Multiply(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;


    }


    //四舍五入简单方法：
}
}