using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class Quack: IQuackBehavior
    {
        public string quack()
        {
            return "Quack Quack!";
        }
    }
}
