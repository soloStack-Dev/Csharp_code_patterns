using System;

public class State
{
    public static void TrafficIntersection()
    {
        var light = new TrafficLight();

        // Simulate 10 cycles
        for (int i = 0; i < 10; i++)
        {
            light.Change();
            Console.WriteLine("---");
        }
    }
    static void Main()
    {
        TrafficIntersection();
    }
}

public interface ITrafficLightState
{
    void Handle(TrafficLight light);
    string Color { get; }
    int DurationSeconds { get; }
}

public class GreenState : ITrafficLightState
{
    public string Color => "🟢 GREEN";
    public int DurationSeconds => 30;

    public void Handle(TrafficLight light)
    {
        Console.WriteLine($"{Color} for {DurationSeconds}s — GO!");
        light.SetState(new YellowState());
    }
}

public class YellowState : ITrafficLightState
{
    public string Color => "🟡 YELLOW";
    public int DurationSeconds => 5;

    public void Handle(TrafficLight light)
    {
        Console.WriteLine($"{Color} for {DurationSeconds}s — PREPARE TO STOP");
        light.SetState(new RedState());
    }
}

public class RedState : ITrafficLightState
{
    public string Color => "🔴 RED";
    public int DurationSeconds => 25;

    public void Handle(TrafficLight light)
    {
        Console.WriteLine($"{Color} for {DurationSeconds}s — STOP");
        light.SetState(new GreenState());
    }
}

public class TrafficLight
{
    private ITrafficLightState _state;

    public TrafficLight() => _state = new RedState();  // Start with red

    public void SetState(ITrafficLightState state) => _state = state;

    public void Change()
    {
        Console.WriteLine($"Current: {_state.Color}");
        _state.Handle(this);  // Delegate to state — it decides what happens next
    }

    public string CurrentColor => _state.Color;
}

