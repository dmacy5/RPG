using System;

namespace RPG
{
    class SpecialAbilityList
    {
        private SpecialAbility[] abilities;

        private int abilityCount;

        public SpecialAbilityList()
        {
            abilities = new SpecialAbility[4];
            abilityCount = 0;

            abilities[0] = null;
            abilities[1] = null;
            abilities[2] = null;
            abilities[3] = null;
        }

        public SpecialAbilityList(SpecialAbility one)
        {
            abilities = new SpecialAbility[4];
            abilityCount = 1;

            abilities[0] = one;
            abilities[1] = null;
            abilities[2] = null;
            abilities[3] = null;
        }

        public SpecialAbilityList(SpecialAbility one, SpecialAbility two)
        {
            abilities = new SpecialAbility[4];
            abilityCount = 2;

            abilities[0] = one;
            abilities[1] = two;
            abilities[2] = null;
            abilities[3] = null;
        }

        public SpecialAbilityList(SpecialAbility one, SpecialAbility two, SpecialAbility three)
        {
            abilities = new SpecialAbility[4];
            abilityCount = 3;

            abilities[0] = one;
            abilities[1] = two;
            abilities[2] = three;
            abilities[3] = null;
        }

        public SpecialAbilityList(SpecialAbility one, SpecialAbility two, SpecialAbility three, SpecialAbility four)
        {
            abilities = new SpecialAbility[4];
            abilityCount = 4;

            abilities[0] = one;
            abilities[1] = two;
            abilities[2] = three;
            abilities[3] = four;
        }

        public SpecialAbility getAbility()
        {
            displayAbilities();
            int option = GameManager.getInputBetween(1, abilityCount);

            if (option == 1)
                return abilities[0];
            else if (option == 2)
                return abilities[1];
            else if (option == 3)
                return abilities[2];
            else if (option == 4)
                return abilities[3];

            return null;
        }

        public void addAbility(SpecialAbility newAbility)
        {
            if( abilityCount >= 0 && abilityCount < 4 )
            {
                abilities[abilityCount] = newAbility;
                abilityCount++;
            }
            else
            {
                int removedIndex = removeAbility();

                if(removedIndex >= 0)
                    abilities[removedIndex] = newAbility;
            }
        }

        private int removeAbility()
        {
            if (abilityCount <= 0)
            {
                Console.WriteLine("No abilities to remove.");
                return -1;
            }

            if(cancelRemove())
            {
                Console.WriteLine("Keeping current abilities.");
                return -1;
            }
            
            Console.WriteLine("Removing ability...");
            displayAbilities();
            int choice = GameManager.getInputBetween(1, abilityCount);
            abilities[choice - 1] = null;

            return choice - 1;
        }

        private void displayAbilities()
        {
            Console.WriteLine("Pick an ability: ");

            if (abilityCount > 0)
                Console.WriteLine("1. " + abilities[0].Name);
            if (abilityCount > 1)
                Console.WriteLine("2. " + abilities[1].Name);
            if (abilityCount > 2)
                Console.WriteLine("3. " + abilities[2].Name);
            if (abilityCount > 3)
                Console.WriteLine("4. " + abilities[3].Name);
        }

        private bool cancelRemove()
        {
            Console.WriteLine("Are you sure you want to remove an ability?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int option = GameManager.getInputBetween(1, 2);

            if (option == 1)
                return false;
            return true;
        }
    }
}
