﻿using System;

namespace 万物之父和装箱拆箱
{
    #region 里氏替换知识回顾
    //概念：父类容器装子类对象
    //作用：方便进行对象存储和管理
    //使用：
    //is和as
    //is用于判断
    //as用于转换
    class Father
    {
        
    }

    class Son:Father
    {
        public void Speak()
        {
            
        }
    }
    #endregion

    #region 知识点一 万物之父
    //万物之父
    //关键字：object
    //概念：
    //object是所有类型的基类，它是一个类（引用类型）
    //作用：
    //1.可以利用里氏替换原则，用object容器装所有对象
    //2.可以用来表示不确定类型，作为函数参数类型
    

    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点二 万物之父的使用

            Father f = new Son();
            if (f is Son)
            {
                (f as Son).Speak();
            }
            //引用类型
            object o = new Son();
            //用is as 来判断转换即可
            if (o is Son)
            {
                (o as Son).Speak();
            }
            
            //值类型
            object o2 = 1f;
            //用强转
            float fl = (float)o2;
            
            //特殊的string类型
            object str = "123";
            string str2 = str.ToString();
            string str3 = str as string;

            object arr = new int[10];
            int[] ar = (int[])arr;
            int[] ar1 = arr as int[];

            #endregion

            #region 知识点三 装箱拆箱
            //发生条件
            //用object存值类型（装箱）
            //再把object转为值类型（拆箱）
            
            //装箱
            //把值类型用引用类型存储
            //栈内存会迁移到堆内存中
            
            //拆箱
            //把引用类型存储的值类型取出来
            //堆内存会迁移到栈内存中
            
            //好处：不确定类型时可以方便参数的存储和传递
            //坏处：存在内存迁移，增加性能消耗
            
            //装箱
            object v = 3;
            //拆箱
            int ivalue = (int)v;
            
            TestFun(1,2,3f,34.5,"213",new Son());
            #endregion
        }

        static void TestFun(params object[] array)
        {
            
        }
    }
    //总结：
    //万物之父：object
    //基于里氏替换原则 可以用object容器装载一切类型的变量
    //是所有类型的基类
    
    //装箱拆箱
    //用object存值类型（装箱）
    //把object里存的值 转换出来（拆箱
    //好处
    //不确定类型时可以用 方便参数存储和传递
    //坏处
    //存在内存的迁移 增加了性能消耗
    
    //不是不用 尽量少用
}

