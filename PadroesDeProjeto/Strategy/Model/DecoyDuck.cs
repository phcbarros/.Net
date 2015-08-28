
namespace Strategy.Model
{
    class DecoyDuck: Duck
    {
        public override string quack()
        {
            return "Não faço barulho!";
        }

        public override string display()
        {
            return "Sou um pato decorativo!";
        }

        public override string fly()
        {
            return "Não posso voar!";
        }
    }
}
