using static System.Console;

namespace CreationalDesign;

//Standard Report Template
public interface IReportPrototype
{
    //cloning the prototype
    IReportPrototype Clone();
}

//create new report templates with existing templates as prototypes
public class MedicalReport : IReportPrototype
{
    public string ReportType { get; set; } = string.Empty;
    public string HospitalName { get; set; } = string.Empty;
    public string HeaderLogo { get; set; } = string.Empty;
    public List<string> StandardSections { get; set; } = new();


    public string PatientName { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;
    public string Results { get; set; } = string.Empty;


    public MedicalReport(string type, string hospital)
    {
        ReportType = type;
        HospitalName = hospital;
        HeaderLogo = "🏥 City Hospital Logo";
        
        
        StandardSections = type switch
        {
            "Blood Test" => new() { "CBC", "Lipid Panel", "Liver Function" },
            "X-Ray" => new() { "Chest View", "Spine View" },
            _ => new()
        };
    }


    public IReportPrototype Clone()
    {
        
        return new MedicalReport(ReportType, HospitalName)
        {
            HeaderLogo = this.HeaderLogo,
            StandardSections = new List<string>(this.StandardSections)
            
        };
    }

    public void Display()
    {
        Console.WriteLine($"=== {ReportType} ===");
        Console.WriteLine($"Hospital: {HospitalName} | {HeaderLogo}");
        Console.WriteLine($"Patient: {PatientName} | Date: {Date:d}");
        Console.WriteLine($"Sections: {string.Join(", ", StandardSections)}");
        Console.WriteLine($"Results: {Results}");
    }

    public class ReportTemplateRegistry
{
    private readonly Dictionary<string, MedicalReport> _templates = new();

    public ReportTemplateRegistry()
    {
        // One-time setup: create base templates
        _templates["Blood Test"] = new MedicalReport("Blood Test", "City Hospital");
        _templates["X-Ray"] = new MedicalReport("X-Ray", "City Hospital");
    }

    public MedicalReport CreateReport(string type)
    {
        if (!_templates.TryGetValue(type, out var template))
            throw new ArgumentException("Unknown report type");

        return (MedicalReport)template.Clone();  // Fresh copy, template untouched
    }
}

// Usage: Doctor gets a fresh copy, fills patient details
public static void GeneratePatientReport()
{
        var registry = new ReportTemplateRegistry();

        var report1 = registry.CreateReport("Blood Test");
        report1.PatientName = "John Doe";
        report1.Date = DateTime.Now;
        report1.Results = "All normal";
        report1.Display();

        var report2 = registry.CreateReport("Blood Test");
        report2.PatientName = "Jane Smith";
        report2.Date = DateTime.Now;
        report2.Results = "High cholesterol";
        report2.Display();
    }
    
    static void Main()
    {
        GeneratePatientReport();
    }
}

