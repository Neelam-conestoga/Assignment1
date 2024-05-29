using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validChoice = false;
            while (!validChoice)
            {
                //Taking the user input to choose pet type
                Console.WriteLine("Please choose a type of pet:\n" +
                    "1. Dog\n" +
                    "2. Rabbit\n" +
                    "3. Cat\n");

                //Reading the user entered input as choice
                int choice1;
                try
                {
                    choice1 = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("You did not provide a valid input:\n");
                    continue;
                }


                //Displaying the user's choice and asking to name their pet
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("\nYou have chosen a Dog. What would you like to name your pet?\n");
                        validChoice = true;
                        break;
                    case 2:
                        Console.WriteLine("\nYou have chosen a Rabbit. What would you like to name your pet?\n");
                        validChoice = true;
                        break;
                    case 3:
                        Console.WriteLine("\nYou have chosen a Cat. What would you like to name your pet?\n");
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Make a valid choice.\n");
                        break;
                }
            }

            //Storing the pet name and asking user for activity choice input
            string petName;
            petName = Console.ReadLine();

            //Setting default value for any pet
            int hunger = 5;
            int happiness = 5;
            int health = 5;
            int choice2 = 0;

            do
            {
                //Asking user to make choice to perform an action
                Console.WriteLine("\nWelcome, {0}! Let's take a good care of him\n" +
                    "1. Feed {0}\n" +
                    "2. Play with {0}\n" +
                    "3. Let {0} rest\n" +
                    "4. Check {0}'s status\n" +
                    "5. Exit\n", petName);

                try
                {
                    choice2 = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n The provided input is not valid");
                    continue;
                }
                Console.WriteLine("\n");

                //If user chooses to feed the pet
                if (choice2 == 1)
                {
                    if (hunger <= 0)
                    {
                        Console.WriteLine("{0} is not hungry.", petName);
                        continue;
                    }
                    Console.WriteLine("You fed {0}. His hunger decreases and health improves slightly", petName);
                    hunger = (hunger - 2 < 0) ? 0 : hunger - 2;
                    health = (health + 1 > 10) ? 10 : health + 1;
                }

                //If user chooses to play with pet
                else if (choice2 == 2)
                {
                    if (hunger >= 10 || health <= 0)
                    {
                        Console.WriteLine("{0} is very hungry and cannot play.", petName);
                        continue;
                    }
                    if (happiness >= 10)
                    {
                        Console.WriteLine("You have been playing with {0} for a long time. Let him rest.", petName);
                        continue;
                    }

                    hunger = (hunger + 1 > 10) ? 10 : hunger + 1;
                    happiness = (happiness + 2 > 10) ? 10 : happiness + 2;
                    health = (health - 1 < 0) ? 0 : health - 1;

                    Console.WriteLine("You played with {0}. His happiness increases but he is getting abit hungry.", petName);
                }

                //If user chooses to let their pet's rest
                else if (choice2 == 3)
                {
                    if (happiness <= 0)
                    {
                        Console.WriteLine("{0} took rest for the long time. He wants to play.", petName);
                        continue;
                    }
                    if (health >= 10)
                    {
                        Console.WriteLine("{0} took rest for the long time. He wants to play.", petName);
                        continue;
                    }
                    Console.WriteLine("You let {0} rest.His health is improved and happiness is decreased.", petName);
                    health = (health + 1 > 10) ? 10 : health + 1;
                    happiness = (happiness - 1 < 0) ? 0 : happiness - 1;
                }

                //If user chooses to check pet's status
                else if (choice2 == 4)
                {
                    Console.WriteLine("Health = {0}" +
                        "\nHunger = {1}" +
                        "\nHappiness = {2}", health, hunger, happiness);
                    continue;
                }

                //If user chooses to exit
                else if (choice2 == 5)
                {
                    Console.WriteLine("Thank you for playing with {0}. Good Bye!", petName);
                }

                //If user chooses invalid choice
                else
                {
                    Console.WriteLine("Invalid choice. Choose any number from 1 to 5.");
                    continue;
                }

                //Implementation of special messages or events based on the pet's status 
                if (happiness <= 1)
                {

                    Console.WriteLine("{0} is very unhappy!Play with him to make him happy.", petName);
                }

                if (health <= 1)
                {
                    Console.WriteLine("{0} is very unhealthy!Feed him or play with him to increase it's health.", petName);
                }

                if (hunger >= 9)
                {
                    Console.WriteLine("{0} is hungry!Please feed him.", petName);
                }
                Console.WriteLine("_________________________________________________________________________________________________");
            } while (choice2 != 5);

        }

    }
}