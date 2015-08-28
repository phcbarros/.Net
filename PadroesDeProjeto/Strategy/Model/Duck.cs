
namespace Strategy.Model
{
    public abstract class Duck
    {
        protected int Id { get; private set; }
        protected string Nome { get; private set; }

        public virtual string quack()
        {
            return "Quack Quack!";
        }

        public void swim() { }

        public virtual string display()
        {
            return "Sou um pato genérico!";
        }

        public virtual string fly()
        {
            return "Estou voando!";
        }

    }
}
