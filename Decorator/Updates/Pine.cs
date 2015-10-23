using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Updates
{
    class Pine : Update
    {
        private const string INFO = " + Pine";
        private const double COST = 1.50;
        private const uint CALORIES = 5;
        public Pine(Pizza.Pizza pizza)
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
