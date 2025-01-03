﻿using System;
using System.Text;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点 StringBuilder

            //c#提供的一个用于处理字符串的公共类
            //主要解决的问题是：
            //修改字符串而不创建新的对象，需要频繁修改和拼接的字符串可以使用它，可以提升性能
            //使用前 需要引用命名空间

            #endregion

            #region 初始化 直接指明内容

            StringBuilder str = new StringBuilder("123123123",100);
            Console.WriteLine(str);
            
            


            #endregion

            #region 容量
            //StringBuilder存在一个容量的问题，每次往里面增加时 会自动扩容
            //获得容量
            Console.WriteLine(str.Capacity);
            //获得字符长度
            Console.WriteLine();

            #endregion

            #region 增删查改替换

            //增
            str.Append("2334");
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Capacity);

            str.AppendFormat("{0}{1}", 100, 999);
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Capacity);
            //插入
            str.Insert(0, "546");
            Console.WriteLine(str);
            //删除
            str.Remove(0, 10);
            Console.WriteLine(str);
            //清空
            //str.Clear();
            //Console.WriteLine(str);

            //查
            Console.WriteLine(str[1]);
            //改
            str[0] = 'A';
            Console.WriteLine(str);
            //替换
            str.Replace("1", "zsy");
            
            //重新赋值 StringBuilder
            str.Clear();
            str.Append("123123");
            Console.WriteLine(str);

            if (str.Equals(123123))
            {
                Console.WriteLine("相等");
            }
            #endregion
        }
    }
}

