using DrinkMachine.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Builder
{
    class Product
    {
        Drink drink = new Drink(); 
        List<Additive> additives = new List<Additive>();

        public void AddDrink(DrinkMachine.Data.AppContext context, int id)
        {
            this.drink = context.Drinks.FirstOrDefault(drink => drink.Id == id);
        }

        public void AddAdditive(DrinkMachine.Data.AppContext context, int id)
        {
            this.additives.Add(context.Additives.FirstOrDefault(additive => additive.Id == id));
        }

        public void Show()
        {
            Console.Clear();
            double cost = 0;

            Console.WriteLine("Your drink:");
            cost += drink.Cost;
            Console.WriteLine(drink.Name);
            Console.WriteLine("________________");

            Console.WriteLine("With additives:");
            foreach (Additive additive in additives)
            {
                cost += additive.Cost;
                Console.WriteLine(additive.Name);
            }
            Console.WriteLine("________________");

            Console.WriteLine("Cost:");
            Console.WriteLine(cost + "$");
        }
    }
}
