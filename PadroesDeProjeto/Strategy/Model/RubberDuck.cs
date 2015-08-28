
namespace Strategy.Model
{
    class RubberDuck : Duck
    {
        public override string quack()
        {
            return "Squeak Squeak!";
        }

        public override string display()
        {
            return "Sou um pato de borracha!";
        }

        public override string fly()
        {
            return "Não posso voar!";
        }
    }
}
