using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Builder
{
    class Machine
    {
        DrinkMachine.Data.AppContext context; Generator generator;

        public Machine(DrinkMachine.Data.AppContext context, Generator generator)
        {
            this.context = context;
            this.generator = generator;
        }

        public void Generate()
        {
        StartPoint:
            Console.Clear();
            Console.WriteLine("1 - Coffee\n2 - Tea");
            Console.Write("Choose a drink: ");
            int idOfDrink = int.Parse(Console.ReadLine());

            if (idOfDrink == 1 || idOfDrink == 2)
                generator.BuildDrink(context, idOfDrink);
            else
            {
                Console.WriteLine("Error!");
                Console.ReadKey();
                goto StartPoint;
            }

            Console.Clear();
            Console.WriteLine("1 - Milk\n2 - Sugar\n3 - Cinnamon\n4 - Lemon");
            Console.Write("Choose additives: ");
            string[] additives = Console.ReadLine().Split(",");
            int[] idOfAdditive = new int[additives.Length];
            for (int i = 0; i < additives.Length; i++)
            {
                if (int.Parse(additives[i]) > 4 || int.Parse(additives[i]) < 1)
                {
                    Console.WriteLine("Error!");
                    Console.ReadKey();
                    goto StartPoint;
                }
                else
                    idOfAdditive[i] = int.Parse(additives[i]);
            }

            generator.BuildAdditive(context, idOfAdditive);
        }
    }
}
