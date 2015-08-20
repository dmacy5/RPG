using System;

namespace RPG
{
    class Enemy : Character
    {
        public Enemy(string thisName): base(thisName){ }

        public override void turn(Character enemy)
        {
            Random generator = new Random();
            double choice = generator.NextDouble();
            if (choice > .4)
                basicAttack(enemy);
        }
    }
}
