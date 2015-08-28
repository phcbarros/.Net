
namespace Strategy.Duck.Model
{
    public abstract class Duck
    {
        protected int Id { get; private set; }
        protected string Nome { get; private set; }

        public void swim() { }

        public virtual string display()
        {
            return "Sou um pato genérico!";
        }

    }
}
