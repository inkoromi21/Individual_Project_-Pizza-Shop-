using System;
using Pizza_Shop.Pizzas;
using Pizza_Shop.Stores;

namespace Pizza_Shop
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.Title = "Pizza Shop (черновик)";

      while (true)
      {
        Console.WriteLine("=== PIZZA SHOP ===");
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1) Заказать пиццу");
        Console.WriteLine("2) Показать меню");
        Console.WriteLine("0) Выход");
        Console.Write("Ваш выбор: ");

        var action = Console.ReadLine();
        Console.WriteLine();

        if (action == "0")
        {
          Console.WriteLine("До свидания!");
          return;
        }

        if (action == "2")
        {
          PrintMenu();
          ContinuePrompt();
          continue;
        }

        if (action != "1")
        {
          Console.WriteLine("Неизвестная команда. Попробуйте снова.");
          Console.WriteLine();
          continue;
        }

        PrintMenu();
        Console.Write("Введите номер пиццы: ");
        var pizzaChoice = Console.ReadLine();
        Console.WriteLine();

        var store = new PizzaStore();
        var pizza = store.OrderPizza(pizzaChoice);
        if (pizza == null)
        {
          Console.WriteLine("Такой пиццы нет в меню.");
          Console.WriteLine();
        }

        ContinuePrompt();
      }
    }

    private static void PrintMenu()
    {
      Console.WriteLine("Меню:");
      Console.WriteLine("1) Маргарита");
      Console.WriteLine("2) Пепперони");
      Console.WriteLine("3) Гавайская");
      Console.WriteLine();
    }

    private static void ContinuePrompt()
    {
      Console.Write("Нажмите Enter, чтобы продолжить...");
      Console.ReadLine();
      Console.WriteLine();
    }
  }
}
