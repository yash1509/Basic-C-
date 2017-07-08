using System;
namespace en
{
    class enumdemonstration
    {
        enum days { Sun,Mon,Tue,Wed,Thur,Fri,Sat };
        public static void Main(String[] args)
        {
            int Westart = (int)days.Mon;
            int Weend = (int)days.Fri;
            double Weekend =(double)days.Sun;
            Console.WriteLine("Monday : {0}", Westart);
            Console.WriteLine("Friday : {0}", Weend);
            Console.WriteLine("Weekend : {0}", Weekend);
            Console.ReadKey();
        }
    }
}