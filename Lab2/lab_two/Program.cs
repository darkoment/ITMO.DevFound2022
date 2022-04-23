using System;

namespace lab_two 
{
    class Program {
        static void Main(string[] args) {
            // int First = 1;
            int Min;
            // int Current;
            int[] Mass = new int[] {4, 7, 8, 3, 1, 4, 6, 7, 33, 12, 45, 43, 12, 43, 1};
            int Temp;

            for (int i = 0; i < Mass.Length; i++) {
                Console.Write($"{Mass[i]} ");
            }
                Console.WriteLine();

            for (int First = 0; First < Mass.Length - 1; First++) {
                for (Min = First + 1; Min < Mass.Length; Min++) {
                    if (Mass[First] > Mass[Min]) {
                        Temp = Mass[First];
                        Mass[First] = Mass[Min];
                        Mass[Min] = Temp;
                    }
                }
            }

            Console.WriteLine("Готовый Массив: ");
            for (int i = 0; i < Mass.Length; i++) {
                Console.Write($"{Mass[i]} ");
            }

        }
    }
}