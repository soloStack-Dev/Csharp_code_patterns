using System;

public class Observer
{
    public static void HospitalMonitoring()
{
    var monitor = new HeartRateMoniter();

    // Attach all observers
    var nurseDisplay = new NurseStationDisplay();
    var doctorPager = new DoctorPager();
    var icuAlarm = new ICUAlarmSystem();
    var familyApp = new FamilyNotificationApp();

    monitor.Attach(nurseDisplay);
    monitor.Attach(doctorPager);
    monitor.Attach(icuAlarm);
    monitor.Attach(familyApp);

    // Normal reading
    monitor.SetVitals(new PatientVitals { HeartRate = 72, BloodPressure = 120, OxygenLevel = 98 });

    // Critical reading — all observers react appropriately
    monitor.SetVitals(new PatientVitals { HeartRate = 155, BloodPressure = 160, OxygenLevel = 85 });

    // Family app unsubscribes (patient requested privacy)
    monitor.Detach(familyApp);

    // Another critical reading — family no longer notified
    monitor.SetVitals(new PatientVitals { HeartRate = 160, BloodPressure = 170, OxygenLevel = 88 });
}
    static void Main()
    {
        HospitalMonitoring();
    }
}

public interface IPatientMonitor
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

public interface IObserver
{
    void Update(PatientVitals vitals);
}

public class PatientVitals
{
    public int HeartRate { get; set; }
    public int BloodPressure { get; set; }
    public double OxygenLevel { get; set; }
    public DateTime Timestamp { get; set; }
}

public class HeartRateMoniter : IPatientMonitor
{
    private readonly List<IObserver> _observers = new();
    public PatientVitals? _currentvitals;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetVitals(PatientVitals vitals)
    {
        _currentvitals = vitals;
        Console.WriteLine($"\n💓 New reading: HR {vitals.HeartRate}, BP {vitals.BloodPressure}");
        Notify();
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_currentvitals ?? new PatientVitals());
        }
    }
}

public class NurseStationDisplay : IObserver
{
    public void Update(PatientVitals vitals)
    {
        Console.WriteLine($"🏥 Nurse Station: Displaying HR {vitals.HeartRate} on central monitor");
    }
}

public class DoctorPager : IObserver
{
    public void Update(PatientVitals vitals)
    {
        if (vitals.HeartRate > 120 || vitals.HeartRate < 50)
        {
            Console.WriteLine($"📟 Doctor Pager: ALERT! Patient HR {vitals.HeartRate} abnormal!");
        }
    }
}

public class ICUAlarmSystem : IObserver
{
    public void Update(PatientVitals vitals)
    {
        if (vitals.OxygenLevel < 90)
        {
            Console.WriteLine($"🚨 ICU Alarm: OXYGEN LOW! {vitals.OxygenLevel}%");
        }
    }
}

public class FamilyNotificationApp : IObserver
{
    public void Update(PatientVitals vitals)
    {
        if (vitals.HeartRate > 150)
        {
            Console.WriteLine($"📱 Family App: Urgent notification sent to family");
        }
    }
}