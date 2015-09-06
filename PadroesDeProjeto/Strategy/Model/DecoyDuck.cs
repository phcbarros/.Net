
namespace Strategy.Duck.Model
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }

        public override string display()
        {
            return "Sou um pato decorativo!";
        }

    }
}
