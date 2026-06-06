using System;

class Employee
{
    private string firstName = string.Empty;
    private string lastName = string.Empty;
    private byte age;

    public Employee()
    {
    }

    public Employee(string firstName,string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Employee(string firstName, string lastName, byte age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}, Age: {age}");
    }

    public void FullName()
    {
        Console.WriteLine($"Full Name: {firstName} {lastName}");
    }
}