import java.util.*;
public class fibonnacci {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = s.nextInt(); // Example: ek number 10 jiska Fibonacci nikalna hai
        int a = 0, b = 1;
        if (n == 0) {
            System.out.println(a);
            return;
        }
        for (int i = 2; i <= n; i++) { // 2 se start karenge kyunki pehle do numbers already defined hain
            int next = a + b;
            a = b;
            b = next;
        }
        System.out.println(b);
        s.close();
    }
}
