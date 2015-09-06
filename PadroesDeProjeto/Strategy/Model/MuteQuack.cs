using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class MuteQuack: IQuackBehavior
    {
        public string quack()
        {
            return ".....!";
        }
    }
}
