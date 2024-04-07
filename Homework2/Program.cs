using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        // Обчислення величини знижки
        double price = 400; // приклад значення вартості товару
        double discountPercentage = 20; // приклад значення відсотка знижки

        double discount = price * (discountPercentage / 100); 

        Console.WriteLine("Сума знижки:" + discount);
        Console.WriteLine("                         ");


        // Час в секундах
        int hours = 1; // приклад значення годин
        int minutes = 20; // приклад значення хвилин
        int seconds = 100; // приклад значення секунд

        int totalSeconds = hours * 3600 + minutes * 60 + seconds;

        Console.WriteLine("Загальний час у секундах:" + totalSeconds);
        Console.WriteLine("                         ");


        // Інформація про книгу
        string назва = "Відьмак";
        string автор = "Анджей Сапковський";
        int рік = 2012;
        int ціна = 210;

        // Виводимо інформацію про книгу у форматованому рядку
        Console.WriteLine("Інформація про книгу:");
        Console.WriteLine("Назва: {0}", назва);
        Console.WriteLine("Автор: {0}", автор);
        Console.WriteLine("Рік: {0}", рік);
        Console.WriteLine("Ціна: {0}грн", ціна);
    }
}
