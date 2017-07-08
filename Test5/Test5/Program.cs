using System;
struct book
{
    private String boo;
    private String author;

    public void getdetails(String a,String b)
    {
        boo = a;
        author = b;
    }
    public void display()
    {
        Console.WriteLine("Book name : {0}", boo);
        Console.WriteLine("Book Author : {0}", author);
    }
}

namespace stud
{
    public class book12
    {
        public static void Main(String[] args)
        {
            book Book1 = new book();
            book Book2 = new book();
            Book1.getdetails("The Rogue", "Trudi Canavan");
            Book2.getdetails("High Lord", "Trudi Canavan");
            Book1.display();
            Book2.display();
            Console.ReadKey();
        }
    }
}