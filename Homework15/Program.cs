using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Оберіть завдання:");
        Console.WriteLine("1 - Магазин продуктів");
        Console.WriteLine("2 - Каталог контактів");

        // Зчитуємо вибір користувача
        var taskChoice = Console.ReadLine();

        switch (taskChoice)
        {
            case "1":
                RunShopTask();
                break;
            case "2":
                RunContactsTask();
                break;
            default:
                Console.WriteLine("Невірний вибір. Завершення програми.");
                break;
        }
    }

    // Функція для запуску завдання "Магазин продуктів"
    static void RunShopTask()
    {
        Shop shop = new Shop();
        Admin admin = new Admin(shop);
        Customer customer = new Customer(shop);

        // Додавання продуктів до магазину адміністраторам
        admin.AddProduct(new Product(1, "Apple", 0.5m));
        admin.AddProduct(new Product(2, "Banana", 0.3m));
        admin.AddProduct(new Product(3, "Orange", 0.7m));
        admin.AddProduct(new Product(4, "Milk", 1.2m));
        admin.AddProduct(new Product(5, "Bread", 1.0m));

        bool continueSession = true;

        while (continueSession)
        {
            Console.WriteLine("Вітаємо у нашому магазині! Ось список доступних ролей:");
            Console.WriteLine("1 - Адміністратор");
            Console.WriteLine("2 - Покупець");
            Console.WriteLine("3 - Завершити сеанс");

            var roleChoice = Console.ReadLine();

            switch (roleChoice)
            {
                case "1":
                    RunAdminSession(admin);
                    break;
                case "2":
                    RunCustomerSession(customer);
                    break;
                case "3":
                    continueSession = false;
                    Console.WriteLine("Завершення сеансу.");
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }

    // Функція для роботи з роллю Адміністратора
    static void RunAdminSession(Admin admin)
    {
        bool continueAdminSession = true;

        while (continueAdminSession)
        {
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1 - Додати продукт до магазину");
            Console.WriteLine("2 - Видалити продукт з магазину");
            Console.WriteLine("3 - Повернутися до вибору ролей");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Введіть ID нового продукту:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть назву нового продукту:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введіть ціну нового продукту:");
                    decimal price = decimal.Parse(Console.ReadLine());
                    admin.AddProduct(new Product(id, name, price));
                    Console.WriteLine("Продукт додано до магазину.");
                    break;
                case "2":
                    Console.WriteLine("Введіть ID продукту, який бажаєте видалити з магазину:");
                    int productIdToRemove = int.Parse(Console.ReadLine());
                    admin.RemoveProduct(productIdToRemove);
                    Console.WriteLine("Продукт видалено з магазину.");
                    break;
                case "3":
                    continueAdminSession = false;
                    break;
                default:
                    Console.WriteLine("Невірна опція. Спробуйте ще раз.");
                    break;
            }
        }
    }

    // Функція для роботи з роллю Покупця
    static void RunCustomerSession(Customer customer)
    {
        bool continueShopping = true;

        while (continueShopping)
        {
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1 - Додати продукт до кошика");
            Console.WriteLine("2 - Видалити продукт з кошика");
            Console.WriteLine("3 - Переглянути загальну вартість кошика");
            Console.WriteLine("4 - Переглянути всі продукти");
            Console.WriteLine("5 - Завершити покупки");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Введіть ID продукту, який бажаєте додати до кошика:");
                    int productIdToAdd = int.Parse(Console.ReadLine());
                    var productToAdd = customer.Shop.GetProductByID(productIdToAdd);
                    if (productToAdd != null)
                    {
                        customer.Cart.AddToCart(productToAdd);
                        Console.WriteLine("Продукт додано до кошика.");
                    }
                    else
                    {
                        Console.WriteLine("Продукт з таким ID не знайдено.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Введіть ID продукту, який бажаєте видалити з кошика:");
                    int productIdToRemove = int.Parse(Console.ReadLine());
                    customer.Cart.RemoveFromCart(productIdToRemove);
                    Console.WriteLine("Продукт видалено з кошика.");
                    break;
                case "3":
                    Console.WriteLine($"Загальна вартість продуктів у кошику: {customer.Cart.GetTotalPrice():C}");
                    break;
                case "4":
                    Console.WriteLine("Доступні продукти:");
                    foreach (var product in customer.Shop.GetAllProducts())
                    {
                        Console.WriteLine(product);
                    }
                    break;
                case "5":
                    continueShopping = false;
                    Console.WriteLine("Дякуємо за покупки!");
                    break;
                default:
                    Console.WriteLine("Невірна опція. Спробуйте ще раз.");
                    break;
            }
        }
    }

    // Функція для запуску завдання "Каталог контактів"
    static void RunContactsTask()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();
        bool continueManagingContacts = true;

        while (continueManagingContacts)
        {
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1 - Додати новий контакт");
            Console.WriteLine("2 - Видалити контакт за іменем");
            Console.WriteLine("3 - Оновити номер телефону існуючого контакту");
            Console.WriteLine("4 - Шукати контакт за іменем");
            Console.WriteLine("5 - Вивести список усіх контактів");
            Console.WriteLine("6 - Завершити керування контактами");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Введіть ім'я контакту:");
                    string nameToAdd = Console.ReadLine();
                    Console.WriteLine("Введіть номер телефону контакту:");
                    string phoneToAdd = Console.ReadLine();
                    contacts[nameToAdd] = phoneToAdd;
                    Console.WriteLine("Контакт додано.");
                    break;
                case "2":
                    Console.WriteLine("Введіть ім'я контакту, який бажаєте видалити:");
                    string nameToRemove = Console.ReadLine();
                    if (contacts.Remove(nameToRemove))
                    {
                        Console.WriteLine("Контакт видалено.");
                    }
                    else
                    {
                        Console.WriteLine("Контакт з таким ім'ям не знайдено.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Введіть ім'я контакту, для якого бажаєте оновити номер телефону:");
                    string nameToUpdate = Console.ReadLine();
                    if (contacts.ContainsKey(nameToUpdate))
                    {
                        Console.WriteLine("Введіть новий номер телефону:");
                        string newPhone = Console.ReadLine();
                        contacts[nameToUpdate] = newPhone;
                        Console.WriteLine("Номер телефону оновлено.");
                    }
                    else
                    {
                        Console.WriteLine("Контакт з таким ім'ям не знайдено.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Введіть ім'я контакту, який бажаєте знайти:");
                    string nameToFind = Console.ReadLine();
                    if (contacts.TryGetValue(nameToFind, out string foundPhone))
                    {
                        Console.WriteLine($"Ім'я: {nameToFind}, Номер телефону: {foundPhone}");
                    }
                    else
                    {
                        Console.WriteLine("Контакт з таким ім'ям не знайдено.");
                    }
                    break;
                case "5":
                    Console.WriteLine("Список усіх контактів:");
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine($"Ім'я: {contact.Key}, Номер телефону: {contact.Value}");
                    }
                    break;
                case "6":
                    continueManagingContacts = false;
                    Console.WriteLine("Завершення керування контактами.");
                    break;
                default:
                    Console.WriteLine("Невірна опція. Спробуйте ще раз.");
                    break;
            }
        }
    }
}

// Клас Product
public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        ID = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Price: {Price:C}";
    }
}

// Клас Shop
public class Shop
{
    private List<Product> products;

    public Shop()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RemoveProduct(int productID)
    {
        var product = products.SingleOrDefault(p => p.ID == productID);
        if (product != null)
        {
            products.Remove(product);
        }
    }

    public Product GetProductByID(int productID)
    {
        return products.SingleOrDefault(p => p.ID == productID);
    }

    public List<Product> GetAllProducts()
    {
        return new List<Product>(products);
    }
}

// Клас Cart
public class Cart
{
    private List<Product> cartProducts;

    public Cart()
    {
        cartProducts = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        cartProducts.Add(product);
    }

    public void RemoveFromCart(int productID)
    {
        var product = cartProducts.SingleOrDefault(p => p.ID == productID);
        if (product != null)
        {
            cartProducts.Remove(product);
        }
    }

    public decimal GetTotalPrice()
    {
        return cartProducts.Sum(p => p.Price);
    }

    public List<Product> GetCartProducts()
    {
        return new List<Product>(cartProducts);
    }
}

// Клас Admin
public class Admin
{
    public Shop Shop { get; }

    public Admin(Shop shop)
    {
        Shop = shop;
    }

    public void AddProduct(Product product)
    {
        Shop.AddProduct(product);
    }

    public void RemoveProduct(int productID)
    {
        Shop.RemoveProduct(productID);
    }
}

// Клас Customer
public class Customer
{
    public Shop Shop { get; }
    public Cart Cart { get; }

    public Customer(Shop shop)
    {
        Shop = shop;
        Cart = new Cart();
    }
}
