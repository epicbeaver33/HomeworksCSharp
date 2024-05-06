using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public void DisplayInfo()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Назва книги: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Рік видання: {Year}");
            Console.WriteLine($"Кількість сторінок: {Pages}");
        }

        public void IsThick()
        {
            if (Pages > 500)
            {
                Console.WriteLine("Ця книга товста!");
            }
            else
            {
                Console.WriteLine("Ця книга не така товста.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення першого екземпляру книги
            Book book1 = new Book();
            book1.Title = "Війна і мир";
            book1.Author = "Лев Толстой";
            book1.Year = 1869;
            book1.Pages = 1225;

            // Створення другого екземпляру книги
            Book book2 = new Book();
            book2.Title = "Преступление и наказание";
            book2.Author = "Федор Достоевский";
            book2.Year = 1866;
            book2.Pages = 671;

            // Виклик методів для першої книги
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Інформація про першу книгу:");
            book1.DisplayInfo();
            book1.IsThick();
            Console.WriteLine();

            // Виклик методів для другої книги
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Інформація про другу книгу:");
            book2.DisplayInfo();
            book2.IsThick();
        }
    }
}
