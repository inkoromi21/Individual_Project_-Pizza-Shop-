using System;
using Pizza_Shop.ConsoleUI;
using Pizza_Shop.Pizzas;

namespace Pizza_Shop.Stores
{
  internal abstract class PizzaStore
  {
    public Pizza OrderPizza(PizzaType type)
    {
      var pizza = CreatePizza(type);
      if (pizza == null)
      {
        return null;
      }

      Console.WriteLine($"Заказ принят: {pizza.Name}");
      Console.WriteLine("Готовим...");
      pizza.Prepare();
      pizza.Bake();
      pizza.Cut();
      pizza.Box();
      Console.WriteLine("Готово! Приятного аппетита.");
      Console.WriteLine();

      return pizza;
    }

    protected abstract Pizza CreatePizza(PizzaType type);
  }
}

