using System;
using Pizza_Shop.ConsoleUI;
using Pizza_Shop.Stores;

namespace Pizza_Shop
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.Title = "Pizza Shop";

      PizzaStore store = new SimplePizzaStore();

      while (true)
      {
        string action = ConsoleMenu.ReadAction();
        Console.WriteLine();

        if (action == "0")
        {
          Console.WriteLine("До свидания!");
          return;
        }

        if (action == "2")
        {
          ConsoleMenu.PrintPizzaMenu();
          ConsoleMenu.ContinuePrompt();
          continue;
        }

        if (action != "1")
        {
          Console.WriteLine("Неизвестная команда. Попробуйте снова.");
          Console.WriteLine();
          continue;
        }

        ConsoleMenu.PrintPizzaMenu();
        PizzaType pizzaType = ConsoleMenu.ReadPizzaType();
        if (pizzaType == PizzaType.Unknown)
        {
          Console.WriteLine("Заказ отменён.");
          Console.WriteLine();
        }
        else
        {
          store.OrderPizza(pizzaType);
        }

        ConsoleMenu.ContinuePrompt();
      }
    }
  }
}
