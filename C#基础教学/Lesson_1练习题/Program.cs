using System;
namespace Lesson_1练习题
{
    /// <summary>
    /// QQ状态枚举
    /// </summary>
    enum E_QQType
    {
        /// <summary>
        /// 在线
        /// </summary>
        Online,
        Offline,
        Busy,
        YinShen,
    }
    enum E_CafeType
    {
        /// <summary>
        /// 中杯
        /// </summary>
        M,
        /// <summary>
        /// 大杯
        /// </summary>
        B,
        /// <summary>
        /// 超大杯
        /// </summary>
        S,
    }
    enum E_sexType
    {
        Man,
        Woman,
    }
    enum E_Ocu
    {/// <summary>
    /// 战士
    /// </summary>
        Warrior,
    /// <summary>
    /// 猎人
    /// </summary>
        Hunter,
        /// <summary>
        /// 法师
        /// </summary>
        Master,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举练习题");
            #region 练习题一
            //定义QQ状态的枚举，并提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型
            E_QQType type=E_QQType.Online;//三缸注释
            try
            {
                Console.WriteLine("请输入QQ的状态（0在线，1离开，2忙，3隐身）");
                int type1 = int.Parse(Console.ReadLine());
                E_QQType qqType=(E_QQType)type1;//整型强转枚举型
                Console.WriteLine(qqType);
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            #endregion
            #region 练习题二
            //用户去星巴克买咖啡 分为中杯（35） 大杯（40） 超大杯（43）
            //请用户选择要买的类型，用户选择后，打印：您购买了xxx咖啡，花费了xx元
            //例如：你购买了中杯咖啡，花费了35元
            try
            {
                Console.WriteLine("请输入咖啡的种类（中杯0 大杯1 超大杯 2）");
                int cafeType=int.Parse(Console.ReadLine());
                E_CafeType cType=(E_CafeType)cafeType;
                switch(cType)
                {
                    case E_CafeType.M:
                        Console.WriteLine("你购买了中杯咖啡，花费了35元");
                        break;
                    case E_CafeType.B:
                        Console.WriteLine("你购买了大杯咖啡，花费了40元");
                        break;
                    case E_CafeType.S:
                        Console.WriteLine("你购买了超大杯咖啡，花费了43元");
                        break;
                    default:
                        Console.WriteLine("请输入正确类型");
                        break;

                }
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            #endregion
            #region
            //请用户选择英雄性别与英雄职业，最后打印英雄的基本属性（攻击力，防御力，技能）
            //性别：
            //男（攻击力+50 防御力+100）
            //女（攻击力+150 防御力+20）
            //职业：
            //战士（攻击力+20，防御力+100，技能：冲锋）
            //猎人（攻击力+120，防御力+30，技能：假死）
            //法师（攻击力+200，防御力+10，技能：奥术冲击）
            try
            {
                Console.WriteLine("请选择性别（男0 女1）");
                E_sexType sex=(E_sexType)int.Parse(Console.ReadLine());
                string sexstr = "";
                int atk = 0;
                int def = 0;
                switch(sex)
                {
                    case E_sexType.Man:
                        sexstr = "男性";
                        atk += 50;
                        def += 100;
                        break;
                    case E_sexType.Woman:
                        sexstr = "女性";
                        atk += 150;
                        def += 20;
                        break;
                    default:
                        break;

                }
                Console.WriteLine("请选择职业（战士0，猎人1，法师2）");
                E_Ocu o=(E_Ocu)int.Parse(Console.ReadLine());
                string skill = "";
                string Ocu = "";
                switch(o)
                {
                    case E_Ocu.Warrior:
                        atk += 20;
                        def += 100;
                        skill = "冲锋";
                        Ocu = "战士";
                        break;
                    case E_Ocu.Hunter:
                        atk += 120;
                        def += 30;
                        skill = "假死";
                        Ocu = "猎人";
                        break;
                    case E_Ocu.Master:
                        atk += 200;
                        def += 10;
                        skill = "奥术冲击";
                        Ocu = "法师";
                        break;
                }
                Console.WriteLine("你选择了\"{0}{1}\",攻击力：{2}，防御力{3}，职业技能：{4}", sexstr, Ocu, atk, def, skill);
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            //打印举例：你选择了“女性法师”，攻击力：350，防御力：30，职业技能：奥术冲击
            
            #endregion
        }
    }
}