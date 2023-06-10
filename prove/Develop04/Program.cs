using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        while (userChoice != 5) {
            // Asking for the User choice assignign it in a variable
            // Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View Activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();
            // Conditions
            if (userChoice == 1) {
                // in case the user choose the Breathing activity.
                Breathing breathing = new Breathing();
                breathing.DisplayMessage();
                breathing.SpinnerAnimation("Get Ready...\n", 5);
                breathing.DisplayAlterningMessage();
                breathing.SpinnerAnimation("Well done!\n", 5);
                breathing.SpinnerAnimation($"You have completed another {breathing.GetDuration()} seconds of the {breathing.GetName()}\n", 5);
                Console.Clear();
                breathingCount += 1;
            }
            // in case the user choose the Reflectiong activity.
            else if (userChoice == 2) {
                Reflecting reflecting = new Reflecting();
                reflecting.DisplayMessage();
                reflecting.SpinnerAnimation("Get Ready...\n", 5);
                reflecting.DisplayPrompt();
                reflecting.DisplayReflections();
                reflecting.SpinnerAnimation("\nWell done!\n", 5);
                reflecting.SpinnerAnimation($"You have completed another {reflecting.GetDuration()} seconds of the {reflecting.GetName()}\n", 5); 
                Console.Clear();
                reflectingCount += 1;
            }
            // in case the user choose the Listing activity.
            else if (userChoice == 3) {
                Listing listing = new Listing();
                listing.DisplayMessage();
                listing.SpinnerAnimation("Get Ready...\n", 5);
                listing.DisplayPrompt();
                listing.ListItems();
                listing.SpinnerAnimation("\nWell done!\n", 5);
                listing.SpinnerAnimation($"You have completed another {listing.GetDuration()} seconds of the {listing.GetName()}\n", 5);
                Console.Clear();
                listingCount += 1;
            }
            // in case the user choose to quit.
            else if (userChoice == 4) {
                Console.WriteLine($"you performed Breathing Activity {breathingCount} Times");
                Console.WriteLine($"you performed Breathing Activity {reflectingCount} Times");
                Console.WriteLine($"you performed Breathing Activity {listingCount} Times");
                Console.ReadKey();
                Console.Clear();
            }
            else if (userChoice == 5) {
                break;
            }
            // in case the user types another number than those on the menu.
            else {
                Console.WriteLine("Please choose a number from the menu.");
            }
        }
    }









}