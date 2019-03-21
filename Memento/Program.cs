using System;

class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero();
        hero.Shoot();

        GameHistory gameHistory = new GameHistory();
        gameHistory.History.Push(hero.SaveState());

        hero.Shoot();
        hero.RestoreState(gameHistory.History.Pop());
        hero.Shoot();

        Console.ReadKey();
    }
}