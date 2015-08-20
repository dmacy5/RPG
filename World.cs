using System;

namespace RPG
{
    class World
    {
        private Character player;
        private Area currentLocation;
        private Area previousLocation;

        public World(Character thisPlayer)
        {
            player = thisPlayer;
            currentLocation = new Area(player);
            previousLocation = null;
        }
        
        public void advance()
        {
            if (player.Health <= 0)
            {
                Console.WriteLine(player.Name + " is dead. Quit and start a new game.");
                return;
            }

            int option;

            Console.WriteLine("Which area do you wish to proceed to: ");
            Console.WriteLine("1. Left");
            Console.WriteLine("2. Forward");
            Console.WriteLine("3. Right");

            if (previousLocation != null)
            {
                Console.WriteLine("4. Back");
                option = GameManager.getInputBetween(1, 4);
            }
            else
                option = GameManager.getInputBetween(1, 3);

            if( option != 4 )
            {
                previousLocation = currentLocation;
                currentLocation = new Area(player);
            }
            else
            {
                currentLocation = previousLocation;
                previousLocation = null;
            }

            currentLocation.enter();
        }
        
    }
}
