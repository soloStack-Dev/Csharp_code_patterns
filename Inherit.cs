using System;

class User
{
    protected string firstName { get; set; } = string.Empty;
    protected string lastName { get; set; } = string.Empty;
    protected byte age { get; set; } = 0;

    public string FullName => $"{firstName} {lastName}";
    public string Introduction => $"My name is {FullName} and I am {age} years old.";
}

class Employees : User
{
    protected string employeeId { get; set; } = string.Empty;

    public Employees(string firstName, string lastName, byte age, string employeeId)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.employeeId = employeeId;
    }

    public string EmployeeInfo => $"Employee ID: {employeeId}, {Introduction}";
}