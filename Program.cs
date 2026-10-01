using System;

namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            LabWork lab = new LabWork();

            Console.WriteLine("=== Задание 1. Методы ===");

            Console.WriteLine("\n-- Задача 2. Сумма знаков --");
            int x1 = lab.ReadIntAtLeastTwoDigits("Введите число (не менее двух знаков): ");
            Console.WriteLine("Результат: " + lab.SumLastNums(x1));

            Console.WriteLine("\n-- Задача 4. Положительное ли число --");
            int x2 = lab.ReadInt("Введите число: ");
            Console.WriteLine("Результат: " + lab.IsPositive(x2));

            Console.WriteLine("\n-- Задача 6. Большая буква --");
            Console.Write("Введите символ: ");
            char ch1 = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Результат: " + lab.IsUpperCase(ch1));

            Console.WriteLine("\n-- Задача 8. Делитель --");
            int a1 = lab.ReadInt("Введите a: ");
            int b1 = lab.ReadInt("Введите b: ");
            Console.WriteLine("Результат: " + lab.IsDivisor(a1, b1));

            Console.WriteLine("\n-- Задача 10. Многократный вызов --");
            Console.WriteLine("Введите пять чисел для последовательного сложения:");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = lab.ReadInt("Число " + (i + 1) + ": ");
            }
            int sum = numbers[0];
            for (int i = 1; i < 5; i++)
            {
                sum = lab.LastNumSum(sum, numbers[i]);
            }
            Console.WriteLine("Итого: " + sum);

            Console.WriteLine("\n=== Задание 2. Условия ===");

            Console.WriteLine("\n-- Задача 2. Безопасное деление --");
            int x3 = lab.ReadInt("Введите x: ");
            int y3 = lab.ReadInt("Введите y: ");
            Console.WriteLine("Результат: " + lab.SafeDiv(x3, y3));

            Console.WriteLine("\n-- Задача 4. Строка сравнения --");
            int x4 = lab.ReadInt("Введите x: ");
            int y4 = lab.ReadInt("Введите y: ");
            Console.WriteLine("Результат: " + lab.MakeDecision(x4, y4));

            Console.WriteLine("\n-- Задача 6. Тройная сумма --");
            int x5 = lab.ReadInt("Введите x: ");
            int y5 = lab.ReadInt("Введите y: ");
            int z5 = lab.ReadInt("Введите z: ");
            Console.WriteLine("Результат: " + lab.Sum3(x5, y5, z5));

            Console.WriteLine("\n-- Задача 8. Возраст --");
            int ageValue = lab.ReadPositiveInt("Введите возраст: ");
            Console.WriteLine("Результат: " + lab.Age(ageValue));

            Console.WriteLine("\n-- Задача 10. Вывод дней недели --");
            Console.Write("Введите день недели: ");
            string day = Console.ReadLine();
            lab.PrintDays(day);

            Console.WriteLine("\n=== Задание 3. Циклы ===");

            Console.WriteLine("\n-- Задача 2. Числа наоборот --");
            int x6 = lab.ReadNonNegativeInt("Введите x (неотрицательное): ");
            Console.WriteLine("Результат: " + lab.ReverseListNums(x6));

            Console.WriteLine("\n-- Задача 4. Возведение в степень --");
            int x7 = lab.ReadInt("Введите x: ");
            int y7 = lab.ReadInt("Введите y: ");
            Console.WriteLine("Результат: " + lab.Pow(x7, y7));

            Console.WriteLine("\n-- Задача 6. Одинаковость --");
            int x8 = lab.ReadInt("Введите число: ");
            Console.WriteLine("Результат: " + lab.EqualNum(x8));

            Console.WriteLine("\n-- Задача 8. Левый треугольник --");
            int x9 = lab.ReadPositiveInt("Введите высоту треугольника (положительное): ");
            lab.LeftTriangle(x9);

            Console.WriteLine("\n-- Задача 10. Угадайка --");
            lab.GuessGame();

            Console.WriteLine("\n=== Задание 4. Массивы ===");

            Console.WriteLine("\n-- Задача 2. Поиск последнего значения --");
            int[] arr1 = lab.ReadArray();
            int searchValue = lab.ReadInt("Введите искомое значение: ");
            Console.WriteLine("Результат: " + lab.FindLast(arr1, searchValue));

            Console.WriteLine("\n-- Задача 4. Добавление в массив --");
            int[] arr2 = lab.ReadArray();
            int insertValue = lab.ReadInt("Введите значение для вставки: ");
            int pos1 = lab.ReadInt("Введите позицию для вставки: ");
            int[] result1 = lab.Add(arr2, insertValue, pos1);
            Console.Write("Результат: ");
            lab.PrintArray(result1);

            Console.WriteLine("\n-- Задача 6. Реверс --");
            int[] arr3 = lab.ReadArray();
            lab.Reverse(arr3);
            Console.Write("Результат: ");
            lab.PrintArray(arr3);

            Console.WriteLine("\n-- Задача 8. Объединение --");
            Console.WriteLine("Первый массив:");
            int[] arr4 = lab.ReadArray();
            Console.WriteLine("Второй массив:");
            int[] arr5 = lab.ReadArray();
            int[] result2 = lab.Concat(arr4, arr5);
            Console.Write("Результат: ");
            lab.PrintArray(result2);

            Console.WriteLine("\n-- Задача 10. Удалить негатив --");
            int[] arr6 = lab.ReadArray();
            int[] result3 = lab.DeleteNegative(arr6);
            Console.Write("Результат: ");
            lab.PrintArray(result3);
        }
    }
}