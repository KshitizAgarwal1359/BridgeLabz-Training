import java.util.*;
public class simpleInterest {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("principal amount: ");
        double p = scanner.nextDouble();
        System.out.print("rate of interest: ");
        double r = scanner.nextDouble();
        System.out.print("time period (in yrs): ");
        double t = scanner.nextDouble();
        double simpleInterest = (p * r * t) / 100;
        System.out.println("The simple interest is: " + simpleInterest);
    }
}