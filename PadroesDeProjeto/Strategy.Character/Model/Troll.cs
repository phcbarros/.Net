
using Strategy.Character.Behavior;

namespace Strategy.Character.Model
{
    public class Troll: Character
    {
        public Troll() 
        {
            weaponBehavior = new AxeBehavior();
        }
    }
}
