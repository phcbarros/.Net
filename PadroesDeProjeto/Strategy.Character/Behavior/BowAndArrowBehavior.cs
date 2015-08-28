using Strategy.Character.Interface;

namespace Strategy.Character.Behavior
{
    public class BowAndArrowBehavior: IWeaponBehavior
    {
        public string useWeapon()
        {
            return "Estou usando Arco e Flecha!";
        }
    }
}
