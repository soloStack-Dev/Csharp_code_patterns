namespace Thead
{
    public class Dowork
    {
        static void Main(String[] args)
        {
            Works worker = new Works("Software Developer", "Develops software applications.", 15000);
            worker.Work();
            worker.salary();
            worker.workerInfo();
        }
    }
}


class Works
{
    public string JobName { get; set; } = string.Empty;
    public string JobDescription { get; set; } = string.Empty;
    public int JobSalary { get; set; } = 0;

    public Works(string jobName, string jobDescription, int jobSalary)
    {
        JobName = jobName;
        JobDescription = jobDescription;
        JobSalary = jobSalary;
    }

    public void Work()
    {
        Console.WriteLine($"I am working as a {JobName}.");
    }

    public void salary()
    {
        if(JobSalary > 0)
        {
            Console.WriteLine($"I am earning {JobSalary + 2000} per month with Bonus.");
        }
        else
        {
            Console.WriteLine($"I am {JobName} not earning any salary.");
        }
    }

    public void workerInfo()
    {
        Console.WriteLine($"I am {JobName} and I work as a {JobDescription}.");
        salary();
    }
}


abstract class Products
{
    public abstract void ProductDetails();
}

class Phone : Products
{
    public string PhoneName { get; set; } = string.Empty;

    public Phone(string phoneName)
    {
        PhoneName = phoneName;
    }
    
    public override void ProductDetails()
    {
        Console.WriteLine($"I am a {PhoneName}.");
    }
}

class Laptop : Products
{
    public string LaptopName { get; set; } = string.Empty;

    public Laptop(string laptopName)
    {
        LaptopName = laptopName;
    }

    public override void ProductDetails()
    {
        Console.WriteLine($"I am a {LaptopName}.");
    }
}
