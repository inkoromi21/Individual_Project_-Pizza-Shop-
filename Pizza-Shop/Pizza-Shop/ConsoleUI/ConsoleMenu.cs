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
      return Console.ReadLine();
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
      Console.Write("Введите номер пиццы: ");
      var input = Console.ReadLine();
      Console.WriteLine();

      if (!int.TryParse(input, out var number))
      {
        return PizzaType.Unknown;
      }

      if (!Enum.IsDefined(typeof(PizzaType), number))
      {
        return PizzaType.Unknown;
      }

      return (PizzaType)number;
    }

    public static void ContinuePrompt()
    {
      Console.Write("Нажмите Enter, чтобы продолжить...");
      Console.ReadLine();
      Console.WriteLine();
    }
  }
}

