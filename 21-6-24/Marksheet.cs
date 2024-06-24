using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int RollNumber { get; set; }
    public Dictionary<string, int> Subjects { get; set; }
    public int TotalMarks { get; private set; }
    public double AverageMarks { get; private set; }

    public Student()
    {
        Subjects = new Dictionary<string, int>();
    }

    public void CalculateTotalAndAverage()
    {
        TotalMarks = 0;
        foreach (var mark in Subjects.Values)
        {
            TotalMarks += mark;
        }
        AverageMarks = (double)TotalMarks / Subjects.Count;
    }

    public void DisplayMarksheet()
    {
        Console.WriteLine("\n--- Marksheet ---");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);

        // Display table header
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("| Subject          | Marks |");
        Console.WriteLine("---------------------------");

        // Display each subject and its marks
        foreach (var subject in Subjects)
        {
            Console.WriteLine("| {0,-15} | {1,5} |",subject.Key,subject.Value);
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine("| Total            | {0,5} |",TotalMarks);
        Console.WriteLine("| Average          | {0,5:F2} |",AverageMarks);
        Console.WriteLine("---------------------------");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.Write("Enter student's name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter student's roll number: ");
        student.RollNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter number of subjects: ");
        int subjectCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < subjectCount; i++)
        {
            Console.Write("Enter subject name: ");
            string subjectName = Console.ReadLine();

            Console.Write("Enter marks for " + subjectName + ": ");
            int marks = int.Parse(Console.ReadLine());

            student.Subjects[subjectName] = marks;
        }

        student.CalculateTotalAndAverage();
        student.DisplayMarksheet();
    }
}
