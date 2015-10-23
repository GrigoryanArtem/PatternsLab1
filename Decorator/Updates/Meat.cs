using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Updates
{
    class Meat : Update
    {
        private const string INFO = " + Meat";
        private const double COST = 5.75;
        private const uint CALORIES = 50;
        public Meat(Pizza.Pizza pizza)
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
