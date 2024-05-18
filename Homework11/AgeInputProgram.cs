using System;

namespace AgeInputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Запит на ввід віку
                    Console.Write("Введіть ваш вік: ");
                    string input = Console.ReadLine();

                    // Спроба конвертації вводу до числа
                    int age = int.Parse(input);

                    // Перевірка чи вік є додатнім числом
                    if (age < 0)
                    {
                        throw new FormatException("Вік не може бути меншим за 0.");
                    }

                    // Вивід віку користувача
                    Console.WriteLine($"Ваш вік: {age}");
                    break;
                }
                catch (FormatException ex)
                {
                    // Обробка виключення некоректного вводу
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
        }
    }
}