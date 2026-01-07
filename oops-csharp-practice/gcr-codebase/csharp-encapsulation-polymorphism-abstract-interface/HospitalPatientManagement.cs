using System;
using System.Collections.Generic;
// Defines medical record-related behavior
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}
// Base class for all patients
abstract class Patient
{
    // Encapsulated fields
    private int patientId;
    private string name;
    private int age;

    // Sensitive data (protected, not public)
    protected string diagnosis;
    protected List<string> medicalHistory = new List<string>();

    // Properties with validation
    public int PatientId
    {
        get { return patientId; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Patient ID must be positive");
            patientId = value;
        }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be valid");
            age = value;
        }
    }

    // Constructor
    protected Patient(int patientId, string name, int age)
    {
        PatientId = patientId;
        Name = name;
        Age = age;
    }

    // Abstract billing method
    public abstract double CalculateBill();

    // Concrete method
    public virtual void GetPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int id, string name, int age, int days, double chargePerDay)
        : base(id, name, age)
    {
        daysAdmitted = days;
        dailyCharge = chargePerDay;
        diagnosis = "Under Observation";
    }

    public override double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }

    public void AddRecord(string record)
    {
        medicalHistory.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (string record in medicalHistory)
        {
            Console.WriteLine($"- {record}");
        }
    }
}
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public OutPatient(int id, string name, int age, double fee)
        : base(id, name, age)
    {
        consultationFee = fee;
        diagnosis = "Routine Checkup";
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        medicalHistory.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (string record in medicalHistory)
        {
            Console.WriteLine($"- {record}");
        }
    }
}
class HospitalPatientManagement
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient(101, "Kshitiz", 22, 5, 3000),
            new OutPatient(102, "Aman", 25, 800)
        };

        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();

            Console.WriteLine($"Total Bill: {patient.CalculateBill()}");

            if (patient is IMedicalRecord record)
            {
                record.AddRecord("Diagnosis updated");
                record.AddRecord("Medication prescribed");
                record.ViewRecords();
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
