using System;

namespace Encapsulation
{
    // Class to represent Election-related functionalities
    internal class Election
    {
        // Private fields to store age and name
        private int Age;
        private string Name;

        // Method to get the Age of the person
        public int GetAge()
        {
            return Age;
        }

        // Method to set the Name of the person
        public void SetName(string name)
        {
            this.Name = name;
        }

        // Method to get the Name of the person
        public string GetName()
        {
            return Name;
        }

        // Method to set the Age based on the person's date of birth (dob)
        public void SetAge(DateTime dob)
        {
            // Calculate age based on the year difference between now and the birth year
            Age = DateTime.Now.Year - dob.Year;

            // Adjust age if birthday hasn't occurred yet this year
            if (dob > DateTime.Now.AddYears(-Age)) Age--;

            // Check if the person is eligible to vote (18 years or older)
            if (Age >= 18)
            {
                Console.WriteLine($"{Name}, you are eligible to vote.");
            }
            else
            {
                Console.WriteLine($"{Name}, you are not eligible to vote..");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for the number of voters
            Console.Write("Enter the number of voters: ");
            int numVoters;
            while (!int.TryParse(Console.ReadLine(), out numVoters) || numVoters <= 0)
            {
                Console.WriteLine("Please enter a valid number greater than 0.");
            }

            // Create an array of Election objects based on the number of voters
            Election[] voters = new Election[numVoters];

            // Loop through each voter
            for (int i = 0; i < numVoters; i++)
            {
                voters[i] = new Election();  // Create a new Election instance for each voter

                // Prompt user for name and set it
                Console.Write($"Enter the name of voter {i + 1}: ");
                string name = Console.ReadLine();
                voters[i].SetName(name);

                // Prompt user for date of birth and validate input format
                Console.Write($"Enter the date of birth of voter {i + 1} (yyyy-mm-dd): ");
                DateTime dob;
                while (!DateTime.TryParse(Console.ReadLine(), out dob))
                {
                    Console.WriteLine("Invalid date format. Please enter in the format yyyy-mm-dd.");
                }

                // Set the age and check eligibility for voting
                voters[i].SetAge(dob);
            }
        }
    }
}


