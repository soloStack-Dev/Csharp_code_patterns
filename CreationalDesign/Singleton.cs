using System;

namespace CreationalDesign
{
    public class Singleton
    {
        static void Main()
        {
            DoctorPortal doctorPortal = new DoctorPortal();
            doctorPortal.ViewPatient(123);

            ReceptionDesk receptionDesk = new ReceptionDesk();
            receptionDesk.CheckInPatient(456);
        }
    }
}

public sealed class HospitalDatabase
{
    private static readonly Lazy<HospitalDatabase> _instance = new Lazy<HospitalDatabase>(() => new HospitalDatabase());

    public static HospitalDatabase Instance => _instance.Value;

    private HospitalDatabase()
    {
        Console.WriteLine("Hospital Database initialized (only once)");
    }

    public void GetPatientRecord(int patientId)
    {
        Console.WriteLine($"Retrieving patient record with ID: {patientId}");
    }
}

//Doctor access the HospitalDatabase
public class DoctorPortal
{
    public void ViewPatient(int id)
    {
        HospitalDatabase.Instance.GetPatientRecord(id);
    }
}

//Receptionist access the Same instance (HospitalDatabase)
public class ReceptionDesk
{
    public void CheckInPatient(int id)
    {
        HospitalDatabase.Instance.GetPatientRecord(id);
    }
}

/* multiple person access only one instance of the database */