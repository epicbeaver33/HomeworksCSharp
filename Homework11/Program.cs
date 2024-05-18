using System;
using UkrainianStringLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("1. Підрахувати кількість голосних літер");
                Console.WriteLine("2. Підрахувати кількість приголосних літер");
                Console.WriteLine("3. Обернути рядок");
                Console.WriteLine("4. Видалити дублікати символів");
                Console.WriteLine("5. Видалити знаки пунктуації");
                Console.WriteLine("6. Вийти");

                string choice = Console.ReadLine();

                // Перевірка вибору користувача
                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть рядок: ");
                        string input1 = Console.ReadLine();
                        int vowelsCount = UkrainianStringUtils.CountVowels(input1);
                        Console.WriteLine($"Кількість голосних: {vowelsCount}");
                        break;

                    case "2":
                        Console.Write("Введіть рядок: ");
                        string input2 = Console.ReadLine();
                        int consonantsCount = UkrainianStringUtils.CountConsonants(input2);
                        Console.WriteLine($"Кількість приголосних: {consonantsCount}");
                        break;

                    case "3":
                        Console.Write("Введіть рядок: ");
                        string input3 = Console.ReadLine();
                        string reversed = UkrainianStringUtils.ReverseString(input3);
                        Console.WriteLine($"Обернений рядок: {reversed}");
                        break;

                    case "4":
                        Console.Write("Введіть рядок: ");
                        string input4 = Console.ReadLine();
                        string noDuplicates = UkrainianStringUtils.RemoveDuplicates(input4);
                        Console.WriteLine($"Рядок без дублікатів: {noDuplicates}");
                        break;

                    case "5":
                        Console.Write("Введіть рядок: ");
                        string input5 = Console.ReadLine();
                        string noPunctuation = UkrainianStringUtils.RemovePunctuation(input5);
                        Console.WriteLine($"Рядок без пунктуації: {noPunctuation}");
                        break;

                    case "6":
                        // Завершення програми
                        Console.WriteLine("Вихід з програми.");
                        return;

                    default:
                        Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                        break;
                }

                // Додаємо порожній рядок для зручності читання
                Console.WriteLine();
            }
        }
    }
}
