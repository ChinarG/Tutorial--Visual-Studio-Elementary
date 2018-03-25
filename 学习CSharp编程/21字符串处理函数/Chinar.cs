using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _21字符串处理函数
{
    class Chinar
    {
        static void Main(string[] args)
        {
            string str = "   WWW.unity.kim  ";

            string strlower = str.ToLower();    //把字符串转 —— 小写，并返回 string
            str.ToUpper();                      //字符串转大写，并返回 string
            string   spaceStr = str.Trim();     //去处字符串，前后的空格
            string[] strArray = str.Split('.'); //把字符串拆分为多个数组,传入一个标记。返回值为字符串数组
            Console.WriteLine(strlower);
            Console.WriteLine(spaceStr);
            foreach (var s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}