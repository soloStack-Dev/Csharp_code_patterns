using System;

class Person
{
    public string firstName = string.Empty;
    public string lastName = string.Empty;
    public int age = 0;
    public string place = string.Empty;

    public void DisplayInfo()
    {
        string fullName = $"{this.firstName} {this.lastName}";
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Age: {this.age}");
        Console.WriteLine($"Place: {this.place}");
    }

     public Person setPlace(string place)
    {
        this.place = place;
        return this;
    }
}