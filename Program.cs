using System;

class Program {
    static void Main() {
        int m = 3; // Задайте значение m
        int n = 2; // Задайте значение n

        int result = Ackermann(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }

    static int Ackermann(int m, int n) {
        if (m == 0) {
            return n + 1;
        } else if (m > 0 && n == 0) {
            return Ackermann(m - 1, 1);
        } else {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}