
using Strategy.Character.Behavior;

namespace Strategy.Character.Model
{
    public class Knight: Character
    {
        public Knight()
        {
            weaponBehavior = new AxeBehavior();
        }
    }
}
