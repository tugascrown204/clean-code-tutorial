using System;

namespace CleanCodeTutorial {
    class Program {
        static int CleanFunction() {
            int totalSum = 0;
            for (int number = 1; number <= 10; number++) {
                totalSum += number;
            }
            return totalSum;
        }

        static void Main(string[] args) {
            Console.WriteLine(CleanFunction());
        }
    }
}
