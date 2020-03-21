using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new BulgerianPizza();
            pizza = new TomatoPizza(pizza);
            pizza = new CheesPizza(pizza);
        }
    }
    abstract class Pizza
    {
        public Pizza(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }
        public abstract int GetCons();
    }

    class ItalianPizza : Pizza
    {

        public ItalianPizza() : base("Italiano pizza")
        {

        }
        public override int GetCons()
        {
            return 10;
        }
    }
    class BulgerianPizza : Pizza
    {

        public BulgerianPizza() : base("Bulgarian pizza")
        {

        }
        public override int GetCons()
        {
            return 8;
        }
    }

    abstract class PizzaDecorator : Pizza
    {
        public Pizza pizza;

        public PizzaDecorator(string name,Pizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }

    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base (pizza.Name + " with tomatos",pizza)
        {

        }

        public override int GetCons()
        {
            return pizza.GetCons() + 3;
        }
    }

    class CheesPizza : PizzaDecorator
    {
        public CheesPizza(Pizza pizza) : base(pizza.Name + " with chees", pizza) { }

        public override int GetCons()
        {
            return pizza.GetCons() + 2;
        }
    }
}
