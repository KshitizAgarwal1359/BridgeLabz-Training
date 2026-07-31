using System; //class implementing this interface have to provide its own logic to calculate rent
public interface IRentable //this defines a contract for rent calculation
{
    double CalculateRent(int days); //calculate total rent for given no. of days
}