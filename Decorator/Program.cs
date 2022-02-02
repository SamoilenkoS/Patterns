using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component pizzaBody = new PizzaBody();//
            Console.WriteLine($"Description:{pizzaBody.Description()}{Environment.NewLine}Price:{pizzaBody.Price()}");
            pizzaBody = new Cheeze(pizzaBody);
            pizzaBody = new Cheeze(pizzaBody);
            pizzaBody = new Tomatoes(pizzaBody);
            Console.WriteLine($"Description:{pizzaBody.Description()}{Environment.NewLine}Price:{pizzaBody.Price()}");
            Console.ReadKey();
        }
    }
}
