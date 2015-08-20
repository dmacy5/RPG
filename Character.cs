using System;

namespace RPG
{
    abstract class Character
    {
        protected string name;
        protected string gender;
        protected int health;
        protected int healthMax;
        protected int stamina;
        protected int staminaMax;
        protected int strength;
        protected int dexterity;
        protected int constitution;
        protected int endurance;
        protected int intelligence;
        protected int charisma;

        protected SpecialAbilityList abilities;
        protected Inventory inventory;
        //armor (clothes)
        //weapon, shield
        //items (belt, necklace, rings)

        public Character(string thisName)
        {
            name = thisName;
            gender = "male";
            health = 100;
            healthMax = 100;
            stamina = 75;
            staminaMax = 100;
            strength = 10;
            dexterity = 10;
            constitution = 10;
            endurance = 10;
            charisma = 10;
            intelligence = 10;

            abilities = new SpecialAbilityList(new Slash());
            inventory = new Inventory();
            inventory.addItem(new HealthPotion());
        }

        public abstract void turn( Character enemy );

        public void basicAttack( Character enemy )
        {
            Console.WriteLine(Name + " is attacking " + enemy.Name + ".");
            int attack = strength * attackModifier();
            enemy.health -= attack;
            Console.WriteLine(enemy.Name + " took " + attack + " damage and now has " + enemy.Health + ".");
        }

        public int attackModifier()
        {
            //Use armor, items, and status to effect attack
            return 1;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int MaxHealth
        {
            get { return healthMax; }
            set { MaxHealth = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
    }
}
