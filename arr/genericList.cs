using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace arr
{
    public class genericList
    {
        static void Main()
        {
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------------------------------");
            names.Insert(1, "David");
            names.Remove("Alice");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Checking if David is in the list...");
            bool hasDavid = names.Contains("David");

            if (hasDavid)
            {
                Console.WriteLine("Name was matched");
            }
            else
            {
                Console.WriteLine("Name was not matched");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Sorting the list...");
            names.Sort();
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Counting the name");

            Console.WriteLine($"There are {names.Count} names in the list.");
            Console.WriteLine("----------------------------------------------");
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            ReadOnlyCollection<int> readOnlyNumbers = numbers.AsReadOnly();
            foreach(int number in readOnlyNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("----------------------------------------------");

            ImmutableList<int> immutableNumbers = ImmutableList.Create(1,2,3);
            ImmutableList<int> newImmutableNumbers = immutableNumbers.Add(4);
            foreach(int number in newImmutableNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("----------------------------------------------");
        }
    }
}