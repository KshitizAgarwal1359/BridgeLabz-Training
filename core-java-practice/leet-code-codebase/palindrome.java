//package core-java-practice.leet-code-codebase;
import java.util.*;
public class palindrome {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int a=s.nextInt();
        int reversedNumber=0;
        if(a<0||(a%10==0 && a!=0)){     //base case check karenge
            System.out.println("Not a palindrome");
            return;
        }
        while(a>reversedNumber){
            reversedNumber=reversedNumber*10+a%10; /*ek half of no. reverseNumber mai daal denge*/
            a=a/10;
        }
        if(a==reversedNumber||a==reversedNumber/10){   /*dono half compare karenge*/
            System.out.println("Number is palindrome");
        }
        s.close();

    }
}
