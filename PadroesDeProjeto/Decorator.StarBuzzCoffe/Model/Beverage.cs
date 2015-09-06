using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.StarBuzzCoffe.Model
{
    public abstract class Beverage
    {
        protected string description = "Unknow Beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
