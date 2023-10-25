using System;

public class MathAssignment : Assignment
{
    // Attributes
    private string _textBookSection;
    private string _problems;

    // Constructors
    public MathAssignment()
    {
    }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
        : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"Section: {_textBookSection} Problems: {_problems}";
    }
}