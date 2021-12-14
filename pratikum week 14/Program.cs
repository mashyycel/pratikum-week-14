using System;

namespace bilangan_prima
{

    class Program
    {

        public static void bilanganPrima(int angka)
        {
            int hitung = 0;
            int kumpulanAngka = 0;
            string statusAngka = "";

            for (int i = 1; i <= angka; i++)
            {
                for (int j = 1; j <= angka; j++)
                {
                    statusAngka = "";
                    while (statusAngka == "")
                    {
                        kumpulanAngka++;
                        for (int k = 1; k <= kumpulanAngka; k++)
                        {
                            if (kumpulanAngka % k == 0)
                            {
                                hitung++;
                            }
                        }
                        if (hitung == 2)
                            statusAngka = "prima";
                        else
                            statusAngka = "bukanPrima";
                    }
                    Console.Write($"{kumpulanAngka}".PadLeft(6));
                }
                Console.WriteLine();
            }
        }

            static void bukanbilanganPrima(int angka)
        {
            int hitung = 0;
            int kumpulanAngka = 0;
            string statusAngka = "";
            
            for (int i = 1; i <= angka; i++)
            {
                for (int j = 1; j <= angka; j++)
                {
                    statusAngka = "";
                    while (statusAngka == "")
                    {
                        kumpulanAngka++;
                        for (int k = 1; k <= kumpulanAngka; k++)
                        {
                            if (kumpulanAngka % k == 0)
                            {
                                hitung++;
                            }
                        }
                        if (hitung == 2)
                        {
                            statusAngka = "";

                        }
                         
                        else
                            statusAngka = "bukanPrima";
                    }
                    
                    Console.Write($"{kumpulanAngka}".PadLeft(6));
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int angka = Convert.ToInt32(Console.ReadLine());
            int hitung = 0;
            
            while (angka < 2)
            {
                Console.Write("Input: ");
                angka = Convert.ToInt32(Console.ReadLine());
            }
            
                for (int j = 1; j <= angka; j++)
                {
                    
                    if (angka % j == 0)
                    {
                        hitung++;
                    
                    }
                    
                }
                if (hitung == 2)
                {
                    bilanganPrima(angka);
                }
                else
                {
                    bukanbilanganPrima(angka);
                }
            
        }
    }
}