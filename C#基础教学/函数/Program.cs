using System;
namespace 函数
{
    class Program
    {
        #region 知识点一 基本概念
        //函数（方法）
        //本质是一块具有名称的代码块
        //可以使用函数（方法）的名称来执行该代码块
        //函数（方法）是封装代码进行重复使用的一种机制

        //函数（方法）的主要作用
        //1.封装代码
        //2.提升代码复用率
        //3.抽象行为
        #endregion
        #region 知识点二 函数写在哪里
        //1.class语句块中
        //2.struct语句块中
        #endregion
        #region 知识点三 基本语法
        //static 返回类型 函数名（参数类型 参数名1，参数类型 参数名2，.....)
        //{
        //  函数的代码逻辑;
        //  return 返回值;（如果有返回类型）
        //}

        //1.关于static 不是必须 在未学习类和结构体之前必须写

        //2-1.关于返回类型 引出一个新的关键字 void（表示没有返回值）
        //2-2.返回类型 可以写任意的变量类型 14种变量类型+复杂数据类型（数组、枚举、结构体、类class)

        //3，关于函数名 使用帕斯卡命名法命名 myName（驼峰命名法） MyName（帕斯卡命名法）

        //4-1.参数不是必须的，可以有0~n个参数 参数类型也是可以任意类型 14种变量类型+复杂数据类型（数组、枚举、结构体、类class)
        // 多个参数 需要 逗号隔开
        //4-2. 参数名 驼峰命名法
        //5.当返回值不为void时 必须通过新的关键词 return返回对应类型的内容 （注意：即使是void也可以选择性使用return)

        #endregion
        #region 知识点四
        //1.无参无返回值的函数
        static void SayHello() { Console.WriteLine("hello"); }

        //2.有参无返回值的函数
        static void SayYourName(string name)
        {
            Console.WriteLine("你的名字是{0}", name);
        }

        //3.无参有返回值的函数
        static string WhatYourName()
        {
            return "myj";
        }

        //4.有参有返回值的函数
        static int Sum(int a,int b)
        {
            //int c = a + b;
            //return c;
            return a + b;
        }

        //5.有参有多返回值的函数
        //函数返回值 一定是一个类型 一个内容
        static int[] Calc(int a, int b)
        {
            int sum = a + b;
            int avg = sum / 2;
            return new int[] { sum, avg };
        }
        #endregion
        #region 知识点五 关于return 
        //即使函数没有返回值 我们也可以使用return
        //return 可以直接不执行之后的代码 直接返回到函数外部
        static void Speak(string str)
        {
            if(str=="fuck u") { return; } 
            Console.WriteLine(str);
        }
        #endregion

        //总结
        //1.基本概念
        //2.函数写在哪里 —— class 或者 struct中
        //3.基本语法
        //4.return 可以提前结束函数逻辑 程序是线性 从上到下执行
        static void Main(string[] args)
        {
            SayHello();
            //参数可以是 常量 变量 函数
            //一定是传一个 能得到对应类型的表达式
            string str = "mou";
            SayYourName(str);
            SayYourName("moyujie");

            SayYourName(WhatYourName());
        
            //有返回值的函数 要不直接拿返回值来用
            //要不就是拿变量 接收他的结果
            string str2=WhatYourName();

            //也可以直接调用 但是 返回值 对我们来说没用

            Console.WriteLine(Sum(2, 5));

            int[] arr = Calc(5, 7);
            Console.WriteLine(arr[0]+" " + arr[1]);

            Speak("fuck u");
        }
    }
}
