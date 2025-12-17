import java.util.*;
public class powerCalculation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("base: ");
        int base = scanner.nextInt();
        System.out.print("exponent: ");
        int exponent = scanner.nextInt();
        double result = Math.pow(base, exponent);
        System.out.println("the result of " + base + " raised to the power of " + exponent + " is:" + result);
    }
}