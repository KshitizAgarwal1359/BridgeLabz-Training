using System;
//custom exception class for robot safety violations
public class RobotSafetyException : Exception //this exception is thrown when any input validation fails
{
    public RobotSafetyException(string message) : base(message) //constructor passes the custom error message to the base exception class
    {
        
    }
}
