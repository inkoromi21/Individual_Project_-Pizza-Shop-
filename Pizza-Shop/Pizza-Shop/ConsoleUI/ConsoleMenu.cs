using System;
using Pizza_Shop.Stores;

namespace Pizza_Shop.ConsoleUI {
  internal static class ConsoleMenu {
    public static string ReadAction() {
      Console.WriteLine("=== PIZZA SHOP ===");
      Console.WriteLine("Выберите действие:");
      Console.WriteLine("1) Заказать пиццу");
      Console.WriteLine("2) Показать меню");
      Console.WriteLine("3) Сменить пиццерию");
      Console.WriteLine("0) Выход");
      Console.Write("Ваш выбор: ");
      return Console.ReadLine()?.Trim();
    }

    public static PizzaStore SelectStore() {
      while (true) {
        Console.WriteLine("Выберите пиццерию:");
        Console.WriteLine("1) Обычная пиццерия");
        Console.WriteLine("2) Премиум-пиццерия");
        Console.Write("Ваш выбор: ");
        string choice = Console.ReadLine()?.Trim();
        Console.WriteLine();

        if (choice == "1") {
          Console.WriteLine("Вы в обычной пиццерии.");
          Console.WriteLine();
          return new SimplePizzaStore();
        }

        if (choice == "2") {
          Console.WriteLine("Вы в премиум-пиццерии.");
          Console.WriteLine();
          return new PremiumPizzaStore();
        }

        Console.WriteLine("Неверный выбор. Попробуйте снова.");
        Console.WriteLine();
      }
    }

    public static void PrintPizzaMenu() {
      Console.WriteLine("Меню:");
      Console.WriteLine("1) Маргарита");
      Console.WriteLine("2) Пепперони");
      Console.WriteLine("3) Гавайская");
      Console.WriteLine("4) Четыре сыра");
      Console.WriteLine("5) Мясная");
      Console.WriteLine();
    }

    public static PizzaType ReadPizzaType() {
      while (true) {
        Console.Write("Введите номер пиццы (0 — отмена): ");
        string input = Console.ReadLine()?.Trim();
        Console.WriteLine();

        if (input == "0") {
          return PizzaType.Unknown;
        }

        int number;
        if (!int.TryParse(input, out number)) {
          Console.WriteLine("Введите число из меню.");
          Console.WriteLine();
          continue;
        }

        if (!Enum.IsDefined(typeof(PizzaType), number)) {
          Console.WriteLine("Такой пиццы нет в меню. Попробуйте снова.");
          Console.WriteLine();
          continue;
        }

        return (PizzaType)number;
      }
    }

    public static void ContinuePrompt() {
      Console.Write("Нажмите Enter, чтобы продолжить...");
      Console.ReadLine();
      Console.WriteLine();
    }
  }
}
