using System;
namespace Test2
{
    class rect
    {
        double len, wid;
        public void give()
        {
            len = 4.1; wid = 6.5;
        }
        public double area()
        {
            return len * wid;
        }
        public void disp()
        {
            Console.WriteLine("Length : {0}", len);
            Console.WriteLine("Width : {0}", wid);
            Console.WriteLine("Area : {0}", area());
        }

    }
    class exe
    {
        static void Main(String[] args)
        {
            rect r = new rect();
            r.disp();
            r.give();
            r.disp();
            Console.ReadLine();
        }
    }
}