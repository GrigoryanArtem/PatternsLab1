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
        static void PrintPizza(Pizza.Pizza pizza)
        {
            Console.WriteLine("\tPizza: {0}\n\tCost: {1}$\n\tCalories: {2}\n\n",
                pizza.GetInfo(), pizza.GetCost(), pizza.GetCalories());
        }
        static void Main(string[] args)
        {
            Pizza.Pizza[] pizzas = new Pizza.Pizza[2];

            pizzas[0] = new ItalianPizza();
            pizzas[1] = new FrancePizza();

            foreach(var pz in pizzas)
                PrintPizza(pz);

            pizzas[0] = new Cheese(pizzas[0]);
            pizzas[0] = new Meat(pizzas[0]);

            pizzas[1] = new Pine(pizzas[1]);
            pizzas[1] = new Sauce(pizzas[1]);

            foreach (var pz in pizzas)
                PrintPizza(pz);
        }
    }
}
