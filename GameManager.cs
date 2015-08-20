using System;

namespace RPG
{
    class GameManager
    {
        static void Main(string[] args)
        {
            World gameWorld = new World(new Player("Drew"));

            int keepGoing = 1;
            while( keepGoing == 1)
            {
                gameWorld.advance();
                Console.WriteLine("Do you want to continue?: (1 = Yes, 2 = No)");
                keepGoing = getInputBetween(1, 2);
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }

        public static int getInputBetween(int start, int end)
        {
            Console.Write("Enter: ");

            try
            {
                string option = Console.ReadLine();
                int num = Convert.ToInt32(option);

                while (start <= end)
                {
                    if (num >= start && num <= end)
                    {
                        Console.WriteLine("");
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option. Try Again.");
                        Console.Write("Enter: ");
                        option = Console.ReadLine();
                        num = Convert.ToInt32(option);
                    }
                }

                Console.WriteLine("Invalid parameters. Returning 1.");
                return 1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input type error.");
                return 1;
            }
        }
    }
    
}
