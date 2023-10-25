using System;

public class WritingAssignment : Assignment
{
    // Attributes
    private string _title;

    // Constructors
    public WritingAssignment()
    {
    }

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}