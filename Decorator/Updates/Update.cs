using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Pizza;

namespace Decorator.Updates
{
    abstract class Update : Pizza.Pizza
    {
        // Обьект для улучшения
        protected Pizza.Pizza _pizza;
    }
}
