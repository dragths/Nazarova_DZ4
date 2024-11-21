using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задания4шт

{
    public enum Worchlivost
    {
        Norm,
        Medium,
        Super,
    }

    public struct Ded
    {
        public string Name;
        public Worchlivost Level;
        public string[] Phrases;
        public int Udar;


        public Ded(string name, Worchlivost level, string[] phrases)
        {
            Name = name;
            Level = level;
            Phrases = phrases;
            Udar = 0;
        }


        public int UdarBabki(params string[] badWords)
        {
            foreach (var phrase in Phrases)
            {
                foreach (var badWord in badWords)
                {
                    if (phrase.Contains(badWord))
                    {
                        Udar++;
                    }
                }
            }
            return Udar;
        }
    }

    internal class Program
    {
        public static void PrintMassiv(int[] massiv)
        {
            foreach (int number in massiv)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        public static int Proiz(params int[] numbers)
        {
            int proiz = 1;
            foreach (int number in numbers)
            {
                proiz *= number;
            }

            return proiz;
        }
        public static double SredArif(params int[] numbers)
        {
            return Sum(numbers) / numbers.Length;

        }
        static void SuperNumber(int number)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("#     #");
                    Console.WriteLine("#     #");
                    Console.WriteLine("#     #");
                    Console.WriteLine(" ##### ");
                    break;
                case 1:
                    Console.WriteLine("   #   ");
                    Console.WriteLine("  ##   ");
                    Console.WriteLine("   #   ");
                    Console.WriteLine("   #   ");
                    Console.WriteLine(" ##### ");
                    break;
                case 2:
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("     # ");
                    Console.WriteLine(" ##### ");
                    Console.WriteLine(" #     ");
                    Console.WriteLine(" ##### ");
                    break;
                case 3:
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("     # ");
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("     # ");
                    Console.WriteLine(" ##### ");
                    break;
                case 4:
                    Console.WriteLine(" #   # ");
                    Console.WriteLine(" #   # ");
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("     # ");
                    Console.WriteLine("     # ");
                    break;
                case 5:
                    Console.WriteLine(" ##### ");
                    Console.WriteLine(" #     ");
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("     # ");
                    Console.WriteLine(" ##### ");
                    break;
                case 6:
                    Console.WriteLine(" ##### ");
                    Console.WriteLine(" #     ");
                    Console.WriteLine(" ##### ");
                    Console.WriteLine(" #   # ");
                    Console.WriteLine(" ##### ");
                    break;
                case 7:
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("     # ");
                    Console.WriteLine("    #  ");
                    Console.WriteLine("   #   ");
                    Console.WriteLine("   #   ");
                    break;
                case 8:
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("#     #");
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("#     #");
                    Console.WriteLine(" ##### ");
                    break;
                case 9:
                    Console.WriteLine(" ##### ");
                    Console.WriteLine(" #   # ");
                    Console.WriteLine(" ##### ");
                    Console.WriteLine("     # ");
                    Console.WriteLine(" ##### ");
                    break;
            }
        }
        static void Main(string[] args)

        {
            /*Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
            которые нужно поменять местами. Вывести на экран получившийся массив.*/
            Console.WriteLine("");
            Console.WriteLine("Задание 1");
            Console.WriteLine("");
            Random random = new Random();
            int[] massiv = new int[20];


            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = random.Next(1, 1000);
            }
            PrintMassiv(massiv);
            Console.WriteLine("Введите два числа из массива, которые хотите поменять местами:");
            int numer1 = int.Parse(Console.ReadLine());
            int numer2 = int.Parse(Console.ReadLine());
            int index1 = Array.IndexOf(massiv, numer1);
            int index2 = Array.IndexOf(massiv, numer2);
            if (index1 == -1 || index2 == -1)
            {
                Console.WriteLine("Введите числа из массива");
            }
            else
            {
                int a = massiv[index1];
                massiv[index1] = massiv[index2];
                massiv[index2] = a;
                PrintMassiv(massiv);
            }


            /*Написать метод, где в качества аргумента будет передан массив (ключевое слово
            params). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение
            массива. Вывести (out) среднее арифметическое в массиве.*/
            Console.WriteLine("");
            Console.WriteLine("Задание 2");
            Console.WriteLine("");

            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Текущий массив");
            Console.WriteLine(string.Join(", ", mas));
            int sum = Sum(mas);
            int proiz = Proiz(mas);
            double sredarif = SredArif(mas);
            Console.WriteLine($"Сумма элементов: {sum}");
            Console.WriteLine($"Произведение элементов: {proiz}");
            Console.WriteLine($"Среднее арифметическое элементов: {sredarif}");

            /*Пользователь вводит числа.Если числа от 0 до 9, то необходимо в консоли нарисовать
            изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль
            должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке. Если
            пользователь ввёл не цифру, то программа должна выпасть в исключение. Программа
            завершает работу, если пользователь введёт слово: exit или закрыть*/
            Console.WriteLine("");
            Console.WriteLine("Задание 3");
            Console.WriteLine("");

            bool flag = true;
            while (flag == true)
            {
                Console.Write("Введите число от 0 до 9 или 'exit'/'закрыть' для выхода: ");
                string input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                    input.Equals("закрыть", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    int number = int.Parse(input);
                    if (number >= 0 && number <= 9)
                    {
                        SuperNumber(number);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Ошибка: число должно быть от 0 до 9.");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
            }


            /*Создать структуру Дед. У деда есть имя, уровень ворчливости (перечисление), массив
            фраз для ворчания (прим.: “Проститутки!”, “Гады!”), количество синяков от ударов
            бабки = 0 по умолчанию. Создать 5 дедов. У каждого деда - разное количество фраз для
            ворчания.*/
            Console.WriteLine("");
            Console.WriteLine("Задание 3");
            Console.WriteLine("");



            Ded ded1 = new Ded("Борис Валентинович", Worchlivost.Norm, new string[] { "Гады!", "Молодёжь!", "В наше время было лучше" });
            Ded ded2 = new Ded("Андрей Дмитриевич", Worchlivost.Medium, new string[] { "Глупые!", "Голубые!", "Трансвиститы!" });
            Ded ded3 = new Ded("Юрий Петрович", Worchlivost.Super, new string[] { "Гады!", "Ублютки", "Тварь!", "Трансвиститы", "Сволочи!" });
            Ded ded4 = new Ded("Тимофей Викторович", Worchlivost.Norm, new string[] { "Негодяи!", "Эх, молодёжь!" });
            Ded ded5 = new Ded("Юрий Максимович", Worchlivost.Medium, new string[] { "Проститутки!", "Гады!", "Сволочи!" });


            string[] badWords = { "Проститутки", "Гады", "Сволочи", "Голубые!", "Ублютки", "Трансвиститы!", "Тварь!", "Негодяи!" };

            Console.WriteLine($"{ded1.Name} получил {ded1.UdarBabki(badWords)} синяков.");
            Console.WriteLine($"{ded2.Name} получил {ded2.UdarBabki(badWords)} синяков.");
            Console.WriteLine($"{ded3.Name} получил {ded3.UdarBabki(badWords)} синяков.");
            Console.WriteLine($"{ded4.Name} получил {ded4.UdarBabki(badWords)} синяков.");
            Console.WriteLine($"{ded5.Name} получил {ded5.UdarBabki(badWords)} синяков.");



        }
    }

}

