
using Strategy.Character.Behavior;

namespace Strategy.Character.Model
{
    public class King : Character
    {
        public King()
        {
            weaponBehavior = new SwordBehavior();
        }
    }
}
