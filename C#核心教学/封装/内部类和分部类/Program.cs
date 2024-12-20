﻿using System;

namespace 内部类和分部类
{
    #region 知识回顾

    class 类名
    {
        #region 特征 成员变量



        #endregion

        #region 行为 成员方法



        #endregion

        #region 初始化调用 构造函数



        #endregion

        #region 释放时调用 析构函数



        #endregion

        #region 保护成员变量 成员属性



        #endregion

        #region 像数组一样使用 索引器



        #endregion

        #region 类名点出使用 静态成员



        #endregion

        #region 自定义对象可计算 运算符重载



        #endregion
    }

    #region 静态类和静态构造函数



    #endregion

    #region 拓展方法



    #endregion

    #endregion

    #region 知识点一 内部类

    //概念
    //在一个类中再申明一个类

    //特点
    //使用时要用包裹者点出自己

    //作用
    //亲密关系的变现

    //注意
    //访问修饰符作用很大

    class Person
    {
        public int age;
        public string name;
        public Body body;

        public class Body
        {
            private Arm leftArm;
            private Arm righArm;

            class Arm
            {

            }
        }
    }

    #endregion

    #region 知识点二 分部类

    //概念
    //把一个类分成几部分申明

    //关键字
    //partial

    //作用
    //分部描述一个类
    //增加程序的拓展性

    //注意
    //分部类可以写在多个脚本文件中
    //分部类的访问修饰符要一致
    //分部类中不能有重复成员

    partial class Student
    {
        public bool sex;
        public string name;

        partial void Speak();
    }

    partial class Student
    {
        public int number;

        public void Speak(string str)
        {
            
        }

        partial void Speak()
        {
            
        }
    }
#endregion

    #region 知识点三 分部方法
    //概念
    //将方法的申明和实现分离
    //特点
    //1.不能加访问修饰符 默认私有
    //2.只能在分部类中申明
    //3.返回值只能是void
    //4.可以有参数但不用 out关键字
    
    //局限性很大 了解即可


    #endregion
    class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            Person.Body body= new Person.Body();

            Student s = new Student();
            
        }
    }
}

