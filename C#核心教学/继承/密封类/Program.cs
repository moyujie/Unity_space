using System;

namespace 密封类
{
    #region 知识点一 基本概念
    //密封类 是使用 sealed密封关键字修饰的类
    //作用：让类无法再被继承

    #endregion

    #region 知识点二 实例

    class Father
    {
        
    }

    sealed class Son : Father
    {
        
    }
    
    #endregion

    #region 知识点三 作用
    //在面向对象程序的设计中，密封类的主要作用就是不允许最底层子类被继承
    //可以保证程序的规范性，安全性
    //目前对于大家来说 可能用处不大
    //以后制作复杂系统或者程序框架时 能慢慢体会密封的作用
    #endregion
    //总结
    //关键字：sealed
    //作用：让类无法再被继承
    //意义：加强面向对象程序设计的 规范性 
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}