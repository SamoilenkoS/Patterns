using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatter = new ReverseFormatter();
            var book = new Book(formatter);
            book.Author = "Pushkin";
            book.Title = "Fairies";
            book.Print();
            Console.ReadKey();
        }
    }
}
