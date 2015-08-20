using System;

namespace RPG
{
    class Battle
    {
        private Character player;
        private Character enemy;

        public Battle(Character thisPlayer, Character thisEnemy)
        {
            player = thisPlayer;
            enemy = thisEnemy;
        }

        public void start()
        {
            while( player.Health > 0 && enemy.Health > 0 )
            {
                round();
            }

            if( player.Health > 0 )
            {
                Console.WriteLine(player.Name + " won the battle!");
            }
            else
            {
                Console.WriteLine(enemy.Name + " defeated you!");
            }
        }

        public void round()
        {
            player.turn(enemy);
            enemy.turn(player);
        }
    }
}
