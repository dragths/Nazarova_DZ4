using System;
using System.Numerics;

namespace тумаков5глава

{
    internal class Program
    {
        static void Task1()
        {
            /*Написать метод, возвращающий наибольшее из двух чисел. Входные
            параметры метода – два целых числа. Протестировать метод .*/
            Console.WriteLine("");
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("");

            double number1 = 99969;
            double number2 = 20.99999999;
            Console.WriteLine($"Наибольшее из {number1} и {number2}: {Max(number1, number2)}");
        }
        static void Task2()
        {
            /*Написать метод, который меняет местами значения двух передаваемых
            параметров. Параметры передавать по ссылке. Протестировать метод.*/
            Console.WriteLine("");
            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("");

            double num1 = 666;
            double num2 = 13;
            Console.WriteLine($"До обмена: num1 = {num1}, num2 = {num2}");
            Swap(num1, num2);
            Console.WriteLine($"После обмена: num1 = {num1}, num2 = {num2}");
        }
        static void Task3()
        {
            /*Написать метод вычисления факториала числа, результат вычислений
            передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
            если в процессе вычисления возникло переполнение, то вернуть значение false. Для
            отслеживания переполнения значения использовать блок checked.*/
            Console.WriteLine("");
            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("");

            int number = 21;
            bool success = Factorial(number, out long factorial);

            if (success)
            {
                Console.WriteLine($"Факториал числа {number} равен {factorial}");
            }
            else
            {
                Console.WriteLine($"Произошло переполнение");
            }
        }
        static void Task4()
        {
            /*Написать рекурсивный метод вычисления факториала числа.*/
            Console.WriteLine("");
            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("");

            uint num = 121;
            BigInteger res = FactorialRec(num);
            Console.WriteLine($"Факториал числа {num} равен {res}");

        }

        static void Task5()
        {
            /*Написать метод, который вычисляет НОД двух натуральных чисел
            (алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех
            натуральных чисел.*/
            Console.WriteLine("");
            Console.WriteLine("Домашнее Задание 5.1");
            Console.WriteLine("");

            int nomer1 = 12;
            int nomer2 = 24;
            int nomer3 = 40;

            int nod1 = Nod(nomer1, nomer2);
            Console.WriteLine($"НОД чисел {nomer1} и {nomer2} равен {nod1}");

            int nod2 = Nod(nomer1, nomer2, nomer3);
            Console.WriteLine($"НОД чисел {nomer1}, {nomer2} и {nomer3} равен {nod2}");
        }

        static void Task6()
        {
            /*Написать рекурсивный метод, вычисляющий значение n-го числа
            ряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,
            13... Для таких чисел верно соотношение Fk = Fk-1 + Fk-2 .*/
            Console.WriteLine("");
            Console.WriteLine("Домашнее Задание 5.2");
            Console.WriteLine("");

            int n = 21;
            int result = Fibonachi(n);
            Console.WriteLine($"Число Фибоначчи {n} равно {result}");
        }
        public static double Max(double a, double b)
        {
            return (a > b) ? a : b;
        }
        public static void Swap(double a, double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        public static bool Factorial(int number, out long result)
        {
            result = 1;
            if (number < 0)
            {
                return false;
            }

            try
            {
                for (int i = 1; i <= number; i++)
                {
                    checked
                    {
                        result *= i;
                    }
                }
            }
            catch (OverflowException)
            {
                return false;
            }

            return true;
        }
        public static BigInteger FactorialRec(uint number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * FactorialRec(number - 1);
        }
        public static int Nod(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        public static int Nod(int a, int b, int c)
        {
            return Nod(Nod(a, b), c);
        }
        public static int Fibonachi(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Console.ReadKey();
        }
    }
}