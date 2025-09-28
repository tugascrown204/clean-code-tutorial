public class CleanExample {
    public static int cleanFunction() {
        int totalSum = 0;
        for (int number = 1; number <= 10; number++) {
            totalSum += number;
        }
        return totalSum;
    }

    public static void main(String[] args) {
        System.out.println(cleanFunction());
    }
}
