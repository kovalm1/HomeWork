using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.HomeWork1();
            Console.ReadKey();
        }

        void HomeWork1()
        {
            for (int a = 1; a <= 9; a++)
            {
                int a7 = a * a * a * a * a * a * a;
                for (int b = 0; b <= 9; b++)
                {
                    int b7 = b * b * b * b * b * b * b;
                    for (int c = 0; c <= 9; c++)
                    {
                        int c7 = c * c * c * c * c * c * c;
                        for (int d = 0; d <= 9; d++)
                        {
                            int d7 = d * d * d * d * d * d * d;
                            for (int e = 0; e <= 9; e++)
                            {
                                int e7 = e * e * e * e * e * e * e;
                                for (int f = 0; f <= 9; f++)
                                {
                                    int f7 = f * f * f * f * f * f * f;
                                    for (int g = 0; g <= 9; g++)
                                    {
                                        int g7 = g * g * g * g * g * g * g;

                                        int sum = a7 + b7 + c7 + d7 + e7 + f7 + g7;
                                        int number = a * 1000000 + b * 100000 + c * 10000 + d * 1000 + e * 100 + f * 10 + g;

                                        if (sum == number)
                                        {
                                            Console.WriteLine(number);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        void HomeWork2()
        {
            for (int Ш = 0; Ш <= 9; Ш++)
            {
                for (int Р = 0; Р <= 9; Р++)
                {
                    if (Р != Ш)
                    {
                        for (int А = 0; А <= 9; А++)
                        {
                            if (А != Р && А != Ш)
                            {
                                for (int М = 0; М <= 9; М++)
                                {
                                    if (М != А && М != Р && М != Ш)
                                    {
                                        int ШРАМ = Ш * 1000 + Р * 100 + А * 10 + М;

                                        for (int Ы = 0; Ы <= 9; Ы++)
                                        {
                                            if (Ы != А && Ы != Р && Ы != Ш && Ы != М)
                                            {
                                                int ШРАМЫ = ШРАМ * 10 + Ы;

                                                if (ШРАМ * Ы == ШРАМЫ)
                                                {
                                                    Console.WriteLine($"{ШРАМ} * {Ы} = {ШРАМЫ}");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Расчет окончен");
        }
    }        
}        