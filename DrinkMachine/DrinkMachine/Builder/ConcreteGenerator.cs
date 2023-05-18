using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Builder
{
    class ConcreteGenerator : Generator
    {
        Product product = new Product();

        public override void BuildDrink(DrinkMachine.Data.AppContext context, int id)
        {
            product.AddDrink(context, id);
        }

        public override void BuildAdditive(DrinkMachine.Data.AppContext context, int[] id)
        {
            foreach (var item in id)
                product.AddAdditive(context, item);
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
