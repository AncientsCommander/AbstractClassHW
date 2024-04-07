using AbstractClassHW.Classes;

string? name;

while (true)
{
    Console.Clear();
    Console.Write("Укажите имя собаки: ");
    name = Console.ReadLine();
    
    if(!string.IsNullOrWhiteSpace(name)) break;
}

Console.Clear();

var dog = new Dog();
dog.SetName(name);

Console.WriteLine($"Имя вашей собаки: {dog.GetName()}");
dog.Eat();