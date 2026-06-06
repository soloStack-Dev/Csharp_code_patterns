using System;

class CarFactory
{
    private string carName = string.Empty;
    private int carYear = 0;

    public string CarName
    {
        get { return carName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Car name cannot be empty.");
            }
            else
            {
                carName = value;
            }
        }
    }

    public int CarYear
    {
        get { return carYear; }
        set { carYear = value; }
    }
}