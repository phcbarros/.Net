
using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    class RubberDuck : Duck, IQuackable
    {
        public override string display()
        {
            return "Sou um pato de borracha!";
        }

        public string quack()
        {
            return "Squeak Squeak!";
        }

    }
}
