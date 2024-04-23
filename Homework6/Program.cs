using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Homework6
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        // Задати масив із 10 елементів та заповнити його випадковими числами від -100 до 100
        int[] array = new int[10];
        Random rand = new Random();
        int countPositive = 0;
        int newElement;

        // Заповнення масиву випадковими числами та підрахунок додатних чисел
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 101);
            if (array[i] > 0)
                countPositive++;
        }

        // Виведення масиву та кількості додатних чисел
        Console.Write("Масив: {");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine($", кількість додатніх чисел = {countPositive}");

        // Інверсія масиву через новий масив
        int[] reversedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i];
        }

        // Виведення інвертованого масиву
        Console.Write("Масив (інверсія через новий масив): {");
        for (int i = 0; i < reversedArray.Length; i++)
        {
            Console.Write(reversedArray[i]);
            if (i < reversedArray.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("}");

        // Інверсія масиву переписавши значення заданого масиву
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }

        // Виведення інвертованого масиву (інверсія переписавши значення)
        Console.Write("Масив (інверсія переписавши значення): {");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("}");

        // Додавання елемента до початку масиву
        newElement = rand.Next(-100, 101);
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = newElement;

        // Виведення масиву після додавання елемента
        Console.Write($"Масив після додавання елемента {newElement} на початок: {{");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("}");

        // Виведення всіх елементів масиву доки не зустрінеться елемент -1
        Console.Write("Масив до зустрічі з елементом -1: {");
        foreach (int num in array)
        {
            if (num == -1)
                break;
            Console.Write(num);
            Console.Write(", ");
        }
        Console.WriteLine("}");
    }
}