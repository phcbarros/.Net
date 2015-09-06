
namespace Decorator.StarBuzzCoffe.Model
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend Coffee";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
