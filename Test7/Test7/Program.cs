using System;
namespace abst
{
    abstract class A
    {
        public abstract void are(); 
    }
    class Ba: A
    {   public int len,br,ar;
        public Ba()
        {
            len = 5;
            br = 6;
        }
        public override void are()
        {
            ar = len * br;
            Console.WriteLine("Area {0}", ar);
        }

    }
    class main
    {
        public static void Main(String [] args)
        {
            Ba obj = new Ba();
            obj.are();
            Console.ReadLine();
        }
    }
}