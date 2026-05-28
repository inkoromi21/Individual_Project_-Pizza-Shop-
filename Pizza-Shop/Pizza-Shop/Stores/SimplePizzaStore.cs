using Pizza_Shop.Pizzas;

namespace Pizza_Shop.Stores
{
  internal class SimplePizzaStore : PizzaStore
  {
    protected override Pizza CreatePizza(string type)
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

