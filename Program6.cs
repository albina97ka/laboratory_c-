using System;

abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double Carry { get; }
    public abstract double Range { get; }
    
    public abstract string GetTransport();
}

abstract class Automobile : Transport
{
    public override string GetTransport()
    {
        return $"Автомобиль с грузоподъемностью {Carry} кг может проехать {Range} км";
    }
}

abstract class Airplane : Transport
{
    public override string GetTransport()
    {
        return $"Самолет с грузоподъемностью {Carry} кг может пролететь {Range} км";
    }
}

abstract class Ship : Transport
{
    public override string GetTransport()
    {
        return $"Корабль с грузоподъемностью {Carry} кг может проплыть {Range} км";
    }
}

class Car : Automobile
{
    public override double Speed => 150;
    public override double Carry => 400;
    public override double Range => 600;

    public Car(){}
}

class Plane : Airplane
{
    public override double Speed => 900;
    public override double Carry => 1000;
    public override double Range => 5000;

    public Plane(){}
}

class ShipClass : Ship
{
    public override double Speed => 30;
    public override double Carry => 2000;
    public override double Range => 10000;

    public ShipClass(){}
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        Plane plane = new Plane();
        ShipClass ship = new ShipClass();

        Console.WriteLine(car.GetTransport());
        Console.WriteLine(plane.GetTransport());
        Console.WriteLine(ship.GetTransport());
    }
}