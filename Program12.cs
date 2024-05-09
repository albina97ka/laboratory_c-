using System;

interface IPublisher
{
    string Title { get; set; }
    string Author { get; set; }
}

interface IBook : IPublisher
{
    string PublicationDate { get; set; }
    int PageCount { get; set; }
}

class Book : IBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationDate { get; set; }
    public int PageCount { get; set; }
}

interface IUser
{
    string Username { get; set; }
    string Password { get; set; }
}

class User : IUser
{
    public string Username { get; set; }
    public string Password { get; set; }
}

class UserBook : IBook, IUser
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationDate { get; set; }
    public int PageCount { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public void BuyBook()
    {
        Console.WriteLine($"{Username} купил книгу '{Title}' автора {Author}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book
        {
            Title = "Книга 1",
            Author = "Автор 1",
            PublicationDate = "01.01.2011",
            PageCount = 200
        };
        Book book2 = new Book
        {
            Title = "Книга 2",
            Author = "Автор 2",
            PublicationDate = "02.02.2012",
            PageCount = 150
        };
        User user1 = new User
        {
            Username = "user1",
            Password = "password1"
        };
        User user2 = new User
        {
            Username = "user2",
            Password = "password2"
        };
        UserBook userBook = new UserBook
        {
            Title = "Книга 3",
            Author = "Автор 3",
            PublicationDate = "03.03.2013",
            PageCount = 180,
            Username = "user3",
            Password = "password3"
        };
        userBook.BuyBook();
    }
}
