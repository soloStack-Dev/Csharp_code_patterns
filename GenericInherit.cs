using System;

interface Info
{
    void DisplayInfo();
}

class Student<T> : Info
{
    public T Name { get; set; }
    public Student(T name)
    {
        Name = name;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

class Teacher<T> : Student<T>
{
    public T TeacherName { get; set; }
    public int Age { get; set; }

    public Teacher(T Name,T teacherName, int age) : base(Name)
    {
        TeacherName = teacherName;
        Age = age;
    }
    public void DisplayInfos()
    {
        Console.WriteLine("----Student Info----");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("-----------------");
        Console.WriteLine("Teacher Info:");
        Console.WriteLine($"Name: {TeacherName} and {Age}");
    }
}