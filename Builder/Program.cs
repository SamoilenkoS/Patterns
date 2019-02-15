using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var homeMaker = new HomeMaker(new AnotherHomeBuilder());
            homeMaker.BuildHome();
            var home = homeMaker.GetHome();
            home.Display();
            Console.ReadKey();
        }
    }
}
