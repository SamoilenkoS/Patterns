using System;

namespace MediatorNamespace
{
    class Program
    {
        static void Main()
        {
            ConcreteMediator concreteMediator = new ConcreteMediator();

            ConcreteColleague1 concreteColleague1 = new ConcreteColleague1(concreteMediator);
            ConcreteColleague2 concreteColleague2 = new ConcreteColleague2(concreteMediator);

            concreteMediator.Colleague1 = concreteColleague1;
            concreteMediator.Colleague2 = concreteColleague2;

            concreteColleague1.Send("How are you?");
            concreteColleague2.Send("Fine, thanks");

            Console.ReadKey();
        }
    }
}