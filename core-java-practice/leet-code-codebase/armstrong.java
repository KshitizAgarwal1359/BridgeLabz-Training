import java.util.*;
public class armstrong {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int num = s.nextInt();
        int original = num;
        int sum = 0;
        while (num > 0) {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }
        if (sum == original) {
            System.out.println("Armstrong number"); //
        } else {
            System.out.println("Not an Armstrong number");
        }
        s.close();
    }
}
