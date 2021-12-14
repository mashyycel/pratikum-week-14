using System;
using System.Collections.Generic;
namespace bilangan_prima
{

    class Program
    {
        public class numbers
        {
            public int angka;
            public int hitung;
        }

        static void bilanganPrima()
        {

            List<int> bilanganPrima = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23,
29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            numbers bilangan = new numbers();
            bilangan.angka = Convert.ToInt32(Console.ReadLine());
            bilangan.hitung = 2;

            for (int i = 1; i <= bilangan.angka; i++)
            {
                if (bilangan.angka % i == 0)
                {
                    bilangan.hitung = bilangan.hitung + 1;
                }
            }
            for (int i = 1; i <= bilangan.angka; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    foreach (var bilprima in bilanganPrima)
                    {
                        Console.Write(bilprima + " ");
                    }
                    Console.WriteLine("");
                }
            }
        }
        static void bukanbilanganPrima()
        {
            List<int> bukanbilanganPrima = new List<int>() {1, 4, 6, 8, 9, 10, 12, 14, 15,
16, 18, 20, 22, 24, 25, 26, 27, 28, 30, 32, 33, 34, 35, 36, 38, 39, 40, 42, 44, 45, 46,
48, 49, 50, 51, 52, 54, 55, 56, 57, 58, 60, 62, 63, 64, 65, 66, 68, 69, 70, 72, 74, 75,
76, 77, 78, 80, 81, 82, 84, 85, 86, 87, 88, 90, 91, 92, 93, 94, 95, 96, 98, 99, 100};
            numbers bilangan = new numbers();
            bilangan.angka = Convert.ToInt32(Console.ReadLine());
            bilangan.hitung = 0;
            for (int i = 1; i <= bilangan.angka; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    foreach (var bilprima in bukanbilanganPrima)
                    {
                        Console.Write(bilprima + " ");
                    }
                    Console.WriteLine("");
                }
            }
        }
        static void Main(string[] args)
        {
            numbers bilangan = new numbers();
            bilangan.hitung = 2;
            if (bilangan.hitung == 2)
            {
                bilanganPrima();
            }
            else
            {
                bukanbilanganPrima();
            }
        }
    }
}