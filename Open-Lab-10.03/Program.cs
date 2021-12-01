using System;

namespace Open_Lab_10._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title = "Kďe všade som (ne)zomrel";
            LOTR.Pages = -269;
            LOTR.Category = "Tragikomédia";
            LOTR.Author = "PPPeter";
            LOTR.ReleaseDate = 2077;

            Console.WriteLine(LOTR.Title);
            Console.WriteLine(LOTR.Pages);
            Console.WriteLine(LOTR.Category);
            Console.WriteLine(LOTR.Author);
            Console.WriteLine(LOTR.ReleaseDate);
        }
    }
}
