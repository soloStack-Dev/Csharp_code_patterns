using System;

namespace CreationalDesign
{
    public class Singleton
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            Console.WriteLine(logger1 == logger2 ? "two obj use same instance" : "two obj use diff instance");


            //singleton pattern
            //help to create only one instance of a class to everywhere use
            //many object use same instance of a class
        }
    }

    public class Logger
    {
        private static Logger? _instance;

        private Logger()
        {
            Console.WriteLine("Logger was created");
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
    }
}