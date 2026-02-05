using System;

/*
 * Exceeding Requirements:
 * - Animation: smoother spinner animation in Activity class.
 * - Counter: Added a counter that tracks how many times each activity has been completed, displayed in the main menu.
 * - No Repeat Questions: Modified the ReflectingActivity to ensure no question is repeated
 *    until all questions have been used at least once in the session by tracking used questions.
 * - User Experience: Added clear screen functionality between activities.
 */

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine($"1. Start breathing activity  ({breathingCount} sessions completed)");
            Console.WriteLine($"2. Start reflecting activity ({reflectingCount} sessions completed)");
            Console.WriteLine($"3. Start listing activity    ({listingCount} sessions completed)");
            Console.WriteLine($"4. Quit");
            Console.Write("> ");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathe = new BreathingActivity();

                    breathe.Run();
                    breathingCount++;
 
                    break;
                case "2":
                    ReflectingActivity reflect = new ReflectingActivity();
 
                    reflect.Run();
                    reflectingCount++;
 
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
 
                    listing.Run();
                    listingCount++;
 
                    break;
                case "4":
                    Console.WriteLine("Goodbye.");
 
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select 1-4.");
 
                    break;
            }
        }
    }
}