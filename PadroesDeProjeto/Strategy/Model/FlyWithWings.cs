using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class FlyWithWings: IFlyBehavior    
    {
        public string fly()
        {
            return "Estou voando!";
        }
    }
}
