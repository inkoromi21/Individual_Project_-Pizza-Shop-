using System;

namespace Pizza_Shop.ConsoleUI
{
  internal static class ConsoleMenu
  {
    public static string ReadAction()
    {
      Console.WriteLine("=== PIZZA SHOP ===");
      Console.WriteLine("Выберите действие:");
      Console.WriteLine("1) Заказать пиццу");
      Console.WriteLine("2) Показать меню");
      Console.WriteLine("0) Выход");
      Console.Write("Ваш выбор: ");
      return Console.ReadLine()?.Trim();
    }

    public static void PrintPizzaMenu()
    {
      Console.WriteLine("Меню:");
      Console.WriteLine("1) Маргарита");
      Console.WriteLine("2) Пепперони");
      Console.WriteLine("3) Гавайская");
      Console.WriteLine();
    }

    public static PizzaType ReadPizzaType()
    {
      while (true)
      {
        Console.Write("Введите номер пиццы (0 — отмена): ");
        string input = Console.ReadLine()?.Trim();
        Console.WriteLine();

        if (input == "0")
        {
          return PizzaType.Unknown;
        }

        int number;
        if (!int.TryParse(input, out number))
        {
          Console.WriteLine("Введите число из меню.");
          Console.WriteLine();
          continue;
        }

        if (!Enum.IsDefined(typeof(PizzaType), number))
        {
          Console.WriteLine("Такой пиццы нет в меню. Попробуйте снова.");
          Console.WriteLine();
          continue;
        }

        return (PizzaType)number;
      }
    }

    public static void ContinuePrompt()
    {
      Console.Write("Нажмите Enter, чтобы продолжить...");
      Console.ReadLine();
      Console.WriteLine();
    }
  }
}

