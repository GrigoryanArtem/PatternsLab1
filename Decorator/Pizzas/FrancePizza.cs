using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pizza
{
    class FrancePizza : Pizza
    {
        //Константы: имя, цена, калории 
        private const string NAME = "France Pizza";
        private const double COST = 33.50;
        private const uint CALORIES = 800;

        public FrancePizza()
        {
            _information = NAME;
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
