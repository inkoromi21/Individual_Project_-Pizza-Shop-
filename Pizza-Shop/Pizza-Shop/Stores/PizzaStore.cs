using System;
using Pizza_Shop.Pizzas;

namespace Pizza_Shop.Stores
{
  internal class PizzaStore
  {
    public Pizza OrderPizza(string type)
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

    private Pizza CreatePizza(string type)
    {
      switch (type)
      {
        case "1":
          return new MargheritaPizza();
        case "2":
          return new PepperoniPizza();
        case "3":
          return new HawaiianPizza();
        default:
          return null;
      }
    }
  }
}

