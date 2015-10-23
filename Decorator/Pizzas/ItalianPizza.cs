using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pizza
{
    class ItalianPizza : Pizza
    {
        private const double COST = 23.50;
        private const uint CALORIES = 600;

        public ItalianPizza()
        {
            _information = "Italian Pizza";
        }

        public override double GetCost()
        {
            return COST;
        }

        public override uint GetCalories()
        {
            return CALORIES;
        }
    }
}
