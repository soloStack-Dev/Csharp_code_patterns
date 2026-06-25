using System;

namespace StructuralDesign;

public class Facade
{
    static void Main()
    {
        var homeTheaterFacade = new HomeTheaterFacade(
            new TV(),
            new SoundBar(),
            new Lights(),
            new Curtains(),
            new BluRayPlayer()
        );
        homeTheaterFacade.WatchMovie("The Matrix");
        homeTheaterFacade.EndMovie();
    }
}


public class TV
{
    //do some action in tv
    public void TurnOn()
    {
        Console.WriteLine("📺 TV: turned on!");
    }
    public void SetInput(string input) => Console.WriteLine($"📺 TV:Setting input to {input}");
    public void TurnOff() => Console.WriteLine("📺 TV: turned off!");
}

public class SoundBar
{
    public void TurnOn() => Console.WriteLine("🔊 SoundBar: On");
    public void SetMode(string mode) => Console.WriteLine($"🔊 SoundBar: {mode} mode");
    public void SetVolume(int level) => Console.WriteLine($"🔊 SoundBar: Volume {level}");
    public void TurnOff() => Console.WriteLine("🔊 SoundBar: Off");
}

public class Lights
{
    public void Dim(int percent) => Console.WriteLine($"💡 Lights: Dimmed to {percent}%");
    public void On() => Console.WriteLine("💡 Lights: Full brightness");
}

public class Curtains
{
    public void Close() => Console.WriteLine("🪟 Curtains: Closed");
    public void Open() => Console.WriteLine("🪟 Curtains: Open");
}

public class BluRayPlayer
{
    public void TurnOn() => Console.WriteLine("💿 Blu-ray: On");
    public void Play(string movie) => Console.WriteLine($"💿 Blu-ray: Playing '{movie}'");
    public void TurnOff() => Console.WriteLine("💿 Blu-ray: Off");
}

public class HomeTheaterFacade
{
    private readonly TV _tv;
    private readonly SoundBar _soundBar;
    private readonly Lights _lights;
    private readonly Curtains _curtains;
    private readonly BluRayPlayer _bluRay;

    public HomeTheaterFacade(TV tv, SoundBar soundBar, Lights lights, Curtains curtains, BluRayPlayer bluRay)
    {
        _tv = tv;
        _soundBar = soundBar;
        _lights = lights;
        _curtains = curtains;
        _bluRay = bluRay;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("\n🎬 Starting Movie Mode...");
        _lights.Dim(20);
        _curtains.Close();
        _tv.TurnOn();
        _tv.SetInput("HDMI1");
        _soundBar.TurnOn();
        _soundBar.SetMode("Movie");
        _soundBar.SetVolume(25);
        _bluRay.TurnOn();
        _bluRay.Play(movie);
        Console.WriteLine("🍿 Enjoy your movie!\n");
    }

    public void EndMovie()
    {
        Console.WriteLine("\n⏹️ Ending Movie Mode...");
        _bluRay.TurnOff();
        _soundBar.TurnOff();
        _tv.TurnOff();
        _curtains.Open();
        _lights.On();
        Console.WriteLine("🏠 Back to normal\n");
    }
}