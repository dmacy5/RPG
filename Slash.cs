using System;

namespace RPG
{
    class Slash : SpecialAbility
    {
        public Slash() : base("Slash") { }

        public override void useAbility(Character player, Character enemy)
        {
            Console.WriteLine(Name + " slashes " + enemy.Name + "!");
            int attack = 2 * player.Strength * player.attackModifier();
            enemy.Health -= attack;
            Console.WriteLine(enemy.Name + " took " + attack + " damage and now has " + enemy.Health + ".");
        }
    }
}
