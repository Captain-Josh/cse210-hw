using System.Security.Cryptography.X509Certificates;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic)
    {
        _textbookSection= textbook;
        _problems = problems;
    }

     public string GetTextbook()
    {
        return _textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }


    public void GetHomeworkList()
    {
        Console.WriteLine($"Section {_textbookSection} Problems {_problems}");
    }
}