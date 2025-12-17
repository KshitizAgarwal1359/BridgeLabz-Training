//package core-java-practice.gcr-codebase.programming-elements;
import java.util.*;
public class fahrenheit {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        double celsius = s.nextDouble();
        double fahrenheit = (celsius * 9/5) + 32;
        System.out.println(fahrenheit);
    }
}