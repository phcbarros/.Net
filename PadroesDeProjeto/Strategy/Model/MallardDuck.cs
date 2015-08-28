
using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override string display()
        {
            return "Sou um pato Mallard!";
        }

    }
}
