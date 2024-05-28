using System;
using System.Collections.Generic;

// Головний клас програми
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Run Plugin System");
        Console.WriteLine("2. Run Logging System");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                RunPluginSystem();
                break;
            case "2":
                RunLoggingSystem();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // Інтерфейс IPlugin з методом Execute
    public interface IPlugin
{
    void Execute();
}

// Клас PluginManager для управління плагінами
public class PluginManager
{
    // Приватний список для зберігання плагінів
    private List<IPlugin> plugins = new List<IPlugin>();

    // Метод для завантаження плагіну
    public void LoadPlugin(IPlugin plugin)
    {
        plugins.Add(plugin); // Додає плагін до списку
    }

    // Метод для виконання всіх завантажених плагінів
    public void ExecuteAll()
    {
        foreach (var plugin in plugins) // Ітерація через всі плагіни
        {
            plugin.Execute(); // Виклик методу Execute кожного плагіну
        }
    }
}

// Клас CalculatorPlugin, який реалізує IPlugin
public class CalculatorPlugin : IPlugin
{
    public void Execute()
    {
        int a = 5;
        int b = 3;
        Console.WriteLine($"Result of {a} + {b} = {a + b}"); // Виводить результат додавання
    }
}

// Клас GreetingPlugin, який реалізує IPlugin
public class GreetingPlugin : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("Hello, world!"); // Виводить привітальне повідомлення
    }
}

// Клас LogEntry, що представляє окремий запис у логах
public class LogEntry
{
    public DateTime Timestamp { get; } // Властивість для зберігання часу створення логу
    public string Message { get; } // Властивість для зберігання повідомлення логу

    // Конструктор, що приймає повідомлення і встановлює час створення
    public LogEntry(string message)
    {
        Timestamp = DateTime.Now; // Встановлює поточний час
        Message = message; // Встановлює повідомлення
    }

    // Переопределення методу ToString для зручного відображення логу
    public override string ToString()
    {
        return $"[{Timestamp}] {Message}";
    }
}

// Статичний клас Logger для управління логами
public static class Logger
{
    // Приватний статичний список для зберігання логів
    private static List<LogEntry> logs = new List<LogEntry>();

    // Статичний метод для додавання нового логу
    public static void AddLog(string message)
    {
        LogEntry log = new LogEntry(message); // Створює новий лог
        logs.Add(log); // Додає лог до списку
    }

    // Статичний метод для отримання всіх логів
    public static List<LogEntry> GetLogs()
    {
        return new List<LogEntry>(logs); // Повертає копію списку логів
    }
}
    // Метод для запуску системи плагінів
    private static void RunPluginSystem()
    {
        // Створення екземпляра PluginManager
        PluginManager manager = new PluginManager();

        // Створення екземплярів плагінів
        IPlugin calculatorPlugin = new CalculatorPlugin();
        IPlugin greetingPlugin = new GreetingPlugin();

        // Завантаження плагінів до менеджера
        manager.LoadPlugin(calculatorPlugin);
        manager.LoadPlugin(greetingPlugin);

        // Виконання всіх завантажених плагінів
        manager.ExecuteAll();
    }

    // Метод для запуску системи логування
    private static void RunLoggingSystem()
    {
        // Додавання логів
        Logger.AddLog("System initialized."); // Додає лог про ініціалізацію системи
        Logger.AddLog("User logged in."); // Додає лог про вхід користувача
        Logger.AddLog("Error occurred: Invalid user input."); // Додає лог про помилку

        // Отримання та виведення всіх логів
        var logs = Logger.GetLogs(); // Отримує список всіх логів
        foreach (var log in logs) // Ітерація через всі логи
        {
            Console.WriteLine(log); // Виводить лог на консоль
        }
    }
}
