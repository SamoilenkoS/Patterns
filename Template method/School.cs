using System;

namespace Template_method
{
    class School : Education
    {
        protected override void Enter()
        {
            Console.WriteLine("Go to first class");
        }

        protected override void Study()
        {
            Console.WriteLine("Going to school and doing homework");
        }

        protected override void GetDocument()
        {
            Console.WriteLine("Get school diploma");
        }
    }
}
