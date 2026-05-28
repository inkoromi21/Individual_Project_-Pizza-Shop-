using System;
using Pizza_Shop.Pizzas;

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

        switch (pizzaChoice)
        {
          case "1":
            ProcessOrder(new MargheritaPizza());
            break;
          case "2":
            ProcessOrder(new PepperoniPizza());
            break;
          case "3":
            ProcessOrder(new HawaiianPizza());
            break;
          default:
            Console.WriteLine("Такой пиццы нет в меню.");
            break;
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

    private static void ProcessOrder(Pizza pizza)
    {
      Console.WriteLine($"Заказ принят: {pizza.Name}");
      Console.WriteLine("Готовим...");
      pizza.Prepare();
      pizza.Bake();
      pizza.Cut();
      pizza.Box();
      Console.WriteLine("Готово! Приятного аппетита.");
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
