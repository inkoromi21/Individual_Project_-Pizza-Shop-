using System;

namespace Pizza_Shop.Pizzas {
  internal class PepperoniPizza : Pizza {
    public PepperoniPizza() {
      Name = "Пепперони";
    }

    public override void Prepare() {
      base.Prepare();
      Console.WriteLine("- Добавляем острую пепперони");
    }
  }
}
