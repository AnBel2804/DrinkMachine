using System;
using DrinkMachine.Builder;
using DrinkMachine.Data;

namespace DrinkMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkMachine.Data.AppContext context = new DrinkMachine.Data.AppContext();

            if (context.Drinks.Count() == 0)
            {
                Drink Coffee = new Drink { Name = "Coffee", Cost = 15 };
                Drink Tea = new Drink { Name = "Tea", Cost = 10 };
                context.Drinks.AddRange(new List<Drink> { Coffee, Tea });

                Additive Milk = new Additive { Name = "Milk", Cost = 2 };
                Additive Sugar = new Additive { Name = "Sugar", Cost = 1 };
                Additive Cinnamon = new Additive { Name = "Cinnamon", Cost = 3 };
                Additive Lemon = new Additive { Name = "Lemon", Cost = 1 };
                context.Additives.AddRange(new List<Additive> { Milk, Sugar, Cinnamon, Lemon });

                context.SaveChanges();
            }

            Generator generator = new ConcreteGenerator();
            Machine machine = new Machine(context, generator);
            machine.Generate();
            Product product = generator.GetResult();
            product.Show();

            Console.ReadKey();
        }
    }
}