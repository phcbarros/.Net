using Strategy.Character.Interface;

namespace Strategy.Character.Behavior
{
    public class AxeBehavior: IWeaponBehavior
    {
        public string useWeapon()
        {
            return "Estou usando um Machado!";
        }
    }
}
