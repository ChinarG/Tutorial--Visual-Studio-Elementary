using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _24排序算法_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            string   str      = Console.ReadLine();         //等待用户输入
            string[] strArray = str.Split(' ');             //用空格分割字符串中的字符
            int[]    numArray = new int[ strArray.Length ]; //记录整数数组

            for (int i = 0; i < strArray.Length; i++)
            {
                int temporary = Convert.ToInt32(strArray[i]); //转换为整数
                numArray[i]   = temporary;                    //存入整数数组
            }

            //Array.Sort(numArray); 使用 CLR 给我们的方法进行排序，这个方法其实是快排算法

            int count = 0;
            for (int j = 1; j < numArray.Length ; j++) //外部控制循环次数
            {
                for (int i = 0; i < numArray.Length - j  ; i++) //内部比较
                {
                    if (numArray[i + 1] < numArray[i]) //后边小于前边
                    {
                        count++;
                        int temporary = numArray[i];                 //前边的值赋值给临时变量
                        numArray[i]   = numArray[i + 1];             //后边数值，赋值，给前边
                        numArray[i                 + 1] = temporary; //后边的数值
                        
                    }
                }
            }


            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i] + " ");
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}