using Strategy.Duck.Interface;

namespace Strategy.Duck.Model
{
    public class FlyRocketPowered: IFlyBehavior
    {
        public string fly()
        {
            return "Estou voando com um foguete!";
        }
    }
}
