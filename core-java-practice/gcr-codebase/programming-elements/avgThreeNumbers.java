import java.util.*;
public class avgThreeNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("first number: ");
        double num1 = scanner.nextDouble();
        System.out.print("second number: ");
        double num2 = scanner.nextDouble();
        System.out.print("third number: ");
        double num3 = scanner.nextDouble();
        double average = (num1 + num2 + num3) / 3;
        System.out.println("The average of the three numbers is: " + average);
    }
}