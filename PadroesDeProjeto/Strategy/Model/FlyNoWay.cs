
using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class FlyNoWay: IFlyBehavior
    {
        public string fly()
        {
           return "Não posso voar!";
        }
    }
}
