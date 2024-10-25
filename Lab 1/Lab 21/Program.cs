// Program to illustrate Indexers in C#.

class Program
{
    static void Main(string[] args)
    {
        StudentList studentList = new StudentList();

        studentList[0] = "Ram";
        studentList[1] = "Shyam";

        Console.WriteLine("Student List:\n");
        Console.WriteLine(studentList[0]);
        Console.WriteLine(studentList[1]);
    }
}

public class StudentList
{
    public string[] students = new string[10];

    public string this[int i]
    {
        get { return students[i]; }
        set { students[i] = value; }
    }
}