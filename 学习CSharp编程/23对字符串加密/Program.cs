using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _23对字符串加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string str      = Console.ReadLine();
            string emptyStr = ""; //空字符串
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z') //说明这个字符是小写字母
                {
                    int num        = str[i];
                    num            += 3;
                    char temporary = (char) num;
                    if (temporary > 'z') //越界形成循环
                    {
                        temporary = (char) (temporary - 'z' + 'a' - 1); //
                    }
                    emptyStr += temporary; //转换过的字符拼接起来
                }
                else if (str[i] >= 'A' && str[i] <= 'Z') //说明这个字符是小写字母
                {
                    int num        = str[i];
                    num            += 3;
                    char temporary = (char) num;
                    if (temporary > 'Z')
                    {
                        temporary = (char) (temporary - 'Z' + 'A' - 1);
                    }
                    emptyStr += temporary; //转换过的字符拼接起来
                }
                else
                {
                    emptyStr += str[i];
                }
            }
            Console.WriteLine(emptyStr);
            Console.ReadLine();
        }
    }
}