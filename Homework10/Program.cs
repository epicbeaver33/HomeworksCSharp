using System;
using System.Text;

public class Person
{
    private string name;
    private int age;
    private string gender;

    public Person(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    public Person(string name) : this(name, 0, "не вказано") { }

    public Person(string name, int age) : this(name, age, "не вказано") { }

    public void PrintDetails()
    {
        Console.WriteLine($"Ім'я: {name}, Вік: {age}, Стать: {gender}");
    }

    public bool IsAdult()
    {
        return age >= 18;
    }

    public void ChangeName(string newName)
    {
        name = newName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберіть завдання:");
        Console.WriteLine("1. Робота з класом Person");
        Console.WriteLine("2. Створення представлення дати");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
        {
            Console.WriteLine("Некоректний вибір! Введіть 1 або 2:");
        }

        switch (choice)
        {
            case 1:
                RunPersonTask();
                break;
            case 2:
                RunDateRepresentationTask();
                break;
        }
    }

    static void RunPersonTask()
    {
        // Приклад використання класу Person
        Person person1 = new Person("Іван", 25, "чоловіча");
        Person person2 = new Person("Марія");
        Person person3 = new Person("Петро", 30);

        person1.PrintDetails();
        Console.WriteLine($"Чи є дорослим: {person1.IsAdult()}");

        person2.PrintDetails();
        Console.WriteLine($"Чи є дорослим: {person2.IsAdult()}");

        person3.PrintDetails();
        Console.WriteLine($"Чи є дорослим: {person3.IsAdult()}");

        person1.ChangeName("Василь");
        person1.PrintDetails();
    }

    static void RunDateRepresentationTask()
    {
        // Виклик методів для перевірки коректності введених дат та форматування їх у вказаний формат
        int day, month, year;
        Console.WriteLine("\nВведіть день:");
        while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
        {
            Console.WriteLine("Некоректне значення! Введіть ціле число від 1 до 31:");
        }

        Console.WriteLine("Введіть місяць:");
        while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
        {
            Console.WriteLine("Некоректне значення! Введіть ціле число від 1 до 12:");
        }

        Console.WriteLine("Введіть рік:");
        while (!int.TryParse(Console.ReadLine(), out year) || year < 1)
        {
            Console.WriteLine("Некоректне значення! Введіть ціле число більше 0:");
        }

        // Форматування дати у вказаний формат
        StringBuilder formattedDate = new StringBuilder();
        formattedDate.Append($"{day:D2}-{month:D2}-{year}");
        Console.WriteLine($"Форматована дата: {formattedDate}");
    }
}

