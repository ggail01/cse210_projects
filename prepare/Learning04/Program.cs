using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assig1 = new Assignment();
        assig1.SetStudentName("Samuel Bennett");
        assig1.SetTopic("Multiplication");
        Console.WriteLine();
        Console.WriteLine(assig1.GetSummary());

        MathAssignment a1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine();
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(a1.GetHomeworkList());

        WritingAssignment a2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine();
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetWritingInformation());
    }
}