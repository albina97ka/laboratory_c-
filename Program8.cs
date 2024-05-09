using System;

class GenericArray<T>
{
    private T[] array;
    private int size;

    public GenericArray(int capacity)
    {
        array = new T[capacity];
        size = 0;
    }

    public void Add(T item)
    {
        if (size < array.Length)
        {
            array[size] = item;
            size++;
        }
        else
        {
            Console.WriteLine("Массив заполнен. Не удается добавить больше элементов");
        }
    }

    public T Get(int index)
    {
        if (index >= 0 && index < size)
        {
            return array[index];
        }
        else
        {
            Console.WriteLine("Неверный индекс");
            return default(T);
        }
    }

    public int Length()
    {
        return size;
    }
}

class Credentials
{
    public string Username { get; set; }
    public string Password { get; set; }
}

class UserCredentials : GenericArray<Credentials>
{
    private string[] usernames;
    private string[] passwords;

    public UserCredentials(int capacity) : base(capacity)
    {
        usernames = new string[capacity];
        passwords = new string[capacity];
    }

    public void RegisterUser(string username, string password)
    {
        if (Length() < usernames.Length) 
        {
            Credentials credentials = new Credentials { Username = username, Password = password };
            Add(credentials); 

            usernames[Length() - 1] = username; 
            passwords[Length() - 1] = password; 
        }
        else
        {
            Console.WriteLine("Не удалось зарегистрировать нового пользователя. Вместимость массива заполнена.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        UserCredentials userCredentials = new UserCredentials(2);
        userCredentials.RegisterUser("user1", "password1");
        userCredentials.RegisterUser("user2", "password2");

        Console.WriteLine("Registered Users:");
        for (int i = 0; i < userCredentials.Length(); i++)
        {
            Credentials credentials = userCredentials.Get(i);
            Console.WriteLine("Username: " + credentials.Username + ", Password: " + credentials.Password);
        }
    }
}
