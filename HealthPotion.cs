using System;

namespace RPG
{
    class HealthPotion : Item
    {
        public HealthPotion() : base("Health Potion", 1.5) { }

        public override bool effect(Character target)
        {
            int healthDifference = target.MaxHealth - target.Health;

            if (healthDifference == 0)
            {
                Console.WriteLine("Nothing to heal. Not using health potion. Lose a turn.");
                return false;
            }
            else if (healthDifference >= 20)
            {
                target.Health += 20;
                Console.WriteLine(target.Name + " healed by 20 and now has " + target.Health + " health.");
            }
            else
            {
                target.Health += target.MaxHealth;
                Console.WriteLine(target.Name + " healed by " + healthDifference
                    + " and now has " + target.Health + " health.");
            }

            return true;
        }
    }
}
