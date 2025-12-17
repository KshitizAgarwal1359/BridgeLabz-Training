//package core-java-practice.gcr-codebase.programming-elements;
import java.util.*;
public class areaCircle {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        double radius = s.nextDouble();
        double area = Math.PI * radius * radius;
        System.out.println(area);
        
    }
}