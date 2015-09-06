
using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }

        public override string display()
        {
            return "Sou um pato de borracha!";
        }

    }
}
