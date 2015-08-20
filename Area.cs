using System;

namespace RPG
{
    class Area
    {
        private Character player;
        //chest?
        //enemy?
        //hidden treasure?

        public Area(Character thisPlayer)
        {
            player = thisPlayer;
        }

        public void enter()
        {
            Random generator = new Random();
            double eventType = generator.NextDouble();
            Event areaEvent;

            if (eventType > .5)
            {
                Character enemy = new Enemy("Bitch");
                Console.WriteLine(player.Name + " is being attacked by " + enemy.Name);
                areaEvent = new Event(player, enemy);
            }
            else
                areaEvent = new Event(player);

            areaEvent.initiate();
        }
    }
}
