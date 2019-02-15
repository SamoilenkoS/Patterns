using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new AdapterClass();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
