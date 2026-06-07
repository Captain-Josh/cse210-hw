public class Activity
{
   protected string _name;
   protected string _description;
   protected int _duration;

    public Activity(string name, string description)
    {
        _name =  name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("You have done a good job!");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
       
    }
    public void ShowSpinner(int seconds)
    {
        
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length; //keeps the loop inside the array 
        }

    }
    public void ShowCountDown(int seconds)
    {
        
       for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}