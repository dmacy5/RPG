using System;

namespace RPG
{
    abstract class SpecialAbility
    {
        protected string name;

        public SpecialAbility(string thisName) { name = thisName; }
       
        public abstract void useAbility(Character player, Character enemy);

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
