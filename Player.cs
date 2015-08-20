using System;

namespace RPG
{
    class Player : Character
    {
        public Player(string thisName): base(thisName){}

        public override void turn(Character enemy)
        {
            Console.WriteLine(Name + "'s turn: ");
            Console.WriteLine("1. Basic attack");
            Console.WriteLine("2. Special abilities");
            Console.WriteLine("3. Inventory");
            Console.WriteLine("4. Run");

            int option = GameManager.getInputBetween(1, 4);

            if (option == 1)
                basicAttack(enemy);
            else if(option == 2)
            {
                SpecialAbility picked = abilities.getAbility();
                picked.useAbility(this, enemy);
            }
            else if(option == 3)
            {
                inventory.useItem(this, enemy);
            }
        }
    }
}
