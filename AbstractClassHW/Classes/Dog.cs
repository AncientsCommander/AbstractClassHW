using AbstractClassHW.AbstractClasses;

namespace AbstractClassHW.Classes;

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Собака что-то ест!");
    }
}