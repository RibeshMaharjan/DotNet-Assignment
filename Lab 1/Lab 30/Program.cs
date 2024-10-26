// Give an example of Generics in C#.

using System;

class Program
{
    static void Main(string[] args)
    {
        Student<string> name = new Student<string>("Harry");
        Student<int> age= new Student<int>(21);

        Console.WriteLine("Student Info:\n");
        Console.Write("Name:\t"); name.GetInfo();
        Console.Write("Age:\t"); age.GetInfo();
    }

    class Student<T>
    {
        public T Value;

        public Student(T value)
        {
            Value = value;
        }

        public void GetInfo()
        {
            Console.WriteLine(Value);
        }
    }
}