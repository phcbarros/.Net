
namespace Decorator.StarBuzzCoffe.Model
{
    public class StemeadMilk:CondimentDecorator
    {
        public StemeadMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Steamead Milk";
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }

    }
}
