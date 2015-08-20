using System;
using System.Collections.Generic;

namespace RPG
{
    class Inventory
    {
        private List<Item> inventory;
        private int itemCount;
        private double totalWeight;
        private double maxWeight;

        public Inventory()
        {
            inventory = new List<Item>();
            itemCount = 0;
            totalWeight = 0.0;
            maxWeight = 75;
        }

        public void addItem(Item newItem)
        {
            if (totalWeight + newItem.Weight <= maxWeight)
            {
                totalWeight += newItem.Weight;
                inventory.Add(newItem);
                itemCount++;
            }
            else
            {
                Console.WriteLine("Not enough room in pack.");
                Console.WriteLine("Do you want to remove item(s) to make room?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                int option = GameManager.getInputBetween(1, 2);

                if(option == 1)
                {
                    makeRoom(newItem.Weight);
                    totalWeight += newItem.Weight;
                    inventory.Add(newItem);
                    itemCount++;
                }
                else
                    Console.WriteLine("Losing " + newItem.Name + "...");
            }
        }

        private void makeRoom(double roomNeeded)
        {
            while (roomNeeded + totalWeight <= maxWeight)
            {
                Console.WriteLine("Pick item to discard: ");
                displayInventory();
                int itemIndex = GameManager.getInputBetween(1, itemCount) - 1;

                totalWeight -= inventory[itemIndex].Weight;
                inventory.RemoveAt(itemIndex);
            }
        }

        public void useItem(Character player, Character enemy)
        {
            Console.WriteLine("Pick item to use: ");
            displayInventory();
            int itemIndex = GameManager.getInputBetween(1, itemCount) - 1;
            Character target = pickTarget(player, enemy); 

            bool removeItem = inventory[itemIndex].effect(target);

            if (removeItem)
            {
                totalWeight -= inventory[itemIndex].Weight;
                inventory.RemoveAt(itemIndex);
            }
        }

        public void displayInventory()
        {
            for(int i = 0; i < itemCount; i++)
            {
                Console.WriteLine( (i+1) + ". " + inventory[i].Name);
            }
        }

        private Character pickTarget(Character him, Character her)
        {
            Console.WriteLine("Pick target for item: ");
            Console.WriteLine("1. " + him.Name);
            Console.WriteLine("2. " + her.Name);
            int option = GameManager.getInputBetween(1, 2);

            if (option == 1)
                return him;
            else return her;
        }
    }
}
