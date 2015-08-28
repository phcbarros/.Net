
using Strategy.Character.Interface;

namespace Strategy.Character.Model
{
    public abstract class Character
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public IWeaponBehavior weaponBehavior { get; protected set; }

        public string fight()
        {
            return weaponBehavior.useWeapon();
        }

        public void alterarArma(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }

    }
}
