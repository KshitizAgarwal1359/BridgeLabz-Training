using System;
class VolumeOfEarth{
	public static void Main(String[] args){
		double radiusKm = 6378;
		double volKm3 = (4.0/3.0)*Math.PI*Math.Pow(radiusKm,3);
		double kmToMiles = 0.621371;
		double volMiles3 = volKm3*Math.Pow(kmToMiles,3);
	 Console.WriteLine(
            $"The volume of earth in cubic kilometers is {volKm3:F2} " +
            $"and cubic miles is {volMiles3:F2}"
        );	
	}
}