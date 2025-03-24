using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueOrdering = true;

        // Welcome message
        Console.WriteLine("Welcome to the restaurant!");
        Console.WriteLine("I am your waiter, and I will show you the menu.");

        while (continueOrdering)
        {
            // Display the menu
            ShowMenu();

            // Ask the customer to make a selection
            Console.Write("\nPlease enter the number of the item you'd like to order: ");
            string input = Console.ReadLine();

            // Validate the input and use a switch statement to handle selection
            if (int.TryParse(input, out int selection))
            {
                switch (selection)
                {
                    case 1:
                        ShowSelection("Pizza", 100);
                        break;
                    case 2:
                        ShowSelection("Burger", 50);
                        break;
                    case 3:
                        ShowSelection("Pasta", 200);
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please choose a valid item from the menu.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }

            // Ask the customer if they want to continue or exit
            Console.Write("\nDo you want to order something else? (y/n): ");
            string continueInput = Console.ReadLine().ToLower();

            switch (continueInput)
            {
                case "y":
                    continueOrdering = true;
                    break;
                case "n":
                    continueOrdering = false;
                    Console.WriteLine("Thank you for your visit! Have a great day!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Assuming you want to exit.");
                    continueOrdering = false;
                    break;
            }
        }
    }

    // Method to display the menu
    static void ShowMenu()
    {
        Console.WriteLine("\n--- Menu ---");
        Console.WriteLine("1. Pizza - $100");
        Console.WriteLine("2. Burger - $50");
        Console.WriteLine("3. Pasta - $200");
    }

    // Method to display the selected item and price
    static void ShowSelection(string item, int price)
    {
        Console.WriteLine($"\nYou have selected: {item} - ${price}");
    }
}
