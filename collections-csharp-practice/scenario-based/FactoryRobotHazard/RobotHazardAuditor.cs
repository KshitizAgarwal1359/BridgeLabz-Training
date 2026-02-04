using System;
public class RobotHazardAuditor //this class is responsible for validating inputs and calculating the robot hazard risk score
{
    public double CalculateHazardRisk(double armPrecision,int workerDensity,string machineryState)
    {
        if (armPrecision < 0.0 || armPrecision > 1.0) //validates arm precision
        {
            throw new RobotSafetyException("error: arm precision must be 0.0-1.0");
        }
        if (workerDensity < 1 || workerDensity > 20) //validate worker density
        {
            throw new RobotSafetyException("error: worker density must be 1-20");
        }
        double machineRiskFactor;
        switch (machineryState) //determine machine risk factor based on machinery state
        {
            case "Worn": machineRiskFactor = 1.3; break;
            case "Faulty" : machineRiskFactor = 2.0; break;
            case "Critical": machineRiskFactor = 3.0; break;
            default: throw new RobotSafetyException("error: unsupported machinery state");
        }
        //hazard risk formula:
        //((1.0-armPrecision)*15.0)+(workerDensity*machineRiskFactor)
        double hazardRisk= ((1.0-armPrecision)*15.0)+(workerDensity*machineRiskFactor);
        return hazardRisk;
    }
}