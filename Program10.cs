using System;

delegate void EventHandler(string message);

class FirstClass
{
    public event EventHandler EventOccured;
    private string name;

    public FirstClass(string name)
    {
        this.name = name;
    }

    public void RaiseEvent()
    {
        EventOccured?.Invoke(name);
    }
}

class SecondClass
{
    private string name;

    public SecondClass(string name)
    {
        this.name = name;
    }

    public void HandleEvent(string eventName)
    {
        Console.WriteLine($"Событие {eventName} вызвано через объект {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FirstClass firstObject1 = new FirstClass("Первый объект 1");
        FirstClass firstObject2 = new FirstClass("Первый объект 2");
        SecondClass secondObject = new SecondClass("Второй объект");

        firstObject1.EventOccured += secondObject.HandleEvent;
        firstObject2.EventOccured += secondObject.HandleEvent;

        firstObject1.RaiseEvent();
        firstObject2.RaiseEvent();
    }
}
