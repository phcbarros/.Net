﻿
namespace Decorator.StarBuzzCoffe.Model
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
