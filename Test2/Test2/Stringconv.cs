using System;
namespace Stringconversion
{
    class stringconv
    {
        public static void Main(String []args)
        {
            int i = 5;
            double k = 123123.23123;
            long p = 242.23;
            float a = 123.452f;
            bool b = true;
            string asd= "Asheleon";
            dynamic gh = "Not";
            Console.WriteLine(i.ToString());
            Console.WriteLine(k.ToString());
            Console.WriteLine(p.ToInt32());
            Console.WriteLine(b.ToString());
            Console.WriteLine(asd);
            Console.WriteLine(gh);
        }
     
    }
}