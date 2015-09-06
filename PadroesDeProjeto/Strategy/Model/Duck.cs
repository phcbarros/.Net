
using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public abstract class Duck
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }

        //propriedade de comportamento são declaradas com o tipo Interface
        public IFlyBehavior flyBehavior { get; protected set; }
        public IQuackBehavior quackBehavior { get; protected set; }

        public string swim()
        {
            return "Todos os patos sabem flutuar!";
        }

        public virtual string display()
        {
            return "Sou um pato genérico!";
        }

        //Substitui o método quack
        public string performQuack()
        {
            return quackBehavior.quack();
        }

        //substitui o métodos fly
        public string perfomFly()
        {
            return flyBehavior.fly();
        }

        public void alterarQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void alterarFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

    }
}
