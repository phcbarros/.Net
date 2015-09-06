
namespace Decorator.StarBuzzCoffe.Model
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }

    }
}
