
namespace Decorator.StarBuzzCoffe.Model
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
