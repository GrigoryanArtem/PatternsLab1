using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pizza
{
    abstract class Pizza
    {
        protected string _information;

        public abstract double GetCost();
        public abstract uint GetCalories();
        public virtual string GetInfo()
        {
            return _information;
        }
    }
}
