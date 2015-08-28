
using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class RedHeadDuck : Duck
    {

        public RedHeadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override string display()
        {
            return "Sou um pato Red Head";
        }

    }
}
