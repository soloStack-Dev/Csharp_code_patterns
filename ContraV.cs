using System;

class PersonInfo
{
    public string Name
    {
        get;
        set;
    }
    public PersonInfo(string name)
    {
        Name = name;
    }
}

class EmployeeInfo : PersonInfo
{
    public string JobTitle;

    public EmployeeInfo(string name, string jobTitle) : base(name)
    {
        JobTitle = jobTitle;
    }
}

interface IGroup<in T>
{
    void Add(T item);

    int Count
    {
        get;
    }
}

class Group<T> : IGroup<T>
{
    private readonly List<T> list = new();

    public int Count => list.Count;
    public void Add(T item)
    {
        list.Add(item);
    }
}