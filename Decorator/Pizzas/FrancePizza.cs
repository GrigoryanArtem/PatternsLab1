using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pizza
{
    class FrancePizza : Pizza
    {
        private const double COST = 33.50;
        private const uint CALORIES = 800;

        public FrancePizza()
        {
            _information = "France Pizza";
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
