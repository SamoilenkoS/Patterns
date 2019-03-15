/// <summary>
/// The 'ConcreteMediator' class
/// </summary>
public class ConcreteMediator : Mediator
{
    public ConcreteColleague1 Colleague1 { private get; set; }

    public ConcreteColleague2 Colleague2 { private get; set; }

    public override void Send(string message, Colleague colleague)
    {
        if (colleague == Colleague1)
        {
            Colleague2.Notify(message);
        }
        else
        {
            Colleague1.Notify(message);
        }
    }
}