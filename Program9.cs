using System;
using System.Collections.Generic;

class Car
{
    public string Model { get; set; }
    public string Color { get; set; }

    public Car(string model, string color)
    {
        Model = model;
        Color = color;
    }
}

class Garage
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void WashAllCars(Washer washer)
    {
        foreach (var car in cars)
        {
            washer.Wash(car);
        }
    }
}

class Washer
{
    public void Wash(Car car)
    {
        Console.WriteLine($"Моем автомобиль {car.Color} {car.Model}");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", "Черный");
        Car car2 = new Car("Audi", "Сиреневый");

        Garage garage = new Garage();
        garage.AddCar(car1);
        garage.AddCar(car2);

        Washer washer = new Washer();
        garage.WashAllCars(washer);
    }
}
