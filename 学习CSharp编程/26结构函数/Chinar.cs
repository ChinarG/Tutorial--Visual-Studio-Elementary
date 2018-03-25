using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _25结构函数
{
    /// <summary>
    /// 结构体 —— 我的名字
    /// </summary>
    struct MyName
    {
        public string firstName;
        public string lastName;


        public string SetName()
        {
            return firstName + " " + lastName;
        }
    }


    /// <summary>
    /// 向量结构体
    /// </summary>
    struct Vector3
    {
        public float x;
        public float y;
        public float z;


        public double Distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }


    struct Student
    {
        public string ID;
        public string Name;
        public bool   IsMan;
        public int    Score;


        public void show()
        {
            Console.WriteLine("姓名：" + Name);
            Console.WriteLine("学号：" + ID);
            Console.WriteLine("性别：" + (IsMan ? "男" : "女"));
            Console.WriteLine("分数：" + Score);
        }
    }

    class Chinar
    {
        static void Main(string[] args)
        {
            //MyName myName;
            //myName.firstName = "Chinar";
            //myName.lastName  = "Wu";
            ////Console.WriteLine("我的名字叫:" + myName.firstName + " " + myName.lastName);
            //Console.WriteLine("我的名字叫：" + myName.SetName());

            Vector3 myVector3;
            myVector3.x = 3;
            myVector3.y = 3;
            myVector3.z = 3;
            Console.WriteLine(myVector3.Distance());



            Student st1;
            st1.Name = "Chinar";
            st1.ID = "1";
            st1.IsMan = true;
            st1.Score = 100;
            st1.show();
            Student st2;
            st2.Name  = "ZhangHua";
            st2.ID    = "2";
            st2.IsMan = false;
            st2.Score = 1000;
            st2.show();
            Console.ReadLine();
        }
    }
}