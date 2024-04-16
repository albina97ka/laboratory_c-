using System;

class Animal
{
    public string name;
    public string food;
    public string location;

    public virtual void makeNoise()
    {
        Console.WriteLine("Животное издает звук");
    }

    public virtual void eat()
    {
        Console.WriteLine("Животное ест");
    }

    public void sleep()
    {
        Console.WriteLine("Животное спит");
    }
}

class Dog : Animal
{
    public string breed;

    public override void makeNoise()
    {
        Console.WriteLine("Собака гавкает");
    }

    public override void eat()
    {
        Console.WriteLine("Собака ест кости");
    }
}

class Cat : Animal
{
    public int livesLeft;

    public override void makeNoise()
    {
        Console.WriteLine("Кошка мяучит");
    }

    public override void eat()
    {
        Console.WriteLine("Кошка ест рыбу");
    }
}

class Horse : Animal
{
    public string color;

    public override void makeNoise()
    {
        Console.WriteLine("Лошадь фыркает");
    }

    public override void eat()
    {
        Console.WriteLine("Лошадь пасется на лугу");
    }
}

class Vet
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine($"Тип животного: {animal.name}, Еда: {animal.food}, Местоположение: {animal.location}");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.name = "собака";
        dog.food = "мясо";
        dog.location = "дом";
        dog.breed = "Овчарка";

        Cat cat = new Cat();
        cat.name = "кошка";
        cat.food = "кошачий корм";
        cat.location = "дом";
        cat.livesLeft = 9;

        Horse horse = new Horse();
        horse.name = "лошадь";
        horse.food = "сено";
        horse.location = "пастбище";
        horse.color = "рыжая";

        Vet veterinarian = new Vet();
        veterinarian.treatAnimal(dog);
        veterinarian.treatAnimal(cat);
        veterinarian.treatAnimal(horse);
    }
}
