using System;

class Program
{
    static void Main(string[] args)
    {
        //I added a timer feature that tracks how long it takes the user to fully memorize the scripture. The program records the start time and displays the total time taken once all words are hidden.
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();
        Reference reference = new Reference("John",4,16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        DateTime start =DateTime.Now;

     while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            Console.Write("Press Enter to Continue or type quit to exit: ");
            string input = Console.ReadLine();
         
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        
    }       

    TimeSpan duration = DateTime.Now - start;
    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine("All words are hidden!");
    Console.WriteLine($"Time taken:{Math.Round(duration.TotalSeconds)} seconds");      
    }
}


