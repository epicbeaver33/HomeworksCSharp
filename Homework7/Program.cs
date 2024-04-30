using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        List<string> subjects = new List<string>();
        List<List<float>> grades = new List<List<float>>();

        while (true)
        {
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1. Подивитися оцінки");
            Console.WriteLine("2. Ввести оцінки");
            Console.WriteLine("3. Порахувати середнє");
            Console.WriteLine("4. Вийти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayGrades(subjects, grades);
                    break;
                case "2":
                    EnterGrades(subjects, grades);
                    break;
                case "3":
                    CalculateAverage(subjects, grades);
                    break;
                case "4":
                    Console.WriteLine("Програма завершує роботу.");
                    return;
                default:
                    Console.WriteLine("Невірний вибір. Будь ласка, виберіть знову.");
                    break;
            }
        }
    }

    static void DisplayGrades(List<string> subjects, List<List<float>> grades)
    {
        if (subjects.Count == 0 || grades.Count == 0)
        {
            Console.WriteLine("Оцінок немає. Будь ласка, спочатку введіть оцінки.");
            return;
        }

        Console.WriteLine("Оцінки:");
        for (int i = 0; i < subjects.Count; i++)
        {
            Console.WriteLine($"{subjects[i]}:");
            for (int j = 0; j < grades[i].Count; j++)
            {
                Console.WriteLine($"Оцінка {j + 1}: {grades[i][j]}");
            }
            Console.WriteLine();
        }
    }

    static void EnterGrades(List<string> subjects, List<List<float>> grades)
    {
        Console.WriteLine("Введіть кількість предметів:");
        int subjectCount;
        while (!int.TryParse(Console.ReadLine(), out subjectCount) || subjectCount <= 0)
        {
            Console.WriteLine("Некоректне значення. Будь ласка, введіть ціле додатне число.");
        }

        subjects.Clear();
        grades.Clear();

        for (int i = 0; i < subjectCount; i++)
        {
            Console.WriteLine($"Введіть назву предмету {i + 1}:");
            subjects.Add(Console.ReadLine());

            Console.WriteLine($"Введіть оцінки для предмету {subjects[i]} через кому:");
            string gradesInput = Console.ReadLine();
            string[] gradesArray = gradesInput.Split(',');

            List<float> subjectGrades = new List<float>();

            foreach (string grade in gradesArray)
            {
                if (float.TryParse(grade.Trim(), out float result))
                {
                    subjectGrades.Add(result);
                }
                else
                {
                    Console.WriteLine("Некоректне значення. Будь ласка, введіть оцінки знову:");
                    break;
                }
            }

            grades.Add(subjectGrades);
        }

        Console.WriteLine("Оцінки збережено.");
    }

    static void CalculateAverage(List<string> subjects, List<List<float>> grades)
    {
        if (subjects.Count == 0 || grades.Count == 0)
        {
            Console.WriteLine("Оцінок немає. Будь ласка, спочатку введіть оцінки.");
            return;
        }

        Console.WriteLine("Середні оцінки:");
        for (int i = 0; i < subjects.Count; i++)
        {
            float totalGrade = 0;
            foreach (float grade in grades[i])
            {
                totalGrade += grade;
            }
            float averageGrade = totalGrade / grades[i].Count;
            Console.WriteLine($"Середній бал для {subjects[i]}: {averageGrade}");
        }
    }
}