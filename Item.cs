using System;

namespace RPG
{
    abstract class Item
    {
        protected string name;
        protected double weight;

        public Item(string thisName, double thisWeight)
        {
            name = thisName;
            weight = thisWeight;
        }

        public abstract bool effect(Character target);

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
