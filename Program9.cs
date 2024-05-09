using System;
using System.Collections.Generic;

delegate void WashCar(Car car); 

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

    public void WashAllCars(WashCar washDelegate)
    {
        foreach (var car in cars)
        {
            washDelegate(car);
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
        WashCar washDelegate = new WashCar(washer.Wash); 
        garage.WashAllCars(washDelegate);
    }
}
