using System;

namespace lab_one
{
    class Program {

        static void Main(string[] args) {
            int a = 0, b = 1; // переменные для чисел фибоначчи
            int c; //переменная для хранения суммы чисел фибоначчи
            int n; // переменная для ввода последовательности
            Console.WriteLine("введите до какой последовательности нужно вывести числа:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);
            for (int i=0; i < n; i++) {
                c = a + b;
                Console.WriteLine($"{a} {b} сумма чисел: {c}");
                a = b;
                b = c;
            }
            
            Console.WriteLine("Конец программы");
            
        }
    }
}
