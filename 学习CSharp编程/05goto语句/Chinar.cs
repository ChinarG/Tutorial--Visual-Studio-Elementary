using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05goto语句
{
    class Chinar
    {
        static void Main(string[] args)
        {
            int num = 5;
            goto chinar;//跳过标签之前的代码，功能类似于点击目录，直接跳转到页面！
            num++;

            chinar: Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
