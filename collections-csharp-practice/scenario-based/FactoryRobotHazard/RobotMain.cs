using System;
class RobotMain
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("enter arm precision(0.0-1.0)"); //read arm precision input
            double armPrecision = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter worker density(1-20)");
            int workerDensity=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Machinery status(Worn/Faulty/Critical): ");
            string machineryState = Console.ReadLine();
            RobotHazardAuditor auditor = new RobotHazardAuditor();
            double risk = auditor.CalculateHazardRisk(armPrecision,workerDensity,machineryState);
            Console.WriteLine("Robot hazard risk score: "+risk);
        }
        catch(RobotSafetyException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}