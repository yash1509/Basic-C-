using System;
namespace add
{
    class adding
    {
        static void Main(String [] args)
        {
            double a, b;
            Console.WriteLine("Enter two numbers for addition:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            int c = (int)a + (int)b;
            Console.WriteLine("a= {0} \nb= {1} \nSum : {2}", a, b, c);
            Console.ReadLine();
        }
    }
}