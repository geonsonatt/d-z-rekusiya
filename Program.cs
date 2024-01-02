using System;

class Program {
    // Главная точка входа в программу.
    static void Main() {
        int startNumber = 3;  // Начальное значение диапазона
        int endNumber = 10;   // Конечное значение диапазона

        PrintNumbersFromMToN(startNumber, endNumber);
    }

    // Рекурсивная функция для вывода чисел от M до N.
    // 'currentNumber' - текущее число для вывода.
    // 'endNumber' - последнее число в диапазоне для вывода.
    static void PrintNumbersFromMToN(int currentNumber, int endNumber) {
        Console.WriteLine(currentNumber);  // Вывод текущего числа

        // Проверка условия для рекурсивного вызова: если текущее число меньше конечного,
        // вызываем функцию снова с увеличенным значением текущего числа.
        if (currentNumber < endNumber) {
            PrintNumbersFromMToN(currentNumber + 1, endNumber);
        }
    }
}
