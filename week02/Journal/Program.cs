using System;
using System.Transactions;
//Added mood tracking to each data entry
//Added random prompts 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");

            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
            Console.Write("How are you feeling? ");
            string moodResponse = Console.ReadLine();
            
            string prompt= promptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.Write("Enter your response: ");
            string response = Console.ReadLine();


            Entry entry = new Entry();
            entry._date = DateTime.Now.ToShortDateString();
            entry._promptText = prompt;
            entry._entryText = response;
            entry._mood = moodResponse;
            journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter file name to save to file: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            else if (choice == "4")
            {
                Console.Write("Enter file name to load from file: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == "5")
            {
                break;
            }
        }

    }
}