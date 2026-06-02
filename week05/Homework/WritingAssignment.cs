public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

   public void GetWritingInformation()
    {
        string studentName = GetName();
        Console.WriteLine( $"{_title} by {studentName}");
        // return $"{_title} by {studentName}"

    }

}