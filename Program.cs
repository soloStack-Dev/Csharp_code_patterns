using System;
using System.Threading;
using System.Diagnostics;
using static System.Console;

public class Program
{
    public static void Main(string[] args)
    {
        /*Variable variable = new Variable();
        variable.VariableDemo();*/

        /*
        Console.WriteLine("----Integer----");

        Console.WriteLine($"Integer range: {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"Double range: {double.MinValue} to {double.MaxValue}");
        int amount = 10;
        int quality = 5;
        int total = amount * quality;
        Console.WriteLine($"Total: {total}");

        int prize_pool = 1_000_000;
        Console.WriteLine($"Prize Pool: {prize_pool}");

        int flag = 0b10011110;
        Console.WriteLine($"Flag: {flag}");
        Console.WriteLine($"Flag in binary: {flag.ToString("2")}");
        */

        /*
        Console.WriteLine("----Floating Point----");
        Console.WriteLine(0.1+0.1+0.1);
        float rate = 5.2F;
        float amount = 10_000.5f;
        Console.WriteLine($"Rate: {rate}");
        Console.WriteLine($"Amount: {amount}");
        */

        /*
        Conditional conditional = new Conditional();
        conditional.ConditionalDemo();
        */

        /*
        Statement statement = new Statement();
        statement.StatementDemo();
        */

        /*
        Loops loops = new Loops();
        loops.LoopDemo();
        */

        /*
        Method obj = new Method();
        obj.Greeting();

        Console.WriteLine("Enter a favorite Unity Game:");
        string? game = Console.ReadLine();
        obj.Game(game ?? "Unknown");

        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Enter the second number:");
        int b = int.Parse(Console.ReadLine() ?? "0");

        int sum = obj.Add(a, b);
        Console.WriteLine($"The sum of {a} and {b} is: {sum}");
        */

        /*
        NofData nofData = new NofData();
        nofData.Demo();*/

        /*
        MultiDimention multiDimention = new MultiDimention();
        multiDimention.Demo();*/

        /*
        ListPrint listPrint = new ListPrint();
        listPrint.Demo();
        listPrint.PrintArray(new decimal[] { 100, 200, 300 });*/

        /*
        ListPattern listPattern = new ListPattern();
        listPattern.Demo();
        */

        /*
        Person person = new Person();
        person.firstName = "John";
        person.lastName = "Doe";
        person.age = 30;
        person 
        .setPlace("New York")
        .DisplayInfo();
        */

        /*
        Employee employee1 = new Employee();
        Employee employee2 = new Employee("Jane", "Smith");
        Employee employee3 = new Employee("Alice", "Johnson", 28);
        employee3.DisplayInfo();
        employee2.FullName();
        */

        /*
        Console.WriteLine("Enter a Car name: ");
        string? carName = Console.ReadLine();
        Console.WriteLine("Enter the car year: ");
        string? carYearInput = Console.ReadLine();
        int carYear = int.Parse(carYearInput ?? "0");

        CarFactory car = new CarFactory();
        car.CarName = carName;
        car.CarYear = carYear;
        Console.WriteLine("----Car Factory----");
        Console.WriteLine($"Car Name: {car.CarName}");
        Console.WriteLine($"Car Year: {car.CarYear}");
        */
        
        /*
        Console.WriteLine("----Indexer Demo----");
        var indexer = new Indexer("Hello World from C#");
        Console.WriteLine(indexer[0]); // Output: Hello
        Console.WriteLine(indexer[1]); // Output: World
        Console.WriteLine(indexer[2]); // Output: from
        Console.WriteLine(indexer[3]); // Output: C#

        ObjInitializer objInitializer = new ObjInitializer
        {
            FruitName = "Apple",
            Color = "Red",
            Quantity = 10,
            Price = 0.5
        };
        objInitializer.DisplayInfo();
        Console.WriteLine("---------Static Method Demo---------");
        ObjInitializer.FruitInfo("Apple",0.5);

        PrintMessage("Hello World! This is a static method demo.");
        */

        /*
        Employees employee = new Employees("John", "Doe", 30, "EMP123");
        Console.WriteLine("----Employee Information----");
        Console.WriteLine(employee.FullName);
        Console.WriteLine("----");
        Console.WriteLine(employee.Introduction);
        Console.WriteLine("----");
        Console.WriteLine(employee.EmployeeInfo);

        Console.WriteLine("----Logger Demo----");
        ConsoleLogger consoleLogger = new ConsoleLogger();
        FileLogger fileLogger = new FileLogger();
        consoleLogger.Log("Hello, Console!");
        fileLogger.Log("Hello, File!");
        */
        
        /*
        Console.WriteLine("----Interface Explicit Implementation Demo----");
        var logger = new ConsoleLoggers();
        logger.Log("This is a message from the console logger.");

        Console.WriteLine("----Interface Extending Demo----");
        var input = new Input();
        input.Undo();
        input.Redo();

        Console.WriteLine("----Abstract Class Demo----");
        var shape =  new List<Shape>();
        shape.Add(new Rectangle(4, 3));
        shape.Add(new Circle(5));
        foreach (var item in shape)
        {
            item.Info();
        }
        */
        
        /*
        tryCatch tryCatch = new tryCatch();
        tryCatch.withTryCatch();
        */

        /*
        Console.WriteLine("----Generic Handle Integer type----");
        int x = 10;
        int y = 20;
        Console.WriteLine($"x: {x}, y: {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"x: {x}, y: {y}");
        Console.WriteLine("----Generic Handle String type----");
        string a = "Hello";
        string b = "World";
        Console.WriteLine($"a: {a}, b: {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}");
        */

        /*
        Console.WriteLine("----Stack Demo----");
        var colors = new Stack<string>(3);
        colors.Push("Red");
        colors.Push("Green");
        colors.Push("Blue");

        while (true)
        {
            var color = colors.Pop();
            if(color == null)
            {
                break;
            }
            Console.WriteLine(color);
        }
        */

        /*
        Teacher<string> teacher = new Teacher<string>("Steven", "FrankLin", 30);
        teacher.DisplayInfos();

        IGroup<PersonInfo> group = new Group<PersonInfo>();
        group.Add(new PersonInfo("John"));
        group.Add(new PersonInfo("Jane"));
        DisplayInfo(group);
        */

        /*
        Console.WriteLine("----Delegate Demo----");
        Message message = SayHi;
        message("Harry");
        message("Jane");
        message("Frank");
        Console.WriteLine("Greeting with friends");

        Console.WriteLine("-----------------");
        Console.WriteLine("----Anonymous Method Demo----");
        Message anonymousMessage = (message) => Console.WriteLine($"Hello, {message}");
        anonymousMessage("Harry");
        anonymousMessage("Jane");
        anonymousMessage("Frank");
        Console.WriteLine("Greeting with anonymous method");
        Console.WriteLine("-----------------");
        Console.WriteLine("----Transformer Demo----");
        Transformer transformer = delegate (int x) { return x * x; };
        Console.WriteLine(transformer(5));
        Console.WriteLine(transformer(10));
        Console.WriteLine(transformer(15));
        Console.WriteLine("Transformer Demo End");
        */

        /*
        Console.WriteLine("--------Lambda Expression Demo--------");
        Console.WriteLine("----Square root----");
        var square = (int x) => x * x;
        Console.WriteLine($"Square of 5 is {square(5)}");
        Console.WriteLine($"Square of 10 is {square(10)}");
        Console.WriteLine($"Square of 15 is {square(15)}");
        Console.WriteLine("Square root End");
        */

        /*
        Console.WriteLine("----Method Grouping----");
        Calculate calculate = MethodG.Add;
        Console.WriteLine(calculate(1, 2));
        Console.WriteLine(calculate(3, 4));
        Console.WriteLine(calculate(5, 6));
        Console.WriteLine("-----------------");
        Calculate2 calculate2 = MethodG.Add;
        Console.WriteLine(calculate2(1.5, 2.5));
        Console.WriteLine(calculate2(3.5, 4.5));
        Console.WriteLine(calculate2(5.5, 6.5));
        */
        /*
        int[] numbers = {1, 2, 3, 4, 5};
        foreach (var number in numbers)
        {
            if (number.IsEven())
            {
                Console.WriteLine($"Number {number} is even.");
            }
            else
            {
                Console.WriteLine($"Number {number} is odd.");
            }
        }
        /*
        Console.WriteLine("-----------------");
        Console.WriteLine("----Time Management----");
        var dt = new DateTime(2023,5,15,7,0,0);
        Console.WriteLine($"DateTime: {dt.ToString()}");
        Console.WriteLine($"Year: {dt.Year}");
        Console.WriteLine($"Month: {dt.Month}");
        Console.WriteLine($"Day: {dt.Day}");
        Console.WriteLine($"Hour: {dt.Hour}");
        Console.WriteLine($"Minute: {dt.Minute}");
        Console.WriteLine($"Second: {dt.Second}");

        var dtss = DateTime.Parse("05/07/2023");
        Console.WriteLine($"Date: {dtss.ToLongDateString()}");
        */
        /*
        Console.WriteLine("-----------------");
        Console.WriteLine("----Tuples in C#----");
        var person = ("Jhon Doe",30);
        Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");
        var Employee = (Name:"Faleel",Age:30,Job:"Software Engineer");
        Console.WriteLine($"Name: {Employee.Name}, Age: {Employee.Age}, Job: {Employee.Job}");

        var point = (20,99);
        var (x,y) = point;
        Console.WriteLine($"x: {x}, y: {y}");
        */
        /*
        Console.WriteLine("-----------------");
        Console.WriteLine("----Thread Demo----");
        ThreadMethod.DoWork();
        ThreadMethod.DoWork();
        */
        /*
        var watch = Stopwatch.StartNew();
        DoWork();
        DoWork();
        watch.Stop();
        Console.WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");
        */

        var watch = Stopwatch.StartNew();
        var t1 = new Thread(() => DoSomeWork("Hi"));
        var t2 = new Thread(() => DoSomeWork("Bye!"));

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
        
        watch.Stop();
        Console.WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");
       }
    
    static void DoWork()
    {
        Console.WriteLine("Doing the work....");
        Thread.Sleep(1000);
        Console.WriteLine("Work done");
    }

    static void DoSomeWork(string message)
    {
        Thread.Sleep(1000);
        Console.WriteLine(message);
    }

    delegate int Calculate(int a, int b);
    delegate double Calculate2(double a, double b);
    
    static void SayHi(string message)
    {
        Console.WriteLine($"Hello, {message}");
    }

    private static void DisplayInfo(IGroup<PersonInfo> group)
    {
        Console.WriteLine(group.Count);
    }

    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    delegate int Transformer(int x);
}

delegate void Message(string message);
