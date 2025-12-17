public class reverseinteger {
    public static void main(String[] args) {
        int x = 123;
        int reversed = 0;
        while (x != 0) {
            int digit = x % 10;
            // Check for overflow
            if (reversed > (Integer.MAX_VALUE - digit) / 10) {
                System.out.println(0);
                return;
            }
            reversed = reversed * 10 + digit;
            x /= 10;
        }
        System.out.println(reversed);
    }
}
