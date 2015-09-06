
namespace Decorator.StarBuzzCoffe.Model
{
    partial class Expresso : Beverage
    {

        public Expresso()
        {
            this.description = "Expresso Coffee";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 1.50;
        }

    }
}
