using Pizza_Shop.ConsoleUI;
using Pizza_Shop.Pizzas;

namespace Pizza_Shop.Stores
{
  internal class SimplePizzaStore : PizzaStore
  {
    protected override Pizza CreatePizza(PizzaType type)
    {
      switch (type)
      {
        case PizzaType.Margherita:
          return new MargheritaPizza();
        case PizzaType.Pepperoni:
          return new PepperoniPizza();
        case PizzaType.Hawaiian:
          return new HawaiianPizza();
        default:
          return null;
      }
    }
  }
}

