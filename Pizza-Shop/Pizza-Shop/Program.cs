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
      Console.Title = "Pizza Shop (черновик)";

      PizzaStore store = new SimplePizzaStore();

      while (true)
      {
        var action = ConsoleMenu.ReadAction();
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
        var pizzaType = ConsoleMenu.ReadPizzaType();
        var pizza = store.OrderPizza(pizzaType);
        if (pizza == null)
        {
          Console.WriteLine("Такой пиццы нет в меню.");
          Console.WriteLine();
        }

        ConsoleMenu.ContinuePrompt();
      }
    }
  }
}
