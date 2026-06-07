using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        //I exceeded requirements by tracking how many times each activity was performed and displayed the user's listed items after the activity.
        string choice = "";
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("MINDFULNESS PROGRAM");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program!");

    
                Console.WriteLine("\n--- Activity Summary ---");
                Console.WriteLine($"Breathing Activity used: {breathingCount} times");
                Console.WriteLine($"Reflection Activity used: {reflectionCount} times");
                Console.WriteLine($"Listing Activity used: {listingCount} times");

                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
                Console.ReadKey();
            }
        }

    
}}