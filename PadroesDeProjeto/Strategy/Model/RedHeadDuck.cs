
using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    class RedHeadDuck: Duck, IFlyable, IQuackable
    {
        public override string display()
        {
            return "Sou um pato Red Head";
        }

        public string fly()
        {
            return "Estou voando!";
        }

        public string quack()
        {
            return "Quack Quack!";
        }
    }
}
