using System;

namespace Template_method
{
    abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        protected abstract void Enter();
        protected abstract void Study();
        protected virtual void PassExams()
        {
            Console.WriteLine("Exams");
        }
        protected abstract void GetDocument();
    }
}
