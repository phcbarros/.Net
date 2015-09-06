using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class Squeak: IQuackBehavior
    {
        public string quack()
        {
            return "Squeak Squeak!";
        }
    }
}
