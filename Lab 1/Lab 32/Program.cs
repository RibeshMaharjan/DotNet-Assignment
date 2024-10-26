//Write a C# Program to select students who are lived in Kritipur and Studied in Patan Multiple Campus using LINQ

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Ram", Address = "Kirtipur", Campus = "Patan Multiple Campus" },
            new Student { Name = "Sita", Address = "Kirtipur", Campus = "Kathmandu University" },
            new Student { Name = "Hari", Address = "Lalitpur", Campus = "Patan Multiple Campus" },
            new Student { Name = "Gita", Address = "Kirtipur", Campus = "Patan Multiple Campus" },
            new Student { Name = "Shyam", Address = "Bhaktapur", Campus = "Tribhuvan University" }
        };

        var selectedStudent = students.Where(student => student.Address == "Kirtipur" && student.Campus == "Patan Multiple Campus");

        Console.WriteLine("Students living in Kirtipur and studying at Patan Multiple Campus:\n");
        foreach (var student in selectedStudent)
        {
            Console.WriteLine(student.Name);
        }
    } 
}

public class Student
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Campus { get; set; }
}