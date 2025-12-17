import java.util.*;
public class addDigits {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int num = s.nextInt();
        while (num >= 10) { //jab tak single digit hai tab tak chalega
            int sum = 0;
            while (num > 0) {
                sum += num % 10; //har digit ko sum mai add karenge
                num /= 10;
            }
            num = sum;
        }
        System.out.println(num);
        s.close();
    }
}
