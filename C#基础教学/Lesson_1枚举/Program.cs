using System;
namespace Lesson_1枚举 
{
    #region 知识点一 基本概念
    #region 1.枚举是什么
    //枚举是一个比较特别的存在
    //它是一个被命名的整形常量的集合
    //一般用它来表示 状态 类型 等等
    #endregion
    #region 2.申明枚举 和 申明枚举变量
    //注意：申明枚举 和 申明枚举变量是两个概念
    //申明枚举：相当于 创建一个自定义的枚举类型
    //申明枚举变量： 使用申明的自定义枚举类型 创建一个枚举变量
    #endregion
    #region 3.申明枚举语法
    //枚举名 以E或者E_开头 作为命名规范
    enum E_自定义枚举名
    {
        自定义枚举项名字,//枚举中包裹的 整形常量 第一个默认值为0 下面依次累加
        自定义枚举项名字1,//1
        自定义枚举项名字2,//2
    }
    enum E_自定义枚举名1
    {
        自定义枚举项名字 = 5,//枚举中包裹的 整形常量 第一个默认值为0 下面依次累加
        自定义枚举项名字1,//6
        自定义枚举项名字2 = 100,//100
        自定义枚举项名字3,//101
        自定义枚举项名字4,//102
    }
    #endregion
    #endregion

    #region 知识点二 在哪里申明枚举
    //1.namespace语句块中（常用）
    //2.class语句块中 struct语句块中
    //注意：枚举不能再函数语句块中申明！！！
    enum E_MonsterType
    {
        Normal,//0
        Boss,//1
    }
    enum E_PlayerType
    {
        Main,
        Other,
    }
    #endregion



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举");
            #region 知识点三 枚举的使用
            //申明枚举变量
            //自定义的枚举类型 变量名=默认值;（自定义的枚举类型.枚举项）
            E_PlayerType playerType = E_PlayerType.Main;//.赋值
            if(playerType == E_PlayerType.Main)
            {
                Console.WriteLine("zhuwanjialuoji");
            }
            else if(playerType == E_PlayerType.Other)
            {
                Console.WriteLine("qitawanjialuoji");
            }
            //枚举和switch是天生一对
            E_MonsterType monsterType = E_MonsterType.Boss;
            switch(monsterType)
            {  
                case E_MonsterType.Boss:
                    break;
                case E_MonsterType.Normal: 
                    break;
                default:
                    break;
            }
            #endregion
            #region 知识点四 枚举的类型转换
            //枚举和int转换
            int i = (int)playerType;
            Console.WriteLine(i);

            playerType = 0;
            //枚举和string转换
            string str=playerType.ToString();
            Console.WriteLine(str);
            //Parse后 第一个参数：转为 枚举类型 第二个参数：用于转换的对应枚举项 字符串
            //转换完毕后 为一个通用类型 需要用括号强转目标类型
            playerType=(E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Other");

            #endregion
            #region 知识点五 枚举的作用
            //在游戏开发中，有很多时候 会有很多状态
            //比如玩家 有一个动作状态 需要一个变量或者标识 来标识玩家当前处于的状态
            //综合考虑 可能会使用int表示状态
            //1.行走2.嗲及3.跑步

            //枚举可以帮助我们 清晰分清楚状态的含义
            #endregion
        }
    }
}
