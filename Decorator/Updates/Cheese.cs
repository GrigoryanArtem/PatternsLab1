using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Updates
{
    class Cheese : Update
    {
        private const string INFO = " + Cheese";
        private const double COST = 2.50;
        private const uint CALORIES = 20;
        public Cheese(Pizza.Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetInfo()
        {
            return _pizza.GetInfo() + INFO;
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + COST;
        }

        public override uint GetCalories()
        {
            return _pizza.GetCalories() + CALORIES;
        }
    }
}
