using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Builder
{
    abstract class Generator
    {
        public abstract void BuildDrink(DrinkMachine.Data.AppContext context, int id);
        public abstract void BuildAdditive(DrinkMachine.Data.AppContext context, int[] id);
        public abstract Product GetResult();
    }
}
