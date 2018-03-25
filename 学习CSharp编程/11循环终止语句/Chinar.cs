using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11循环终止语句
{
    class Chinar
    {
        static void Main(string[] args)
        {
            //int index=0;
            //while (true)
            //{
            //    index++;
            //    if (index==5||index<=8&&index>5)
            //    {
            //        continue;
            //    }
            //    if (index==10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(index);   
            //}
            //Console.ReadKey();

            int num=0;
            int he = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i%7==0)
                {
                    Console.WriteLine(i+"可以被7整除");
                    he += i;
                    num++;
                    if (num==5)
                    {
                        Console.WriteLine(he+"是5个数的和");
                        he = 0;
                        num = 0;
                    }
                }
                
            }

            Console.ReadKey();




            /*
             * break 终止循环
             *
             * continue 中断当前循环继续循环
             *
             * goto 直接跳转到其他标签处
             *
             * return 是用来返回方法的
             */
        }
    }
}
