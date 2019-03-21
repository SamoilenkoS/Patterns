using System.Collections.Generic;

class GameHistory
{
    public Stack<HeroMemento> History { get; private set; }
    public GameHistory()
    {
        History = new Stack<HeroMemento>();
    }
}