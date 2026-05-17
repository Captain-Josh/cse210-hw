using System;
//Added mood tracking to each data entry
public class Entry
{
    public string _date;
    public string _promptText;

    public string _mood;
    public string _entryText;


    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }
}