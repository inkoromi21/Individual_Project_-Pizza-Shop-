using System;

namespace Pizza_Shop.Pizzas {
  internal abstract class Pizza {
    public string Name { get; protected set; }

    public virtual void Prepare() {
      Console.WriteLine($"- Подготовка ингредиентов для \"{Name}\"");
    }

    public virtual void Bake() {
      Console.WriteLine($"- Выпекаем \"{Name}\"");
    }

    public virtual void Cut() {
      Console.WriteLine($"- Нарезаем \"{Name}\"");
    }

    public virtual void Box() {
      Console.WriteLine($"- Упаковываем \"{Name}\"");
    }
  }
}
