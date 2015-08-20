using System;

namespace RPG
{
    class Event
    {
        private Character player;
        private Character enemy;

        public Event(Character thisPlayer)
        {
            player = thisPlayer;
            enemy = null;
        }

        public Event(Character thisPlayer, Character thisEnemy)
        {
            player = thisPlayer;
            enemy = thisEnemy;
        }

        public void initiate()
        {
            if( enemy != null )
            {
                Battle battle = new Battle(player, enemy);
                battle.start();
            }
        }
    }
}
