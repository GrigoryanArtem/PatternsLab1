using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Updates
{
    class Sauce : Update
    {
        private const string INFO = " + Sauce";
        private const double COST = 1.0;
        private const uint CALORIES = 0;
        public Sauce(Pizza.Pizza pizza)
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
