using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Homework4
{
    // Вибір необхідного методу.
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Оберіть void Task для виклику (введіть число від 1 до 4):");
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
            default:
                Console.WriteLine("Невірний вибір. Будь ласка, введіть число від 1 до 4.");
                break;
        }

    }

    static void Task1()
    {
        do
        {
            Console.WriteLine("Введіть перше число: ");
            double перше_число = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число: ");
            double друге_число = double.Parse(Console.ReadLine());

            if (перше_число == друге_число)
            {
                Console.WriteLine($"Результат: {перше_число} дорівнює {друге_число}");
            }
            else if (перше_число < друге_число)
            {
                Console.WriteLine($"Результат: {перше_число} менше {друге_число}");
            }
            else
            {
                Console.WriteLine($"Результат: {перше_число} більше {друге_число}");
            }
        } while (true);
    }

    static void Task2()
    {
        do
        {
            Console.WriteLine("Введіть номер місяця: ");
            int номер_місяця = int.Parse(Console.ReadLine());

            switch (номер_місяця)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Літо");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осінь");
                    break;
                default:
                    Console.WriteLine("Немає такого місяця на цій планеті");
                    break;
            }
        } while(true);
    }

    static void Task3()
    {
        Console.WriteLine("Введіть число від 1 до 100: ");
        int число = int.Parse(Console.ReadLine());

        string результат = (число % 15 == 0) ? "FizzBuzz" : (число % 3 == 0) ? "Fizz" : (число % 5 == 0) ? "Buzz" : число.ToString();

        Console.WriteLine(результат);
    }

    static void Task4()
    {
        double a, b, c;

        Console.WriteLine("Введіть значення коефіцієнта a: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Некоректне значення. Спробуйте ще раз:");
        }

        Console.WriteLine("Введіть значення коефіцієнта b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Некоректне значення. Спробуйте ще раз:");
        }

        Console.WriteLine("Введіть значення коефіцієнта c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Некоректне значення. Спробуйте ще раз:");
        }

        ВивестиРівняння(a, b, c);

        double D = ОбчислитиДискримінант(a, b, c);

        ВивестиКорені(a, b, D);
    }

    static void ВивестиРівняння(double a, double b, double c)
    {
        Console.WriteLine($"Рівняння: {a} * x^2 + {b} * x + {c} = 0");
    }

    static double ОбчислитиДискримінант(double a, double b, double c)
    {
        return b * b - 4 * a * c;
    }

    static void ВивестиКорені(double a, double b, double D)
    {
        if (D < 0)
        {
            Console.WriteLine("Рівняння не має коренів");
        }
        else if (D == 0)
        {
            double корінь = -b / (2 * a);
            Console.WriteLine($"Рівняння має один корінь: {корінь}");
        }
        else
        {
            double корінь1 = (-b + Math.Sqrt(D)) / (2 * a);
            double корінь2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"Рівняння має два корені: {корінь1} та {корінь2}");
        }
    }
}
