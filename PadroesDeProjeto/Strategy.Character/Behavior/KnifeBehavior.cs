using Strategy.Character.Interface;

namespace Strategy.Character.Behavior
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public string useWeapon()
        {
            return "Estou usando uma Faca!";
        }
    }
}
