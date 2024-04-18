using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Homework5
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Оберіть void Task для виклику (введіть число від 1 до 3):");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
            default:
                Console.WriteLine("Невірний вибір. Будь ласка, введіть число від 1 до 3.");
                break;
        }

    }

    static void Task1()
    {
        string password = "root";
        string input;

        Console.WriteLine("Введіть пароль:");

        do
        {
            input = Console.ReadLine();

            if (input != password)
            {
                Console.WriteLine("Неправильний пароль!");
                Console.WriteLine("Введіть пароль ще раз:");
            }

        } while (input != password);

        Console.WriteLine("Пароль введений правильно!");
    }

    static void Task2()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 147);
        int guess;
        bool guessed = false;

        Console.WriteLine("Програма загадала число від 1 до 146. Спробуйте вгадати!");

        while (!guessed)
        {
            Console.Write("Ваша спроба: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < numberToGuess)
                Console.WriteLine("Більше!");
            else if (guess > numberToGuess)
                Console.WriteLine("Менше!");
            else
                guessed = true;
        }

        Console.WriteLine("Вітаємо! Ви вгадали число!");
    }

    static void Task3()
    {
        Console.WriteLine("Таблиця множення:");
        Console.WriteLine("==================");

        // Верхній рядок (заголовок)
        Console.Write("    ");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine("\n");

        // Роздільна лінія
        Console.WriteLine("    " + new string('=', 40));

        // Виведення таблиці множення
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i,2} |");

            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }

}
