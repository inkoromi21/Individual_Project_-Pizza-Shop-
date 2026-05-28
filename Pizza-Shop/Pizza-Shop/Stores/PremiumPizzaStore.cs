using System;
using Pizza_Shop.ConsoleUI;
using Pizza_Shop.Pizzas;

namespace Pizza_Shop.Stores {
  internal class PremiumPizzaStore : PizzaStore {
    public override Pizza OrderPizza(PizzaType type) {
      Console.WriteLine("=== Премиум-пиццерия ===");
      Console.WriteLine("Шеф-повар лично контролирует ваш заказ.");
      Console.WriteLine();
      return base.OrderPizza(type);
    }

    protected override Pizza CreatePizza(PizzaType type) {
      switch (type) {
        case PizzaType.Margherita:
          return new MargheritaPizza();
        case PizzaType.Pepperoni:
          return new PepperoniPizza();
        case PizzaType.Hawaiian:
          return new HawaiianPizza();
        case PizzaType.FourCheese:
          return new FourCheesePizza();
        case PizzaType.MeatLovers:
          return new MeatLoversPizza();
        default:
          return null;
      }
    }
  }
}
