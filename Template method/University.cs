using System;

namespace Template_method
{
    class University : Education
    {
        protected override void Enter()
        {
            Console.WriteLine("Pass exams");
        }

        protected override void Study()
        {
            Console.WriteLine("Lections");
            Console.WriteLine("Practices");
        }

        protected override void PassExams()
        {
            Console.WriteLine("Pass profile exams");
        }

        protected override void GetDocument()
        {
            Console.WriteLine("Get profile diploma");
        }
    }
}
