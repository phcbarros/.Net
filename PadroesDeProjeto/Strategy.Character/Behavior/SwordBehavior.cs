using Strategy.Character.Interface;

namespace Strategy.Character.Behavior
{
    public class SwordBehavior: IWeaponBehavior
    {
        public string useWeapon()
        {
            return "Estou usando uma Espada!";
        }
    }
}
