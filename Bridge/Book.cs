using System;

namespace Bridge
{
    public class Book : Manuscript
    {
        public Book(IFormatter formatter) : base(formatter)
        {

        }
        public string Title { get; set; }
        public string Author { get; set; }
        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine(formatter.Format("Author", Author));
        }
    }
}
