using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задание 1
            Console.Write("Vvedite chisla ot 1 do 100: ");
            short x = short.Parse(Console.ReadLine());
            if (x > 0 && x < 101)
            {       
            if (x % 3 == 0)
            Console.WriteLine("Fizz");
            else if (x % 5 == 0)
            Console.WriteLine("Buzz");
            else if (x % 3 == 0 && x % 5 == 0)
            Console.WriteLine("Fizz Buzz");
            else
            Console.WriteLine(x);
            }
            else
            Console.WriteLine("Vvedite chislo v zadanom diapazone");
            */

            /*
            Задание 2
            Console.Write("Vvedite chislo: ");
            //short x = short.Parse(Console.ReadLine());
            //Console.Write("Vvedite chislo kotoroe budet procentami: ");
            //short y = short.Parse(Console.ReadLine());
            //Console.WriteLine($"{y}% ot {x} poluchaetca {(float)y * x / 100}");
            */

            /*
            Задание 4
            Console.Write("Vvedite shesti znachnoe chislo: ");
            int chislo = int.Parse(Console.ReadLine());
            Console.Write("Vvedite chislo kotoroe hotite izmenit: ");
            short izmenenie_1 = short.Parse(Console.ReadLine());
            Console.Write("Vvedite chislo s kotorim hotite izmenit: ");
            short izmenenie_2 = short.Parse(Console.ReadLine());
            int otvet = 0;
            if ((chislo / 100000) > 0 && (chislo / 100000) < 10)
            {
                if (izmenenie_1 < 1 || izmenenie_1 > 6)
                    Console.WriteLine("Viberete pravilnoe chislo kotoroe hotite izmenit");
                else if (izmenenie_2 < 1 || izmenenie_2 > 6)
                    Console.WriteLine("Viberete pravilnoe chislo s kotorim hotite izmenit");
                else
                {
                    int first_digit = chislo / (int)Math.Pow(10, 6 - izmenenie_1) - chislo / (int)Math.Pow(10, 7 - izmenenie_1) * 10;
                    int second_digit = chislo / (int)Math.Pow(10, 6 - izmenenie_2) - chislo / (int)Math.Pow(10, 7 - izmenenie_2) * 10;
                    otvet = chislo + (second_digit - first_digit) * (int)(Math.Pow(10, 6 - izmenenie_1) - Math.Pow(10, 6 - izmenenie_2));
                    Console.WriteLine("Vashe izmenenoe chislo: " + otvet);
                }
            }
            else
                Console.WriteLine("Vvedite 6 randomnih cifer");
           */

            /*
            Задание 6
            Console.Write("Vvedite temperaturu: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Esli hotite temperaturu v Celsiah vvedite "C", esli hotite temperaturu v Faringeitah vvedite "F": ");
            char scale = char.Parse(Console.ReadLine());
            if (scale == 'C')
            {
                Console.WriteLine($"Gradusov v Celsiah: {t}°C");
                Console.WriteLine($"Gradusov v Fahrenheit: {(float)t * 9 / 5 + 32}°F");
            }
            else if (scale == 'F')
            {
                Console.WriteLine($"Gradusov v Celsius: {((float)t - 32) * 5 / 9}°C");
                Console.WriteLine($"Gradusov v Fahrenheit: {t}°F");
            }
            else
                Console.WriteLine("Vvedite pravilnuu bukvu0");
            */

            /*
            Задание 7
            Console.Write("Vvedite pervoe chislo: ");
             int x = int.Parse(Console.ReadLine());
            Console.Write("Vvedite vtoroe chislo: ");
            int y = int.Parse(Console.ReadLine());
              if (x > y)
            {
            int a = x;
            x = y;
            y = a;
            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            */
        }
    }
}