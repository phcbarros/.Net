
using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    class MallardDuck: Duck, IFlyable, IQuackable
    {
        public override string display()
        {
            return "Sou um pato Mallard!";
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
