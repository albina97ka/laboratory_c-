using LibraryNamespace;
using System;
using UniversityNamespace;

namespace UniversityNamespace
{
    public class Student
    {
        public string Name { get; set; }
        public string GroupNumber { get; set; }
        private int age; 
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name}, Group: {GroupNumber}, Age: {Age}");
        }
    }
}

namespace LibraryNamespace
{
    public class Reader
    {
        private string fullName;
        public int LibraryCardNumber { get; set; }
        private DateTime dateOfBirth;
        public string Faculty { get; set; } 
        public string FullName 
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public DateTime DateOfBirth 
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public string PhoneNumber { get; set; }

        public void takeBook(int count)
        {
            Console.WriteLine($"{FullName} взял {count} книги");
        }

        public void takeBook(params string[] bookNames)
        {
            Console.Write($"{FullName} взял книги: ");
            foreach (string book in bookNames)
            {
                Console.Write($"{book}, ");
            }
            Console.WriteLine();
        }

        public void returnBook(int count)
        {
            Console.WriteLine($"{FullName} вернул {count} книги");
        }

        public void returnBook(params string[] bookNames)
        {
            Console.Write($"{FullName} вернул книги: ");
            foreach (string book in bookNames)
            {
                Console.Write($"{book}, ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[]
        {
           new Student { Name = "Иванов И.И.", GroupNumber = "Группа 101", Age = 20 },
           new Student { Name = "Петров П.П.", GroupNumber = "Группа 102", Age = 21 },
           new Student { Name = "Сидоров С.С.", GroupNumber = "Группа 103", Age = 19 }
        };

        Reader[] readers = new Reader[]
        {
           new Reader { FullName = "Иванов И.И.", LibraryCardNumber = 1001, Faculty = "Факультет 1", DateOfBirth = new DateTime(1998, 5, 10), PhoneNumber = "123-456-7890" },
           new Reader { FullName = "Петров П.П.", LibraryCardNumber = 1002, Faculty = "Факультет 2", DateOfBirth = new DateTime(1999, 3, 15), PhoneNumber = "987-654-3210" },
           new Reader { FullName = "Сидоров С.С.", LibraryCardNumber = 1003, Faculty = "Факультет 3", DateOfBirth = new DateTime(1997, 8, 20), PhoneNumber = "111-222-3333" }
        };


        foreach (Student student in students)
        {
            student.DisplayInfo();
        }

        Random rnd = new Random();
        foreach (Reader reader in readers)
        {
            reader.takeBook(rnd.Next(1, 5)); 
            reader.returnBook(rnd.Next(1, 5)); 
        }
    }
}
