using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Homework3
{
    // Вибір необхідного методу.
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Оберіть void Task для виклику (введіть число від 1 до 5):");
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
            case 4:
                Task4();
                break;
            case 5:
                Task5();
                break;
            default:
                Console.WriteLine("Невірний вибір. Будь ласка, введіть число від 1 до 5.");
                break;
        }

    }

    // Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.
    static void Task1()
    {
        // Введення трьохзначного числа з клавіатури
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Введіть трьохзначне число: ");
        string numberString = Console.ReadLine();

        // Перевірка, чи введене число є трьохзначним
        if (numberString.Length != 3)
        {
            Console.WriteLine("Будь ласка, введіть трьохзначне число.");
            return;
        }

        // Міняємо місцями першу та останню цифру
        char[] charArray = numberString.ToCharArray();
        char temp = charArray[0];
        charArray[0] = charArray[2];
        charArray[2] = temp;

        // Формуємо нове число і виводимо результат
        string reversedNumberString = new string(charArray);
        Console.WriteLine($"Число, отримане під час міняння місцями першої та останньої цифри: {reversedNumberString}");
    }

    // Написати програму, яка обчислює квадрат будь-якого введеного числа (бажано використати Math).
    static void Task2()
    {
        // Введення числа з клавіатури
        do
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть число для піднесення його до квадратного кореня: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            double result = Math.Sqrt(number);
            Console.WriteLine($"Квадратний корінь з числа {number} дорівнює {result}");
        } while (true);
        Console.WriteLine();
    }

    // Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
    static void Task3()
    {
        // Введення трьохзначного числа з клавіатури
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Введіть трьохзначне число: ");
        string numberString = Console.ReadLine();

        // Перевірка, чи введене число є трьохзначним
        if (numberString.Length != 3)
        {
            Console.WriteLine("Будь ласка, введіть трьохзначне число.");
            return;
        }

        // Міняємо місцями першу та останню цифру
        char[] charArray = numberString.ToCharArray();
        char temp = charArray[0];
        charArray[0] = charArray[1];
        charArray[1] = temp;

        // Формуємо нове число і виводимо результат
        string reversedNumberString = new string(charArray);
        Console.WriteLine($"Число, отримане під час міняння місцями першої та останньої цифри: {reversedNumberString}");
    }

    // Написати програму, яка обчислює середнє арифметичне двох чисел.
    static void Task4()
    {
        do
        {
            // Питання користувача для першого числа
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть перше число: ");
            double number1 = double.Parse(Console.ReadLine());

            // Питання користувача для другого числа
            Console.Write("Введіть друге число: ");
            double number2 = double.Parse(Console.ReadLine());

            // Додавання двох чисел
            double sum = number1 + number2;

            // Ділення суми на два
            double result = sum / 2;

            // Виведення результату
            Console.WriteLine($"Середнє арифметичне чисел {number1} і {number2} дорівнює {result}");
            Console.WriteLine();
        }
        while (true);

    }

    // Користувач вводить радіус круга. Напишіть програму, яка обчислює площу цього круга і виводить в консоль результат.
    static void Task5()
    {
        do
        {
            // Питання користувача для введення радіуса
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть радіус круга: ");
            double radius = double.Parse(Console.ReadLine());

            // Обчислення площі круга
            double area = Math.PI * radius * radius;

            // Виведення результату
            Console.WriteLine($"Площа круга з радіусом {radius} дорівнює {area}");
        } while (true);
    }
}
