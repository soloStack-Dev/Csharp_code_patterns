using System;

namespace StructuralDesign;

public class Adapter
{
    public void TravelScenario()
    {
        var hotel = new HotelRoom();
        var myCharger = new EuropeanCharger();

        var adapter = new PowerPlugAdapter(myCharger);
        hotel.ChangeDevice(adapter);
    }
    static void Main()
    {
        
    }
}

public interface IUSASocket
{
    void SupplyPower110v();
}

public class EuropeanCharger
{
    public void Connect220v()
    {
        Console.WriteLine("🔌 European charger connected to 220V");
    }
}

public class PowerPlugAdapter : IUSASocket
{
    private readonly EuropeanCharger _europeanCharger;

    public PowerPlugAdapter(EuropeanCharger charger)
    {
        _europeanCharger = charger;
    }

    public void SupplyPower110v()
    {
        Console.WriteLine("⚡ Adapter converting 110V → 220V");
        _europeanCharger.Connect220v();
    }
}

public class HotelRoom
{
    public void ChangeDevice(IUSASocket socket)
    {
        socket.SupplyPower110v();
    }
}