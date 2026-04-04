using System;
class Patient
{
    public static string HospitalName = "City Care Hospital";     // static variable (shared hospital name)
    private static int totalPatients = 0;
    public readonly int PatientID;     // readonly variable (unique patient ID)
    public string Name;     // instance variables
    public int Age;
    public string Ailment;
    public Patient(int PatientID, string Name, int Age, string Ailment)     // Constructor using 'this' keyword
    {
        this.PatientID = PatientID;
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        totalPatients++;
    }
    public static void GetTotalPatients()     // static method to get total patients
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
        Console.WriteLine();
    }
    public void DisplayPatientDetails(object obj)     // Method using 'is' operator for safe type checking
    {
        if (obj is Patient)
        {
            Console.WriteLine("Hospital Name : " + HospitalName);
            Console.WriteLine("Patient ID   : " + PatientID);
            Console.WriteLine("Name         : " + Name);
            Console.WriteLine("Age          : " + Age);
            Console.WriteLine("Ailment      : " + Ailment);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid patient object");
        }
    }
}
class HospitalManagementSystem // Main class
{
    static void Main(string[] args)
    {
        Patient p1 = new Patient(1, "Kshitiz", 22, "Fever");
        Patient p2 = new Patient(2, "Aman", 25, "Fracture");
        p1.DisplayPatientDetails(p1);
        p2.DisplayPatientDetails(p2);
        Patient.GetTotalPatients();
    }
}
