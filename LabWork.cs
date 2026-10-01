using System;

namespace Lab1
{
    public class LabWork
    {
        /// ============================================================
        /// ЗАДАНИЕ 1. МЕТОДЫ
        /// ============================================================

        /// Задача 2. Сумма знаков
        public int SumLastNums(int x)
        {
            int lastDigit = x % 10;
            int secondLastDigit = (x / 10) % 10;
            return lastDigit + secondLastDigit;
        }

        /// Задача 4. Положительное ли число
        public bool IsPositive(int x)
        {
            return x > 0;
        }

        /// Задача 6. Большая буква
        public bool IsUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        /// Задача 8. Делитель
        public bool IsDivisor(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return false;
            }
            return a % b == 0 || b % a == 0;
        }

        /// Задача 10. Многократный вызов
        public int LastNumSum(int a, int b)
        {
            return Math.Abs(a % 10) + Math.Abs(b % 10);
        }

        /// ============================================================
        /// ЗАДАНИЕ 2. УСЛОВИЯ
        /// ============================================================

        /// Задача 2. Безопасное деление
        public double SafeDiv(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            return (double)x / y;
        }

        /// Задача 4. Строка сравнения
        public string MakeDecision(int x, int y)
        {
            if (x > y)
            {
                return x + " > " + y;
            }
            else if (x < y)
            {
                return x + " < " + y;
            }
            else
            {
                return x + " == " + y;
            }
        }

        /// Задача 6. Тройная сумма
        public bool Sum3(int x, int y, int z)
        {
            return x + y == z || x + z == y || y + z == x;
        }

        /// Задача 8. Возраст
        public string Age(int x)
        {
            int lastTwo = x % 100;
            int lastOne = x % 10;
            string word;

            if (lastTwo >= 11 && lastTwo <= 14)
            {
                word = "лет";
            }
            else if (lastOne == 1)
            {
                word = "год";
            }
            else if (lastOne >= 2 && lastOne <= 4)
            {
                word = "года";
            }
            else
            {
                word = "лет";
            }

            return x + " " + word;
        }

        /// Задача 10. Вывод дней недели (switch + индекс, без goto)
        public void PrintDays(string x)
        {
            string[] days = { "понедельник", "вторник", "среда", "четверг",
                              "пятница", "суббота", "воскресенье" };

            int index;

            switch (x)
            {
                case "понедельник": index = 0; break;
                case "вторник": index = 1; break;
                case "среда": index = 2; break;
                case "четверг": index = 3; break;
                case "пятница": index = 4; break;
                case "суббота": index = 5; break;
                case "воскресенье": index = 6; break;
                default:
                    Console.WriteLine("это не день недели");
                    return;
            }

            for (int i = index; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }

        /// ============================================================
        /// ЗАДАНИЕ 3. ЦИКЛЫ
        /// ============================================================

        /// Задача 2. Числа наоборот
        public string ReverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i;
                if (i > 0)
                {
                    result += " ";
                }
            }
            return result;
        }

        /// Задача 4. Возведение в степень (поддерживает отрицательные степени)
        public double Pow(int x, int y)
        {
            if (y >= 0)
            {
                double result = 1;
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
                return result;
            }
            else
            {
                double result = 1;
                for (int i = 0; i < -y; i++)
                {
                    result *= x;
                }
                return 1 / result;
            }
        }

        /// Задача 6. Одинаковость
        public bool EqualNum(int x)
        {
            int firstDigit = x % 10;
            x /= 10;

            while (x > 0)
            {
                if (x % 10 != firstDigit)
                {
                    return false;
                }
                x /= 10;
            }
            return true;
        }

        /// Задача 8. Левый треугольник
        public void LeftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// Задача 10. Угадайка
        public void GuessGame()
        {
            Random random = new Random();
            int secret = random.Next(0, 10);
            int attempts = 0;
            int userNumber = -1;

            while (userNumber != secret)
            {
                Console.Write("Введите число от 0 до 9: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out userNumber))
                {
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    continue;
                }

                attempts++;

                if (userNumber != secret)
                {
                    Console.WriteLine("Вы не угадали, попробуйте снова.");
                }
            }

            Console.WriteLine("Вы угадали!");
            Console.WriteLine("Вы отгадали число за " + attempts + " попытки");
        }

        /// ============================================================
        /// ЗАДАНИЕ 4. МАССИВЫ
        /// ============================================================

        /// Задача 2. Поиск последнего значения
        public int FindLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        /// Задача 4. Добавление в массив
        public int[] Add(int[] arr, int x, int pos)
        {
            int[] result = new int[arr.Length + 1];

            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }

            result[pos] = x;

            for (int i = pos; i < arr.Length; i++)
            {
                result[i + 1] = arr[i];
            }

            return result;
        }

        /// Задача 6. Реверс
        public void Reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        /// Задача 8. Объединение
        public int[] Concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }

            return result;
        }

        /// Задача 10. Удалить негатив
        public int[] DeleteNegative(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            return result;
        }

        /// ============================================================
        /// ПРОВЕРКИ
        /// ============================================================

        public void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        public int[] ReadArray()
        {
            Console.Write("Введите количество элементов массива: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("Некорректный ввод. Введите целое неотрицательное число: ");
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "] = ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Некорректный ввод. arr[" + i + "] = ");
                }
            }
            return arr;
        }

        public int ReadInt(string message)
        {
            Console.Write(message);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Некорректный ввод. " + message);
            }
            return value;
        }

        public int ReadIntAtLeastTwoDigits(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    continue;
                }

                if (Math.Abs(value) < 10)
                {
                    Console.WriteLine("Число должно содержать не менее двух знаков (по модулю).");
                    continue;
                }

                return value;
            }
        }

        public int ReadNonNegativeInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    continue;
                }

                if (value < 0)
                {
                    Console.WriteLine("Число должно быть неотрицательным.");
                    continue;
                }

                return value;
            }
        }

        public int ReadPositiveInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    continue;
                }

                if (value <= 0)
                {
                    Console.WriteLine("Число должно быть положительным.");
                    continue;
                }

                return value;
            }
        }
    }
}
