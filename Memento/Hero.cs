using System;

internal class Hero
{
    private int patrons;
    private int lives;

    public Hero()
    {
        patrons = 10;
        lives = 5;
    }

    public void Shoot()
    {
        if (patrons > 0)
        {
            patrons--;
            Console.WriteLine($"Make a shoot. {patrons} {nameof(patrons)} left");
        }
        else
            Console.WriteLine($"There is no {nameof(patrons)}");
    }

    public HeroMemento SaveState()
    {
        Console.WriteLine("Game saved.");
        return new HeroMemento(patrons, lives);
    }

    public void RestoreState(HeroMemento memento)
    {
        patrons = memento.Patrons;
        lives = memento.Lives;
        Console.WriteLine($"Game loaded. Params: {patrons} {nameof(patrons)}, {lives} {nameof(lives)}.");
    }
}