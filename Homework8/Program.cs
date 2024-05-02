using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        string[] allItems = new string[100]; // Масив для зберігання всіх товарів
        int[] allPrices = new int[allItems.Length]; // Масив для зберігання всіх цін

        int totalItems = 0; // Кількість введених товарів
        int totalcost = 0; // Загальна вартість товарів

        do
        {
            Console.WriteLine("Введіть назви товарів які бажаєте додати до списку.");
            string input = Console.ReadLine();
            string[] items = input.Split(',');
            int[] prices = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"Введіть ціну для товару \"{items[i].Trim()}\"");
                string valueInput = Console.ReadLine();
                int price;
                if (int.TryParse(valueInput, out price))
                {
                    prices[i] = price;
                    totalcost += price; // Накопичення загальної вартості товарів
                    allItems[totalItems] = items[i]; // Додати товар до загального масиву
                    allPrices[totalItems] = price; // Додати ціну до загального масиву
                    totalItems++; // Збільшити лічильник введених товарів
                }
                else
                {
                    Console.WriteLine("Неправильний формат ціни. Введіть ціле число.");
                    i--;
                }
            }

            Console.WriteLine("Бажаєте продовжити? (для продовження введіть \"так\").\n(для виведення списку товару та загальної вартості введіть будь що.)");
        } while (Console.ReadLine().ToLower() == "так");

        // Виведення чеку після завершення введення всіх товарів
        Console.WriteLine("Чек:");
        for (int i = 0; i < totalItems; i++)
        {
            Console.WriteLine($"{allItems[i].Trim()} - {allPrices[i]} грн."); // Виведення назви товару та його ціни
        }
        Console.WriteLine($"Загальна вартість складає {totalcost} грн.");
    }
}
