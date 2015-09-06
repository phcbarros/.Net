
namespace Decorator.StarBuzzCoffe.Model
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "Dark Roast Coffee";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
