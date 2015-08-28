
namespace Strategy.Duck.Model
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyNoWay();
        }

        public override string display()
        {
            return "Sou um pato modelo!";
        }
    }
}
