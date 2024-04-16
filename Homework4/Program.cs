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
        Console.WriteLine("Оберіть void Task для виклику (введіть число від 1 до 2):");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            default:
                Console.WriteLine("Невірний вибір. Будь ласка, введіть число від 1 до 2.");
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
}
