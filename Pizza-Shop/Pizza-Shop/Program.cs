using System;

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
            ProcessOrder("Маргарита");
            break;
          case "2":
            ProcessOrder("Пепперони");
            break;
          case "3":
            ProcessOrder("Гавайская");
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

    private static void ProcessOrder(string pizzaName)
    {
      Console.WriteLine($"Заказ принят: {pizzaName}");
      Console.WriteLine("Готовим...");
      Console.WriteLine($"- Подготовка ингредиентов для \"{pizzaName}\"");
      Console.WriteLine($"- Выпекаем \"{pizzaName}\"");
      Console.WriteLine($"- Нарезаем \"{pizzaName}\"");
      Console.WriteLine($"- Упаковываем \"{pizzaName}\"");
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
