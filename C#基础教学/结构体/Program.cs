﻿using System;
namespace 结构体
{
    #region 知识点一 基本概念
    //结构体 是一种自定义变量类型 类似枚举需要自己定义
    //它是数据和函数的集合
    //在结构体中 可以申明各种变量和方法

    //作用：用来表现存在关系的数据集合 比如用结构体表现学生 动物 人类等等
    #endregion
    #region 知识点二 基本语法
    //1.结构体一般写在namespace语句中
    //2.结构体关键字 struct

    struct 自定义结构体名
    {


        //第一部分
        //变量

        //第二部分
        //构造函数（可选）

        //第三部分
        //函数
    }
    //注意 结构体名字 帕斯卡命名法
    #endregion
    #region 知识点三 实例
    //表现学生数据 的 结构体
    struct Student
    {
        #region 知识点五 访问修饰符
        //修饰结构体中变量和方法 是否能够被外界使用
        //public 公共的 可以被外部访问
        //private 私有的 只能在内部使用
        //默认不写 为private
        #endregion


        //变量
        //在结构体中申明的变量 不能直接初始化
        //变量类型 可以写任意类型 包括结构体 但不能是自身
        //年龄
        public int age;
        //性别
        public bool sex;
        //学号
        public int number;
        //姓名
        public string name;


        //构造函数
        #region 知识点六 结构体的构造函数
        //基本概念
        //1.没有返回值
        //2.函数名称必须和结构体名相同
        //3.必须有参数
        //4.如果申明了构造函数 那么必须在其中对所有变量数据初始化
        
        //构造函数 一般用于在外部方便初始化的
        public Student(int age, bool sex, int number, string name)
        {
            //新的关键字 this
            //代表自己
            this.age = age;
            this.sex = sex;
            this.number = number;
            this.name = name;
        }
        #endregion


        //函数方法
        //表现这个数据结构的行为

        //注意 在结构体中的方法 目前不需要加static关键字
        public void Speak()
        {
            //函数中可以直接使用结构体内部申明的变量
            Console.WriteLine("我的名字是{0},我今年{1}岁", name, age);
        }
        //可以根据需求写无数个函数
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点四 结构体的使用
            //变量类型 变量名;
            Student s1;
            s1.age = 10;
            s1.sex = true;
            s1.number = 1;
            s1.name = "myj";
            s1.Speak();

            Student s2 = new Student(18, true, 2, "myj");
            s2.Speak();
            #endregion
        }
    }


    //总结
    //1.概念：结构体 struct 是变量和函数的集合 用来表示特定的数据集合

    //访问修饰符：public和private用来修饰变量和方法的 public外部可以调用 private内部用 不写默认private
    //构造函数：没有返回值 函数名好玩结构体名相同 可以重载 主要是帮助我们快速初始化结构体对象

    //注意
    //1.在结构体中申明的变量 不能初始化 只能在外部或者函数中赋值（初始化）
    //2.在结构体中申明的函数 不用加static
}