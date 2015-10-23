using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Pizza;
using Decorator.Updates;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza.Pizza pizza = new ItalianPizza();

            Console.WriteLine("\tPizza: {0}\n\tCost: {1}$\n\tCalories: {2}\n\n",
                pizza.GetInfo(), pizza.GetCost(), pizza.GetCalories());

            pizza = new Cheese(pizza);

            Console.WriteLine("\tPizza: {0}\n\tCost: {1}$\n\tCalories: {2}\n\n",
                pizza.GetInfo(), pizza.GetCost(), pizza.GetCalories());
        }
    }
}
