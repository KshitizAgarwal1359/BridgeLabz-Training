import java.util.*;
public class perimeterRectangle {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("length: ");
        int l = scanner.nextInt();
        System.out.print("width: ");
        int w = scanner.nextInt();
        int p = 2 * (l + w);
        System.out.println("perimeter of the rectangle is: " + p);
    }
}