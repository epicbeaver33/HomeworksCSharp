using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Course { get; set; }
    }

    static void Main()
    {
        // Завдання 1: Фільтрація чисел більше 10
        List<int> numbers = new List<int> { 2, 5, 8, 12, 15, 18, 22 };
        var filteredNumbers = numbers.Where(n => n > 10).ToList();
        Console.WriteLine("Фільтрація чисел більше 10: " + string.Join(", ", filteredNumbers));

        // Завдання 2: Сортування фруктів в алфавітному порядку
        List<string> fruits = new List<string> { "Яблуко", "Апельсин", "Банан", "Ківі" };
        var sortedFruits = fruits.OrderBy(f => f).ToList();
        Console.WriteLine("Сортування фруктів: " + string.Join(", ", sortedFruits));

        // Завдання 3: Видалення дублікатів
        List<string> strings = new List<string> { "А", "Б", "В", "А", "Г", "В" };
        var uniqueStrings = strings.Distinct().ToList();
        Console.WriteLine("Видалення дублікатів: " + string.Join(", ", uniqueStrings));

        // Завдання 4: Підрахунок студентів з оцінками більше 90
        List<int> grades = new List<int> { 85, 92, 78, 95, 88, 90 };
        var count = grades.Count(g => g > 90);
        Console.WriteLine("Студенти з оцінками більше 90: " + count);

        // Завдання 5: Фільтрація та сортування товарів
        List<Product> products = new List<Product>
        {
            new Product { Name = "Товар1", Price = 45 },
            new Product { Name = "Товар2", Price = 60 },
            new Product { Name = "Товар3", Price = 30 }
        };
        var filteredProducts = products.Where(p => p.Price < 50).OrderBy(p => p.Price).ToList();
        Console.WriteLine("Фільтрація та сортування товарів:");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price}");
        }

        // Завдання 6: Пошук максимального за індексом
        List<int> numbersForMaxIndex = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };
        var maxIndex = numbersForMaxIndex.IndexOf(numbersForMaxIndex.Max());
        Console.WriteLine("Індекс максимального числа: " + maxIndex);

        // Завдання 7: Робота зі списком студентів
        List<Student> students = new List<Student>
        {
            new Student { Name = "Олена", Grade = 95, Course = 1 },
            new Student { Name = "Андрій", Grade = 88, Course = 2 },
            new Student { Name = "Марія", Grade = 92, Course = 1 },
            new Student { Name = "Петро", Grade = 78, Course = 3 },
            new Student { Name = "Іван", Grade = 90, Course = 2 }
        };

        // Фільтрація студентів з оцінкою >= 90
        var highGrades = students.Where(s => s.Grade >= 90).ToList();
        Console.WriteLine("Студенти з оцінкою >= 90:");
        foreach (var student in highGrades)
        {
            Console.WriteLine(student.Name);
        }

        // Сортування студентів за оцінкою в спадаючому порядку
        var sortedStudents = students.OrderByDescending(s => s.Grade).ToList();
        Console.WriteLine("\nСтуденти, відсортовані за оцінкою:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.Name}: {student.Grade}");
        }

        // Групування студентів за курсами
        var groupedByCourse = students.GroupBy(s => s.Course);
        Console.WriteLine("\nСтуденти за курсами:");
        foreach (var group in groupedByCourse)
        {
            Console.WriteLine($"Курс {group.Key}:");
            foreach (var student in group)
            {
                Console.WriteLine(student.Name);
            }
        }

        // Підрахунок кількості студентів на кожному курсі
        var countByCourse = students.GroupBy(s => s.Course)
                                    .Select(g => new { Course = g.Key, Count = g.Count() })
                                    .ToList();
        Console.WriteLine("\nКількість студентів на кожному курсі:");
        foreach (var course in countByCourse)
        {
            Console.WriteLine($"Курс {course.Course}: {course.Count} студентів");
        }

        // Проекція ім'я та оцінки кожного студента
        var nameGradeList = students.Select(s => $"Ім'я: {s.Name}, Оцінка: {s.Grade}").ToList();
        Console.WriteLine("\nІм'я та оцінка кожного студента:");
        foreach (var item in nameGradeList)
        {
            Console.WriteLine(item);
        }
    }
}

