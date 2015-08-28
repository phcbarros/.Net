
using Strategy.Character.Behavior;

namespace Strategy.Character.Model
{
    public class Queen : Character
    {
        public Queen()
        {
            weaponBehavior = new BowAndArrowBehavior();
        }
    }
}
